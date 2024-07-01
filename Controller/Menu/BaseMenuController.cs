using HotelCalcApp.Model.Data;
using System.Text;

namespace HotelCalcApp.Controller.Menu
{
    public abstract class BaseMenuController
    {
        internal HotelCalcAppDBContext _DataBase = new HotelCalcAppDBContext();
        internal AddingDataToDatabaseMenuController _AddingDataToDatabaseMenuController;
        internal DataExtractionMenuController _DataExtractionMenuController;

        internal ConsoleKeyInfo btn;

        /// <summary>Сообщение</summary>
        private StringBuilder _Message = new StringBuilder();
        public StringBuilder Message
        {
            get { return _Message; }
            set { _Message = value; }
        }
    }
}
