namespace HotelCalcApp.Model.Data
{
    /// <summary>Стоп продаж сервиса</summary>
    public class ServiceSalesStop
    {
        /// <summary>Идентификатор стопа продажи сервиса</summary>
        public Guid Id { get; set; }

        private DateTime _DateStartServiceSalesStop;

        private DateTime _DateEndServiceSalesStop;

        /// <summary>Дата начала действия стопа продажи сервиса</summary>
        public DateTime DateStartServiceSalesStop
        {
            get
            {
                return _DateStartServiceSalesStop;
            }
            set
            {
                _DateStartServiceSalesStop = value;
            }
        }

        /// <summary>Дата окончания действия стопа продажи сервиса</summary>
        public DateTime DateEndServiceSalesStop
        {
            get
            {
                return _DateEndServiceSalesStop;
            }
            set
            {
                _DateEndServiceSalesStop = value;
            }
        }

        /// <summary>Идентификатор сервиса отеля</summary>
        public Int64 IdHotelService { get; set; }

        public ServiceSalesStop(DateTime dateStartServiceSalesStop, DateTime dateEndServiceSalesStop)
        {
            DateStartServiceSalesStop = dateStartServiceSalesStop;
            DateEndServiceSalesStop= dateEndServiceSalesStop;
        }
    }
}
