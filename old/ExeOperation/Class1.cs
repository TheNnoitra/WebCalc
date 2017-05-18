using CalcLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExeOperation
{
    public class ExeOperation : IOperationArgs
    {
        public string NameOfOperation => "excel";

        public double Execute(IEnumerable<double> args)
        {
            return args.Sum();
        }

        public double Execute(double x, double y)
        {
            return (x+y)*2;
        }
    }
}


