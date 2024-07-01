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


        private DataBaseMenuView _DataBaseMenuView = new DataBaseMenuView();
        public DataBaseMenuView DataBaseMenuView
        {
            get { return _DataBaseMenuView; }
            set { _DataBaseMenuView = value; }
        }

        /// <summary>Поток  Отображения меню работы с базой данных</summary>
        public void DatabaseCommandsMenu()
        {
            do
            {
                Console.Clear();
                DataBaseMenuView.MessageOutput(Message.Insert(0, DataBaseMenuModel.DATABASE_VIEW_MENU));
                Message.Clear();
                btn = Console.ReadKey();

                switch (btn.Key)
                {
                    case ConsoleKey.D1:
                        // TODO: тут добавить вызов соответствующего контроллера.
                        Console.WriteLine(".    Вызов контроллера ДОБАВИТЬ ДАННЫЕ");
                        _AddingDataToDatabaseMenuController.AddDataToDBCommandsMenu();
                        return;
                    case ConsoleKey.D2:
                        // TODO: тут добавить вызов соответствующего контроллера.
                        Console.WriteLine(".    Вызов контроллера ЧТЕНИЯ ДАННЫХ");
                        return;
                    case ConsoleKey.D3:
                        // TODO: тут добавить вызов соответствующего контроллера.
                        Console.WriteLine(".    Вызов контроллера РЕДАКТИРОВАТЬ ДАННЫЕ");
                        return;
                    case ConsoleKey.D4:
                        // TODO: тут добавить вызов соответствующего контроллера.
                        Console.WriteLine(".    Вызов контроллера УДАЛИТЬ ДАННЫЕ");
                        return;
                }
            }
            while (!(btn.Key == ConsoleKey.Escape));
            Console.Clear();
            GoToMainMenu();
        }

        /// <summary>Переход в Поток главноего(меню) отображения</summary>
        public void GoToMainMenu()
        {
            MainMenuController mainController = new MainMenuController();
            mainController.MainViewStream();
        }
    }
}
