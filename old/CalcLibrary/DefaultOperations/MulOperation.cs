using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcLibrary.DefaultOperations
{
    public class MulOperation : IOperationArgs
    {
        public string NameOfOperation
        {
            get { return "mul"; }
        }

        public double Execute(IEnumerable<double> args)
        {
            return 0;
        }

        public double Execute(double x, double y)
        {
            return x * y;
        }
    }
}
