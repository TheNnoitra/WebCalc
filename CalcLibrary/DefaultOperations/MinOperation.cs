using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcLibrary.DefaultOperations
{
    public class MinOperation : IOperationargs
    {
        public string NameofOperation
        {
            get { return "min"; }
        }

        public double Execute(double[] args)
        {
            throw new NotImplementedException();
        }

        public double Execute(double x, double y)
        {
            return x - y;
        }
    }
}
