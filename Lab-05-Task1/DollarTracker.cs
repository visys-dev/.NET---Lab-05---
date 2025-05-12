using System;

namespace Task1
{
    public class DollarTracker
    {
        public delegate void DollarUpdatedEventHandler(double newRate);
        public event DollarUpdatedEventHandler DollarUpdated;

        public void SetDollarRate(double newRate)
        {
            OnDollarUpdated(newRate);
        }

        protected virtual void OnDollarUpdated(double newRate)
        {
            DollarUpdated?.Invoke(newRate);
        }
    }
}