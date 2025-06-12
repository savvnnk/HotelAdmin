using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace course
{
    public partial class GuestsTableControl : UserControl
    {
        public GuestsTableControl()
        {
            InitializeComponent();
        }

        private void GuestsTableControl_Load(object sender, EventArgs e)
        {
            dataGridView_Guests.Rows.Clear();
            var guestManager = new GuestManager();
            var guests = guestManager.Guests;

            foreach (var guest in guests)
            {
                dataGridView_Guests.Rows.Add(
                    guest.RoomName,
                    guest.Name,
                    guest.Surname,
                    guest.Phone,
                    guest.CheckInDate.ToString("dd.MM.yyyy"),
                    guest.LeaveDate.ToString("dd.MM.yyyy"),
                    guest.CheckInTime.ToString("HH:mm"),
                    guest.LeaveTime.ToString("HH:mm"),
                    guest.Price,
                    guest.PassportNum,
                    guest.Status,
                    guest.NoteTxt
                );
            }

            dataGridView_Guests.CellValueChanged += dataGridView_Guests_CellValueChanged;
            dataGridView_Guests.CellContentClick += dataGridView_Guests_CellContentClick;
        }

        private void dataGridView_Guests_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var updatedGuests = new List<Guest>();
            foreach (DataGridViewRow row in dataGridView_Guests.Rows)
            {
                if (row.IsNewRow) continue;

                updatedGuests.Add(new Guest
                {
                    RoomName = row.Cells[0].Value?.ToString(),
                    Name = row.Cells[1].Value?.ToString(),
                    Surname = row.Cells[2].Value?.ToString(),
                    Phone = row.Cells[3].Value?.ToString(),
                    CheckInDate = DateTime.Parse(row.Cells[4].Value?.ToString()),
                    LeaveDate = DateTime.Parse(row.Cells[5].Value?.ToString()),
                    CheckInTime = DateTime.Parse(row.Cells[6].Value?.ToString()),
                    LeaveTime = DateTime.Parse(row.Cells[7].Value?.ToString()),
                    Price = row.Cells[8].Value?.ToString(),
                    PassportNum = row.Cells[9].Value?.ToString(),
                    Status = row.Cells[10].Value?.ToString(),
                    NoteTxt = row.Cells[11].Value?.ToString()
                });
            }

            var guestManager = new GuestManager();
            guestManager.SaveGuests(updatedGuests);
        }

        private void dataGridView_Guests_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dataGridView_Guests.Columns[e.ColumnIndex].Name == "NoteTxtButton")
            {
                var row = dataGridView_Guests.Rows[e.RowIndex];

                var guest = new Guest
                {
                    RoomName = row.Cells[0].Value?.ToString(),
                    Name = row.Cells[1].Value?.ToString(),
                    Surname = row.Cells[2].Value?.ToString(),
                    Phone = row.Cells[3].Value?.ToString(),
                    CheckInDate = DateTime.Parse(row.Cells[4].Value?.ToString()),
                    LeaveDate = DateTime.Parse(row.Cells[5].Value?.ToString()),
                    CheckInTime = DateTime.Parse(row.Cells[6].Value?.ToString()),
                    LeaveTime = DateTime.Parse(row.Cells[7].Value?.ToString()),
                    Price = row.Cells[8].Value?.ToString(),
                    PassportNum = row.Cells[9].Value?.ToString()
                };

                string fileName = GuestManager.GenerateReceipt(guest);

                MessageBox.Show($"Квитанцію збережено як {fileName}", "Успіх");
                System.Diagnostics.Process.Start("notepad.exe", fileName);
            }
        }

        public void SearchGuests(string query)
        {
            query = query.ToLower();

            foreach (DataGridViewRow row in dataGridView_Guests.Rows)
            {
                if (row.IsNewRow) continue;

                row.Visible = row.Cells.Cast<DataGridViewCell>().Any(cell =>
                    cell.Value != null && cell.Value.ToString().ToLower().Contains(query));
            }
        }
        public void LoadGuestsFromFile(string filePath)
        {
            var guestManager = new GuestManager(); 
            dataGridView_Guests.Rows.Clear();

            foreach (var guest in guestManager.Guests)
            {
                dataGridView_Guests.Rows.Add(
                    guest.RoomName,
                    guest.Name,
                    guest.Surname,
                    guest.Phone,
                    guest.CheckInDate.ToString("dd.MM.yyyy"),
                    guest.LeaveDate.ToString("dd.MM.yyyy"),
                    guest.CheckInTime.ToString("HH:mm"),
                    guest.LeaveTime.ToString("HH:mm"),
                    guest.Price,
                    guest.PassportNum,
                    guest.Status,
                    guest.NoteTxt
                );
            }
        }
        public void SearchByStatus(string query)
        {
            query = query.ToLower();

            foreach (DataGridViewRow row in dataGridView_Guests.Rows)
            {
                if (row.IsNewRow) continue;

                var statusCell = row.Cells[10];
                row.Visible = statusCell.Value != null &&
                              statusCell.Value.ToString().ToLower().Contains(query);
            }
        }
    }
}
