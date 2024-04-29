namespace HotelCalcApp.Model.Data
{
    /// <summary>Стоп продаж сервиса</summary>
    internal class ServiceSalesStop
    {
        /// <summary>Идентификатор стопа продажи сервиса</summary>
        public Guid Id { get; set; }

        /// <summary>Дата начала действия стопа продажи сервиса</summary>
        public DateTime DateStartServiceSalesStop { get; set; }

        /// <summary>Дата окончания действия стопа продажи сервиса</summary>
        public DateTime DateEndServiceSalesStop { get; set; }

        /// <summary>Идентификатор сервиса отеля</summary>
        public Int64 IdHotelService { get; set; }
    }
}
