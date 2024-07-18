using HotelCalcApp.Model.Data;

namespace HotelCalcApp.Model.Services.Database
{
    public class GettingDataFromDatabase : BaseServiceForWorkingWithDatabase
    {
        public List<Hotel> GetHotels()
        {
            List<Hotel> hotels = DataBase.Hotels.ToList();
            return hotels;
        }
    }
}
