using HotelCalcApp.Model.Menu;
using HotelCalcApp.View.Menu;

namespace HotelCalcApp.Controller.Menu
{
    /// <summary>Контроллер  Меню добавления данных в базу данных</summary>
    public class AddingDataToDatabaseMenuController : BaseMenuController
    {
        private AddingDataToDatabaseMenuModel _AddingDataToDatabaseMenuModel = new AddingDataToDatabaseMenuModel();
        public AddingDataToDatabaseMenuModel AddingDataToDatabaseMenuModel
        {
            get { return _AddingDataToDatabaseMenuModel; }
            set { _AddingDataToDatabaseMenuModel = value;}
        }

        /// <summary>Отображение пунктов Меню для добавления данных в базу данных</summary>
        private AddingDataToDatabaseMenuView _AddingDataToDatabaseMenuView = new AddingDataToDatabaseMenuView();
        public AddingDataToDatabaseMenuView AddingDataToDatabaseMenuView
        {
            get { return _AddingDataToDatabaseMenuView; }
            set { _AddingDataToDatabaseMenuView = value; }
        }

        /// <summary>Меню добавления данных в базу данных</summary>
        public void ShowItemsMenuForAddingDataToDatabase()
        {
            do
            {
                Console.Clear();

                AddingDataToDatabaseMenuView.MessageOutput(Message.Insert(0, AddingDataToDatabaseMenuModel.ADD_DATA_TO_DB_VIEW_MENU));
                Message.Clear();
                btn = Console.ReadKey();

                switch (btn.Key)
                {
                    case ConsoleKey.D1:
                        // TODO: тут добавить вызов соответствующего контроллера.
                        Console.WriteLine(".    Вызов метода ДОБАВИТЬ ОТЕЛЬ");
                        //  TODO:   Подумать как избавиться от зависимости(Как вариант - использовать интерфейс)
                        // _DataExtractionMenuController.GetHotel();
                        AddingDataToDatabaseMenuModel.AddHotel(AddingDataToDatabaseMenuModel.DataEntry());
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
           // GoToMainMenu();
        }
    }
}
