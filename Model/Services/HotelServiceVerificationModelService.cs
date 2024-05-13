using HotelCalcApp.Model.Data;

namespace HotelCalcApp.Model.Services
{
    /// <summary>Сервис для проверки  сервиса отеля</summary>
    public class HotelServiceVerificationModelService
    {
        private Hotel _CurrentHotel;
        private HotelService _HotelServiceForVerification;
        private ServiceSaleStop _CurrentStopSaleService;

        public Hotel CurrentHotel
        {
            get
            {
                return _CurrentHotel;
            }
            set
            {
                _CurrentHotel = value;
            }
        }

        /// <summary>Проверяемый сервис отеля</summary>
        public HotelService HotelServiceForVerification
        {
            get
            {
                return _HotelServiceForVerification;
            }
            set
            {
                _HotelServiceForVerification = value;
            }
        }

        /// <summary>Актуальный период Стоп Продаж сервис отеля</summary>
        public ServiceSaleStop CurrentStopSaleService
        {
            get
            {
                return _CurrentStopSaleService;
            }
            set
            {
                _CurrentStopSaleService = value;
            }
        }

        /// <summary>Новая проверка сервиса отеля</summary>
        /// <param name="hotelServiceForVerification">Проверяемый сервис отеля</param>
        /// <param name="currentStopSaleService">Текущие периоды Стоп Продаж сервиса отеля</param>
        public HotelServiceVerificationModelService(Hotel currentHotel, HotelService hotelServiceForVerification, ServiceSaleStop currentStopSaleService)
        {
            CurrentHotel = currentHotel;
            HotelServiceForVerification = hotelServiceForVerification;
            CurrentStopSaleService = currentStopSaleService;
        }
    }
}
