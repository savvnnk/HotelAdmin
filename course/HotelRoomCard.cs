using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.IO;

namespace course
{
    public partial class HotelRoomCard: UserControl
    {
        public HotelRoomCard()
        {
            InitializeComponent();
        }
        public string RoomName
        {
            get => label_name.Text;
            set => label_name.Text = value;
        }
        public string RoomPrice
        {
            get => label_price.Text;
            set => label_price.Text = value;
        }

        public string RoomSquare
        {
            get => label_amo.Text;
            set => label_amo.Text = value;
        }
        public string RoomView
        {
            get => label_view.Text;
            set => label_view.Text = value;
        }
        public Image RoomImage
        {
            get => pictureBoxRoom.Image;
            set => pictureBoxRoom.Image = value;
        }
        public string ExtraInfo
        {
            get => textBox_info.Text;
            set => textBox_info.Text = value;
        }
        public string RoomImagePath { get; private set; }

        private void button_book_Click(object sender, EventArgs e)
        {
            var bookingForm = new BookingForm(RoomName); 
            bookingForm.Show();
        }
        private void button_edit_Click(object sender, EventArgs e)
        {
            var editForm = new CreateRoom();

            editForm.SetData(RoomName, RoomPrice, RoomSquare, RoomView, ExtraInfo, RoomImagePath);

            if (editForm.ShowDialog() == DialogResult.OK)
            {
                RoomName = editForm.RoomName;
                RoomPrice = editForm.RoomPrice;
                RoomSquare = editForm.RoomSquare;
                RoomView = editForm.RoomView;
                ExtraInfo = editForm.ExtraInfo;
                RoomImagePath = editForm.RoomImagePath;

                if (File.Exists(RoomImagePath))
                {
                    RoomImage = Image.FromFile(RoomImagePath);
                }
                var rooms = HotelRoomManager.LoadRooms();
                var current = rooms.FirstOrDefault(r => r.RoomName == RoomName); 

                if (current != null)
                {
                    current.RoomName = RoomName;
                    current.RoomPrice = RoomPrice;
                    current.RoomSquare = RoomSquare;
                    current.RoomView = RoomView;
                    current.ExtraInfo = ExtraInfo;
                    current.RoomImage = RoomImagePath;
                    HotelRoomManager.SaveRooms(rooms);
                }

                MessageBox.Show("Кімната успішно оновлена.");
            }
        }
        private void button_Delete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show($"Ви дійсно хочете видалити кімнату \"{RoomName}\"?",
                                         "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                var rooms = HotelRoomManager.LoadRooms();

                var roomToRemove = rooms.FirstOrDefault(r => r.RoomName == RoomName);
                if (roomToRemove != null)
                {
                    rooms.Remove(roomToRemove);
                    HotelRoomManager.SaveRooms(rooms);
                    this.Parent?.Controls.Remove(this);
                    MessageBox.Show("Кімнату успішно видалено.");
                }
            }
        }
        private void HotelRoomCard_Load(object sender, EventArgs e)
        {
        }
    }
}
