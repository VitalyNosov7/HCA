using HotelCalcApp.Controller.Menu;

namespace HotelCalcApp
{
    internal class Program
    {
        static void Main()
        {
            //  TODO:   Вынести в отдельный класс - инициализация!
            MainMenuController mainMenuController = new MainMenuController();
            mainMenuController.MainMenuModelProperty.StartApp();
            mainMenuController.MainMenuModelProperty.MainCommandsMenu();
        }
    }
}
