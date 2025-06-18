using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace course
{
    public partial class BookingForm: Form
    {
        private string roomName;
        private GuestManager guestManager;
        public BookingForm(string roomName)
        {
            InitializeComponent();
            this.roomName = roomName;
            this.guestManager = new GuestManager(); 
            labelRoomName.Text = roomName; 
        }
        private void BookingForm_Load(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Guest guest = new Guest
            {
                Name = textBox_Name1.Text,
                Surname = textBox_surname.Text,
                Phone = textBox_phoneNum.Text,
                RoomName = labelRoomName.Text,
                CheckInDate = dateTimePicker1.Value,
                LeaveDate = dateTimePicker2.Value,
                CheckInTime = dateTimePicker3.Value,
                LeaveTime = dateTimePicker4.Value,
                PassportNum = textBox_card.Text
            };

            guestManager.AddGuest(guest);

            this.Close();
        }
    }
}
