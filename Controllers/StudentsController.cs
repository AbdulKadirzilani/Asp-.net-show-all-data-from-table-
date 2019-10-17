using System;
using System.Collections.Generic;
using System.Linq;
using Tuto7.Models;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc; 
using System.Data.SqlClient;
using Tuto7.Manager;
using Tuto7.Gateway;

namespace Tuto7.Controllers
{
    public class StudentsController : Controller
    {
        public ActionResult SaveStd()
        {
            StudentManager studentManager = new StudentManager();


            ViewBag.Students = studentManager.GetStudents();
            ViewBag.Mobile = GetMobiles();
            return View();
        }




        [HttpPost]
        public ActionResult SaveStd(Student student)

        {
            StudentManager studentManager = new StudentManager();

            string mgs = "";

            SqlConnection connection = new SqlConnection(@"Server=DESKTOP-059A10P\SQLEXPRESS;Database=ASPCRUD;Integrated Security=true;");

  
            string query = "INSERT INTO Contact3(Name, Mobile)VALUES('" + student.Name + "','" + student.Mobile + "')";
            SqlCommand cmd = new SqlCommand(query, connection);
            connection.Open();
            int rowCount = cmd.ExecuteNonQuery();
            if (rowCount > 0)
            {
                mgs = "save data success";
            }

            else 
            {
                mgs = "failed";
            }
            ViewBag.Mobile = GetMobiles();

            ViewBag.Students = studentManager.GetStudents();
            ViewBag.Message = mgs;
            return View();


        }

        public ActionResult Index2()
        {
            return View();
        }


        public ActionResult Index4()
        {

            ViewBag.Message = "Hellow Batch";
            ViewBag.hlw = "Hellow Batch2";
            ViewBag.hlw1 = "Hellow Batch3";
            ViewBag.hlw2 = "Hellow Batch4";
            ViewBag.hlw3 = "Hellow Batch5";
            return View();
        }



        public ActionResult Index5()
        {
            var student = new Student();

            student.Name = " Noman";
            student.Mobile = "01222222";

            ViewBag.Student = student;

            return View();
        }



        public List<string> GetMobiles()
        {

            return new List<string> { "samsung", "Iphone", "Oneplus" };
            


        }

        public ActionResult GetAll()
        {
            ViewBag.Students = Students();
            return View();
        }

        public List<Student> Students()
        {
            return new List<Student>
            {
                new Student { Name = "Arshad", Mobile = "222204333" },
                new Student { Name = "DOLLAR", Mobile = "222204333" },
                
            };


        }

    }
}