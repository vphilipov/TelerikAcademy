namespace GSMClasses
{
    class Display
    {
        private int size;
        private int colors;

        public int Size
        {
            get
            {
                return this.size;
            }
            set
            {
                this.size = value;
            }
        }

        public int Colors
        {
            get
            {
                return this.colors;
            }
            set
            {
                this.colors = value;
            }
        }

        public Display(int size, int colors)
        {
            this.size = size;
            this.colors = colors;
        }
    }
}
