using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    //
    // Summary:
    //     This class inherits from System.Object class.
    //     It represents an abstraction of a real car.
    public class Car
    {
        public string Brand { get; set; }
        public byte Speed { get; set; }
        public void SpeedUp()
        {
            this.Speed += 30;
            if (this.Speed > 200)
            {
                var Crashdata = new CrashEventArgs()
                {
                    CrashTime = DateTime.Now.ToLongTimeString(),
                    ResultingSpeed = Speed + 30
                };
                //Crash?.Invoke(this, new EventArgs());
                Crash?.Invoke(this, Crashdata);
            }
        }
        public event EventHandler Crash;
    }

    public class CrashEventArgs : EventArgs
    {
        public int ResultingSpeed { get; set; }
        public string CrashTime { get; set; }
    }
}