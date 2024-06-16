using System.Text;

namespace HotelCalcApp.View.Menu
{
    public abstract class BaseMenuView
    {
        private StringBuilder _Message = new StringBuilder();

        public StringBuilder Message
        {
            get { return _Message; }
            set { _Message = value; }
        }

        public void MessageOutput(StringBuilder message)
        {
            Console.WriteLine(message);
        }
    }
}
