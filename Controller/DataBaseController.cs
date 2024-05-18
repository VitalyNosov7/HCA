using HotelCalcApp.Model.Data;

namespace HotelCalcApp.Controller
{
    /// <summary>Контроллер взаимодействия с Базой данных(CRUD)</summary>
    public class DataBaseController
    {
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
