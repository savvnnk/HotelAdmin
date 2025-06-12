using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course
{
    public class HotelRoom
    {
        public string RoomName { get; set; }
        public string RoomPrice { get; set; }
        public string RoomSquare { get; set; }
        public string RoomView { get; set; }
        public string RoomImage { get; set; }
        public string ExtraInfo { get; set; }

        private HotelRoom _roomInfo;
        public void SetRoomName(HotelRoom room)
        {
            _roomInfo = room;

            RoomName = room.RoomName;
        }
    }
}
