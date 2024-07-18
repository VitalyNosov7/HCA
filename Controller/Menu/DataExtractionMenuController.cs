using HotelCalcApp.Model.Menu;
using HotelCalcApp.View.Menu;

namespace HotelCalcApp.Controller.Menu
{
    /// <summary>Контроллер Меню получения данных</summary>
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

        /// <summary>Показать пункты Меню для получения данных из базы данных</summary>
        public void ShowItemsMenuForExtractingDataFromTheDatabase()
        {
            do
            {
                Console.Clear();

                DataExtractionMenuView.MessageOutput(Message.Insert(0, DataExtractionMenuModel.MENU_ITEMS_FOR_GETTING_DATA_FROM_THE_DATABASE));
                Message.Clear();
                btn = Console.ReadKey();

                switch (btn.Key)
                {
                    case ConsoleKey.D1:
                        // TODO: тут добавить вызов соответствующего контроллера.
                        Console.WriteLine(".    Вызов метода ПОЛУЧИТЬ СПИСОК ОТЕЛЕЙ");
                        Console.WriteLine("Список отелей:");
                        DataExtractionMenuModel.GetHotels();
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
    }
}
