namespace HotelCalcApp.Model.Data
{
    /// <summary>Бонус Гостя</summary>
    public class GuestBonus
    {
        /// <summary>Идентификатор бонуса гостя</summary>
        public Guid Id { get; set; }

        /// <summary>Название бонуса</summary>
        public String? NameGuestBonus { get; set; }

        /// <summary>Дата начала действия бонуса гостя</summary>
        public DateTime DateStartGuestBonus { get; set; }

        /// <summary>Дата окончания действия бонуса гостя</summary>
        public DateTime DateEndGuestBonus { get; set; }

        /// <summary>Идентификатор отеля</summary>
        public Int32 IdHotel { get; set; }
    }
}
