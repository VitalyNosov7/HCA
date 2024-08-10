using HotelCalcApp.Controller.Menu;

namespace HotelCalcApp.Model.Menu
{
    public class DataBaseMenuModel : BaseMenuModel
    {
        /// <summary>Основное Меню для работы с Базой Данных</summary>
        internal String DATABASE_VIEW_MENU = "МЕНЮ КОММАНД:\n" +
          "(нажмите соответствующую цифру для перехода)\n" +
          "1.     ДОБАВИТЬ ДАННЫЕ\n" +
          "2.     ПОЛУЧИТЬ ДАННЫЕ\n" +
          "3.     РЕДАКТИРОВАТЬ ДАННЫЕ\n" +
          "4.     УДАЛИТЬ ДАННЫЕ\n" +
          "ESC.   ВЫХОД В ГЛАВНОЕ МЕНЮ ПРОГРАММЫ";

        public event CallingMenuItem OnCallingMenuItem;

        /// <summary>Поток  Отображения меню работы с базой данных</summary>
        public void DatabaseCommandsMenu()
        {
            do
            {
                Console.Clear();

                DisplayMessage(DATABASE_VIEW_MENU);

                btn = Console.ReadKey();

                switch (btn.Key)
                {
                    case ConsoleKey.D1:
                        // TODO: тут добавить вызов соответствующего контроллера.
                        Console.WriteLine(".    Вызов контроллера ДОБАВИТЬ ДАННЫЕ");
                        OnCallingMenuItem();
                        return;
                    case ConsoleKey.D2:
                        // TODO: тут добавить вызов соответствующего контроллера.
                        Console.WriteLine(".    Вызов контроллера ЧТЕНИЯ ДАННЫХ");
                        return;
                    case ConsoleKey.D3:
                        // TODO: тут добавить вызов соответствующего контроллера.
                        Console.WriteLine(".    Вызов контроллера РЕДАКТИРОВАТЬ ДАННЫЕ");
                        return;
                    case ConsoleKey.D4:
                        // TODO: тут добавить вызов соответствующего контроллера.
                        Console.WriteLine(".    Вызов контроллера УДАЛИТЬ ДАННЫЕ");
                        return;
                }
            }
            while (!(btn.Key == ConsoleKey.Escape));
            Console.Clear();
           //  TODO:   Реализовать переход в главное меню!( GoToMainMenu();)
        }
    }
}
