using HotelCalcApp.Interfaces;

namespace HotelCalcApp.View.Menu
{
    public abstract class BaseMenuView : IMessageTransferBuffer
    {
        public void MessageOutput(String message)
        {
            Console.WriteLine(message);
        }
    }
}
