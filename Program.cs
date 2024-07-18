using HotelCalcApp.Controller.Menu;

namespace HotelCalcApp
{
    internal class Program
    {
        static void Main()
        {
            MainMenuController mainController = new MainMenuController();
            mainController.StartApp();
            mainController.MainViewStream();
        }
    }
}
