namespace GSMClasses
{
    class MobilePhoneDevice
    {
        private string model;
        private string manufacturer;
        private decimal price;
        private string owner;
        private Battery battery;
        private Display display;

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

        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }

            set
            {
                this.manufacturer = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }

            set
            {
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
    }
}
