using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using  WebApp.Model.Model;
using WebApp.BLL.BLL;
namespace WebApp.Controllers
{
    public class StudentController : Controller
    {
        StudentManager _studentManager = new StudentManager();
        //public string Add(string rollNo, string name, string address, int? age, int? departmentId)

        [HttpGet]
        public ActionResult Add()
        {
            Student student = new Student();

            return View(student);
        }

        [HttpPost]
        public ActionResult Add(Student student)
        {
            string message = "<h3>Student Information </h3><br / > ";

            //message += "Roll No:" + student.RollNo;
            //message += "<br / > Name:" + student.Name;
            //message += "<br / > Address:" + student.Address;
            //message += "<br / > Age:" + student.Age;
            //message += "<br / > Department:" + student.DepartmentId;

            
            if (_studentManager.Add(student))
            {
                message = "Saved";
            }
            else
            {
                message = "Not Saved";
            }

            ViewBag.Message = message;

            return View(student);
        }
    }
}