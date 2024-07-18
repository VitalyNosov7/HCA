using HotelCalcApp.Model.Menu;
using HotelCalcApp.View.Menu;

namespace HotelCalcApp.Controller.Menu
{
    /// <summary>Контроллер Главного Меню </summary>
    public  class MainMenuController : BaseMenuController
    {
        private MainMenuModel _mainMenuModel = new MainMenuModel();
        public MainMenuModel MainMenuModelProperty
        {
            get { return _mainMenuModel; }
            set { _mainMenuModel = value; }
        }

        /// <summary>Основное Отображение</summary>
        private MainMenuView _mainView = new MainMenuView();
        public MainMenuView MainViewProperty
        {
            get { return _mainView; }
            set { _mainView = value; }
        }

        private DataBaseMenuModel _dataBaseMenuModel = new DataBaseMenuModel();
        public DataBaseMenuModel DataBaseMenuModelProperty
        {
            get { return _dataBaseMenuModel; }
            set { _dataBaseMenuModel = value; }
        }

        private DataBaseMenuView _dataBaseMenuView = new DataBaseMenuView();
        public DataBaseMenuView DataBaseMenuViewProperty
        {
            get { return _dataBaseMenuView; }
            set { _dataBaseMenuView = value; }
        }

        /// <summary>Главное Меню (вывод на экран)</summary>
        public void MainCommandsMenu()
        {
            do
            {
                Console.Clear();

                MainMenuModelProperty.DisplayMessage(MainMenuModelProperty.MAIN_VIEW_MENU);

                MainMenuModelProperty.btn = Console.ReadKey();

                switch (MainMenuModelProperty.btn.Key)
                {
                    case ConsoleKey.D1:
                        // Вызов контроллера БД (Меню команд для работы с базой данных);
                        DataBaseMenuModelProperty.DatabaseCommandsMenu();
                        return;
                    case ConsoleKey.D2:
                        // TODO: тут добавить вызов соответствующего контроллера.
                        Console.WriteLine(".    Вызов контроллера Сервисов");
                        return;
                }
            }
            while (!(MainMenuModelProperty.btn.Key == ConsoleKey.Escape));
            Console.Clear();
            MainMenuModelProperty.StopApp();
        }
    }
}
