using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSystem
{
    public class Hotel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public double Rating { get; set; }
        public List<Room> Rooms { get; set; }
        public List<Feature> Features { get; set; }
        public List<PointOfInterest> NearbyPlaces { get; set; }

        public Hotel()
        {
            Rooms = new List<Room>();
            Features = new List<Feature>();
            NearbyPlaces = new List<PointOfInterest>();
        }
    }
}
