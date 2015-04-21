namespace MobilePhone
{
    public class Display
    {
        // fields
        private int sizeOfDisplay;
        private int numberOfColors;

        // empty constrictor
        public Display()
        {

        }

        // constructor with size and colors
        public Display(int size, int numberOfColors)
        {
            this.sizeOfDisplay = size;
            this.numberOfColors = numberOfColors;
        }

        // property .Size 
        public int Size
        {
            get
            {
                return this.sizeOfDisplay;
            }
        }

        // property .NumberOfColors
        public int NumberOfColors
        {
            get
            {
                return this.numberOfColors;
            }
        }
    }
}
