using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program2
    {
        static void Main(string[] args)
        {
            double angle = 30.00d;
            double num = 34.00d;
            Console.WriteLine($" {angle} degrees are {angle.ToRadians()} radians.");
            Console.WriteLine($" The Cubic Root of {num} is {num.CubeRoot()} \n");
        }
    }
    public static class Extensions
    {
        public static double ToRadians(this double angle)
        {
            return Convert.ToSingle(Math.PI / 180) * angle;
        }
        public static double CubeRoot(this double number)
        {
            return Math.Pow(number, (1.0/3));
        }
    }

}
