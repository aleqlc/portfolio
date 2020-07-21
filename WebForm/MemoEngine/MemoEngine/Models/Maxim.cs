using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MemoEngine.Models
{
    //Maxim 모델 클래스 : Maxims 테이블과 일대일
    public class Maxim
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public DateTime CreationDate { get; set; }
    }
}