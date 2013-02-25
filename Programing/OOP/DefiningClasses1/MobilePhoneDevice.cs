using System;

namespace GSMClasses
{
    class MobilePhoneDevice
    {
        //Fields
        private string manufacturer = "Nokia";
        private string model = "6310i";
        private decimal? price = null;
        private string owner = null;
        private Battery battery = null;
        private Display display = null;

        //Static iPhone4S
        public static MobilePhoneDevice iPhone4S = new MobilePhoneDevice("Apple Inc", "iPhone4S", price: 299.99m, battery: new Battery(), display: new Display("3.5 in"));

        //Constructor
        public MobilePhoneDevice(string manufacturer, string model, decimal? price = null,
            string owner = null, Battery battery = null, Display display = null)
        {
            this.Manufacturer = manufacturer;
            this.Model = model;
            this.Price = price;
            this.Owner = owner;
            this.Battery = battery;
            this.Display = display;
        }

        //Properties
        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Invalid manufacturer!");
                }
                this.manufacturer = value;
            }
        }

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
                    throw new ArgumentException("Invalid model!");
                }
                this.model = value;
            }
        }

        public decimal? Price
        {
            get
            {
                return this.price;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Price cannot be negative");
                }
                this.price = value;
            }
        }

        public string Owner
        {
            get
            {
                return this.owner;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Invalid input!");
                }
                this.owner = value;
            }
        }

        public Battery Battery
        {
            get
            {
                return this.battery;
            }

            set
            {
                this.battery = value;
            }
        }

        public Display Display
        {
            get
            {
                return this.display;
            }

            set
            {
                this.display = value;
            }
        }

        //This is the override method for ex.4
        public override string ToString()
        {
            return string.Format("Devise information - Manufacturer: {0}, Model: {1}, Price: {2,C}, Battery: {3}, Display: {4}, Owner: {5}",
            this.manufacturer, this.model, this.price, this.battery, this.display, this.owner);
        }
    }
}
