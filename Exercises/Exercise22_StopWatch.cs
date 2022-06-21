using System;

namespace Exercise22
{
    public class StopWatch
    {
        public TimeSpan Duration { get; set; }
        private DateTime _startTime;
        private bool _hasStarted;
        public void Start()
        {
            if (_hasStarted)
                throw new InvalidOperationException("The stopwatch has already been started before.");
            _startTime = DateTime.Now;
            _hasStarted = true;
        }

        public void Stop()
        {
            Duration = DateTime.Now - _startTime;
            _hasStarted = false;
        }
    }
}
