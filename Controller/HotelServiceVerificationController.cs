using HotelCalcApp.Model.Data;
using HotelCalcApp.Model.Services;

namespace HotelCalcApp.Controller
{
    // TODO: Подумать о переносе элементов этого класса в модель  HotelServiceVerificationModelService

    /// <summary>Контроллер Сервиса для проверки  сервиса отеля</summary>
    public class HotelServiceVerificationController
    {
        /// <summary>Актуальная дата периода стоп продаж сервиса</summary>
        private DateTime _DateOfActualPeriodServiceSaleStop;

        /// <summary>Текущий Стоп продаж сервиса</summary>
        private ServiceSaleStop _CurrentTheServiceSaleStop;

        /// <summary>Экземпляр Сервиса для проверки  сервиса отеля</summary>
        private HotelServiceVerificationModelService _HotelServiceVerificationService;

        /// <summary>Актуальная дата периода стоп продаж сервиса</summary>
        public DateTime DateOfActualPeriodServiceSaleStop
        {
            get
            {
                return _DateOfActualPeriodServiceSaleStop;
            }
            set
            {
                _DateOfActualPeriodServiceSaleStop = value;
            }
        }

        /// <summary>Текущий Стоп продаж сервиса</summary>
        public ServiceSaleStop CurrentTheServiceSaleStop
        {
            get
            {
                return _CurrentTheServiceSaleStop;
            }
            set
            {
                _CurrentTheServiceSaleStop = value;
            }
        }

        /// <summary>Экземпляр Сервиса для проверки  сервиса отеля</summary>
        public HotelServiceVerificationModelService HotelServiceVerificationService
        {
            get
            {
                return _HotelServiceVerificationService;
            }
            set
            {
                _HotelServiceVerificationService = value;
            }
        }

        /// <summary>Экземпляр Контроллера Сервиса для проверки  сервиса отеля</summary>
        public HotelServiceVerificationController() { }

        // TODO:    1.  Определить актуальную дату периодов сервисов отеля статуса - Стоп Продаж;
        //          2.  Проанализировать передаваемый период - попадает ли он в периоды стоп продаж;
        //          3.  Вывести информацию о том, попадает ли анализируемый период в стоп продажи.

        //Определить актуальную дату периодов сервисов отеля статуса - Стоп Продаж
        /// <summary>
        /// Получаем актуальную дату периодов сервисов отеля статуса - Стоп Продаж
        /// </summary>
        /// <param name="currentDate">Дата пользователя, на которую необходимо определить актуальную дату</param>
        /// <param name="salesStopDataSource">Источник данных со стопами продаж</param>
        /// <returns></returns>
        public DateTime ReturnDateOfActualPeriodServiceSaleStop(DateTime currentDate, List<ServiceSaleStop> salesStopDataSource)
        {
            DateTime searchedActualDate = new DateTime();
            
            //  1.  Поиск актуального периода:
            //      1.1.    Актуальный период должен быть меньше или равен currentDate
            //              и должен быть больше остальных из уже имеющихся!


            return searchedActualDate;
        }

        /// <summary>Попадает ли период сервиса отеля в статус - Стоп Продаж</summary>
        public Boolean StopSalesOfHotelService()
        {
            return true;
        }
    }
}
