using HotelCalcApp.Model.Data;
using HotelCalcApp.View;
using System.Text;

namespace HotelCalcApp.Controller
{
    /// <summary>Контроллер добавления данных в базу данных</summary>
    public class AddDataToDBController
    {
        /// <summary>Контекст базы данных</summary>
        HotelCalcAppDBContext db = new HotelCalcAppDBContext();

        ConsoleKeyInfo btn;
        //  TODO:   Перенести в соответствующий View раздел
        private const String ADDDATATODB_VIEW_MENU = "ДОБАВИТЬ ДАННЫЕ:\n" +
            "1.     ОТЕЛИ\n" +
            "2.     СЕРВИСЫ ОТЕЛЯ\n" +
            "3.     ЦЕНЫ(ТАРИФЫ)\n" +
            "4.     АКЦИИ ОТЕЛЯ\n" +
            "5.     СТОП-ПРОДАЖИ\n" +
            "6.     МЕНЮ БАЗА ДАННЫХ\n" +
            "ESC.   ВЫЙТИ ИЗ ПРОГРАММЫ\n";

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
            // ConsoleKeyInfo btn;
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
                        GetHotel();
                        AddHotel(DataEntry());
                        break;
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
                    case (ConsoleKey.D6):
                        // TODO: тут добавить вызов соответствующего контроллера.
                        Console.WriteLine(".    Вызов метода МЕНЮ БАЗА ДАННЫХ)");
                        return;
                }
            }
            while (!(btn.Key == ConsoleKey.Escape));
            Console.Clear();
            GoToMainMenu();
        }


        /// <summary>
        /// Добавить отель.
        /// </summary>
        /// <param name="nameHotel">Название отеля</param>
        public void AddHotel(String nameHotel)
        {
            Hotel newHotel = new Hotel { NameHotel = nameHotel };
            db.Hotels.Add(newHotel);
            db.SaveChanges();
        }

        /// <summary>Ввод данных пользователем</summary>
        public String DataEntry()
        {
            String result = String.Empty;
            result = Console.ReadLine();
            return result;
        }

        /// <summary>Добавить отель.</summary>
        //public void AddHotel()
        //{
        ////    while (!(btn.Key == ConsoleKey.Escape))
        ////    {
        ////        // Добавление отеля
        ////        Console.WriteLine("Введите название отеля:");
        ////        Console.WriteLine("(Для отмены ввода нажмите Esc)");
        ////        String nameHotel = Console.ReadLine();
        ////        Hotel newHotel = new Hotel { NameHotel = nameHotel };
        ////        db.Hotels.Add(newHotel);
        ////        db.SaveChanges();
        ////        GetHotel();
        ////    }
        ////    AddDataToDBViewStream();
        //}

        //  TODO: Этот метод из этого класса необходимо убрать, он пока для тестирования.
        //  Получаем отели из базы данных
        public void GetHotel()
        {
            // получаем объекты из бд и выводим на консоль
            var hotels = db.Hotels.ToList();
            Console.WriteLine("Список отелей:");
            foreach (Hotel hotel in hotels)
            {
                Console.WriteLine($"{hotel.Id}.{hotel.NameHotel}");
            }
        }

        /// <summary>Переход в Поток главноего(меню) отображения</summary>
        public void GoToMainMenu()
        {
            MainController mainController = new MainController();
            mainController.MainViewStream();
        }
    }
}
