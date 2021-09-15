using System;
using System.Collections.Generic;
/* Note: This code is to be run as a console application. It showcases DateTime, TimeSpan,
   Beep, and Sleep. */

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        var secondsTimer = new SecondsTimer();

        Console.WriteLine("Would you like to start the timer? [yes/no]");
        string input = Console.ReadLine().ToLower();
        bool on_off = true;

        while (on_off)
        {
            if(input == "yes")
            {
                Console.Clear();
                Console.WriteLine("Please enter the duration of the timer in seconds: ");
                int seconds = Convert.ToInt32(Console.ReadLine());

                secondsTimer.Start();

                Console.Clear();
                for (int i = 1; i <= seconds; i++)
                {
                    Console.Beep(392, 450); // frequency = G, duration = 450 milliseconds
                    Console.WriteLine(TimeSpan.FromSeconds(i));
                    Thread.Sleep(500); // duration = 500 milliseconds
                    Console.Clear();
                }
                
                secondsTimer.Stop();

                Console.WriteLine("Actual duration: " + secondsTimer.GetInterval()); // to string isn't needed
                Console.WriteLine("Would you like to go again? [yes/no]");
                input = Console.ReadLine();
            }
            
            else if(input != "yes")
            {
                Console.Clear();
                Console.WriteLine("Goodbye :)");
                Thread.Sleep(1500);
                on_off = false;
            }      
        } 
    }
}

