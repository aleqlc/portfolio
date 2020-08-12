using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using StoredProcedureMVC.Models;

namespace StoredProcedureMVC.Controllers
{
    public class HomeController : Controller
    {
        database_Access_layer.db dblayer = new database_Access_layer.db();

        //~Home/Show_data
        public ActionResult Show_data()
        {
            DataSet ds = dblayer.Show_data();
            ViewBag.emp = ds.Tables[0];
            return View();
        }

        public ActionResult Add_record()//이 코드 없으면 ~Home/Add_record의 view안보임. 뷰추가도 여기에함
        {
            return View();
        }
        //~Home/Add_record
        [HttpPost]
        public ActionResult Add_record(FormCollection fc)
        {
            Employee emp = new Employee();
            emp.Name = fc["Name"];               //cshtml에 name값을 ""안에 적어줌
            emp.Address = fc["Address"];         //cshtml에 name값을 ""안에 적어줌
            emp.City = fc["City"];               //cshtml에 name값을 ""안에 적어줌
            emp.Pin_Code = fc["pin"];            //cshtml에 name값을 ""안에 적어줌
            emp.Designation = fc["designation"]; //cshtml에 name값을 ""안에 적어줌
            dblayer.Add_record(emp);
            TempData["msg"] = "저장되었습니다.";
            return View();
        }

        public ActionResult update_record(int id)
        {
            DataSet ds = dblayer.Show_record_byid(id);
            ViewBag.emprecord = ds.Tables[0];
            return View();
        }
        [HttpPost]
        public ActionResult update_record(int id, FormCollection fc)
        {
            Employee emp = new Employee();
            emp.empid = id;
            emp.Name = fc["Name"];
            emp.Address = fc["Address"];
            emp.City = fc["City"];
            emp.Pin_Code = fc["pin"];
            emp.Designation = fc["designation"];
            dblayer.Update_record(emp);
            TempData["msg"] = "수정되었습니다.";
            return RedirectToAction("Show_data");
        }

        public ActionResult Delete_record(int id)
        {
            dblayer.delete_record(id);
            TempData["msg"] = "삭제되었습니다.";
            return RedirectToAction("Show_data");
        }
    }
}