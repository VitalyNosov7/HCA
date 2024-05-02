namespace HotelCalcApp.Model.Data
{
    /// <summary>Отель</summary>
    public class Hotel
    {
        /// <summary>Идентификатор отеля</summary>
        public Int32 Id { get; set; }

        private String _NameHotel;
        private List<HotelService> _HotelServices;

        /// <summary>Название отеля</summary>
        public String NameHotel
        {
            get
            {
                return _NameHotel;
            }
            set
            {
                _NameHotel = value;
            }
        }

        /// <summary>Сервисы отеля</summary>
        public List<HotelService> HotelServices
        {
            get
            {
                return _HotelServices;
            }
            set
            {
                _HotelServices = value;
            }
        }

        /// <summary>
        /// Новый отель
        /// </summary>
        /// <param name="nameHotel">Название отеля</param>
        /// <param name="hotelServices">Список сервисов отеля</param>
        public Hotel(String nameHotel, List<HotelService> hotelServices)
        {
            NameHotel = nameHotel;
            _HotelServices = hotelServices;
        }

        /// <summary>Переопределенный метод. Выводит строковое название отеля</summary>
        public override string ToString()
        {
            return _NameHotel;
        }
    }
}
