using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcLibrary.DefaultOperations
{
    public class MulOperation : IOperationargs
    {
        public string NameofOperation
        {
            get { return "mul"; }
        }

        public double Execute(double[] args)
        {
            throw new NotImplementedException();
        }

        public double Execute(double x, double y)
        {
            return x * y;
        }
    }
}
