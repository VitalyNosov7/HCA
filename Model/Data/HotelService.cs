namespace HotelCalcApp.Model.Data
{
    /// <summary>Сервис отеля</summary>
    public class HotelService
    {
        private String _HotelServiceName = String.Empty;
        private List<HotelServicePrice> _HotelServicePricesList = new List<HotelServicePrice> { };

        /// <summary>Идентификатор сервиса отеля</summary>
        public Int64 Id { get; set; }

        /// <summary>Название сервиса отеля</summary>
        public String HotelServiceName
        {
            get
            {
                return _HotelServiceName;
            }
            set
            {
                _HotelServiceName = value;
            }
        }

        /// <summary>Расценки сервиса отеля</summary>
        public List<HotelServicePrice> HotelServicePricesList
        {
            get
            {
                return _HotelServicePricesList;
            }
            set
            {
                _HotelServicePricesList = value;
            }
        }

        /// <summary>Ссылка на идентификатор отеля</summary>
        public Int32 IdHotel { get; set; }

        /// <summary>
        /// Новый сервис отеля
        /// </summary>
        /// <param name="nameService">Название сервиса</param>
        /// <param name="hotelServicePricesList">Список цен сервиса отеля</param>
        public HotelService(String hotelServiceName, List<HotelServicePrice> hotelServicePricesList)
        {
            HotelServiceName = hotelServiceName;
            HotelServicePricesList = hotelServicePricesList;
        }

        /// <summary>Переопределенный метод. Выводит строковое название сервиса отеля</summary>
        public override string ToString()
        {
            return _HotelServiceName;
        }
    }
}
