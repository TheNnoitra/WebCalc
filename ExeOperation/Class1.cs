using CalcLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExeOperation
{
    public class ExeOperation : IOperation
    {
        public string NameofOperation => "Excel";

        string IOperation.NameofOperation
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public double Sum(double x, double y)
        {
            return x + y;
        }

        double IOperation.Execute(double x, double y)
        {
            throw new NotImplementedException();
        }
    }
}
