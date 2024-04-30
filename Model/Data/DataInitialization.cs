namespace HotelCalcApp.Model.Data
{
    internal class DataInitialization
    {

        #region СПИСОК ОТЕЛЕЙ

        //  Экземпляры отелей:
        public List<Hotel> hotelsList = new List<Hotel>()
            {
                new Hotel() { Id = 1, NameHotel = "Планета" },
                new Hotel() { Id = 2, NameHotel = "Рябинка" }
            };
        #endregion

        #region СПИСОК СЕРВИСОВ ОТЕЛЯ ПЛАНЕТА

        //  Экземпляры сервисов отелей:
        //  Экземпляры сервисов отеля Планета:
        public List<HotelService> hotelServicesListPlaneta = new List<HotelService>()
            {
                new HotelService() { Id = 1, NameService = "Стандарт 1 мест." },
                new HotelService() { Id = 2, NameService = "Стандарт 2 мест." },
                new HotelService() { Id = 3, NameService = "Стандарт доп." },
                new HotelService() { Id = 4, NameService = "Стандарт детский." }
            };
        #endregion

        #region СПИСОК ЦЕН ОТЕЛЯ ПЛАНЕТА

        //  Экземпляры цен на сервисы отеля Планета:
        public List<HotelServicePrice> hotelServicePricesListPlaneta = new List<HotelServicePrice>()
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

        #region СПИСОК СТОПОВ ПРОДАЖ ОТЕЛЯ ПЛАНЕТА

        public List<ServiceSalesStop> serviceSalesStopListPlaneta = new List<ServiceSalesStop>()
        {
            new ServiceSalesStop()
            {
                Id = Guid.NewGuid(),
                DateStartServiceSalesStop = Convert.ToDateTime("10.04.2024"),
                DateEndServiceSalesStop = Convert.ToDateTime("15.04.2024"),
                IdHotelService = 1
            }
        };

        #endregion

        #region СПИСОК БОНУСОВ ГОСТЯ ОТЕЛЯ ПЛАНЕТА

        public List<GuestBonus> guestBonusListPlaneta = new List<GuestBonus>
        {
            new GuestBonus()
            {
                Id = Guid.NewGuid(),
                NameGuestBonus = GuestBonusType.EarlyBooking10.ToString(),
                DateStartGuestBonus = Convert.ToDateTime("16.04.2024"),
                DateEndGuestBonus = Convert.ToDateTime("20.04.2024"),
                IdHotel = 1
            },
            new GuestBonus()
            {
                Id = Guid.NewGuid(),
                NameGuestBonus = GuestBonusType.EarlyBooking15.ToString(),
                DateStartGuestBonus = Convert.ToDateTime("01.09.2024"),
                DateEndGuestBonus = Convert.ToDateTime("15.09.2024"),
                IdHotel = 1
            },
            new GuestBonus()
            {
                Id = Guid.NewGuid(),
                NameGuestBonus = GuestBonusType.RegularGuest.ToString(),
                DateStartGuestBonus = Convert.ToDateTime("01.01.2024"),
                DateEndGuestBonus = Convert.ToDateTime("31.12.2024"),
                IdHotel = 1
            }
        };

        #endregion
    }
}
