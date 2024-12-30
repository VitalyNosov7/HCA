using HotelCalcApp.Model.Menu;
using HotelCalcApp.View.Menu;

namespace HotelCalcApp.Controller.Menu
{
    public class MenuControlController
    {

        private MenuControlModel _menuControlModel = new MenuControlModel();
        public MenuControlModel MenuControlModelProperty
        {
            get{ return _menuControlModel; }
            set { _menuControlModel = value; }
        }

        private MenuControlView _menuControlView = new MenuControlView();
        public MenuControlView MenuControlViewProperty
        {
            get { return _menuControlView; }
            set { _menuControlView = value; }
        }

        //  TODO:   Реализовать метод, который будет обрабатывать события из контроллеров меню (делегаты, события, лямбды)
    }
}
