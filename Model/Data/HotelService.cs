namespace HotelCalcApp.Model.Data
{
    /// <summary>Сервис отеля</summary>
    internal class HotelService
    {
        /// <summary>Идентификатор сервиса отеля</summary>
        public Int64 Id { get; set; }

        /// <summary>Название сервиса отеля</summary>
        public String? NameService { get; set; }

        /// <summary>Расценки сервиса отеля</summary>
        public HotelServicePrice[]? HotelServicePrices { get; set; }

        /// <summary>Ссылка на идентификатор отеля</summary>
        public Int32 IdHotel { get; set; }

        public HotelService() { }
    }
}
