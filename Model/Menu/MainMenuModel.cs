using HotelCalcApp.Controller.Menu;
using HotelCalcApp.View.Menu;

namespace HotelCalcApp.Model.Menu
{
    public class MainMenuModel : BaseMenuModel
    {
        internal const String START_APP_MESSAGE = "Добро пожаловать в программу HotelCalcApp!";
        internal const String STOP_APP_MESSAGE = "_Выход из программы";
        internal const String MAIN_VIEW_MENU = "МЕНЮ КОММАНД:\n" +
            "(нажмите соответствующую цифру для перехода)\n" +
            "1.     БАЗА ДАННЫХ\n" +
            "2.     СЕРВИСЫ\n" +
            "ESC.   ВЫХОД ИЗ ПРОГРАММЫ";

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
                       // DataBaseMenuController.DatabaseCommandsMenu();
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
