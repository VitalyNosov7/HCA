namespace HotelCalcApp.Controller.Menu
{
    /// <summary>Базовый Контроллер Меню</summary>
    public abstract class BaseMenuController
    {
        private AddingDataToDatabaseMenuController _addingDataToDatabaseMenuController = new AddingDataToDatabaseMenuController();
        public AddingDataToDatabaseMenuController AddingDataToDatabaseMenuController { get { return _addingDataToDatabaseMenuController; } }

        private DataExtractionMenuController _dataExtractionMenuController = new DataExtractionMenuController();
        public DataExtractionMenuController DataExtractionMenuController { get { return _dataExtractionMenuController; } }

        private DataBaseMenuController _dataBaseMenuController = new DataBaseMenuController();
        public DataBaseMenuController DataBaseMenuController { get { return _dataBaseMenuController; } }

        /// <summary>Сообщение</summary>
        private String _message = String.Empty;
        public String Message
        {
            get { return _message; }
            set { _message = value; }
        }
    }
}
