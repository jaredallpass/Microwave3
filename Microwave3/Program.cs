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
            Console.WriteLine("Welcome to your Microwave!");
            Console.WriteLine("Put your food in the microwave..");
            string food = Console.ReadLine();
            Console.WriteLine("Please enter the amount of minutes:");
            int min = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the amount of seconds:");
            int sec = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the heat required:");
            int heat = int.Parse(Console.ReadLine());
            TimeSpan ts = new TimeSpan(0, min, sec);
            TimeSpan tr = new TimeSpan(0, 0, 0);
            TimeSpan tm = new TimeSpan(0, 0, 1);
            while (ts > tr) {
                ts = ts - tm;
                Console.SetCursorPosition(0, 12);
                Console.Write("Your {1} will be ready in {0} ", ts, food);
                System.Threading.Thread.Sleep(1000);
            }
            Console.WriteLine("\r\nYour food is ready!");
            Console.WriteLine("Press enter to remove your {0}..", food);
            string key = Console.ReadLine();
            if (key == "")
                Console.WriteLine("Enjoy your {0}!", food);
            else
                Console.WriteLine("You did not press enter.");
        }
    }
}

