using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LabRob2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Task1();
            Task2();
        }
        static void Task1()
        {

            OperatingSystem os = System.Environment.OSVersion;
            Console.WriteLine("Platform: {0}", os.Platform);
            System.Console.WriteLine("The current date and time so " + System.DateTime.Now);
            

        }
        static double Task2()
        {
            System.Console.ReadLine();
            // x2, y;
            Console.WriteLine("Input x = \r");
            double x1 = Convert.ToDouble(Console.ReadLine());
            
            /*x2 = Convert.ToDouble(Console.ReadLine());
            y = Convert.ToDouble(Console.ReadLine());*/
            double K = 1.3 * Math.Exp(-x1 / 2) + Math.Abs(Math.Cos((2 * Math.PI * x1 / 3) - 1.4)) + 6 / 11;
            Console.WriteLine("x = {0} \t K = {1}", x1, K);

            return K;

        }
    }
}
