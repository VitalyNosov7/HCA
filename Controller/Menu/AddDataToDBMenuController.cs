using HotelCalcApp.Model.Data;
using HotelCalcApp.Model.Menu;
using HotelCalcApp.View.Menu;
using System.Text;

namespace HotelCalcApp.Controller.Menu
{
    /// <summary>Контроллер добавления данных в базу данных</summary>
    public class AddDataToDBMenuController
    {
        /// <summary>Контекст базы данных</summary>
        HotelCalcAppDBContext db = new HotelCalcAppDBContext();

        ConsoleKeyInfo btn;

        /// <summary>Сообщение</summary>
        private StringBuilder _Message = new StringBuilder();
        public StringBuilder Message
        {
            get { return _Message; }
            set { _Message = value; }
        }

        /// <summary>Отображение работы с базой данных</summary>
        private AddDataToDBMenuView _AddDataToDBView = new AddDataToDBMenuView();
        public AddDataToDBMenuView AddDataToDBView
        {
            get { return _AddDataToDBView; }
            set { _AddDataToDBView = value; }
        }

        /// <summary>Поток  Отображения меню работы с базой данных</summary>
        public void AddDataToDBViewStream()
        {
            do
            {
                Console.Clear();

                AddDataToDBView.MessageOutput(_Message.Insert(0, AddDataToDBMenuModel.ADDDATATODB_VIEW_MENU));
                _Message.Clear();
                btn = Console.ReadKey();

                switch (btn.Key)
                {
                    case ConsoleKey.D1:
                        // TODO: тут добавить вызов соответствующего контроллера.
                        Console.WriteLine(".    Вызов метода ДОБАВИТЬ ОТЕЛЬ");
                        GetHotel();
                        AddHotel(DataEntry());
                        break;
                    case ConsoleKey.D2:
                        // TODO: тут добавить вызов соответствующего контроллера.
                        Console.WriteLine(".    Вызов метода ДОБАВИТЬ СЕРВИС ОТЕЛЯ");
                        return;
                    case ConsoleKey.D3:
                        // TODO: тут добавить вызов соответствующего контроллера.
                        Console.WriteLine(".    Вызов метода ДОБАВИТЬ ЦЕНУ(ТАРИФ)");
                        return;
                    case ConsoleKey.D4:
                        // TODO: тут добавить вызов соответствующего контроллера.
                        Console.WriteLine(".    Вызов метода ДОБАВИТЬ АКЦИЮ");
                        return;
                    case ConsoleKey.D5:
                        // TODO: тут добавить вызов соответствующего контроллера.
                        Console.WriteLine(".    Вызов метода ДОБАВИТЬ СТОП-ПРОДАЖУ)");
                        return;
                    case ConsoleKey.D6:
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
        public void AddHotel(string nameHotel)
        {
            Hotel newHotel = new Hotel { NameHotel = nameHotel };
            db.Hotels.Add(newHotel);
            db.SaveChanges();
        }

        /// <summary>Ввод данных пользователем</summary>
        public string DataEntry()
        {
            string result = string.Empty;
            result = Console.ReadLine();
            return result;
        }


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
            MainMenuController mainController = new MainMenuController();
            mainController.MainViewStream();
        }
    }
}
