using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course
{
    public class Guest
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public string RoomName { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime LeaveDate { get; set; }
        public DateTime CheckInTime { get; set; }
        public DateTime LeaveTime { get; set; }
        public string Price { get; set; }
        public string PassportNum { get; set; }
        public string Status { get; set; }
        public string NoteTxt { get; set; }
    }
}
