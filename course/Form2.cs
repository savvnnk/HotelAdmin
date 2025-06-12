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

namespace course
{
    public partial class Form2 : Form
    {
        private GuestsTableControl guestsTableControl;
        public Form2()
        {
            InitializeComponent();

            guestsTableControl = new GuestsTableControl();
            guestsTableControl.Location = new Point(0, 70);
            guestsTableControl.Visible = false;
            this.Controls.Add(guestsTableControl);
            this.textBox2.KeyDown += textBoxSearchGuest_KeyDown;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            var rooms = HotelRoomManager.LoadRooms();

            foreach (var room in rooms)
            {
                var card = new HotelRoomCard();
                card.RoomName = room.RoomName;
                card.RoomPrice = room.RoomPrice;
                card.RoomSquare = room.RoomSquare;
                card.RoomView = room.RoomView;
                card.ExtraInfo = room.ExtraInfo;

                string fullPath = Path.Combine(Application.StartupPath, room.RoomImage);
                if (File.Exists(fullPath))
                {
                    try
                    {
                        using (var tempImage = Image.FromFile(fullPath))
                        {
                            card.RoomImage = new Bitmap(tempImage);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Помилка при завантаженні зображення: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Файл зображення не знайдено:\n" + fullPath);
                }

                card.Location = new Point(0, 0);
                flowLayoutPanel.Controls.Add(card);
            }
        }

        private void pictureBoxLogOut_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void button_NewRoom_Click(object sender, EventArgs e)
        {
            CreateRoom form = new CreateRoom();

            if (form.ShowDialog() == DialogResult.OK)
            {
                HotelRoom newRoom = new HotelRoom
                {
                    RoomName = form.RoomName,
                    RoomPrice = form.RoomPrice,
                    RoomSquare = form.RoomSquare,
                    RoomView = form.RoomView,
                    ExtraInfo = form.ExtraInfo,
                    RoomImage = form.RoomImagePath
                };

                var rooms = HotelRoomManager.LoadRooms();
                rooms.Add(newRoom);
                HotelRoomManager.SaveRooms(rooms);

                var card = new HotelRoomCard();
                card.RoomName = newRoom.RoomName;
                card.RoomPrice = newRoom.RoomPrice;
                card.RoomSquare = newRoom.RoomSquare;
                card.RoomView = newRoom.RoomView;
                card.ExtraInfo = newRoom.ExtraInfo;

                string fullPath = Path.Combine(Application.StartupPath, newRoom.RoomImage);
                    if (File.Exists(fullPath))
                    {
                        using (var tempImage = Image.FromFile(fullPath))
                        {
                            card.RoomImage = new Bitmap(tempImage);
                        }
                    }
                flowLayoutPanel.Controls.Add(card);
            }
        }
        private void button_view_Click(object sender, EventArgs e)
        {
            if (!guestsTableControl.Visible)
            {
                guestsTableControl.Visible = true;
                flowLayoutPanel.Visible = false;
                button_NewRoom.Visible = false;
                button_view.Text = "Повернути список номерів";

                string filePath = Path.Combine(Application.StartupPath, "guests.json");
                guestsTableControl.LoadGuestsFromFile(filePath);
            }
            else
            {
                guestsTableControl.Visible = false;
                flowLayoutPanel.Visible = true;
                button_NewRoom.Visible = true;
                button_view.Text = "Переглянути бронювання та зайняті номери";
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SearchRooms(textBox1.Text.Trim());
        }
        private void SearchRooms(string query)
        {
            foreach (Control control in flowLayoutPanel.Controls)
            {
                if (control is HotelRoomCard roomCard)
                {
                    bool matches = roomCard.RoomName.IndexOf(query, StringComparison.OrdinalIgnoreCase) >= 0;
                    roomCard.Visible = matches;
                }
            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            guestsTableControl.SearchGuests(textBox2.Text.Trim());
        }
        private void textBoxSearchGuest_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;

                guestsTableControl.SearchGuests(textBox2.Text.Trim());
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            guestsTableControl.SearchByStatus(textBox3.Text);
        }
    }
}
