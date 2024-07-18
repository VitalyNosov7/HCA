using HotelCalcApp.Controller.Menu;
using HotelCalcApp.Model.Services.Database;
using HotelCalcApp.View.Menu;

namespace HotelCalcApp.Model.Menu
{
    public abstract class BaseMenuModel
    {
        private const String STOP_APP_MESSAGE = "_Выход из программы";

        private GettingDataFromDatabase _gettingDataFromDatabase = new GettingDataFromDatabase();
        internal GettingDataFromDatabase GettingDataFromDatabaseProperty { get { return _gettingDataFromDatabase; } }

        private MainMenuView _mainMenuView = new MainMenuView();

        public void DisplayMessage(String message)
        {
            _mainMenuView.MessageOutput(message);
        }

        internal ConsoleKeyInfo btn;

        /// <summary>Действия при завершении программы</summary>
        public void StopApp()
        {
            DisplayMessage(STOP_APP_MESSAGE);
            Console.ReadKey();
        }

        //public void GoToMainMenu()
        //{
        //    //MainMenuModel mainMenuModel = new MainMenuModel();
        //    //mainMenuModel.MainCommandsMenu();
        //}
    }
}
