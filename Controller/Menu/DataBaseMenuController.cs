using HotelCalcApp.Model.Data;
using HotelCalcApp.Model.Menu;
using HotelCalcApp.View.Menu;

namespace HotelCalcApp.Controller.Menu
{
    /// <summary>Контроллер взаимодействия с Базой данных(CRUD)</summary>
    public class DataBaseMenuController : BaseMenuController
    {
        /// <summary>Отображение работы с базой данных</summary>
        private DataBaseMenuView _DataBaseMenuView = new DataBaseMenuView();
        public DataBaseMenuView DataBaseMenuView
        {
            get { return _DataBaseMenuView; }
            set { _DataBaseMenuView = value; }
        }

        /// <summary>Добавление данных в базу данных</summary>
        private AddDataToDBMenuController _AddDataToDBController = new AddDataToDBMenuController();
        public AddDataToDBMenuController AddDataToDBController
        {
            get { return _AddDataToDBController; }
            set { _AddDataToDBController = value; }
        }


        //  TODO:   Перенести в соответствующее меню.
        public void GetHotel()
        {
            // получаем объекты из бд и выводим на консоль
            var hotels = db.Hotels.ToList();
            Console.WriteLine("Данные после добавления:");
            foreach (Hotel hotel in hotels)
            {
                Console.WriteLine($"{hotel.Id}.{hotel.NameHotel}");
            }
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
                        AddDataToDBController.AddDataToDBCommandsMenu();
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
