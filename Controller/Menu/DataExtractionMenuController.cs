using HotelCalcApp.Model.Data;
using HotelCalcApp.Model.Menu;
using HotelCalcApp.View.Menu;

namespace HotelCalcApp.Controller.Menu
{
    /// <summary>Контроллер меню получения данных</summary>
    public class DataExtractionMenuController : BaseMenuController
    {
        private DataExtractionMenuModel _DataExtractionMenuModel = new DataExtractionMenuModel();
        public DataExtractionMenuModel DataExtractionMenuModel
        {
            get { return _DataExtractionMenuModel; }
            set { _DataExtractionMenuModel = value;}
        }


        private DataExtractionMenuView _DataExtractionMenuView = new DataExtractionMenuView();
        public DataExtractionMenuView DataExtractionMenuView
        {
            get { return _DataExtractionMenuView; }
            set { _DataExtractionMenuView = value; }
        }

        /// <summary>Меню команд для получения данных из базы данных</summary>
        public void CommandsMenuForExtractingDataFromTheDatabase()
        {
            do
            {
                Console.Clear();

                DataExtractionMenuView.MessageOutput(Message.Insert(0, DataExtractionMenuModel.GET_DATA_FROM_DB_VIEW_MENU));
                Message.Clear();
                btn = Console.ReadKey();

                switch (btn.Key)
                {
                    case ConsoleKey.D1:
                        // TODO: тут добавить вызов соответствующего контроллера.
                        Console.WriteLine(".    Вызов метода ПОЛУЧИТЬ СПИСОК ОТЕЛЕЙ");
                        GetHotel();
                        break;
                    case ConsoleKey.D6:
                        // TODO: тут добавить вызов соответствующего контроллера.
                        Console.WriteLine(".    Вызов метода МЕНЮ БАЗА ДАННЫХ)");
                        return;
                }
            }
            while (!(btn.Key == ConsoleKey.Escape));
            Console.Clear();
           // GoToMainMenu();
        }

        //  Получаем отели из базы данных
        public void GetHotel()
        {
            // получаем объекты из бд и выводим на консоль
            var hotels = _DataBase.Hotels.ToList();
            //  TODO:   Вынести сообщение в модель!
            Console.WriteLine("Список отелей:");
            foreach (Hotel hotel in hotels)
            {
                Console.WriteLine($"{hotel.Id}.{hotel.NameHotel}");
            }
        }
    }
}
