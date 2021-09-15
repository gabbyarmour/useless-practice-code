/* Note: This code serves as practice for Object Oriented Programming (OOP). 
   Each object controls itself. */

using System;

public class SecondsTimer
{
    private DateTime _startTime { get; set; } // Empty DateTime
    private DateTime _stopTime { get; set; } // Empty DateTime
    private bool _running; // Preserves state of class methods

    // Start the timer
    public void Start()
    {
        if (_running)
            throw new InvalidOperationException("Seconds Timer is already running!");
            
        _startTime = DateTime.Now;
        _running = true;  
    }

    // Stop the timer
    public void Stop()
    {
        if(!_running)
            throw new InvalidOperationException("Seconds Timer is not running!");

        _stopTime = DateTime.Now;
        _running = false;
            
    }

    // Return elapsed time
    public TimeSpan GetInterval()
    {
        return _stopTime - _startTime;
    }     
}

