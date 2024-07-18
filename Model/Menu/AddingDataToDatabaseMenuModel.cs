using HotelCalcApp.Controller.Menu;
using HotelCalcApp.Model.Data;

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
