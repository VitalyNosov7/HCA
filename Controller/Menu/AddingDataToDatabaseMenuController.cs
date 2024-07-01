using HotelCalcApp.Model.Data;
using HotelCalcApp.Model.Menu;
using HotelCalcApp.View.Menu;

namespace HotelCalcApp.Controller.Menu
{
    /// <summary>Контроллер добавления данных в базу данных</summary>
    public class AddingDataToDatabaseMenuController : BaseMenuController
    {
        /// <summary>Отображение меню для работы с базой данных</summary>
        private AddDataToDBMenuView _AddDataToDBMenuView = new AddDataToDBMenuView();
        public AddDataToDBMenuView AddDataToDBMenuView
        {
            get { return _AddDataToDBMenuView; }
            set { _AddDataToDBMenuView = value; }
        }

        /// <summary>Меню команд для работы с базой данных</summary>
        public void AddDataToDBCommandsMenu()
        {
            do
            {
                Console.Clear();

                AddDataToDBMenuView.MessageOutput(Message.Insert(0, AddDataToDBMenuModel.ADD_DATA_TO_DB_VIEW_MENU));
                Message.Clear();
                btn = Console.ReadKey();

                switch (btn.Key)
                {
                    case ConsoleKey.D1:
                        // TODO: тут добавить вызов соответствующего контроллера.
                        Console.WriteLine(".    Вызов метода ДОБАВИТЬ ОТЕЛЬ");
                        //  TODO:   Подумать как избавиться от зависимости(Как вариант - использовать интерфейс)
                        _DataExtractionMenuController.GetHotel();
                        AddHotel(DataEntry());
                        break;
                    case ConsoleKey.D2:
                        // TODO: тут добавить вызов соответствующего контроллера.
                        Console.WriteLine(".    Вызов метода ДОБАВИТЬ СЕРВИС ОТЕЛЯ");
                        return;
                    case ConsoleKey.D3:
                        // TODO: тут добавить вызов соответствующего контроллера.
                        Console.WriteLine(".    Вызов метода ДОБАВИТЬ ЦЕНУ(ТАРИФ)");
                        return;
                    case ConsoleKey.D4:
                        // TODO: тут добавить вызов соответствующего контроллера.
                        Console.WriteLine(".    Вызов метода ДОБАВИТЬ АКЦИЮ");
                        return;
                    case ConsoleKey.D5:
                        // TODO: тут добавить вызов соответствующего контроллера.
                        Console.WriteLine(".    Вызов метода ДОБАВИТЬ СТОП-ПРОДАЖУ)");
                        return;
                    case ConsoleKey.D6:
                        // TODO: тут добавить вызов соответствующего контроллера.
                        Console.WriteLine(".    Вызов метода МЕНЮ БАЗА ДАННЫХ)");
                        return;
                }
            }
            while (!(btn.Key == ConsoleKey.Escape));
            Console.Clear();
            GoToMainMenu();
        }

        /// <summary>
        /// Добавить отель.
        /// </summary>
        /// <param name="nameHotel">Название отеля</param>
        public void AddHotel(String nameHotel)
        {
            Hotel newHotel = new Hotel { NameHotel = nameHotel };
            _DataBase.Hotels.Add(newHotel);
            _DataBase.SaveChanges();
        }

        /// <summary>Ввод данных пользователем</summary>
        public String DataEntry()
        {
            String result = String.Empty;
            result = Console.ReadLine();
            return result;
        }

        /// <summary>Переход в Поток главноего(меню) отображения</summary>
        public void GoToMainMenu()
        {
            MainMenuController mainController = new MainMenuController();
            mainController.MainViewStream();
        }
    }
}
