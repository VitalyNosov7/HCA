using HotelCalcApp.Model.Menu;
using HotelCalcApp.View.Menu;
using System.Text;

namespace HotelCalcApp.Controller.Menu
{
    /// <summary>Главный контроллер</summary>
    public class MainMenuController
    {

        private MainMenuModel _MainMenuModel = new MainMenuModel();
        public MainMenuModel MainMenuModel
        {
            get { return _MainMenuModel; }
            set { _MainMenuModel = value; }
        }

        private DataBaseMenuController _DataBaseController = new DataBaseMenuController();
        public DataBaseMenuController DataBaseController
        {
            get { return _DataBaseController; }
            set { _DataBaseController = value; }
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

        private StringBuilder _Message = new StringBuilder();
        public StringBuilder Message
        {
            get { return _Message; }
            set { _Message = value; }
        }

        /// <summary>Поток главноего(меню) отображения</summary>
        public void MainViewStream()
        {
            ConsoleKeyInfo btn;
            do
            {
                Console.Clear();
                MainView.MessageOutput(_Message.Insert(0, MainMenuModel.MAIN_VIEW_MENU));
                _Message.Clear();
                btn = Console.ReadKey();

                switch (btn.Key)
                {
                    case ConsoleKey.D1:
                        // TODO: тут добавить вызов соответствующего контроллера.
                        Console.WriteLine(".    Вызов контроллера БД");
                        DataBaseController.DataBaseViewStream();
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
            MainView.MessageOutput(_Message.Insert(0, MainMenuModel.START_APP_MESSAGE));
            _Message.Clear();
            Console.ReadKey();
        }

        /// <summary>Действия при завершении программы</summary>
        public void StopApp()
        {
            _Message.Clear();
            MainView.MessageOutput(_Message.Insert(0, MainMenuModel.STOP_APP_MESSAGE));
            Console.ReadKey();
        }
    }
}
