using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSystem
{
    public class InventoryType
    {
        public string Date { get; set; }
        public int HotelId { get; set; }
        public RoomTypes RoomType { get; set; }
        public int AvailableRooms { get; set; }

        public InventoryType(string date,int hotelId,RoomTypes roomType, int availableRooms)
        {
            Date = date;
            HotelId = hotelId;
            RoomType = roomType;
            AvailableRooms = availableRooms;
        }

        public InventoryType()
        {
        }        
    }
}
