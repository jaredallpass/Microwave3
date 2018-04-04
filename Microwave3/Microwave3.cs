using System;
using System.Threading;

public class Microwave
{

    /// <summary>
    /// Allows you to manufacture a new microwave oven
    /// </summary>
    public Microwave()
    {
    }


    private TimeSpan _ts;

    /// <summary>
    /// Sets the minutes and seconds of how long you would like to cook your food.
    /// </summary>
    /// <param name="Ts"></param>
    public void SetTimer(TimeSpan a)
    {
        if (a > new TimeSpan(0, 30, 0))
        {
            throw new InvalidOperationException("Timer cannot be set for longer than 30 minutes.");
        }
        else if (a < new TimeSpan(0, 0, 10))
        {
            throw new InvalidOperationException("Timer cannot be set shorter than 10 seconds.");
        }

        _ts = a;
    }


    /// <summary>
    /// Retrieves the value of the amount of time remaining
    /// </summary>
    public void TimeRemaining()
    {
        Convert.ToString(_ts);
    }



    public void CurrentTemperature()
    {
        Convert.ToString(_temperature);
    }

    public void DoorState()
    {
        if (_door == false)
        {
            Console.WriteLine("Door is closed");
        }
        else if (_door == true)
        {
            Console.WriteLine("Door is open");
        }
    }



    /// <summary>
    /// If value == true, door is open. If value == false, door is closed.
    /// </summary>
    private bool _door;

    private void OpenDoor()
    {
        if (_door == false)
        {
            _door = true;
        }
        else if(_door == true)
        {
            throw new InvalidOperationException("Door is already open");
        }
    }

    private void CloseDoor()
    {
        if (_door == true)
        {
            _door = false;
        }
        else if (_door == false)
        {
            throw new InvalidOperationException("Door is already closed");
        }
    }


    private int _temperature;
    
    /// <summary>
    /// Sets the Temperature of your Microwave
    /// </summary>
    /// <param name="temp"></param>
    public void SetTemperature(int a)
    {
        if (a > 100)
        {
            throw new InvalidOperationException("Temperature can only be set between 10% and 100%");
        }
        else if (a < 10)
        {
            throw new InvalidOperationException("Temperature can only be set between 10% and 100%");
        }

        _temperature = a;       
    }

    private bool _microwaveState = false;

    /// <summary>
    /// Returns a string stating whether or not the microwave is running
    /// </summary>
    public void MicrowaveState()
    {
        if (_microwaveState == false)
        {
            Console.WriteLine("Microwave is not running");
        }
        else if (_microwaveState == true)
        {
            Console.WriteLine("Microwave is currently running");
        }
    }

    /// <summary>
    /// Starts Microwave and timer countdown
    /// </summary>
    public void Start()
    {
        if (_ts == new TimeSpan(0, 0, 0))
        {
            throw new InvalidOperationException("Timer not set, please set your timer to start the microwave.");
        }
        else if (_temperature == 0)
        {
            throw new InvalidOperationException("Temperature is not set, please set your temperature to start the microwave.");
        }    
                   
        TimeSpan a = new TimeSpan(0, 0, 0);
        TimeSpan b = new TimeSpan(0, 0, 1);

        while (_ts != a)
        {
            _microwaveState = true;
            _ts = _ts - b;
            Console.Write("Time left: {0}", _ts);
            Thread.Sleep(1000);
            while (Console.KeyAvailable)
            {
                var consoleKey = Console.ReadKey(true);

                if (consoleKey.Key == ConsoleKey.Escape)
                {
                    _ts = a;
                }

            }
        }
        _microwaveState = false;
    }
}









