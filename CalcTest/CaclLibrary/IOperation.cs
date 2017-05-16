using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaclLibrary
{
    interface IOperation
    {
        
            string Name { get; }
            double Calc(int x, int y);
       
    }
}
