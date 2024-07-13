using System.Text;

namespace HotelCalcApp.Controller.Menu
{
    public abstract class BaseMenuController
    {
        internal AddingDataToDatabaseMenuController _addingDataToDatabaseMenuController;
        internal DataExtractionMenuController _dataExtractionMenuController;
        internal DataBaseMenuController _dataBaseMenuController;

        //  TODO:   после переноса методов из контроллеров - удалить это поле.
        internal ConsoleKeyInfo btn;

        //  TODO:   после переноса методов из контроллеров - удалить это поле.
        /// <summary>Сообщение</summary>
        private StringBuilder _Message = new StringBuilder();
        public StringBuilder Message
        {
            get { return _Message; }
            set { _Message = value; }
        }
    }
}
