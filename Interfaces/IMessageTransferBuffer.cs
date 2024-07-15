namespace HotelCalcApp.Interfaces
{
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