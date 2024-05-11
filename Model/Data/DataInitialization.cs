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
                new HotelServicePrice(Convert.ToDateTime("20.04.2024"),
                                      Convert.ToDateTime("01.05.2024"),
                                      Convert.ToDateTime("31.05.2024"),
                                      5500)
                {
                    Id = Guid.NewGuid(),
                    IdHotelService = 1
                },
                new HotelServicePrice(Convert.ToDateTime("20.04.2024"),
                                      Convert.ToDateTime("01.05.2024"),
                                      Convert.ToDateTime("31.05.2024"),
                                      10000)
                {
                    Id = Guid.NewGuid(),
                    IdHotelService = 2
                },
                new HotelServicePrice(Convert.ToDateTime("20.04.2024"),
                                      Convert.ToDateTime("01.05.2024"),
                                      Convert.ToDateTime("31.05.2024"),
                                      5400)
                {
                    Id = Guid.NewGuid(),
                    IdHotelService = 3
                },
                new HotelServicePrice(Convert.ToDateTime("20.04.2024"),
                                      Convert.ToDateTime("01.05.2024"),
                                      Convert.ToDateTime("31.05.2024"),
                                      3000)
                {
                    Id = Guid.NewGuid(),
                    IdHotelService = 4
                },
                //===========================================================
                new HotelServicePrice(Convert.ToDateTime("20.04.2024"),
                                      Convert.ToDateTime("01.06.2024"),
                                      Convert.ToDateTime("30.06.2024"),
                                      7500)
                {
                    Id = Guid.NewGuid(),
                    IdHotelService = 1
                },
                new HotelServicePrice(Convert.ToDateTime("20.04.2024"),
                                      Convert.ToDateTime("01.06.2024"),
                                      Convert.ToDateTime("30.06.2024"),
                                      14000)
                {
                    Id = Guid.NewGuid(),
                    IdHotelService = 2
                },
                new HotelServicePrice(Convert.ToDateTime("20.04.2024"),
                                      Convert.ToDateTime("01.06.2024"),
                                      Convert.ToDateTime("30.06.2024"),
                                      7400)
                {
                    Id = Guid.NewGuid(),
                    IdHotelService = 3
                },
                new HotelServicePrice(Convert.ToDateTime("20.04.2024"),
                                      Convert.ToDateTime("01.06.2024"),
                                      Convert.ToDateTime("30.06.2024"),
                                      6000)
                {
                    Id = Guid.NewGuid(),
                    IdHotelService = 4
                }
            };

        #endregion

        #region СПИСОК ЦЕН ОТЕЛЯ ПЛАНЕТА

        //  Экземпляры цен на сервисы отеля Планета:
        public static List<HotelServicePrice> hotelServicePricesListRiabinka = new List<HotelServicePrice>()
            {
                new HotelServicePrice(Convert.ToDateTime("20.04.2024"),
                                      Convert.ToDateTime("01.05.2024"),
                                      Convert.ToDateTime("31.05.2024"),
                                      6000)
                {
                    Id = Guid.NewGuid(),
                    IdHotelService = 1
                },
                new HotelServicePrice(Convert.ToDateTime("20.04.2024"),
                                      Convert.ToDateTime("01.05.2024"),
                                      Convert.ToDateTime("31.05.2024"),
                                      10500)
                {
                    Id = Guid.NewGuid(),
                    IdHotelService = 2
                },
                new HotelServicePrice(Convert.ToDateTime("20.04.2024"),
                                      Convert.ToDateTime("01.05.2024"),
                                      Convert.ToDateTime("31.05.2024"),
                                      5900)
                {
                    Id = Guid.NewGuid(),
                    IdHotelService = 3
                },
                new HotelServicePrice(Convert.ToDateTime("20.04.2024"),
                                      Convert.ToDateTime("01.05.2024"),
                                      Convert.ToDateTime("31.05.2024"),
                                      3500)
                {
                    Id = Guid.NewGuid(),
                    IdHotelService = 4
                },
                //===========================================================
                new HotelServicePrice(Convert.ToDateTime("20.04.2024"),
                                      Convert.ToDateTime("01.06.2024"),
                                      Convert.ToDateTime("30.06.2024"),
                                      8000)
                {
                    Id = Guid.NewGuid(),
                    IdHotelService = 1
                },
                new HotelServicePrice(Convert.ToDateTime("20.04.2024"),
                                      Convert.ToDateTime("01.06.2024"),
                                      Convert.ToDateTime("30.06.2024"),
                                      14500)
                {
                    Id = Guid.NewGuid(),
                    IdHotelService = 2
                },
                new HotelServicePrice(Convert.ToDateTime("20.04.2024"),
                                      Convert.ToDateTime("01.06.2024"),
                                      Convert.ToDateTime("30.06.2024"),
                                      7900)
                {
                    Id = Guid.NewGuid(),
                    IdHotelService = 3
                },
                new HotelServicePrice(Convert.ToDateTime("20.04.2024"),
                                      Convert.ToDateTime("01.06.2024"),
                                      Convert.ToDateTime("30.06.2024"),
                                      6500)
                {
                    Id = Guid.NewGuid(),
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

        public  List<ServiceSaleStop> serviceSalesStopListPlaneta = new List<ServiceSaleStop>()
        {
            new ServiceSaleStop(Convert.ToDateTime("01.03.2024"),
                Convert.ToDateTime("01.04.2024"),
                Convert.ToDateTime("10.04.2024"))
            {
                Id = Guid.NewGuid(),
                IdHotelService = 1
            },
            new ServiceSaleStop(Convert.ToDateTime("01.04.2024"),
                Convert.ToDateTime("10.05.2024"),
                Convert.ToDateTime("15.05.2024"))
            {
                Id = Guid.NewGuid(),
                IdHotelService = 1
            },
            new ServiceSaleStop(Convert.ToDateTime("16.04.2024"),
                Convert.ToDateTime("20.05.2024"),
                Convert.ToDateTime("31.05.2024"))
            {
                Id = Guid.NewGuid(),
                IdHotelService = 1
            },
            new ServiceSaleStop(Convert.ToDateTime("10.04.2024"),
                Convert.ToDateTime("11.05.2024"),
                Convert.ToDateTime("19.05.2024"))
            {
                Id = Guid.NewGuid(),
                IdHotelService = 1
            },
            new ServiceSaleStop(Convert.ToDateTime("11.03.2024"),
                Convert.ToDateTime("16.04.2024"),
                Convert.ToDateTime("20.03.2024"))
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
