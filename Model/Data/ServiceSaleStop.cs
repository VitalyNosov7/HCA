namespace HotelCalcApp.Model.Data
{
    /// <summary>Стоп продаж сервиса</summary>
    public class ServiceSaleStop : BaseObjectOfDatabase
    {
        /// <summary>Идентификатор стопа продажи сервиса</summary>
        public Guid Id { get; set; }

        private DateTime _DateOfActualPeriodServiceSaleStop;
        /// <summary>Актуальная дата действия периода стопа продажи сервиса</summary>
        public DateTime DateOfActualPeriodServiceSaleStop
        {
            get { return _DateOfActualPeriodServiceSaleStop; }
            set { _DateOfActualPeriodServiceSaleStop = value; }
        }

        private DateTime _DateStartServiceSaleStop;
        /// <summary>Дата начала действия стопа продажи сервиса</summary>
        public DateTime DateStartServiceSaleStop
        {
            get { return _DateStartServiceSaleStop; }
            set { _DateStartServiceSaleStop = value; }
        }

        private DateTime _DateEndServiceSaleStop;
        /// <summary>Дата окончания действия стопа продажи сервиса</summary>
        public DateTime DateEndServiceSaleStop
        {
            get { return _DateEndServiceSaleStop; }
            set { _DateEndServiceSaleStop = value; }
        }

        /// <summary>Идентификатор сервиса отеля</summary>
        public Int64 IdHotelService { get; set; }

        /// <summary>Новый, актуальный период стоп продажи сервиса отеля</summary>
        /// <param name="dateOfActualPeriodServiceSaleStop">Актуальная дата действия периода стопа продажи сервиса</param>
        /// <param name="dateStartServiceSaleStop">Дата начала действия стопа продажи сервиса</param>
        /// <param name="dateEndServiceSaleStop">Дата окончания действия стопа продажи сервиса</param>
        public ServiceSaleStop(DateTime dateOfActualPeriodServiceSaleStop,
                               DateTime dateStartServiceSaleStop,
                               DateTime dateEndServiceSaleStop)
        {
            DateOfActualPeriodServiceSaleStop = dateOfActualPeriodServiceSaleStop;
            DateStartServiceSaleStop = dateStartServiceSaleStop;
            DateEndServiceSaleStop = dateEndServiceSaleStop;
        }
    }
}
