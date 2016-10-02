using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSystem
{
    public class Room
    {
        public RoomType Type { get; set; }
        public double NightlyRate { get; set; }
        public int RoomCapacity { get; set; }
        public bool IsReserverd { get; set; }
       
        public Room(RoomType type, double nightlyRate,int capacity)
        {
            Type = type;
            NightlyRate = nightlyRate;
            RoomCapacity = capacity;
        }

        public Room()
        {
        }
    }
}
