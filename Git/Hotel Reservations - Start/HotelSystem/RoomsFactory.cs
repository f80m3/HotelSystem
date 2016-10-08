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
            return new Room(RoomTypes.KB, nightlyRate, capacity);
        }
        public Room CreateQueen(double nightlyRate, int capacity)
        {
            return new Room(RoomTypes.QB, nightlyRate, capacity);
        }

        public Room CreateDouble(double nightlyRate, int capacity)
        {
            return new Room(RoomTypes.DB, nightlyRate, capacity);
        }

        public Room CreateSuite(double nightlyRate, int capacity)
        {
            return new Room(RoomTypes.BS, nightlyRate, capacity);
        }
    }
}
