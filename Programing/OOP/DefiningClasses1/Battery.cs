namespace GSMClasses
{
    class Battery
    {
        private string model;
        private int hoursIdle;
        private int hoursTalk;

        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                this.model = value;
            }
        }

        public int HoursIdle
        {
            get
            {
                return this.hoursIdle;
            }
            set
            {
                this.hoursIdle = value;
            }
        }

        public int HoursTalk
        {
            get
            {
                return this.hoursTalk;
            }
            set
            {
                this.hoursTalk = value;
            }
        }

        public Battery(string model, int hoursIdle, int hoursTalk)
        {
            this.model = model;
            this.hoursIdle = hoursIdle;
            this.hoursTalk = hoursTalk;
        }
    }
}
