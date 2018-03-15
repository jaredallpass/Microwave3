using System;

public class Microwave
{

    /// Allows a new microwave to be installed    
    public Microwave()
    {       
    }

    public int min;

    public int minutes
    {
        get { return min; }
        set { min = value; }
    }

    public int sec;

    public int seconds
    {
        get { return sec; }
        set { sec = value; }
    }

    public TimeSpan ts;

    public TimeSpan timer
    {
        get { return ts; }
        set { ts = value; }
    }
    /// Allows you to set the minutes and seconds of how long your food must be cooked
    public void SetTimer(TimeSpan ts)
    {
        timer = ts;
    }

    /// <summary>
    /// ////////////////////////////////////////////////////////////////
    /// </summary>

    public string food;

    public string foods
    {
        get { return food; }
        set { food = value; }
    }

    /// Allows you to specify the food you're putting in
    public void PutFoodIn(string food)
    {
        foods = food;
    }

    public void TakeFoodOut()
    {
        food = null;
        Console.WriteLine("Microwave is now empty");
    }

    /// <summary>
    /// ////////////////////////////////////////////////////////////////
    /// </summary>

    public int temp;

    public int temps
    {
        get { return temp; }
        set { temp = value; }
    }
    /// Allows you to set the heat in degrees celsius
    public void Temperature(int temp)
    {
        temps = temp;
    }
    /// Allows you to start your Microwave
    public void Start()
    {
        TimeSpan tr = new TimeSpan(0, 0, 0);
        TimeSpan tm = new TimeSpan(0, 0, 1);
        Console.WriteLine("Heat: {0}*C", temp);
        Console.WriteLine("Food: {0}", food);
        while (ts > tr)
        {
            ts = ts - tm;

            Console.SetCursorPosition(0, 2);
            Console.Write("Time left: {0}", ts);
            System.Threading.Thread.Sleep(1000);
        }
        Console.WriteLine("Enjoy your {0}", food);
    }

    /// <summary>
    /// ////////////////////////////////////////////////////////////////
    /// </summary>
    


}








