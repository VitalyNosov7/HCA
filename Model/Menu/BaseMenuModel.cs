using HotelCalcApp.Model.Services.Database;

namespace HotelCalcApp.Model.Menu
{
    public abstract class BaseMenuModel
    {
        private GettingDataFromDatabase _GettingDataFromDatabase = new GettingDataFromDatabase();
        internal GettingDataFromDatabase GettingDataFromDatabase {  get { return _GettingDataFromDatabase; } }
    }
}
