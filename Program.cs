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
            Console.WriteLine("Завдання 1");
            OperatingSystem os = System.Environment.OSVersion;
            Console.WriteLine("Platform: {0}", os.Platform);
            System.Console.WriteLine("The current date and time so " + System.DateTime.Now);
            System.Console.ReadLine();
        }
        static double Task2()
        {
            Console.WriteLine("Завдання 2");
            System.Console.WriteLine("The current date and time is = " + System.DateTime.Now);
            double pi = 3.14159;
            double x1 = Convert.ToDouble(Console.ReadLine());
            double K = 1.3 * Math.Exp(-x1 / 2) + Math.Abs(Math.Cos((2 * pi * x1 / 3) - 1.4)) + 6 / 11;
            Console.WriteLine("x = {0} \t y = {1}", x1, K);
            System.Console.ReadLine();
            return K;

        }
    }
}
