using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSystem
{
    public class PointOfInterest
    {
        public string Name { get; set; }
        public double DistanceFromHotel { get; set; }
        public string Address { get; set; }
        public PointOfInterestCategory Category { get; set; }

        public PointOfInterest(PointOfInterestCategory caetgory,string name,double distanceFromHotel,string address)
        {
            Name = name;
            DistanceFromHotel = distanceFromHotel;
            Address = address;
            Category = caetgory;
        }

        public PointOfInterest()
        {

        }
    }
}
