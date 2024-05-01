using HotelCalcApp.Model.Data;
using System.IO;

namespace HotelCalcApp
{
    internal class Program
    {
        static void Main()
        {
            DataInitialization dataInitialization = new DataInitialization();
            var hotelsList = dataInitialization.hotelsList;
            var hotelServiceListPlaneta = dataInitialization.hotelServicesListPlaneta;
            var hotelServicePricesListPlaneta = dataInitialization.hotelServicePricesListPlaneta;
            var guestBonusListPlaneta = dataInitialization.guestBonusListPlaneta;

            Console.WriteLine("Названия отелей:");
            foreach (var hotel in hotelsList)
            {
                Console.WriteLine($"Отель # {hotel.Id} : {hotel.NameHotel}");
            }

            Console.WriteLine("\nСервисы отелей:");
            foreach (var servicePlaneta in hotelServiceListPlaneta)
            {
                Console.WriteLine($"Сервис отеля Планета № {servicePlaneta.Id} : {servicePlaneta.NameService}");
            }

            Console.WriteLine("\nЦены сервисов отелей:");
            foreach (var hotelServicePricePlaneta in hotelServicePricesListPlaneta)
            {
                Console.WriteLine($"Цены сервисов отеля Планета № : " +
                                  $"сервис - {hotelServicePricePlaneta.IdHotelService}, " +
                                   $"назв серв. : {-1}");
                //$"назв серв. : {from p in hotelServiceListPlaneta
                //                            where p.Id == hotelServicePricePlaneta.IdHotelService
                //                            select p.NameService}");

                Console.WriteLine($"Цены сервисов отеля Планета : " +
                    $"сервис № {hotelServicePricePlaneta.IdHotelService} " +
                    $"[{hotelServiceListPlaneta.Find(item => item.Id == hotelServicePricePlaneta.IdHotelService)}]\t" +
                    $"цена : {hotelServicePricePlaneta.PriceService}");
            }
            Console.WriteLine("\nБонусы отелей:");
            foreach (var guestBonusPlaneta in guestBonusListPlaneta)
            {
                Console.WriteLine($"Бонус отеля Планета : " +
                    $"Бонус отеля {hotelsList.Find(item => item.Id == guestBonusPlaneta.IdHotel)}: " +
                    $"{guestBonusPlaneta.NameGuestBonus}");
            }
        }
    }
}
