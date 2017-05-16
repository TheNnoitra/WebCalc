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

            int x;
            int.TryParse(args[0], out x);

            int y;
            int.TryParse(args[1], out y);

            var ioperation = args[2];

            double result = 0;
            
            Output.WriteLine($"{x} {ioperation} {y} = {result}");

            Output.ReadKey();
        }
    }
}
