using HotelCalcApp.Model.Data;

namespace HotelCalcApp.Model.Menu
{
    public abstract class BaseMenuModel
    {
        internal HotelCalcAppDBContext _DataBase = new HotelCalcAppDBContext();
    }
}
