using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding  = System.Text.Encoding.UTF8;

            var tracker = new DollarTracker();
            var subscriber = new DollarSubscriber(tracker);
            tracker.SetDollarRate(27.5);
            tracker.SetDollarRate(35.0);
            tracker.SetDollarRate(41.46);
            tracker.SetDollarRate(42.35);
            Console.WriteLine("Натисніть будь-яку клавішу для виходу");
            Console.ReadKey();
        }
    }
}