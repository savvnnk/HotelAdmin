using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course
{
    public static class HotelRoomManager
    {
        private static string filePath = "rooms.json";

        public static List<HotelRoom> LoadRooms()
        {
            if (!File.Exists(filePath))
                return new List<HotelRoom>();

            string json = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<List<HotelRoom>>(json);
        }

        public static void SaveRooms(List<HotelRoom> rooms)
        {
            string json = JsonConvert.SerializeObject(rooms, Formatting.Indented);
            File.WriteAllText(filePath, json);
        }

        public static void AddRoom(HotelRoom room)
        {
            var rooms = LoadRooms();
            rooms.Add(room);
            SaveRooms(rooms);
        }

        public static void UpdateRoom(int index, HotelRoom updatedRoom)
        {
            var rooms = LoadRooms();
            if (index >= 0 && index < rooms.Count)
            {
                rooms[index] = updatedRoom;
                SaveRooms(rooms);
            }
        }

        public static void DeleteRoom(int index)
        {
            var rooms = LoadRooms();
            if (index >= 0 && index < rooms.Count)
            {
                rooms.RemoveAt(index);
                SaveRooms(rooms);
            }
        }
    }
}
