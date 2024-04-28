namespace HotelCalcApp.Model.Data
{
    /// <summary>Отель</summary>
    internal class Hotel
    {
        /// <summary>Идентификатор отеля</summary>
        public Int32 Id { get; set; }

        /// <summary>Название отеля</summary>
        public String? NameHotel { get; set; }

        /// <summary>Сервисы отеля</summary>
        public HotelService[]? HotelServices { get; set; }

        public Hotel() { }
    }
}
