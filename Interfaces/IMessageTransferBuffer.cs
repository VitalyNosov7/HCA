namespace HotelCalcApp.Interfaces
{
    //  TODO:   интерфейс не реализован. Подумать,, где и как его использовать!
    internal interface IMessageTransferBuffer
    {
        private static String _message = String.Empty;
        public String Message
        {
            get { return _message; }
            set { _message = value; }
        }
    }
}