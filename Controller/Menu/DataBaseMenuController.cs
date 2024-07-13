using HotelCalcApp.Model.Menu;
using HotelCalcApp.View.Menu;

namespace HotelCalcApp.Controller.Menu
{
    /// <summary>Контроллер взаимодействия с Базой данных(CRUD)</summary>
    public class DataBaseMenuController : BaseMenuController
    {
        private DataBaseMenuModel _DataBaseMenuModel = new DataBaseMenuModel();
        public DataBaseMenuModel DataBaseMenuModel
        {
            get { return _DataBaseMenuModel; }
            set { _DataBaseMenuModel = value;}
        }
    }
}
