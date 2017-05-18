using CalcLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebCalc.Models
{
    public class OperationViewModel
    {


        public string Operation { get; set; }

        public string InputData { get; set; }

        public string Result { get; set; }
        public SelectList Operations { get; internal set; }

    }
}