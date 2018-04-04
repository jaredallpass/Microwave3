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
            Microwave mv = new Microwave(); // door is closed, temperature is set (lets say 100%), time remaining is 0, iscooking is false
            mv.TimeRemaining = new TimeSpan(0, 0, 5);

            Console.WriteLine("The temperature is set at {0:P} for {1} time.", mv.Temperature, mv.TimeRemaining);

            // how do we open the door?

            //mv.DoorState // mv.IsDoorClosed // true/false .... 
            if (!mv.IsDoorClosed) 
            {
                Console.WriteLine("The doors still open dummy.");
                Console.ReadLine();
                return;
            }

            if (mv.TimeRemaining == new TimeSpan())
            {
                Console.WriteLine("No time is set for cooking.");
                Console.ReadLine();
                return;
            }

            mv.Start(); // door closed, time remaining, temperature set
            
            while (mv.IsCooking)
            {
                System.Threading.Thread.Sleep(1000);
                Console.Write(".");
            }

            Console.WriteLine("done.");
            Console.ReadLine();

        }
    }
}

