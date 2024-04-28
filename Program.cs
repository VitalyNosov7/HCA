using HotelCalcApp.Model.Data;

namespace HotelCalcApp
{
    internal class Program
    {
        static void Main()
        {
            #region /*ТЕСТОВЫЕ ДАННЫЕ*/

            //  Экземпляры отелей:
            List<Hotel> hotelsList = new List<Hotel>()
            {
                new Hotel() { Id = 1, NameHotel = "Планета" },
                new Hotel() { Id = 2, NameHotel = "Рябинка" }
            };


            //  Экземпляры сервисов отелей:
            //  Экземпляры сервисов отеля Планета:
            List<HotelService> hotelServicesListPlaneta = new List<HotelService>()
            {
                new HotelService() { Id = 1, NameService = "Стандарт 1 мест." },
                new HotelService() { Id = 2, NameService = "Стандарт 2 мест." },
                new HotelService() { Id = 3, NameService = "Стандарт доп." },
                new HotelService() { Id = 2, NameService = "Стандарт детский." }
            };


            //  Экземпляры цен на сервисы отелей:
            //  Экземпляры цен на сервисы отеля Планета:
            List<HotelServicePrice> hotelServicePricesListPlaneta = new List<HotelServicePrice>()
            {
                new HotelServicePrice()
                {
                    Id = Guid.NewGuid(),
                    DateActualPrice = Convert.ToDateTime("20.04.2024"),
                    DateStartPrice = Convert.ToDateTime("01.05.2024"),
                    DateEndPrice = Convert.ToDateTime("31.05.2024"),
                    PriceService = 5500,
                    IdHotelService = 1
                },
                new HotelServicePrice()
                {
                    Id = Guid.NewGuid(),
                    DateActualPrice = Convert.ToDateTime("20.04.2024"),
                    DateStartPrice = Convert.ToDateTime("01.05.2024"),
                    DateEndPrice = Convert.ToDateTime("31.05.2024"),
                    PriceService = 10000,
                    IdHotelService = 2
                },
                new HotelServicePrice()
                {
                    Id = Guid.NewGuid(),
                    DateActualPrice = Convert.ToDateTime("20.04.2024"),
                    DateStartPrice = Convert.ToDateTime("01.05.2024"),
                    DateEndPrice = Convert.ToDateTime("31.05.2024"),
                    PriceService = 5400,
                    IdHotelService = 3
                },
                new HotelServicePrice()
                {
                    Id = Guid.NewGuid(),
                    DateActualPrice = Convert.ToDateTime("20.04.2024"),
                    DateStartPrice = Convert.ToDateTime("01.05.2024"),
                    DateEndPrice = Convert.ToDateTime("31.05.2024"),
                    PriceService = 3000,
                    IdHotelService = 4
                },
                //===========================================================
                new HotelServicePrice()
                {
                    Id = Guid.NewGuid(),
                    DateActualPrice = Convert.ToDateTime("20.04.2024"),
                    DateStartPrice = Convert.ToDateTime("01.06.2024"),
                    DateEndPrice = Convert.ToDateTime("30.06.2024"),
                    PriceService = 7500,
                    IdHotelService = 1
                },
                new HotelServicePrice()
                {
                    Id = Guid.NewGuid(),
                    DateActualPrice = Convert.ToDateTime("20.04.2024"),
                    DateStartPrice = Convert.ToDateTime("01.06.2024"),
                    DateEndPrice = Convert.ToDateTime("30.06.2024"),
                    PriceService = 14000,
                    IdHotelService = 2
                },
                new HotelServicePrice()
                {
                    Id = Guid.NewGuid(),
                    DateActualPrice = Convert.ToDateTime("20.04.2024"),
                    DateStartPrice = Convert.ToDateTime("01.06.2024"),
                    DateEndPrice = Convert.ToDateTime("30.06.2024"),
                    PriceService = 7400,
                    IdHotelService = 3
                },
                new HotelServicePrice()
                {
                    Id = Guid.NewGuid(),
                    DateActualPrice = Convert.ToDateTime("20.04.2024"),
                    DateStartPrice = Convert.ToDateTime("01.06.2024"),
                    DateEndPrice = Convert.ToDateTime("30.06.2024"),
                    PriceService = 6000,
                    IdHotelService = 4
                }
            };

            #endregion

            foreach (var hotel in hotelsList)
            {
                Console.WriteLine($"Отель # {hotel.Id} : {hotel.NameHotel}");
            }
        }
    }
}
