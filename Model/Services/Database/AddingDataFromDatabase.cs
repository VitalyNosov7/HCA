using HotelCalcApp.Model.Data;

namespace HotelCalcApp.Model.Services.Database
{
    public class AddingDataFromDatabase : BaseServiceForWorkingWithDatabase
    {
        /// <summary>Добавить отель</summary>
        /// <param name="nameHotel">Название отеля</param>
        public void AddHotel(String nameHotel)
        {
            Hotel newHotel = new Hotel { NameHotel = nameHotel };
            DataBase.Hotels.Add(newHotel);
            DataBase.SaveChanges();
        }
    }
}
