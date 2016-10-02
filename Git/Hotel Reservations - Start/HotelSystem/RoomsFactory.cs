using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSystem
{
    public class RoomsFactory
    {
        public Room CreateKing(double nightlyRate, int capacity)
        {
            return new Room(RoomType.King, nightlyRate, capacity);
        }
        public Room CreateQueen(double nightlyRate, int capacity)
        {
            return new Room(RoomType.Queen, nightlyRate, capacity);
        }

        public Room CreateDouble(double nightlyRate, int capacity)
        {
            return new Room(RoomType.Double, nightlyRate, capacity);
        }

        public Room CreateSuite(double nightlyRate, int capacity)
        {
            return new Room(RoomType.Suite, nightlyRate, capacity);
        }
    }
}
