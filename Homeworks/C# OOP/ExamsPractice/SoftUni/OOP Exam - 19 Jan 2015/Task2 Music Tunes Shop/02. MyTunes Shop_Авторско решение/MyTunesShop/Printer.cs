namespace MyTunesShop
{
    using System.Text;

    public class Printer
    {
        private StringBuilder output;

        public Printer()
        {
            this.output = new StringBuilder();
        }

        public void Print(string text)
        {
            this.output.Append(text);
        }
        
        public void Print(string format, params object[] args)
        {
            this.output.AppendFormat(format, args);
        }

        public void PrintLine(string text)
        {
            this.output.AppendLine(text);
        }

        public void PrintLine(string format, params object[] args)
        {
            this.output.AppendFormat(format, args).AppendLine();
        }

        public string SendToConsole()
        {
            return this.output.ToString();
        }
    }
}
