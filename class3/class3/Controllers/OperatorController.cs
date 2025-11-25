using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Mvc;

namespace class3.Controllers
{
    public class OperatorController : Controller
    {
        // GET: Operator
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(FormCollection obj)
        {
            try
            {
                int num1 = Convert.ToInt32(obj["num1"]);
                int num2 = Convert.ToInt32(obj["num2"]);
                string opt = obj["operator"];
                string result = string.Empty;
                switch (opt)
                {
                    case "Add":
                        result = $"Addition:{num1 + num2}";
                        break;
                    case "Sub":
                        result = $"Subtraction:{num1 - num2}";
                        break;
                    case "multiply":
                        result = $"Multiply:{num1 * num2}";
                        break;
                    case "divide":
                        result = $"Division:{num1 / num2}";
                        break;
                }

                ViewBag.result = result;
            }
            catch (Exception ex)
            {
                ViewBag.result = $"Error: {ex.Message}";
            }


            return View();
        }
    }
}