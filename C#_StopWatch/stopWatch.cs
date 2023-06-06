namespace WatchDive
{
    class StopWatch
    {
        private DateTime end_Time;
        private DateTime start_Time;
        public DateTime startTime
        {
            get {return start_Time;}
            set {start_Time = value;}
        }

        //This one is better
        public DateTime endTime {
            get { return end_Time;}
            set {end_Time = value;}
        }

        public StopWatch()
        {
            this.start_Time = DateTime.Now;
            end_Time = start_Time;
        }

        public void Start()
        {
            this.start_Time = DateTime.Now;
        }

        public void Stop()
        {
            this.end_Time = DateTime.Now;
        }

        public int GetElapsedTime()
        {
            TimeSpan elapsedTime = end_Time - start_Time;
            return (int)elapsedTime.TotalMicroseconds;
        }

    }
}
