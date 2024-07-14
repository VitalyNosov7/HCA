using HotelCalcApp.Controller.Menu;
using HotelCalcApp.Model.Data;

namespace HotelCalcApp
{
    internal class Program
    {
        static void Main()
        {
            MainMenuController mainController = new MainMenuController();
            mainController.MainMenuModel.StartApp();
            mainController.MainMenuModel.MainViewStream();
          //  mainController.StopApp();
        }
    }
}
