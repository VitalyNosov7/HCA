using HotelCalcApp.Model.Data;

namespace HotelCalcApp.Model.Services
{
    /// <summary>Сервис для проверки  сервиса отеля</summary>
    public class HotelServiceVerificationService
    {
        private HotelService? _HotelServiceForVerification;
        private ServiceSalesStop? _CurrentStopSaleService;

        /// <summary>Проверяемый сервис отеля</summary>
        public HotelService? HotelServiceForVerification
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
        public ServiceSalesStop? CurrentStopSaleService
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

        /// <summary>
        /// Новая проверка сервиса отеля
        /// </summary>
        /// <param name="hotelServiceForVerification">Проверяемый сервис отеля</param>
        /// <param name="currentStopSaleService">Актуальный период Стоп Продаж сервиса отеля</param>
        public HotelServiceVerificationService(HotelService hotelServiceForVerification, ServiceSalesStop currentStopSaleService)
        {
            HotelServiceForVerification = hotelServiceForVerification;
            CurrentStopSaleService = currentStopSaleService;
        }

        /// <summary>Попадает ли период сервиса отеля в статус - Стоп Продаж</summary>
        public Boolean StopSalesOfHotelService()
        {
            // TODO:    1.  Определить актуальную дату периодов сервисов отеля статуса - Стоп Продаж;
            //          2.  

            return true;
        }
    }
}
