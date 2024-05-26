using HotelCalcApp.View;
using System.Text;

namespace HotelCalcApp.Controller
{
    /// <summary>Контроллер добавления данных в базу данных</summary>
    public class AddDataToDBController
    {
        private const String ADDDATATODB_VIEW_MENU = "ДОБАВИТЬ ДАННЫЕ:\n" +
            "1.     ОТЕЛИ\n" +
            "2.     СЕРВИСЫ ОТЕЛЯ\n" +
            "3.     ЦЕНЫ(ТАРИФЫ)\n" +
            "4.     АКЦИИ ОТЕЛЯ\n" +
            "5.     СТОП-ПРОДАЖИ\n";

        /// <summary>Сообщение</summary>
        private StringBuilder _Message = new StringBuilder();
        public StringBuilder Message
        {
            get { return _Message; }
            set { _Message = value; }
        }

        /// <summary>Отображение работы с базой данных</summary>
        private AddDataToDBView _AddDataToDBView = new AddDataToDBView();
        public AddDataToDBView AddDataToDBView
        {
            get { return _AddDataToDBView; }
            set { _AddDataToDBView = value; }
        }

        /// <summary>Поток  Отображения меню работы с базой данных</summary>
        public void AddDataToDBViewStream()
        {
            ConsoleKeyInfo btn;
            do
            {
                Console.Clear();
                AddDataToDBView.MessageOutput(_Message.Insert(0, ADDDATATODB_VIEW_MENU));
                _Message.Clear();
                btn = Console.ReadKey();

                switch (btn.Key)
                {
                    case (ConsoleKey.D1):
                        // TODO: тут добавить вызов соответствующего контроллера.
                        Console.WriteLine(".    Вызов метода ДОБАВИТЬ ОТЕЛЬ");
                        return;
                    case (ConsoleKey.D2):
                        // TODO: тут добавить вызов соответствующего контроллера.
                        Console.WriteLine(".    Вызов метода ДОБАВИТЬ СЕРВИС ОТЕЛЯ");
                        return;
                    case (ConsoleKey.D3):
                        // TODO: тут добавить вызов соответствующего контроллера.
                        Console.WriteLine(".    Вызов метода ДОБАВИТЬ ЦЕНУ(ТАРИФ)");
                        return;
                    case (ConsoleKey.D4):
                        // TODO: тут добавить вызов соответствующего контроллера.
                        Console.WriteLine(".    Вызов метода ДОБАВИТЬ АКЦИЮ");
                        return;
                    case (ConsoleKey.D5):
                        // TODO: тут добавить вызов соответствующего контроллера.
                        Console.WriteLine(".    Вызов метода ДОБАВИТЬ СТОП-ПРОДАЖУ)");
                        return;
                }

            }
            while (!(btn.Key == ConsoleKey.Escape));
            Console.Clear();
            GoToMainMenu();
        }

        /// <summary>Переход в Поток главноего(меню) отображения</summary>
        public void GoToMainMenu()
        {
            MainController mainController = new MainController();
            mainController.MainViewStream();
        }
    }
}
