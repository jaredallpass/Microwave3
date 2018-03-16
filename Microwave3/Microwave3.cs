using System;

public class Microwave
{

    /// <summary>
    /// Allows you to manufacture a new microwave oven
    /// </summary>
    public Microwave()
    {       
    }

    private int Min;

    private int Minutes
    {
        get { return Min; }
        set { Min = value; }
    }

    private int Sec;

    private int Seconds
    {
        get { return Sec; }
        set { Sec = value; }
    }

    private TimeSpan Ts;

    private TimeSpan Timer
    {
        get { return Ts; }
        set { Ts = value; }
    }
    /// <summary>
    /// Sets the minutes and seconds of how long you would like to cook your food.
    /// </summary>
    /// <param name="Ts"></param>
    public void SetTimer(TimeSpan Ts)
    {
        Timer = Ts;
    }


    private string Food;

    private string Foods
    {
        get { return Food; }
        set { Food = value; }
    }

    /// <summary>
    /// Opens Microwave door allowing you to put your food in
    /// </summary>
    public void PutFoodIn(string Food)
    {
        Foods = Food;
    }

    /// <summary>
    /// Opens Microwave door allowing you to take your food out
    /// </summary>
    public void OpenDoor()
    {
        Food = null;
        Console.WriteLine("Door is now open.");
    }


    private int Temp;

    private int Temps
    {
        get { return Temp; }
        set { Temp = value; }
    }

    /// <summary>
    /// Sets the Temperature of your Microwave
    /// </summary>
    /// <param name="temp"></param>
    public void SetTemperature(int Temp)
    {
        Temps = Temp;
    }

    /// <summary>
    /// Starts Microwave and timer countdown
    /// </summary>
    public void StartMicrowave()
    {
        TimeSpan Tr = new TimeSpan(0, 0, 0);
        TimeSpan Tm = new TimeSpan(0, 0, 1);
        Console.WriteLine("Heat: {0}*C", Temp);
        Console.WriteLine("Food: {0}", Food);
        while (Ts > Tr)
        {
            Ts = Ts - Tm;

            Console.SetCursorPosition(0, 2);
            Console.Write("Time left: {0}", Ts);
            System.Threading.Thread.Sleep(1000);
        }
        Console.WriteLine("Enjoy your {0}", Food);
    }

}








