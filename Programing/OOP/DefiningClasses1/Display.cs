using System;

namespace GSMClasses
{
    class Display
    {
        //Fields
        private string size;
        private uint? colors = null;

        //Constructors
        public Display()
        {
        }

        public Display(string size, uint? colors = null)
        {
            this.Size = size;
            this.Colors = colors;
        }

        //Properties
        public string Size
        {
            get
            {
                return this.size;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Invalid input!");
                }
                this.size = value;
            }
        }

        public uint? Colors
        {
            get;
            set;
        }
    }
}
