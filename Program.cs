using HotelCalcApp.Controller.Menu;

namespace HotelCalcApp
{
    internal class Program
    {
        static void Main()
        {
            MainMenuController mainMenuController = new MainMenuController();
            mainMenuController.MainMenuModel.StartApp();
            mainMenuController.MainMenuModel.MainViewStream();
            mainMenuController.MainMenuModel.StopApp();
        }
    }
}
