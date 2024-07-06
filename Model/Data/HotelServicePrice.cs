namespace HotelCalcApp.Model.Data
{
    /// <summary>Стоимость сервиса отеля</summary>
    public class HotelServicePrice : BaseObjectOfDatabase
    {
        /// <summary>Идентификатор цены отеля</summary>
        public Guid Id { get; set; }

        private DateTime _DateActualPrice;
        /// <summary>Дата актуальных цен</summary>
        public DateTime DateActualPrice
        {
            get { return _DateActualPrice; }
            set { _DateActualPrice = value; }
        }

        private DateTime _DateStartPrice;
        /// <summary>Дата начала действия стоимости сервиса</summary>
        public DateTime DateStartPrice
        {
            get { return _DateStartPrice; }
            set { _DateStartPrice = value; }
        }

        private DateTime _DateEndPrice;
        /// <summary>Дата окончания действия стоимости сервиса</summary>
        public DateTime DateEndPrice
        {
            get { return _DateEndPrice; }
            set { _DateEndPrice = value; }
        }

        private Decimal _PriceService;
        /// <summary>Стоимость сервиса</summary>
        public Decimal PriceService
        {
            get { return _PriceService; }
            set { _PriceService = value; }
        }

        /// <summary>Ссылка на идентификатор сервиса отеля</summary>
        public Int64 IdHotelService { get; set; }

        /// <summary>Новая цена сервиса отеля</summary>
        /// <param name="dateActualPrice">Актуальная дата стоимости сервиса</param>
        /// <param name="dateStartPrice">Дата начала действия стоимости сервиса</param>
        /// <param name="dateEndPrice">Дата окончания действия стоимости сервиса</param>
        /// <param name="priceService">Стоимость сервиса</param>
        public HotelServicePrice(DateTime dateActualPrice,
                                 DateTime dateStartPrice,
                                 DateTime dateEndPrice,
                                 decimal priceService)
        {
            _DateActualPrice = dateActualPrice;
            _DateStartPrice = dateStartPrice;
            _DateEndPrice = dateEndPrice;
            _PriceService = priceService;
        }
    }
}
