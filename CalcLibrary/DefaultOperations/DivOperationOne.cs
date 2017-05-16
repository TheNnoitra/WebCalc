using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcLibrary.DefaultOperations
{
    public class DivOperationOne : IOperation
    {
        public string NameofOperation
        {
            get { return "div"; }
        }

        public double Execute(double[] args)
        {
            return 0 ;
        }

        public double Execute(double x, double y)
        {
            return x;
        }
    }
}
