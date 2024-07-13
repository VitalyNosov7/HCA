using HotelCalcApp.Model.Menu;
using HotelCalcApp.View.Menu;

namespace HotelCalcApp.Controller.Menu
{
    /// <summary>Главный контроллер</summary>
    public class MainMenuController : BaseMenuController
    {

        private MainMenuModel _MainMenuModel = new MainMenuModel();
        public MainMenuModel MainMenuModel
        {
            get { return _MainMenuModel; }
            set { _MainMenuModel = value; }
        }

        private DataBaseMenuController _DataBaseMenuController = new DataBaseMenuController();
        public DataBaseMenuController DataBaseMenuController
        {
            get { return _DataBaseMenuController; }
            set { _DataBaseMenuController = value; }
        }

        private HotelServiceVerificationController _HotelServiceVerificationController = new HotelServiceVerificationController();
        public HotelServiceVerificationController HotelServiceVerifController
        {
            get { return _HotelServiceVerificationController; }
            set { _HotelServiceVerificationController = value; }
        }
    }
}
