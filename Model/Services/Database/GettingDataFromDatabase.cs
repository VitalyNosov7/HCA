using HotelCalcApp.Model.Data;

namespace HotelCalcApp.Model.Services.Database
{
    public class GettingDataFromDatabase
    {
        private HotelCalcAppDBContext _DataBase = new HotelCalcAppDBContext();
        public HotelCalcAppDBContext DataBase { get { return _DataBase; } }


        public List<Hotel> GetHolels()
        {
            List<Hotel> hotels = DataBase.Hotels.ToList();
            return hotels;
        }
    }
}
