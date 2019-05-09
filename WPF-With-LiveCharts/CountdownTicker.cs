using System;

namespace WPF_With_LiveCharts
{
    class CountdownTicker
    {
        private System.Timers.Timer _timer;
        private DateTime _startTime;
        private Random _rnd;
        int number;

        public void Start()
        {
            _startTime = DateTime.Now;
            _timer = new System.Timers.Timer(1000 * 1); // 1 second
            _timer.Elapsed += timer_Elapsed;
            _timer.Enabled = true;
            Console.WriteLine("Timer has started");
            _rnd = new Random();
        
        }

        void timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            TimeSpan timeSinceStart = DateTime.Now - _startTime;
            number = number + _rnd.Next(1, 5);
            string output = string.Format(
                "{0},{1}\r\n", 
                DateTime.Now.ToLongDateString(), 
                (int)Math.Floor(timeSinceStart.TotalMinutes)
                );
            Console.Write(output);
        }
    }
}

