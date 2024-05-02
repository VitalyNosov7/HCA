namespace HotelCalcApp.Model.Data
{
    public class DataInitialization
    {

        #region СПИСОК ОТЕЛЕЙ

        //  Экземпляры отелей:
        public List<Hotel> hotelsList = new List<Hotel>()
            {
                new Hotel("Планета", hotelServicesListPlaneta) { Id = 1},
                new Hotel("Рябинка", hotelServicesListRiabinka) { Id = 2}
            };
        #endregion



        #region СПИСОК ЦЕН ОТЕЛЯ ПЛАНЕТА

        //  Экземпляры цен на сервисы отеля Планета:
        public static List<HotelServicePrice> hotelServicePricesListPlaneta = new List<HotelServicePrice>()
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

        #region СПИСОК ЦЕН ОТЕЛЯ ПЛАНЕТА

        //  Экземпляры цен на сервисы отеля Планета:
        public static List<HotelServicePrice> hotelServicePricesListRiabinka = new List<HotelServicePrice>()
            {
                new HotelServicePrice()
                {
                    Id = Guid.NewGuid(),
                    DateActualPrice = Convert.ToDateTime("20.04.2024"),
                    DateStartPrice = Convert.ToDateTime("01.05.2024"),
                    DateEndPrice = Convert.ToDateTime("31.05.2024"),
                    PriceService = 6000,
                    IdHotelService = 1
                },
                new HotelServicePrice()
                {
                    Id = Guid.NewGuid(),
                    DateActualPrice = Convert.ToDateTime("20.04.2024"),
                    DateStartPrice = Convert.ToDateTime("01.05.2024"),
                    DateEndPrice = Convert.ToDateTime("31.05.2024"),
                    PriceService = 10500,
                    IdHotelService = 2
                },
                new HotelServicePrice()
                {
                    Id = Guid.NewGuid(),
                    DateActualPrice = Convert.ToDateTime("20.04.2024"),
                    DateStartPrice = Convert.ToDateTime("01.05.2024"),
                    DateEndPrice = Convert.ToDateTime("31.05.2024"),
                    PriceService = 5900,
                    IdHotelService = 3
                },
                new HotelServicePrice()
                {
                    Id = Guid.NewGuid(),
                    DateActualPrice = Convert.ToDateTime("20.04.2024"),
                    DateStartPrice = Convert.ToDateTime("01.05.2024"),
                    DateEndPrice = Convert.ToDateTime("31.05.2024"),
                    PriceService = 3500,
                    IdHotelService = 4
                },
                //===========================================================
                new HotelServicePrice()
                {
                    Id = Guid.NewGuid(),
                    DateActualPrice = Convert.ToDateTime("20.04.2024"),
                    DateStartPrice = Convert.ToDateTime("01.06.2024"),
                    DateEndPrice = Convert.ToDateTime("30.06.2024"),
                    PriceService = 8000,
                    IdHotelService = 1
                },
                new HotelServicePrice()
                {
                    Id = Guid.NewGuid(),
                    DateActualPrice = Convert.ToDateTime("20.04.2024"),
                    DateStartPrice = Convert.ToDateTime("01.06.2024"),
                    DateEndPrice = Convert.ToDateTime("30.06.2024"),
                    PriceService = 14500,
                    IdHotelService = 2
                },
                new HotelServicePrice()
                {
                    Id = Guid.NewGuid(),
                    DateActualPrice = Convert.ToDateTime("20.04.2024"),
                    DateStartPrice = Convert.ToDateTime("01.06.2024"),
                    DateEndPrice = Convert.ToDateTime("30.06.2024"),
                    PriceService = 7900,
                    IdHotelService = 3
                },
                new HotelServicePrice()
                {
                    Id = Guid.NewGuid(),
                    DateActualPrice = Convert.ToDateTime("20.04.2024"),
                    DateStartPrice = Convert.ToDateTime("01.06.2024"),
                    DateEndPrice = Convert.ToDateTime("30.06.2024"),
                    PriceService = 6500,
                    IdHotelService = 4
                }
            };

        #endregion

        #region СПИСОК СЕРВИСОВ ОТЕЛЯ ПЛАНЕТА

        //  Экземпляры сервисов отеля Планета:
        public static List<HotelService> hotelServicesListPlaneta = new List<HotelService>()
            {
                new HotelService("Стандарт 1 мест.", hotelServicePricesListPlaneta) { Id = 1},
                new HotelService("Стандарт 2 мест.", hotelServicePricesListPlaneta) { Id = 2},
                new HotelService("Стандарт доп.", hotelServicePricesListPlaneta ) { Id = 3},
                new HotelService("Стандарт детский.", hotelServicePricesListPlaneta) { Id = 4}
            };
        #endregion

        #region СПИСОК СЕРВИСОВ ОТЕЛЯ РЯБИНКА

        //  Экземпляры сервисов отеля Рябинка:
        public static List<HotelService> hotelServicesListRiabinka = new List<HotelService>()
            {
                new HotelService("Улучшенный 1 мест.", hotelServicePricesListRiabinka) { Id = 1},
                new HotelService("Улучшенный 2 мест.", hotelServicePricesListRiabinka) { Id = 2},
                new HotelService("Улучшенный доп.", hotelServicePricesListRiabinka ) { Id = 3},
                new HotelService("Улучшенный детский.", hotelServicePricesListRiabinka) { Id = 4}
            };
        #endregion

        #region СПИСОК СТОПОВ ПРОДАЖ ОТЕЛЯ ПЛАНЕТА

        public List<ServiceSalesStop> serviceSalesStopListPlaneta = new List<ServiceSalesStop>()
        {
            new ServiceSalesStop(Convert.ToDateTime("10.04.2024"), Convert.ToDateTime("15.04.2024"))
            {
                Id = Guid.NewGuid(),
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
