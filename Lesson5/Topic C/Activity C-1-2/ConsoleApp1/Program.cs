using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static Car myCar = new Car();
        static bool carCrash;

        static void Main(string[] args)
        {
            myCar.Crash += MyCar_Crash;
            myCar.Brand = "Ferrari";
            myCar.Speed = 0;
            myCar.SpeedUp();
            string ans = String.Empty;
            while (ans.ToUpper() != "N" )
            {
                myCar.SpeedUp();
                if (carCrash) break;
                Console.WriteLine($"My {myCar.Brand } goes at {myCar.Speed} Mi/h.");

                Console.WriteLine("Do you want to accelerate? (Y/N)?");
                ans = Console.ReadLine();
            }
        }

        private static void MyCar_Crash(object sender, EventArgs e)
        {
            var resultingSpeed = ((CrashEventArgs)e).ResultingSpeed;
            var CrashTime = ((CrashEventArgs)e).CrashTime;
            Console.WriteLine($"My {myCar.Brand } has crashed at {CrashTime}\n");
            Console.WriteLine($"The resulting speed would have been {resultingSpeed} Mi/h\n");
            carCrash = true;
        }
    }
}
