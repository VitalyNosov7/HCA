using HotelCalcApp.Model.Data;

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
                Console.WriteLine($"Цены сервисов отеля Планета № : " +
                                  $"сервис - {hotelServicePricePlaneta.IdHotelService}, " +
                                  $"цена : {from p in hotelServiceListPlaneta
                                            where p.Id == hotelServicePricePlaneta.IdHotelService
                                            select p.NameService}");
            }
        }
    }
}
