using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Domain;
using Service;
using MVCAJAX12.Models;

namespace MVCAJAX12.Controllers
{
    public class StudentController : Controller
    {
        private StudentService service = new StudentService();

        //GET: Student
        public ActionResult IndexRazor()
        {
            var model = (from c in service.Get()
                         select new StudentModel
                         {
                             ID = c.studentID,
                             Code = c.studentCode,
                             Name = c.studentName,
                             LastName = c.studentLastName,
                             Address = c.studentAddress
                         }).ToList();

            return View(model);
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult getStudent(string id)
        {
            return Json(service.Get(), JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult createStudent(Student std)
        {
            service.Insert(std);
            string message = "SUCCESS";
            return Json(new { Message = message, JsonRequestBehavior.AllowGet });
        }
    }
}