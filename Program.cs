using HotelCalcApp.Controller.Menu;

namespace HotelCalcApp
{
    internal class Program
    {
        static void Main()
        {
            //  Выводим сообщение о программе (название программы, версия).
            //  Выводим начальное меню комманд.

            MenuControlController menuControlController = new MenuControlController();
            menuControlController.MenuControlModelProperty.MainMenuControllerProperty.MainMenuModelProperty.StartApp();
            menuControlController.MenuControlModelProperty.MainMenuControllerProperty.MainMenuModelProperty.MainCommandsMenu();
        }
    }
}
