using System;
using System.Threading;

namespace Lab_9
{
    public class Car
    {
        public event Action<Car, double> OnOverSpeedAction;
        private bool _running;
        private int  _refueling_perc;
        private int _speed;
        
        private System.Threading.Timer _timer;
        
        public int MaxSpeed { get; set; }
        public int FuelСonsumption { get; set; }

        public Car()
        {
            _timer = new System.Threading.Timer(this.OnTimedEvent, null, 1000, Timeout.Infinite);
            OnOverSpeedAction += OnOverSpeed;
        }

        private void OnOverSpeed(Car car, double speed)
        {
            Console.WriteLine($"Overspeed speed: {_speed}");
            _speed = 0;
        }
        
        private void OnTimedEvent(Object source)
        {
            _speed += 20;
            if (_speed > MaxSpeed)
            {
                OnOverSpeedAction?.Invoke(this, _speed);
            }

            Console.WriteLine($"Car speed: {_speed}");
            _timer = new System.Threading.Timer(this.OnTimedEvent, null, 1000, Timeout.Infinite);
        }
        
        public Car Start()
        {
            _running = true;
            _timer.Change(0, 1000);
            return this;
        }
        public Car Stop()
        {
            _running = false;
            _timer.Dispose();
            return this;
        }

        public Car Refueling(int refueling_perc)
        {
            _refueling_perc = refueling_perc;
            return this;
        }
    }
}