using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Dapper;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using MemoEngine.DotNetNote;

namespace DotNetNote.Models
{
    public class NoteRepository
    {
        private SqlConnection con;
        public NoteRepository()
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings[
                "ConnectionString"].ConnectionString);
        }

        public int SaveOrUpdate(Note n, BoardWriteFormType formType)
        {
            int r = 0;
            var p = new DynamicParameters();

            p.Add("@Name", value: n.Name, dbType: DbType.String);
            p.Add("@Email", value: n.Email, dbType: DbType.String);
            p.Add("@Title", value: n.Title, dbType: DbType.String);
            p.Add("@Content", value: n.Content, dbType: DbType.String);
            p.Add("@Password", value: n.Password, dbType: DbType.String);
            p.Add("@Encoding", value: n.Encoding, dbType: DbType.String);
            p.Add("@Homepage", value: n.Homepage, dbType: DbType.String);
            p.Add("@FileName", value: n.FileName, dbType: DbType.String);
            p.Add("@FileSize", value: n.FileSize, dbType: DbType.String);

            switch (formType)
            {
                case BoardWriteFormType.Write:
                    //글쓰기 전용
                    p.Add("@PostIP", value: n.PostIP, dbType: DbType.String);
                    r = con.Execute("WriteNote", p, commandType: CommandType.StoredProcedure);
                    break;
                case BoardWriteFormType.Modify:
                    //수정하기 전용
                    p.Add("@ModifyIp", value: n.ModifyIp, dbType: DbType.String);
                    p.Add("@Id", value: n.Id, dbType: DbType.Int32);
                    r = con.Execute("ModifyNote", p, commandType: CommandType.StoredProcedure);
                    break;
                case BoardWriteFormType.Reply:
                    //답변쓰기 전용
                    p.Add("@PostIp", value: n.PostIP, dbType: DbType.String);
                    p.Add("@ParentNum", value: n.ParentNum, dbType: DbType.Int32);
                    r = con.Execute("ReplyNote", p, commandType: CommandType.StoredProcedure);
                    break;
            }
            return r;
        }

        //게시판 글쓰기
        public void Add(Note vm)
        {
            try
            {
                SaveOrUpdate(vm, BoardWriteFormType.Write);
            }
            catch(System.Exception ex)
            {
                throw new System.Exception(ex.Message);//로깅 처리 권장영역
            }
        }

        //수정하기
        public int UpdateNote(Note vm)
        {
            int r = 0;
            try
            {
                r = SaveOrUpdate(vm, BoardWriteFormType.Modify);
            }
            catch(System.Exception ex)
            {
                throw new System.Exception(ex.Message);
            }
            return r;
        }

        //답변 글쓰기
        public void ReplyNote(Note vm)
        {
            try
            {
                SaveOrUpdate(vm, BoardWriteFormType.Reply);
            }
            catch(System.Exception ex)
            {
                throw new System.Exception(ex.Message);
            }
        }

        //게시판 리스트
        public List<Note> GetAll(int page)
        {
            try
            {
                var parameters = new DynamicParameters(new { Page = page });
                return con.Query<Note>("ListNotes", parameters,
                    commandType: CommandType.StoredProcedure).ToList();
            }
            catch(System.Exception ex)
            {
                throw new System.Exception(ex.Message);
            }
        }

        //검색 카운트
        public int GetCountBySearch(string searchField, string searchQuery)
        {
            try
            {
                return con.Query<int>("SearchNoteCount", new
                {
                    SearchField = searchField,
                    SearchQuery = searchQuery
                },
                    commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
            catch(System.Exception ex)
            {
                throw new System.Exception(ex.Message);
            }
        }

        //Notes 테이블의 모든 레코드 수
        public int GetCountAll()
        {
            try
            {
                return con.Query<int>(
                    "Select Count(*) From Notes").SingleOrDefault();
            }
            catch (System.Exception)
            {
                return -1;
            }
        }

        //Id에 해당하는 파일명 반환
        public string GetFileNameById(int id)
        {
            return con.Query<string>("Select FileName From Notes Where Id=@Id",
                new { Id = id }).SingleOrDefault();
        }

        //검색 결과 리스트
        public List<Note> GetSearchAll(
            int page, string searchField, string searchQuery)
        {
            var parameters = new DynamicParameters(new
            {
                Page = page,
                SearchField = searchField,
                SearchQuery = searchQuery
            });
            return con.Query<Note>("SearchNotes", parameters,
                commandType: CommandType.StoredProcedure).ToList();
        }

        //다운 카운트 1 증가
        public void UpdateDownCount(string fileName)
        {
            con.Execute("Update Notes Set DownCount = DownCount + 1"
                + " Where FileName = @FileName", new { FileName = fileName });
        }
        public void UpdateDownCountById(int id)
        {
            var p = new DynamicParameters(new { Id = id });
            con.Execute("Update Notes Set DownCount = DownCount + 1 "
                + " Where Id = @Id", p, commandType: CommandType.Text);
        }

        //상세보기
        public Note GetNoteById(int id)
        {
            var parameters = new DynamicParameters(new { Id = id });
            return con.Query<Note>("ViewNote", parameters,
                commandType: CommandType.StoredProcedure).SingleOrDefault();
        }

        //삭제
        public int DeleteNote(int id, string password)
        {
            return con.Execute("DeleteNote",
                new { Id = id, Password = password },
                commandType: CommandType.StoredProcedure);
        }

        //최근 올라온 사진 리스트 4개 출력
        public List<Note> GetNewPhotos()
        {
            string sql =
                "SELECT TOP 4 Id, Title, FileName, FileSize FROM Notes "
                + " Where FileName Like '%.png' Or FileName Like '%.jpg' Or "
                + " FileName Like '%.jpeg' Or FileName Like '%.gif' "
                + " Order By Id Desc";
            return con.Query<Note>(sql).ToList();
        }

        //최근 글 리스트
        public List<Note> GetNoteSummaryByCategory(string category)
        {
            string sql = "SELECT TOP 3 Id, Title, Name, PostDate, FileName, "
                + " FileSize, ReadCount, CommentCount, Step "
                + " FROM Notes "
                + " Where Category = @Category Order By Id Desc";
            return con.Query<Note>(sql, new { Category = category }).ToList();
        }

        //최근 글 리스트 전체(최근 글 5개 리스트)
        public List<Note> GetRecentPosts()
        {
            string sql = "SELECT TOP 3 Id, Title, Name, PostDate FROM Notes "
                + "Order By Id Desc";
            return con.Query<Note>(sql).ToList();
        }

        //최근 글 리스트 n개
        public List<Note> GetRecentPosts(int numberOfNotes)
        {
            string sql =
                $"SELECT TOP {numberOfNotes} Id, Title, Name, PostDate "
                + " FROM Notes Order By Id Desc";
            return con.Query<Note>(sql).ToList();
        }
    }
}