using HotelCalcApp.Model.Menu;
using HotelCalcApp.View.Menu;

namespace HotelCalcApp.Controller.Menu
{
    /// <summary>Контроллер Главного Меню </summary>
    public class MainMenuController : BaseMenuController
    {
        public MainMenuController()
        {
            MainMenuModel.StartApp();
            MainMenuModel.MainCommandsMenu();
        }

        private MainMenuModel _mainMenuModel = new MainMenuModel();
        public MainMenuModel MainMenuModel
        {
            get { return _mainMenuModel; }
            set { _mainMenuModel = value; }
        }

        /// <summary>Основное Отображение</summary>
        private MainMenuView _mainView = new MainMenuView();
        public MainMenuView MainView
        {
            get { return _mainView; }
            set { _mainView = value; }
        }
    }
}
