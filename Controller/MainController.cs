using HotelCalcApp.View;
using System.Text;

namespace HotelCalcApp.Controller
{
    /// <summary>Главный контроллер</summary>
    public class MainController
    {
        private const String START_APP_MESSAGE = "Добро пожаловать в программу HotelCalcApp!";
        private const String STOP_APP_MESSAGE = "_Выход из программы";
        private const String MAIN_VIEW_MENU = "МЕНЮ КОММАНД:\n" +
            "(нажмите соответствующую цифру для перехода)\n" +
            "1.     БАЗА ДАННЫХ\n" +
            "2.     СЕРВИСЫ\n" +
            "ESC.   ВЫХОД ИЗ ПРОГРАММЫ";

        private DataBaseController _DataBaseController = new DataBaseController();
        public DataBaseController DataBaseController
        {
            get { return _DataBaseController; }
            set { _DataBaseController = value; }
        }

        private HotelServiceVerificationController _HotelServiceVerificationController = new HotelServiceVerificationController();
        public HotelServiceVerificationController HotelServiceVerifController
        {
            get { return _HotelServiceVerificationController; }
            set { _HotelServiceVerificationController = value; }
        }

        private MainView _MainView = new MainView();
        public MainView MainView
        {
            get { return _MainView; }
            set { _MainView = value; }
        }

        private StringBuilder _Message = new StringBuilder();
        public StringBuilder Message
        {
            get { return _Message; }
            set { _Message = value; }
        }

        /// <summary>Главный поток отображения</summary>
        public void MainViewStream()
        {
            ConsoleKeyInfo btn;
            do
            {
                Console.Clear();
                MainView.MessageOutput(_Message.Insert(0, MAIN_VIEW_MENU));
                _Message.Clear();
                btn = Console.ReadKey();

                switch (btn.Key)
                {
                    case (ConsoleKey.D1):
                        // TODO: тут добавить вызов соответствующего контроллера.
                        Console.WriteLine(".    Вызов контроллера БД");
                        return;
                    case (ConsoleKey.D2):
                        // TODO: тут добавить вызов соответствующего контроллера.
                        Console.WriteLine(".    Вызов контроллера Сервисов");
                        return ;
                }

            }
            while (!(btn.Key == ConsoleKey.Escape));
            Console.Clear();
            StopApp();
        }

        /// <summary>Действия при старте программы</summary>
        public void StartApp()
        {
            MainView.MessageOutput(_Message.Insert(0, START_APP_MESSAGE));
            _Message.Clear();
            Console.ReadKey();
        }

        /// <summary>Действия при завершении программы</summary>
        public void StopApp()
        {
            _Message.Clear();
            MainView.MessageOutput(_Message.Insert(0, STOP_APP_MESSAGE));
            Console.ReadKey();
        }
    }
}
