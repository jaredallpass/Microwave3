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

    private TimeSpan Timer
    {
        get { return _ts; }
        set { _ts = value; }
    }
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
        else
        {
            Timer = a;
        }
    }

    private string _food;

    private string Food
    {
        get { return _food; }
        set { _food = value; }
    }

    public void PutFoodIn(string a)
    {
        Food = a;
    }

    private int _temperature;

    private int Temperature
    {
        get { return _temperature; }
        set { _temperature = value; }
    }
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
        else
        {
        Temperature = a;
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
        else
        {
            TimeSpan a = new TimeSpan(0, 0, 0);
            TimeSpan b = new TimeSpan(0, 0, 1);
            Console.WriteLine("Heat: {0}*C", _temperature);
            Console.WriteLine("Food: {0}", _food);
            while (_ts != a)
            {
                _ts = _ts - b;
                Console.SetCursorPosition(0, 2);
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
            Console.WriteLine("\r\nEnjoy your {0}", _food);
        }
    }
}









