using HotelCalcApp.Model.Menu;
using HotelCalcApp.View.Menu;

namespace HotelCalcApp.Controller.Menu
{
    /// <summary>Контроллер Меню получения данных</summary>
    public class DataExtractionMenuController : BaseMenuController
    {
        private DataExtractionMenuModel _DataExtractionMenuModel = new DataExtractionMenuModel();
        public DataExtractionMenuModel DataExtractionMenuModel
        {
            get { return _DataExtractionMenuModel; }
            set { _DataExtractionMenuModel = value;}
        }


        private DataExtractionMenuView _DataExtractionMenuView = new DataExtractionMenuView();
        public DataExtractionMenuView DataExtractionMenuView
        {
            get { return _DataExtractionMenuView; }
            set { _DataExtractionMenuView = value; }
        }
    }
}
