﻿using CaclLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Output = System.Console; //alias - shortcut


namespace Console
{
    class Program
    {//Console.exe "1" "2"
        static void Main(string[] args)
        {
            var test = new Calc();

            int x;
            int.TryParse(args[0], out x); //v args zapisivaet v X

            int y;
            int.TryParse(args[1], out y); //v args zapisivaet v Y

            var operation = args[2];

            double result = 0;

            if (operation == "sum")
            {
                result = test.Sum(x, y);
            }
           
            else if (operation == "divide")
            {
                result = test.Divide(x, y);
            }

            Output.WriteLine($"{x}{operation}{y}={result}");

            Output.ReadKey();

        }
    }
}
