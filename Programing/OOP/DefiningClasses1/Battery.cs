using System;

namespace GSMClasses
{
    class Battery
    {
        public enum BatteryType //This is for ex.3
        {
            LiIon, NiMH, NiCd
        }

        //Fields
        private string model = null;
        private ushort? hoursIdle = null;
        private ushort? hoursTalk = null;
        private BatteryType type;

        //Constructors
        public Battery()
        {
        }

        public Battery(string model, BatteryType type, ushort? hoursIdle = null, ushort? hoursTalk = null)
        {
            this.Model = model;
            this.Type = type;
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
        }

        //Properties
        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Invalid battery model!");
                }
                this.model = value;
            }
        }

        public ushort? HoursIdle
        {
            get;
            set;
        }

        public ushort? HoursTalk
        {
            get;
            set;
        }

        public BatteryType Type
        {
            get;
            set;
        }
    }
}
