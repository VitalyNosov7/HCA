using HotelCalcApp.Controller.Menu;
using HotelCalcApp.Model.Data;

namespace HotelCalcApp
{
    internal class Program
    {
        static void Main()
        {
            MainMenuController mainController = new MainMenuController();
            mainController.StartApp();
            mainController.MainViewStream();
          //  mainController.StopApp();


            #region ТЕСТОВЫЙ РАБОЧИЙ КОД С ДАННЫМИ
            //DataInitialization dataInitialization = new DataInitialization();
            //var hotelsList = dataInitialization.hotelsList;
            //var hotelServiceListPlaneta = DataInitialization.hotelServicesListPlaneta;
            //var hotelServicePricesListPlaneta = DataInitialization.hotelServicePricesListPlaneta;
            //var guestBonusListPlaneta = dataInitialization.guestBonusListPlaneta;
            //var serviceSalesStopListPlaneta = dataInitialization.serviceSalesStopListPlaneta;

            //Console.WriteLine("Названия отелей:");
            //foreach (var hotel in hotelsList)
            //{
            //    Console.WriteLine($"Отель # {hotel.Id} : {hotel.NameHotel}");
            //}

            //Console.WriteLine("\nСервисы отелей:");
            //foreach (var servicePlaneta in hotelServiceListPlaneta)
            //{
            //    Console.WriteLine($"Сервис отеля Планета № {servicePlaneta.Id} : {servicePlaneta.HotelServiceName}");
            //}

            //Console.WriteLine("\nЦены сервисов отелей:");
            //foreach (var hotelServicePricePlaneta in hotelServicePricesListPlaneta)
            //{
            //    Console.WriteLine($"Цены сервисов отеля Планета № : " +
            //                      $"сервис - {hotelServicePricePlaneta.IdHotelService}, " +
            //                       $"назв серв. : {-1}");
            //    //$"назв серв. : {from p in hotelServiceListPlaneta
            //    //                            where p.Id == hotelServicePricePlaneta.IdHotelService
            //    //                            select p.NameService}");

            //    Console.WriteLine($"Цены сервисов отеля Планета : " +
            //        $"сервис № {hotelServicePricePlaneta.IdHotelService} " +
            //        $"[{hotelServiceListPlaneta.Find(item => item.Id == hotelServicePricePlaneta.IdHotelService)}]\t" +
            //        $"цена : {hotelServicePricePlaneta.PriceService}");
            //}
            //Console.WriteLine("\nБонусы отелей:");
            //foreach (var guestBonusPlaneta in guestBonusListPlaneta)
            //{
            //    Console.WriteLine($"Бонус отеля Планета : " +
            //        $"Бонус отеля {hotelsList.Find(item => item.Id == guestBonusPlaneta.IdHotel)}: " +
            //        $"{guestBonusPlaneta.NameGuestBonus}");
            //}
            //Console.WriteLine("\nСтоп продаж сервисов отеля Планета:");

            //HotelServiceVerificationController hotelServiceVerificationController = new HotelServiceVerificationController();
            //hotelServiceVerificationController.ReturnDateOfActualPeriodServiceSaleStop(Convert.ToDateTime("11.04.2024"), serviceSalesStopListPlaneta);

            //Console.WriteLine("Добавить отель:");
            //String nameHotel = Console.ReadLine();
            //DataBaseController dataBaseController = new DataBaseController();
            //dataBaseController.AddHotel(nameHotel);

            //dataBaseController.GetHotel();

            //=============================================
            //Console.WriteLine("\nНе отсортированный список:");
            //foreach (var stopService in serviceSalesStopListPlaneta)
            //{
            //    Console.WriteLine($"Актуальная дата: {stopService.DateOfActualPeriodServiceSaleStop} " +
            //        $"старт париода: {stopService.DateStartServiceSaleStop} " +
            //        $"конец периода : {stopService.DateEndServiceSaleStop}");
            //}

            //Console.WriteLine("\nОтсортированный список по убыванию(по актуальной дате):");

            //var sorted = serviceSalesStopListPlaneta.OrderByDescending(x => x.DateOfActualPeriodServiceSaleStop).ToList();

            //foreach (var stopService in sorted)
            //{
            //    Console.WriteLine($"Актуальная дата: {stopService.DateOfActualPeriodServiceSaleStop} " +
            //        $"старт периода: {stopService.DateStartServiceSaleStop} " +
            //        $"конец периода : {stopService.DateEndServiceSaleStop}");
            //}

            //Console.WriteLine("\nАктуальный период на указанную дату:");

            //DateTime currentDate = Convert.ToDateTime("09.04.2024");

            //Console.WriteLine($"На дату : {currentDate}");

            //for (int i = 0; i < sorted.Count; i++)
            //{
            //    if (currentDate >= sorted[i].DateOfActualPeriodServiceSaleStop)
            //    {
            //        Console.WriteLine($"Актуальная дата в списке : {sorted[i].DateOfActualPeriodServiceSaleStop}");
            //        return;
            //        //if (sorted[i + 1].DateOfActualPeriodServiceSaleStop != null)
            //        //{
            //        //    if (sorted[i].DateOfActualPeriodServiceSaleStop < sorted[i + 1].DateOfActualPeriodServiceSaleStop)
            //        //    {

            //        //    }
            //        //}
            //    }
            //}
            #endregion
        }
    }
}
