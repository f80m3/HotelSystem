using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSystem
{
    public class PointsOfInterestFactory
    {
        public PointOfInterest CreateBeach(string name, double distanceFromHotel,string address)
        {
            return new PointOfInterest(PointOfInterestCategory.Beach, name, distanceFromHotel,address);
        }

        public PointOfInterest CreateShopping(string name, double distanceFromHotel, string address)
        {
            return new PointOfInterest(PointOfInterestCategory.Shopping, name, distanceFromHotel, address);
        }

        public PointOfInterest CreateTransportation(string name, double distanceFromHotel, string address)
        {
            return new PointOfInterest(PointOfInterestCategory.Transportation, name, distanceFromHotel, address);
        }

        public PointOfInterest CreateDining(string name, double distanceFromHotel, string address)
        {
            return new PointOfInterest(PointOfInterestCategory.Dining, name, distanceFromHotel, address);
        }

        public PointOfInterest CreateEntertainment(string name, double distanceFromHotel, string address)
        {
            return new PointOfInterest(PointOfInterestCategory.Entertainment, name, distanceFromHotel, address);
        }
    }
}
