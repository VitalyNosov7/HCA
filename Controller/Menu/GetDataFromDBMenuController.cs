using HotelCalcApp.Model.Data;
using HotelCalcApp.Model.Menu;
using HotelCalcApp.View.Menu;

namespace HotelCalcApp.Controller.Menu
{
    public class GetDataFromDBMenuController : BaseMenuController
    {
        private GetDataFromDBMenuView _GetDataFromDBMenuView = new GetDataFromDBMenuView();
        public GetDataFromDBMenuView GetDataFromDBMenuView
        {
            get { return _GetDataFromDBMenuView; }
            set { _GetDataFromDBMenuView = value; }
        }

        public void GetDataFromDBCommandsMenu()
        {
            do
            {
                Console.Clear();

                GetDataFromDBMenuView.MessageOutput(Message.Insert(0, GetDataFromDBMenuModel.GET_DATA_FROM_DB_VIEW_MENU));
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
            var hotels = db.Hotels.ToList();
            //  TODO:   Вынести сообщение в модель!
            Console.WriteLine("Список отелей:");
            foreach (Hotel hotel in hotels)
            {
                Console.WriteLine($"{hotel.Id}.{hotel.NameHotel}");
            }
        }
    }
}
