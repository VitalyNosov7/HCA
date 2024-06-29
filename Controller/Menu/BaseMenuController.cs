
using HotelCalcApp.Model.Data;
using System.Text;

namespace HotelCalcApp.Controller.Menu
{
    public abstract class BaseMenuController
    {
        /// <summary>Контекст базы данных</summary>
        internal HotelCalcAppDBContext db = new HotelCalcAppDBContext();
        internal AddDataToDBMenuController addDataToDBMenuController;
        internal GetDataFromDBMenuController getDataFromDBMenuController;

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
