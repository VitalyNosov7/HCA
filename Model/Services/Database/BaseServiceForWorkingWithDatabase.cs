using HotelCalcApp.Model.Data;

namespace HotelCalcApp.Model.Services.Database
{
    abstract public class BaseServiceForWorkingWithDatabase
    {
        private HotelCalcAppDBContext _DataBase = new HotelCalcAppDBContext();
        public HotelCalcAppDBContext DataBase { get { return _DataBase; } }
    }
}
