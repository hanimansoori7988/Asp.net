using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Configuration;
using System.Data.SqlClient;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using System.Xml.Linq;
using class7.Models;

namespace class7.Controllers
{
    public class studentController : Controller
    {
        string cs = ConfigurationManager.ConnectionStrings["testdb"].ConnectionString;
        // GET: student
        public ActionResult Index()
        {
           List<student> students= new List<student>();
            SqlConnection con = new SqlConnection(cs);
            string query = "select*from student";
            SqlCommand queryrun = new SqlCommand(query, con);
            con.Open();
            var fetch = queryrun.ExecuteReader();
            while (fetch.Read())
            {
                students.Add(new student
                {
                    Id = Convert.ToInt32(fetch["id"]),
                    Name = fetch["name"].ToString(),
                    Age = Convert.ToInt32(fetch["age"]),
                    Address = fetch["std_address"].ToString()
                });
            }
            
            return View(students);
        }

       
        // GET: student/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: student/Create
        [HttpPost]
        public ActionResult Create(student std)
        {
            try
            {
                SqlConnection con = new SqlConnection(cs);
                string query = "insert into student(name , age , std_address) values (@Name , @Age , @Address)";
                SqlCommand queryrun = new SqlCommand(query, con);
                queryrun.Parameters.AddWithValue("@Name", std.Name);
                queryrun.Parameters.AddWithValue("@Age", std.Age);
                queryrun.Parameters.AddWithValue("@Address", std.Address);
                con.Open();
                queryrun.ExecuteNonQuery();
                return RedirectToAction("Create");
            }
            catch
            {
                return View();
            }
        }

        // GET: student/Edit/5
        public ActionResult Edit(int id)
        {
            student std = null;
            SqlConnection con = new SqlConnection(cs);
            string query = "select*from student where id =@id";
            SqlCommand queryrun = new SqlCommand(query, con);
            queryrun.Parameters.AddWithValue("@id", id);
            con.Open();
            var fetch = queryrun.ExecuteReader();

            if (fetch.Read())
            {
                 std = new student{
                    Id = Convert.ToInt32(fetch["id"]),
                    Name = fetch["name"].ToString(),
                    Age = Convert.ToInt32(fetch["age"]),
                    Address = fetch["std_address"].ToString()
                };

            }
            
            return View(std);
        }

        // POST: student/Edit/5
        [HttpPost]
        public ActionResult Edit(student std) 
        {
            try
            {

                SqlConnection con = new SqlConnection(cs);
                string query1 = "update student set  name =@Name , age =@Age, std_address= @Address WHERE id=@id ";
                SqlCommand queryrun = new SqlCommand(query1, con);
                queryrun.Parameters.AddWithValue("@Name", std.Name);
                queryrun.Parameters.AddWithValue("@Age", std.Age);
                queryrun.Parameters.AddWithValue("@Address", std.Address);
                queryrun.Parameters.AddWithValue("@Id", std.Id);
                con.Open();
                queryrun.ExecuteNonQuery();
              
                return RedirectToAction("Index");
            }
            catch (SqlException er)
            {
                ViewBag.error = er.Message;
                return View();
            }
        }

        // GET: student/Delete/5
        public ActionResult Delete(int id)
        {
            student std = null;
            SqlConnection con = new SqlConnection(cs);
            string query = "select*from student where id =@id";
            SqlCommand queryrun = new SqlCommand(query, con);
            queryrun.Parameters.AddWithValue("@id", id);
            con.Open();
            var fetch = queryrun.ExecuteReader();

            if (fetch.Read())
            {
                std = new student
                {
                    Id = Convert.ToInt32(fetch["id"]),
                    Name = fetch["name"].ToString(),
                    Age = Convert.ToInt32(fetch["age"]),
                    Address = fetch["std_address"].ToString()
                };

            }
            return View();
        }

        // POST: student/Delete/5
        [HttpPost]
        public ActionResult Delete(student std)
        {
            try
            {

                SqlConnection con = new SqlConnection(cs);
                string query1 = "delete from student  WHERE id=@id ";
                SqlCommand queryrun = new SqlCommand(query1, con);
                //queryrun.Parameters.AddWithValue("@Name", std.Name);
                //queryrun.Parameters.AddWithValue("@Age", std.Age);
                //queryrun.Parameters.AddWithValue("@Address", std.Address);
                queryrun.Parameters.AddWithValue("@Id", std.Id);
                con.Open();
                queryrun.ExecuteNonQuery();

                return RedirectToAction("Index");
            }
            catch (SqlException er)
            {
                ViewBag.error = er.Message;
                return View();
            }
        }
        }
}
