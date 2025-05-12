using System;

namespace Task1
{
    public class DollarSubscriber
    {
        public DollarSubscriber(DollarTracker tracker)
        {
            tracker.DollarUpdated += rate =>
                Console.WriteLine($"Новий курс долара: {rate}");
        }
    }
}