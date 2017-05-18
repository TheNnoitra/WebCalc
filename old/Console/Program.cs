using CalcLibrary;
using Output = System.Console;

namespace Console
{
    class Program
    {
        // console.exe "1" "2"

        static void Main(string[] args)
        {
            var test = new Calc();

            double x;
            double.TryParse(args[0], out x);

            double y;
            double.TryParse(args[1], out y);

            var ioperation = args[2];

            double result = 0;
            
            Output.WriteLine($"{result}");

            Output.ReadKey();
        }
    }
}
