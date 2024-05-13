using HotelCalcApp.Model.Data;
using HotelCalcApp.Model.Services;

namespace HotelCalcApp.Controller
{
    /// <summary>Контроллер Сервиса для проверки  сервиса отеля</summary>
    public class HotelServiceVerificationController
    {
        /// <summary>Экземпляр Сервиса для проверки  сервиса отеля</summary>
        private HotelServiceVerificationModelService _HotelServiceVerificationService;

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

            Console.WriteLine("\nАктуальный период на указанную дату:");

            // DateTime currentDate = Convert.ToDateTime("09.04.2024");

            Console.WriteLine($"На дату : {currentDate}");

            Console.WriteLine("\nОтсортированный список по убыванию(по актуальной дате):");

            var sorted = salesStopDataSource.OrderByDescending(x => x.DateOfActualPeriodServiceSaleStop).ToList();

            foreach (var stopService in sorted)
            {
                Console.WriteLine($"Актуальная дата: {stopService.DateOfActualPeriodServiceSaleStop} " +
                    $"старт периода: {stopService.DateStartServiceSaleStop} " +
                    $"конец периода : {stopService.DateEndServiceSaleStop}");
            }

            for (int i = 0; i < sorted.Count; i++)
            {
                if (currentDate >= sorted[i].DateOfActualPeriodServiceSaleStop)
                {
                    searchedActualDate = sorted[i].DateOfActualPeriodServiceSaleStop;
                    //Console.WriteLine($"Актуальная дата в списке : {sorted[i].DateOfActualPeriodServiceSaleStop}");
                    Console.WriteLine($"\nАктуальная дата в списке : {searchedActualDate}");
                    break;
                }
            }

            return searchedActualDate;
        }

        /// <summary>Попадает ли период сервиса отеля в статус - Стоп Продаж</summary>
        public Boolean StopSalesOfHotelService()
        {
            return true;
        }
    }
}
