using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microwave3
{
    class Program
    {
        static void Main(string[] args)
        {
            Microwave a = new Microwave();
            a.SetTemperature(100);
            a.SetTimer(new TimeSpan(0, 1, 0));
            a.PutFoodIn("Dog");
            a.Start();

        }
    }
}

