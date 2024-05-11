using HotelCalcApp.Model.Data;

namespace HotelCalcApp.Model.Services
{
    /// <summary>Сервис для проверки  сервиса отеля</summary>
    public class HotelServiceVerificationModelService
    {
        private HotelService _HotelServiceForVerification;
        private ServiceSaleStop _CurrentStopSaleService;

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
        public HotelServiceVerificationModelService(HotelService hotelServiceForVerification, ServiceSaleStop currentStopSaleService)
        {
            HotelServiceForVerification = hotelServiceForVerification;
            CurrentStopSaleService = currentStopSaleService;
        }
    }
}
