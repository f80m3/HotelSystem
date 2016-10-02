using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSystem
{
    public class HotelsDataProvider
    {
        private PointsOfInterestFactory _poiFactory;
        private FeaturesFactory _featuresFactory;
        private RoomsFactory _roomsFactory;
        private List<Hotel> _hotels;

        public HotelsDataProvider()
        {
            _poiFactory = new PointsOfInterestFactory();
            _featuresFactory = new FeaturesFactory();
            _roomsFactory = new RoomsFactory();
            _hotels = new List<Hotel>();
            GenerateHotels();
        }

        protected void GenerateHotels()
        {
            //hotel 1
            Hotel operaHotel = new Hotel();
            operaHotel.Name = "Opera Tower";
            operaHotel.Address = "1750 N Basyhore Drive, Miami FL 33132";
            operaHotel.Rating = 5.0;
            operaHotel.Id = 1;
            operaHotel.Features.Add(_featuresFactory.CreateAirConditioning());
            operaHotel.Features.Add(_featuresFactory.CreatePool());
            operaHotel.Features.Add(_featuresFactory.CreateValetParking());
            operaHotel.NearbyPlaces.Add(_poiFactory.CreateBeach("South Beach", 1, "Ocean Drive"));
            operaHotel.NearbyPlaces.Add(_poiFactory.CreateBeach("North Miami Beach", 11, "Collins 135th"));
            operaHotel.NearbyPlaces.Add(_poiFactory.CreateDining("Nove Sushi", 0.1, "1750 N Bayshore Drive"));
            operaHotel.NearbyPlaces.Add(_poiFactory.CreateShopping("Lincoln Shopping Mall", 2, "Lincoln Road"));
            operaHotel.Rooms.Add(_roomsFactory.CreateKing(400, 2));
            operaHotel.Rooms.Add(_roomsFactory.CreateKing(400, 2));
            operaHotel.Rooms.Add(_roomsFactory.CreateKing(400, 2));
            operaHotel.Rooms.Add(_roomsFactory.CreateKing(400, 2));
            operaHotel.Rooms.Add(_roomsFactory.CreateQueen(200, 2));
            operaHotel.Rooms.Add(_roomsFactory.CreateQueen(200, 2));
            operaHotel.Rooms.Add(_roomsFactory.CreateQueen(300, 2)); //sure this queen is worth more but thats because im sure its a ocean view room :D
            operaHotel.Rooms.Add(_roomsFactory.CreateQueen(100, 2));
            operaHotel.Rooms.Add(_roomsFactory.CreateQueen(100, 2));
            _hotels.Add(operaHotel);
            //------------------------------------------------

            //hotel 2
            Hotel wHotel = new Hotel();
            wHotel.Name = "W South Beach";
            wHotel.Address = "2201 Collins Ave, Miami Beach, FL 33139";
            wHotel.Rating = 5.0;
            wHotel.Id = 2;
            wHotel.Features.Add(_featuresFactory.CreateAirConditioning());
            wHotel.Features.Add(_featuresFactory.CreatePool());
            wHotel.Features.Add(_featuresFactory.CreateValetParking());
            wHotel.Features.Add(_featuresFactory.CreateLaundry());
            wHotel.Features.Add(_featuresFactory.CreateWiFi());
            wHotel.NearbyPlaces.Add(_poiFactory.CreateBeach("South Beach", 1, "Ocean Drive"));
            wHotel.NearbyPlaces.Add(_poiFactory.CreateDining("Juvia", 0.1, "Lincoln Road"));
            wHotel.NearbyPlaces.Add(_poiFactory.CreateDining("Hiro Sushi", 0.1, "Lincoln Road"));
            wHotel.NearbyPlaces.Add(_poiFactory.CreateTransportation("MIA International", 0.1, "Lejune and 836"));
            wHotel.NearbyPlaces.Add(_poiFactory.CreateShopping("Lincoln Shopping Mall", 2, "Lincoln Road"));
            //the W is a huge hotel, has a lot of rooms
            for(int i = 0; i < 15; i++)
                wHotel.Rooms.Add(_roomsFactory.CreateKing(600, 2));
            for (int i = 0; i < 15; i++)
                wHotel.Rooms.Add(_roomsFactory.CreateQueen(500, 2));
            for (int i = 0; i < 5; i++)
                wHotel.Rooms.Add(_roomsFactory.CreateSuite(750, 2));            
            _hotels.Add(wHotel);
            //------------------------------------------------

            Hotel fountainBlueHotel = new Hotel();
            fountainBlueHotel.Name = "Fountain Bleau";
            fountainBlueHotel.Address = "4441 Collins Ave, Miami Beach, FL 33140";
            fountainBlueHotel.Rating = 4.5;
            fountainBlueHotel.Id = 3;
            fountainBlueHotel.Features.Add(_featuresFactory.CreateAirConditioning());
            fountainBlueHotel.Features.Add(_featuresFactory.CreatePool());
            fountainBlueHotel.Features.Add(_featuresFactory.CreateValetParking());
            fountainBlueHotel.Features.Add(_featuresFactory.CreateLaundry());
            fountainBlueHotel.Features.Add(_featuresFactory.CreateWiFi());
            fountainBlueHotel.NearbyPlaces.Add(_poiFactory.CreateBeach("South Beach", 6, "Ocean Drive"));
            fountainBlueHotel.NearbyPlaces.Add(_poiFactory.CreateEntertainment("Liv Club", 0.1, "SoFlo"));           
            fountainBlueHotel.NearbyPlaces.Add(_poiFactory.CreateShopping("Bal Harbour Showps", 2, "170 Collins"));
            //another big hotel with a lot of rooms
            for (int i = 0; i < 50; i++)
                fountainBlueHotel.Rooms.Add(_roomsFactory.CreateKing(500, 2));
            for (int i = 0; i < 75; i++)
                fountainBlueHotel.Rooms.Add(_roomsFactory.CreateQueen(400, 2));
            for (int i = 0; i < 20; i++)
                fountainBlueHotel.Rooms.Add(_roomsFactory.CreateSuite(600, 2));
            for (int i = 0; i < 15; i++)
                fountainBlueHotel.Rooms.Add(_roomsFactory.CreateDouble(200, 2));
            _hotels.Add(fountainBlueHotel);
            //------------------------------------------------

            //hotel 4
            Hotel mandarinOrientalHotel = new Hotel();
            mandarinOrientalHotel.Name = "Mandarin Oriental";
            mandarinOrientalHotel.Address = "500 Brickell Key Dr, Miami, FL 33131";
            mandarinOrientalHotel.Rating = 5.0;
            mandarinOrientalHotel.Id = 4;
            mandarinOrientalHotel.Features.Add(_featuresFactory.CreateAirConditioning());
            mandarinOrientalHotel.Features.Add(_featuresFactory.CreatePool());
            mandarinOrientalHotel.Features.Add(_featuresFactory.CreateValetParking());
            mandarinOrientalHotel.Features.Add(_featuresFactory.CreateLaundry());
            mandarinOrientalHotel.Features.Add(_featuresFactory.CreateWiFi());
            mandarinOrientalHotel.NearbyPlaces.Add(_poiFactory.CreateBeach("South Beach", 8, "Ocean Drive"));
            mandarinOrientalHotel.NearbyPlaces.Add(_poiFactory.CreateEntertainment("Palm Club", 0.1, "Mango"));
            mandarinOrientalHotel.NearbyPlaces.Add(_poiFactory.CreateShopping("Bal Harbour Shops", 2, "370 Washington"));
            //another big hotel with a lot of rooms
            for (int i = 0; i < 45; i++)
                mandarinOrientalHotel.Rooms.Add(_roomsFactory.CreateKing(700, 2));
            for (int i = 0; i < 55; i++)
                mandarinOrientalHotel.Rooms.Add(_roomsFactory.CreateQueen(600, 2));
            for (int i = 0; i < 15; i++)
                mandarinOrientalHotel.Rooms.Add(_roomsFactory.CreateSuite(900, 2));
            for (int i = 0; i < 15; i++)
                mandarinOrientalHotel.Rooms.Add(_roomsFactory.CreateDouble(300, 2));
            _hotels.Add(mandarinOrientalHotel);
            //------------------------------------------------

            //hotel 5
            Hotel savoyHotel = new Hotel();
            savoyHotel.Name = "Savoy Hotel";
            savoyHotel.Address = "425 Ocean Drive, Miami Beach, FL 33139-6613";
            savoyHotel.Rating = 3.5;
            savoyHotel.Id = 5;
            savoyHotel.Features.Add(_featuresFactory.CreateAirConditioning());
            savoyHotel.Features.Add(_featuresFactory.CreatePool());
            savoyHotel.Features.Add(_featuresFactory.CreateValetParking());
            savoyHotel.Features.Add(_featuresFactory.CreateLaundry());
            savoyHotel.Features.Add(_featuresFactory.CreateWiFi());
            savoyHotel.NearbyPlaces.Add(_poiFactory.CreateBeach("South Beach", 10, "Ocean Drive"));
            savoyHotel.NearbyPlaces.Add(_poiFactory.CreateEntertainment("Riviera Club", 0.1, "Apple Martini"));
            savoyHotel.NearbyPlaces.Add(_poiFactory.CreateShopping("Bal Harbour Shops", 2, "330 Washington"));
            //another big hotel with a lot of rooms
            for (int i = 0; i < 35; i++)
                savoyHotel.Rooms.Add(_roomsFactory.CreateKing(300, 2));
            for (int i = 0; i < 25; i++)
                savoyHotel.Rooms.Add(_roomsFactory.CreateQueen(200, 2));
            for (int i = 0; i < 10; i++)
                savoyHotel.Rooms.Add(_roomsFactory.CreateSuite(400, 2));
            for (int i = 0; i < 10; i++)
                savoyHotel.Rooms.Add(_roomsFactory.CreateDouble(300, 2));
            _hotels.Add(savoyHotel);
            //------------------------------------------------

            //hotel 6
            Hotel pelicanHotel = new Hotel();
            pelicanHotel.Name = "Pelican Hotel";
            pelicanHotel.Address = "826 Ocean Dr, Miami Beach, FL 33139-5809";
            pelicanHotel.Rating = 3.0;
            pelicanHotel.Id = 6;
            pelicanHotel.Features.Add(_featuresFactory.CreateAirConditioning());
            pelicanHotel.Features.Add(_featuresFactory.CreatePool());
            pelicanHotel.Features.Add(_featuresFactory.CreateValetParking());
            pelicanHotel.NearbyPlaces.Add(_poiFactory.CreateBeach("South Beach", 1, "Ocean Drive"));
            pelicanHotel.NearbyPlaces.Add(_poiFactory.CreateBeach("South Beach", 12, "Collins 135th"));
            pelicanHotel.NearbyPlaces.Add(_poiFactory.CreateDining("Nove Sushi", 0.1, "1750 N Bayshore Drive"));
            pelicanHotel.NearbyPlaces.Add(_poiFactory.CreateShopping("Lincoln Shopping Mall", 2, "Lincoln Road"));
            pelicanHotel.Rooms.Add(_roomsFactory.CreateKing(275, 2));
            pelicanHotel.Rooms.Add(_roomsFactory.CreateKing(275, 2));
            pelicanHotel.Rooms.Add(_roomsFactory.CreateKing(275, 2));
            pelicanHotel.Rooms.Add(_roomsFactory.CreateKing(275, 2));
            pelicanHotel.Rooms.Add(_roomsFactory.CreateQueen(150, 2));
            pelicanHotel.Rooms.Add(_roomsFactory.CreateQueen(150, 2));
            pelicanHotel.Rooms.Add(_roomsFactory.CreateQueen(250, 2)); //sure this queen is worth more but thats because im sure its a ocean view room :D
            pelicanHotel.Rooms.Add(_roomsFactory.CreateQueen(100, 2));
            pelicanHotel.Rooms.Add(_roomsFactory.CreateQueen(100, 2));
            _hotels.Add(pelicanHotel);
            //------------------------------------------------

            //hotel 7
            Hotel theTidesHotel = new Hotel();
            theTidesHotel.Name = "The Tides Hotel";
            theTidesHotel.Address = "1220 Ocean Dr, Miami Beach, FL 33139-4610";
            theTidesHotel.Rating = 2.5;
            theTidesHotel.Id = 7;
            theTidesHotel.Features.Add(_featuresFactory.CreateAirConditioning());
            theTidesHotel.Features.Add(_featuresFactory.CreatePool());
            theTidesHotel.Features.Add(_featuresFactory.CreateValetParking());
            theTidesHotel.Features.Add(_featuresFactory.CreateLaundry());
            theTidesHotel.Features.Add(_featuresFactory.CreateWiFi());
            theTidesHotel.NearbyPlaces.Add(_poiFactory.CreateBeach("South Beach", 0.5, "Washington Drive"));
            theTidesHotel.NearbyPlaces.Add(_poiFactory.CreateEntertainment("Riviera Club", 1.2, "Apple Martini"));
            theTidesHotel.NearbyPlaces.Add(_poiFactory.CreateShopping("Bal Harbour Shops", 2, "1230 Washington"));
            //another big hotel with a lot of rooms
            for (int i = 0; i < 15; i++)
                theTidesHotel.Rooms.Add(_roomsFactory.CreateKing(300, 2));
            for (int i = 0; i < 25; i++)
                theTidesHotel.Rooms.Add(_roomsFactory.CreateQueen(200, 2));
            for (int i = 0; i < 10; i++)
                theTidesHotel.Rooms.Add(_roomsFactory.CreateSuite(400, 2));
            for (int i = 0; i < 10; i++)
                theTidesHotel.Rooms.Add(_roomsFactory.CreateDouble(300, 2));
            _hotels.Add(theTidesHotel);
            //------------------------------------------------

            //hotel 8
            Hotel redHotel = new Hotel();
            redHotel.Name = "Red South Beach Hotel";
            redHotel.Address = "3010 Collins Avenue, Miami Beach";
            redHotel.Rating = 4.0;
            redHotel.Id = 8;
            redHotel.Features.Add(_featuresFactory.CreateAirConditioning());
            redHotel.Features.Add(_featuresFactory.CreatePool());
            redHotel.Features.Add(_featuresFactory.CreateValetParking());
            redHotel.Features.Add(_featuresFactory.CreateLaundry());
            redHotel.Features.Add(_featuresFactory.CreateWiFi());
            redHotel.NearbyPlaces.Add(_poiFactory.CreateBeach("South Beach", 1.8, "Ocean Drive"));
            redHotel.NearbyPlaces.Add(_poiFactory.CreateEntertainment("Riviera Club", 2.1, "Apple Martini"));
            redHotel.NearbyPlaces.Add(_poiFactory.CreateShopping("Bal Harbour Shops", 4, "330 Washington"));
            //another big hotel with a lot of rooms
            for (int i = 0; i < 10; i++)
                redHotel.Rooms.Add(_roomsFactory.CreateKing(300, 2));
            for (int i = 0; i < 15; i++)
                redHotel.Rooms.Add(_roomsFactory.CreateQueen(200, 2));
            for (int i = 0; i < 5; i++)
                redHotel.Rooms.Add(_roomsFactory.CreateSuite(400, 2));
            for (int i = 0; i < 5; i++)
                redHotel.Rooms.Add(_roomsFactory.CreateDouble(300, 2));
            _hotels.Add(redHotel);
            //------------------------------------------------

            //hotel 9
            Hotel kimptonHotel = new Hotel();
            kimptonHotel.Name = "Kimpton Surfcomber Hotel";
            kimptonHotel.Address = "1717 Collins Ave, Miami Beach, FL 33139-2006";
            kimptonHotel.Rating = 2.0;
            kimptonHotel.Id = 9;
            kimptonHotel.Features.Add(_featuresFactory.CreateAirConditioning());
            kimptonHotel.Features.Add(_featuresFactory.CreatePool());
            kimptonHotel.Features.Add(_featuresFactory.CreateValetParking());
            kimptonHotel.NearbyPlaces.Add(_poiFactory.CreateBeach("South Beach", 1, "Collins Ave"));
            kimptonHotel.NearbyPlaces.Add(_poiFactory.CreateBeach("South Beach", 2, "Collins 935th"));
            kimptonHotel.NearbyPlaces.Add(_poiFactory.CreateDining("Nove Sushi", 11.1, "1750 N Bayshore Drive"));
            kimptonHotel.NearbyPlaces.Add(_poiFactory.CreateShopping("Lincoln Shopping Mall", 2, "Lincoln Road"));
            kimptonHotel.Rooms.Add(_roomsFactory.CreateKing(175, 2));
            kimptonHotel.Rooms.Add(_roomsFactory.CreateKing(175, 2));
            kimptonHotel.Rooms.Add(_roomsFactory.CreateKing(175, 2));
            kimptonHotel.Rooms.Add(_roomsFactory.CreateKing(175, 2));
            kimptonHotel.Rooms.Add(_roomsFactory.CreateQueen(100, 2));
            kimptonHotel.Rooms.Add(_roomsFactory.CreateQueen(100, 2));
            kimptonHotel.Rooms.Add(_roomsFactory.CreateQueen(150, 2)); //sure this queen is worth more but thats because im sure its a ocean view room :D
            kimptonHotel.Rooms.Add(_roomsFactory.CreateQueen(80, 2));
            kimptonHotel.Rooms.Add(_roomsFactory.CreateQueen(80, 2));
            _hotels.Add(kimptonHotel);
            //------------------------------------------------

            //hotel 10
            Hotel delanoHotel = new Hotel();
            delanoHotel.Name = "Delano South Beach";
            delanoHotel.Address = "1717 Collins Ave, Miami Beach, FL 33139-2006";
            delanoHotel.Rating = 4.5;
            delanoHotel.Id = 10;
            delanoHotel.Features.Add(_featuresFactory.CreateAirConditioning());
            delanoHotel.Features.Add(_featuresFactory.CreatePool());
            delanoHotel.Features.Add(_featuresFactory.CreateValetParking());
            delanoHotel.NearbyPlaces.Add(_poiFactory.CreateBeach("South Beach", 1.7, "Collins Ave"));
            delanoHotel.NearbyPlaces.Add(_poiFactory.CreateBeach("South Beach", 3, "Collins 935th"));
            delanoHotel.NearbyPlaces.Add(_poiFactory.CreateDining("Nove Sushi", 1.1, "1750 N Bayshore Drive"));
            delanoHotel.NearbyPlaces.Add(_poiFactory.CreateShopping("Lincoln Shopping Mall", 6.2, "Lincoln Road"));
            delanoHotel.Rooms.Add(_roomsFactory.CreateKing(500, 2));
            delanoHotel.Rooms.Add(_roomsFactory.CreateKing(500, 2));
            delanoHotel.Rooms.Add(_roomsFactory.CreateKing(600, 2));
            delanoHotel.Rooms.Add(_roomsFactory.CreateKing(450, 2));
            delanoHotel.Rooms.Add(_roomsFactory.CreateQueen(400, 2));
            delanoHotel.Rooms.Add(_roomsFactory.CreateQueen(375, 2));
            delanoHotel.Rooms.Add(_roomsFactory.CreateQueen(475, 2)); //sure this queen is worth more but thats because im sure its a ocean view room :D
            delanoHotel.Rooms.Add(_roomsFactory.CreateQueen(350, 2));
            delanoHotel.Rooms.Add(_roomsFactory.CreateQueen(425, 2));
            _hotels.Add(delanoHotel);
            //------------------------------------------------
        }

        public List<Hotel> GetHotels()
        {
            return _hotels;
        }       

        /// <summary>
        /// This Method will return all the room types per hotel that are not reserved.
        /// </summary>
        /// <returns></returns>
        public List<InventoryType> GetRoomsInventory()
        {
            var hotels = GetHotels();
            List<InventoryType> inventory = new List<InventoryType>();
            foreach (var hotel in hotels)
            {
                foreach (var room in hotel.Rooms)
                {
                    if (!inventory.Any(x => x.RoomType == room.Type &&
                                       x.HotelId == hotel.Id))
                    {
                        var roomInventory = new InventoryType(DateTime.Now.ToShortDateString(),
                                                                hotel.Id,
                                                                room.Type,
                                                                hotel.Rooms.Count(x => x.Type == room.Type && !x.IsReserverd));
                        inventory.Add(roomInventory);
                    }
                }
            }
            return inventory;
        }
    }
}
