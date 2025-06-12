using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course
{
    public class GuestManager
    {
        private readonly string filePath = "guests.json";
        public List<Guest> Guests { get; private set; }

        public GuestManager()
        {
            LoadGuests();
        }

        public void LoadGuests()
        {
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                Guests = JsonConvert.DeserializeObject<List<Guest>>(json) ?? new List<Guest>();
            }
            else
            {
                Guests = new List<Guest>();
            }
        }

        public void AddGuest(Guest guest)
        {
            Guests.Add(guest);
            SaveGuests();
        }
        public void SaveGuests()
        {
            string json = JsonConvert.SerializeObject(Guests, Formatting.Indented);
            File.WriteAllText(filePath, json);
        }
        public void SaveGuests(List<Guest> updatedGuests)
        {
            string json = JsonConvert.SerializeObject(Guests, Formatting.Indented);
            File.WriteAllText(filePath, json);
        }
        public static string GenerateReceipt(Guest guest)
        {
            string receipt = $"КВИТАНЦІЯ\n" +
                             $"Кімната: {guest.RoomName}\n" +
                             $"Ім’я: {guest.Name}\n" +
                             $"Прізвище: {guest.Surname}\n" +
                             $"Телефон: {guest.Phone}\n" +
                             $"Заселення: {guest.CheckInDate:dd.MM.yyyy} {guest.CheckInTime:HH:mm}\n" +
                             $"Виселення: {guest.LeaveDate:dd.MM.yyyy} {guest.LeaveTime:HH:mm}\n" +
                             $"До сплати: {guest.Price}\n" +
                             $"Паспорт: {guest.PassportNum}\n";

            string fileName = $"Квитанція_{guest.Name}_{guest.Surname}.txt";
            File.WriteAllText(fileName, receipt);
            return fileName;
        }
    }
}
