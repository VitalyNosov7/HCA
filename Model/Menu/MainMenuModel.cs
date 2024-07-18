using HotelCalcApp.Controller.Menu;

namespace HotelCalcApp.Model.Menu
{
    public class MainMenuModel : BaseMenuModel
    {
        private const String START_APP_MESSAGE = "Добро пожаловать в программу HotelCalcApp!";
        private const String MAIN_VIEW_MENU = "МЕНЮ КОММАНД:\n" +
            "(нажмите соответствующую цифру для перехода)\n" +
            "1.     БАЗА ДАННЫХ\n" +
            "2.     СЕРВИСЫ\n" +
            "ESC.   ВЫХОД ИЗ ПРОГРАММЫ";

        private DataBaseMenuController _dataBaseMenuController = new DataBaseMenuController();
        public DataBaseMenuController DataBaseMenuControllerProperty
        {
            get { return _dataBaseMenuController; }
            set { _dataBaseMenuController = value; }
        }

        /// <summary>Действия при старте программы</summary>
        public void StartApp()
        {
            DisplayMessage(START_APP_MESSAGE);
            Console.ReadKey();
        }

        /// <summary>Главное Меню (вывод на экран)</summary>
        public void MainCommandsMenu()
        {
            do
            {
                Console.Clear();

                DisplayMessage(MAIN_VIEW_MENU);

                btn = Console.ReadKey();

                switch (btn.Key)
                {
                    case ConsoleKey.D1:
                        // Вызов контроллера БД (Меню команд для работы с базой данных);
                        DataBaseMenuControllerProperty.DataBaseMenuModel.DatabaseCommandsMenu();
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
    }
}
