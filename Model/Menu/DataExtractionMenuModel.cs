using HotelCalcApp.Model.Data;
using HotelCalcApp.Model.Services.Database;

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

        private GettingDataFromDatabase _GettingDataFromDatabase = new GettingDataFromDatabase();
        public GettingDataFromDatabase GettingDataFromDatabase {  get { return _GettingDataFromDatabase; } }


        //  TODO:   Переработать метод вывода элементов БД. Подумать как можно обобщить, чтобы метод стал универсальным!
        void ShowHotels()
        {
            List<Hotel> hotels = GettingDataFromDatabase.GetHolels();

            foreach (Hotel hotel in hotels)
            {
                Console.WriteLine($"{hotel.Id}.{hotel.NameHotel}");
            }
        }
    }
}
