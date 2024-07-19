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

        /// <summary>Отображение пунктов Меню для добавления данных в базу данных</summary>
        private AddingDataToDatabaseMenuView _AddingDataToDatabaseMenuView = new AddingDataToDatabaseMenuView();
        public AddingDataToDatabaseMenuView AddingDataToDatabaseMenuView
        {
            get { return _AddingDataToDatabaseMenuView; }
            set { _AddingDataToDatabaseMenuView = value; }
        }
    }
}
