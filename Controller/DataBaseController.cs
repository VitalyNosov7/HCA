using HotelCalcApp.Model.Data;
using HotelCalcApp.View;
using System.Text;

namespace HotelCalcApp.Controller
{
    /// <summary>Контроллер взаимодействия с Базой данных(CRUD)</summary>
    public class DataBaseController
    {
        /// <summary>Контекст базы данных</summary>
        HotelCalcAppDBContext db = new HotelCalcAppDBContext();

        /// <summary>Основное Меню для работы с Базой Данных</summary>
        private const String DATABASE_VIEW_MENU = "МЕНЮ КОММАНД:\n" +
          "(нажмите соответствующую цифру для перехода)\n" +
          "1.     ДОБАВИТЬ ДАННЫЕ\n" +
          "2.     РЕДАКТИРОВАТЬ ДАННЫЕ\n" +
          "3.     УДАЛИТЬ ДАННЫЕ\n" +
          "ESC.   ВЫХОД В ГЛАВНОЕ МЕНЮ ПРОГРАММЫ";

        /// <summary>Сообщение</summary>
        private StringBuilder _Message = new StringBuilder();
        public StringBuilder Message
        {
            get { return _Message; }
            set { _Message = value; }
        }

        /// <summary>Отображение работы с базой данных</summary>
        private DataBaseView _DataBaseView = new DataBaseView();
        public DataBaseView DataBaseView
        {
            get { return _DataBaseView; }
            set { _DataBaseView = value; }
        }

        /// <summary>Добавление данных в базу данных</summary>
        private AddDataToDBController _AddDataToDBController = new AddDataToDBController();
        public AddDataToDBController AddDataToDBController
        {
            get { return _AddDataToDBController; }
            set { _AddDataToDBController= value; }
        }



        // ======================================
        // Перенесен в AddDataToDBController
        ///// <summary>
        ///// Добавить отель.
        ///// </summary>
        ///// <param name="nameHotel">Название отеля</param>
        //public void AddHotel(String nameHotel)
        //{
        //    // Добавление

        //    Hotel newHotel = new Hotel { NameHotel = nameHotel };
        //    db.Hotels.Add(newHotel);
        //    db.SaveChanges();
        //}
        // ======================================

        //  TODO:   Перенести в соответствующее меню.
        public void GetHotel()
        {
            // получаем объекты из бд и выводим на консоль
            var hotels = db.Hotels.ToList();
            Console.WriteLine("Данные после добавления:");
            foreach (Hotel hotel in hotels)
            {
                Console.WriteLine($"{hotel.Id}.{hotel.NameHotel}");
            }
        }


        /// <summary>Поток  Отображения меню работы с базой данных</summary>
        public void DataBaseViewStream()
        {
            ConsoleKeyInfo btn;
            do
            {
                Console.Clear();
                DataBaseView.MessageOutput(_Message.Insert(0, DATABASE_VIEW_MENU));
                _Message.Clear();
                btn = Console.ReadKey();

                switch (btn.Key)
                {
                    case (ConsoleKey.D1):
                        // TODO: тут добавить вызов соответствующего контроллера.
                        Console.WriteLine(".    Вызов контроллера ДОБАВИТЬ ДАННЫЕ");
                        AddDataToDBController.AddDataToDBViewStream();
                        return;
                    case (ConsoleKey.D2):
                        // TODO: тут добавить вызов соответствующего контроллера.
                        Console.WriteLine(".    Вызов контроллера РЕДАКТИРОВАТЬ ДАННЫЕ");
                        return;
                    case (ConsoleKey.D3):
                        // TODO: тут добавить вызов соответствующего контроллера.
                        Console.WriteLine(".    Вызов контроллера УДАЛИТЬ ДАННЫЕ");
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
