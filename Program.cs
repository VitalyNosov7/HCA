using HotelCalcApp.Controller.Menu;

namespace HotelCalcApp
{
    internal class Program
    {
        static void Main()
        {
            MenuControlController menuControlController = new MenuControlController();
            menuControlController.MenuControlModelProperty.MainMenuControllerProperty.MainMenuModelProperty.StartApp();
            menuControlController.MenuControlModelProperty.MainMenuControllerProperty.MainMenuModelProperty.MainCommandsMenu();
        }
    }
}
