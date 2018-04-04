using System;
using System.Threading;

/// <summary>
/// Similates interaction with a microwave.
/// </summary>
public class Microwave
{

    /// <summary>
    /// Initializes a new instance of a Microwave class.
    /// </summary>
    public Microwave()
    {
        _temperature = 1M;
        _timeRemaining = new TimeSpan();
        IsCooking = false;
        IsDoorClosed = true;
    }

    private TimeSpan _timeRemaining;
    /// <summary>
    /// Gets or sets the remaining cooking time. 
    /// </summary>
    public TimeSpan TimeRemaining
    {
        get
        {
            return _timeRemaining;
        }
        set
        {
            if (value < new TimeSpan())
            {
                throw new InvalidOperationException("The time remaining cannot be less than 0.");
            }

            if (IsCooking && value == new TimeSpan())
            {
                Stop();
            }

            _timeRemaining = value;
        }
    }

    private decimal _temperature;
    /// <summary>
    /// Gets or sets the cooking temperature as a percentage.
    /// </summary>
    /// <param name="temp"></param>
    public decimal Temperature
    {
        get
        {
            return _temperature;
        }
        set
        {
            if (value > 1M)
            {
                throw new InvalidOperationException("Temperature can only be set between 10% and 100%.");
            }
            else if (value < 0.1M)
            {
                throw new InvalidOperationException("Temperature can only be set between 10% and 100%.");
            }

            _temperature = value;
        }
    }

    /// <summary>
    /// Returns true if the door is closed.
    /// </summary>
    public bool IsDoorClosed { get; set; }

    /// <summary>
    /// Returns true if the microwave is busy cooking else returns false.
    /// </summary>
    public bool IsCooking { get; private set; }

    /// <summary>
    /// Starts Microwave and timer countdown
    /// </summary>
    public void Start()
    {
        if (TimeRemaining == new TimeSpan(0, 0, 0))
        {
            throw new InvalidOperationException("A time remaining is required to start cooking.");
        }

        if (!IsDoorClosed)
        {
            throw new InvalidOperationException("The door must be closed to start cooking.");
        }

        IsCooking = true;
        if (Timer == null)
        {
            Timer = new Timer(new TimerCallback((o) => Cook()), null, 0, 1000);
        }
    }

    private Timer Timer { get; set;  }

    /// <summary>
    /// Executes the cooking processes.
    /// </summary>
    private void Cook()
    {
        TimeRemaining = TimeRemaining.Subtract(new TimeSpan(0, 0, 1));

        //if (TimeRemaining == new TimeSpan())
        //{
        //    Stop();
        //}
    }

    /// <summary>
    /// Stops the cooking process.
    /// </summary>
    public void Stop()
    {
        IsCooking = false;
        Timer.Dispose();
        Timer = null;
    }

}









