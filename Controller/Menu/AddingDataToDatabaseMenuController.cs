using HotelCalcApp.Model.Menu;
using HotelCalcApp.View.Menu;

namespace HotelCalcApp.Controller.Menu
{
    /// <summary>Контроллер  Меню добавления данных в базу данных</summary>
    public class AddingDataToDatabaseMenuController : BaseMenuController
    {
        private AddingDataToDatabaseMenuModel _AddingDataToDatabaseMenuModel = new AddingDataToDatabaseMenuModel();
        public AddingDataToDatabaseMenuModel AddingDataToDatabaseMenuModel
        {
            get { return _AddingDataToDatabaseMenuModel; }
            set { _AddingDataToDatabaseMenuModel = value;}
        }
    }
}
