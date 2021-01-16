using System;

namespace LinkedListImplementation
{
    public class Stopwatch
    {
        private DateTime _start;
        private DateTime _end;
        private bool _isRunning;

        public void Start()
        {
            if (_isRunning)
            {
                throw new InvalidOperationException("Stopwatch is already running!");
            }

            _start = DateTime.Now;
            _isRunning = true;
        }
        public void Stop()
        {
            if (_isRunning == false)
            {
                throw new InvalidOperationException("Stopwatch is not running!");
            }

            _end = DateTime.Now;
        }

        public TimeSpan TimeSpan
        {
            get
            {
                return _end - _start;
            }
        }
    }
}
