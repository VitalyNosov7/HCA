using HotelCalcApp.Controller.Menu;

namespace HotelCalcApp.Model.Menu
{
    public class MenuControlModel
    {
        private MainMenuController _mainMenuController = new MainMenuController();
        public MainMenuController MainMenuControllerProperty
        {
            get { return _mainMenuController; }
            set { _mainMenuController = value; }
        }

        private DataBaseMenuController _dataBaseMenuController = new DataBaseMenuController();
        public DataBaseMenuController DataBaseMenuControllerProperty
        {
            get { return _dataBaseMenuController; }
            set { _dataBaseMenuController = value; }
        }

        private DataExtractionMenuController _dataExtractionMenuController = new DataExtractionMenuController();
        public DataExtractionMenuController DataExtractionMenuControllerProperty
        {
            get { return _dataExtractionMenuController; }
            set { _dataExtractionMenuController = value; }
        }

        private AddingDataToDatabaseMenuController _addingDataToDatabaseMenuController = new AddingDataToDatabaseMenuController();
        public AddingDataToDatabaseMenuController AddingDataToDatabaseMenuControllerProperty
        {
            get { return _addingDataToDatabaseMenuController; }
            set { _addingDataToDatabaseMenuController = value; }
        }
    }
}
