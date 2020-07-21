using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AboutDataBindingWithDataTable
{
    class GlobalInstance
    {
        static public GlobalInstance Singleton
        {
            get;
            private set;
        }

        static GlobalInstance()
        {
            Singleton = new GlobalInstance();
        }

        DataTable dt = new DataTable("MemberTable");
        public DataTable Source
        {
            get
            {
                return dt;
            }
        }

        private GlobalInstance()
        {
            DesignMemberShema();
            SetDemoData();
        }

        private void SetDemoData()
        {
            AddMember("홍길동", "hgd");
            AddMember("강감찬", "ggc");
            AddMember("이순신", "lss");
            AddMember("장보고", "jbg");
            AddMember("김구", "kg");
        }

        private bool AddMember(string name, string id)
        {
            DataRow dr = dt.NewRow();
            dr["id"] = id;
            dr["name"] = name;

            try
            {
                dt.Rows.Add(dr);
            }
            catch
            {
                return false;
            }
            return true;
        }

        private void DesignMemberShema()
        {
            DataColumn idCol = new DataColumn("id", typeof(string));
            idCol.AllowDBNull = false;
            idCol.Unique = true;
            dt.Columns.Add(idCol);

            DataColumn nameCol = new DataColumn("name", typeof(string));
            nameCol.AllowDBNull = false;
            dt.Columns.Add(nameCol);
        }
    }
}
