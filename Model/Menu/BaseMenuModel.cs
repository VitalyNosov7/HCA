using HotelCalcApp.Interfaces;
using HotelCalcApp.Model.Services.Database;
using HotelCalcApp.View.Menu;

namespace HotelCalcApp.Model.Menu
{
    public abstract class BaseMenuModel : IMessageTransferBuffer
    {
        private GettingDataFromDatabase _GettingDataFromDatabase = new GettingDataFromDatabase();
        internal GettingDataFromDatabase GettingDataFromDatabase {  get { return _GettingDataFromDatabase; } }

        private MainMenuView _mainMenuView = new MainMenuView();

        public void DisplayMessage(String message)
        {
            _mainMenuView.MessageOutput(message);
        }

        internal ConsoleKeyInfo btn;
    }
}
