using HotelCalcApp.Model.Data;
using HotelCalcApp.View;

namespace HotelCalcApp.Controller
{
        /// <summary>Контроллер взаимодействия с Базой данных(CRUD)</summary>
    public class DataBaseController
    {
        private const String DATABASE_VIEW_MENU = "МЕНЮ КОММАНД:\n" +
          "(нажмите соответствующую цифру для перехода)\n" +
          "1.     ДОБАВИТЬ ДАННЫЕ\n" +
          "2.     РЕДАКТИРОВАТЬ ДАННЫЕ\n" +
          "3.     УДАЛИТЬ ДАННЫЕ\n" +
          "ESC.   ВЫХОД В ГЛАВНОЕ МЕНЮ ПРОГРАММЫ";


        private DataBaseView _DataBaseView = new DataBaseView();
        public DataBaseView DataBaseView
        {
            get { return _DataBaseView; }
            set { _DataBaseView = value; }
        }

      
        HotelCalcAppDBContext db = new HotelCalcAppDBContext();

        /// <summary>
        /// Добавить отель.
        /// </summary>
        /// <param name="nameHotel">Название отеля</param>
        public void AddHotel(String nameHotel)
        {
            // Добавление
          
                Hotel newHotel = new Hotel { NameHotel = nameHotel };
                db.Hotels.Add(newHotel);
                db.SaveChanges();     
        }

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
    }
}
