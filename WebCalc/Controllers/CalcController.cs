using CalcLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using WebCalc.Models;

namespace WebCalc.Controllers
{
    public class CalcController : Controller
    {
        // GET: Calc
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(OperationViewModel model)
        {
            var calc = new Calc(@"C:\Users\Asus\Desktop\CalcTest\WebCalc\bin");

            var result = calc.Execute(model.Operation, model.InputData.Split(' '));


            model.Result = $"{result}";

            return View(model);
        }

    }
}