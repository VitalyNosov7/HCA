using HotelCalcApp.Model.Services;

namespace HotelCalcApp.Controller
{
    /// <summary>Контроллер сервиса для проверки  сервиса отеля</summary>
    public class HotelServiceVerificationController
    {
        private HotelServiceVerificationModelService _CurrentVerificationOfHotelService;


        public HotelServiceVerificationModelService CurrentVerificationOfHotelService
        {
            get
            {
                return _CurrentVerificationOfHotelService;
            }
            set
            {
                _CurrentVerificationOfHotelService = value;
            }
        }

        /// <summary>Попадает ли период сервиса отеля в статус - Стоп Продаж</summary>
        public Boolean StopSalesOfHotelService()
        {
            // TODO:    1.  Определить актуальную дату периодов сервисов отеля статуса - Стоп Продаж;
            //          2.  

            return true;
        }

        //Определить актуальную дату периодов сервисов отеля статуса - Стоп Продаж
        public DateTime ReturnDateOfActualPeriodServiceSaleStop()
        {
            return new DateTime();
        }
    }
}
