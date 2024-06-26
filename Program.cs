﻿using HotelCalcApp.Model.Data;
using static System.Reflection.Metadata.BlobBuilder;

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

            Console.WriteLine("Сервисы отелей:");
            foreach (var servicePlaneta in hotelServiceListPlaneta)
            {
                Console.WriteLine($"Сервис отеля Планета № {servicePlaneta.Id} : {servicePlaneta.NameService}");
            }

            Console.WriteLine("Цены сервисов отелей:");
            foreach (var hotelServicePricePlaneta in hotelServicePricesListPlaneta)
            {
                Console.WriteLine($"Цены сервисов отеля Планета : " +
                    $"сервис № {hotelServicePricePlaneta.IdHotelService} " +
                    $"[{hotelServiceListPlaneta.Find(item => item.Id == hotelServicePricePlaneta.IdHotelService)}]\t" +
                    $"цена : {hotelServicePricePlaneta.PriceService}");
            }
            Console.WriteLine("Бонусы отелей:");
            foreach (var guestBonusPlaneta in guestBonusListPlaneta)
            {
                Console.WriteLine($"Бонус отеля Планета : " +
                    $"Бонус отеля {hotelsList.Find(item => item.Id == guestBonusPlaneta.IdHotel)}: " +
                    $"{guestBonusPlaneta.NameGuestBonus}");
            }
        }
    }
}
