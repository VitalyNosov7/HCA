using System.Diagnostics;

namespace HotelCalcApp.Model.Data
{
    /// <summary>Цены Отеля</summary>
    public class HotelServicePrice
    {
        /// <summary>Идентификатор цены отеля</summary>
        public Guid Id { get; set; }

        /// <summary>Дата актуальных цен</summary>
        public DateTime DateActualPrice { get; set; }

        /// <summary>Дата начала действия стоимости сервиса</summary>
        public DateTime DateStartPrice { get; set; }

        /// <summary>Дата окончания действия стоимости сервиса</summary>
        public DateTime DateEndPrice { get; set; }

        /// <summary>Цена сервиса</summary>
        public Decimal PriceService { get; set; }

        /// <summary>Ссылка на идентификатор сервиса отеля</summary>
        public Int64 IdHotelService { get; set; }

        public HotelServicePrice() { }
    }
}
