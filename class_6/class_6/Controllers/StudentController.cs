using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using class_6.Models;
namespace class_6.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            var students = new List<Student>
            {
new Student{Id =1,Name="hani",age=20},
new Student{Id =2,Name="hanoo",age=22},
new Student{Id =3,Name="hassan",age=21}

            };
            return View(students);
        }
    }
}