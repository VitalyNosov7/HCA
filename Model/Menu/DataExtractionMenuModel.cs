using HotelCalcApp.Model.Data;
using HotelCalcApp.Model.Services.Database;
using HotelCalcApp.View.Menu;

namespace HotelCalcApp.Model.Menu
{
    public class DataExtractionMenuModel : BaseMenuModel
    {
        internal String MENU_ITEMS_FOR_GETTING_DATA_FROM_THE_DATABASE = "ПОЛУЧИТЬ ДАННЫЕ:\n" +
            "1.     ОТЕЛИ\n" +
            "2.     СЕРВИСЫ ОТЕЛЯ\n" +
            "3.     ЦЕНЫ(ТАРИФЫ)\n" +
            "4.     АКЦИИ ОТЕЛЯ\n" +
            "5.     СТОП-ПРОДАЖИ\n" +
            "6.     ВЫЙТИ В МЕНЮ БАЗА ДАННЫХ\n" +
            "ESC.   ВЫЙТИ ИЗ ПРОГРАММЫ\n";

        internal String MESSAGE_IS_A_LIST_OF_HOTELS = "Список отелей:";

        private DataExtractionMenuView _DataExtractionMenuView = new DataExtractionMenuView();
        public DataExtractionMenuView DataExtractionMenuView
        {
            get { return _DataExtractionMenuView; }
            set { _DataExtractionMenuView = value; }
        }

        //  TODO:   Переработать метод вывода элементов БД. Подумать как можно обобщить, чтобы метод стал универсальным!
        void ShowHotels()
        {
            List<Hotel> hotels = GettingDataFromDatabaseProperty.GetHotels();

            foreach (Hotel hotel in hotels)
            {
                Console.WriteLine($"{hotel.Id}.{hotel.NameHotel}");
            }
        }

        /// <summary>Показать пункты Меню для получения данных из базы данных</summary>
        public void ShowItemsMenuForExtractingDataFromTheDatabase()
        {
            do
            {
                Console.Clear();

                DisplayMessage(MENU_ITEMS_FOR_GETTING_DATA_FROM_THE_DATABASE);

                btn = Console.ReadKey();

                switch (btn.Key)
                {
                    case ConsoleKey.D1:
                        // TODO: тут добавить вызов соответствующего контроллера.
                        Console.WriteLine(".    Вызов метода ПОЛУЧИТЬ СПИСОК ОТЕЛЕЙ");
                        Console.WriteLine("Список отелей:");
                       // GettingDataFromDatabase.GetHotels();
                       ShowHotels();
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
    }
}
