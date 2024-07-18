using HotelCalcApp.Controller.Menu;

namespace HotelCalcApp.Model.Menu
{
    public class MainMenuModel : BaseMenuModel
    {
        private const String START_APP_MESSAGE = "Добро пожаловать в программу HotelCalcApp!";
        internal  String MAIN_VIEW_MENU = "МЕНЮ КОММАНД:\n" +
            "(нажмите соответствующую цифру для перехода)\n" +
            "1.     БАЗА ДАННЫХ\n" +
            "2.     СЕРВИСЫ\n" +
            "ESC.   ВЫХОД ИЗ ПРОГРАММЫ";


        /// <summary>Действия при старте программы</summary>
        public void StartApp()
        {
            DisplayMessage(START_APP_MESSAGE);
            Console.ReadKey();
        }
    }
}
