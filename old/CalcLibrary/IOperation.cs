using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcLibrary
{
    public interface IOperation
    {
        string NameOfOperation { get; }

        double Execute(double x, double y);
    }

    public interface IOperationArgs : IOperation
    {
        double Execute(IEnumerable<double> args);
    }
}
