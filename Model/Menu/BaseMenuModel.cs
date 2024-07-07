using HotelCalcApp.Model.Services.Database;
using System.Text;

namespace HotelCalcApp.Model.Menu
{
    public abstract class BaseMenuModel
    {
        private GettingDataFromDatabase _GettingDataFromDatabase = new GettingDataFromDatabase();
        internal GettingDataFromDatabase GettingDataFromDatabase {  get { return _GettingDataFromDatabase; } }

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
