using HotelCalcApp.Model.Menu;
using HotelCalcApp.View.Menu;

namespace HotelCalcApp.Controller.Menu
{
    /// <summary>Главный контроллер</summary>
    public class MainMenuController : BaseMenuController
    {

        private MainMenuModel _MainMenuModel = new MainMenuModel();
        public MainMenuModel MainMenuModel
        {
            get { return _MainMenuModel; }
            set { _MainMenuModel = value; }
        }

        private DataBaseMenuController _DataBaseMenuController = new DataBaseMenuController();
        public DataBaseMenuController DataBaseMenuController
        {
            get { return _DataBaseMenuController; }
            set { _DataBaseMenuController = value; }
        }

        private HotelServiceVerificationController _HotelServiceVerificationController = new HotelServiceVerificationController();
        public HotelServiceVerificationController HotelServiceVerifController
        {
            get { return _HotelServiceVerificationController; }
            set { _HotelServiceVerificationController = value; }
        }

        /// <summary>Основное Отображение</summary>
        private MainMenuView _MainView = new MainMenuView();
        public MainMenuView MainView
        {
            get { return _MainView; }
            set { _MainView = value; }
        }


        /// <summary>Поток главноего(меню) отображения</summary>
        public void MainViewStream()
        {
            do
            {
                Console.Clear();
                MainView.MessageOutput(Message.Insert(0, MainMenuModel.MAIN_VIEW_MENU));
                Message.Clear();
                btn = Console.ReadKey();

                switch (btn.Key)
                {
                    case ConsoleKey.D1:
                       // Вызов контроллера БД (Меню команд для работы с базой данных);
                        DataBaseMenuController.DatabaseCommandsMenu();
                        return;
                    case ConsoleKey.D2:
                        // TODO: тут добавить вызов соответствующего контроллера.
                        Console.WriteLine(".    Вызов контроллера Сервисов");
                        return;
                }

            }
            while (!(btn.Key == ConsoleKey.Escape));
            Console.Clear();
            StopApp();
        }

        /// <summary>Действия при старте программы</summary>
        public void StartApp()
        {
            MainView.MessageOutput(Message.Insert(0, MainMenuModel.START_APP_MESSAGE));
            Message.Clear();
            Console.ReadKey();
        }

        /// <summary>Действия при завершении программы</summary>
        public void StopApp()
        {
            Message.Clear();
            MainView.MessageOutput(Message.Insert(0, MainMenuModel.STOP_APP_MESSAGE));
            Console.ReadKey();
        }
    }
}
