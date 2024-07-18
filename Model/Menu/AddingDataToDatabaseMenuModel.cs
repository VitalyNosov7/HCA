using HotelCalcApp.Model.Services.Database;
using HotelCalcApp.View.Menu;

namespace HotelCalcApp.Model.Menu
{
    public class AddingDataToDatabaseMenuModel : BaseMenuModel
    {
        internal  String ADD_DATA_TO_DB_VIEW_MENU = "ДОБАВИТЬ ДАННЫЕ:\n" +
            "1.     ОТЕЛИ\n" +
            "2.     СЕРВИСЫ ОТЕЛЯ\n" +
            "3.     ЦЕНЫ(ТАРИФЫ)\n" +
            "4.     АКЦИИ ОТЕЛЯ\n" +
            "5.     СТОП-ПРОДАЖИ\n" +
            "6.     ВЫЙТИ В МЕНЮ БАЗА ДАННЫХ\n" +
            "ESC.   ВЫЙТИ ИЗ ПРОГРАММЫ\n";

        /// <summary>Отображение пунктов Меню для добавления данных в базу данных</summary>
        private AddingDataToDatabaseMenuView _AddingDataToDatabaseMenuView = new AddingDataToDatabaseMenuView();
        public AddingDataToDatabaseMenuView AddingDataToDatabaseMenuView
        {
            get { return _AddingDataToDatabaseMenuView; }
            set { _AddingDataToDatabaseMenuView = value; }
        }

        private AddingDataFromDatabase _addingDataFromDatabase = new AddingDataFromDatabase();
        internal AddingDataFromDatabase AddingDataFromDatabaseProperty
        {
            get { return _addingDataFromDatabase; }
            set { _addingDataFromDatabase = value; }
        }

        /// <summary>Меню добавления данных в базу данных</summary>
        public void ShowItemsMenuForAddingDataToDatabase()
        {
            do
            {
                Console.Clear();

                DisplayMessage(ADD_DATA_TO_DB_VIEW_MENU);

                btn = Console.ReadKey();

                switch (btn.Key)
                {
                    case ConsoleKey.D1:
                        // TODO: тут добавить вызов соответствующего контроллера.
                        Console.WriteLine(".    Вызов метода ДОБАВИТЬ ОТЕЛЬ");
                        //  TODO:   Подумать как избавиться от зависимости(Как вариант - использовать интерфейс)
                        AddingDataFromDatabaseProperty.AddHotel(DataEntry());
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
            // GoToMainMenu();
        }

        /// <summary>Ввод данных пользователем</summary>
        public String DataEntry()
        {
            String result = String.Empty;
            result = Console.ReadLine();
            return result;
        }
    }
}
