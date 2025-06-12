using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace course
{
    public partial class CreateRoom : Form
    {
        public string RoomName { get; set; }
        public string RoomPrice { get; set; }
        public string RoomSquare { get; set; }
        public string RoomView { get; set; }
        public Image RoomImage { get; set; }
        public string ExtraInfo { get; set; }
        public string RoomImagePath { get; set; }

        private string selectedImagePath = "";
        public CreateRoom()
        {
            InitializeComponent();
        }

        private void CreateRoom_Load(object sender, EventArgs e)
        {
        }

        private void button_AddPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image Files|*.jpg;*.png;*.bmp";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                selectedImagePath = dialog.FileName;
                pictureBox_Room.Image = Image.FromFile(selectedImagePath);
            }
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            RoomName = textBox_name.Text.Trim();
            RoomPrice = textBox_price.Text.Trim();
            RoomSquare = textBox_square.Text.Trim();
            RoomView = textBox_view.Text.Trim();
            ExtraInfo = textBox_info.Text.Trim();

            if (string.IsNullOrWhiteSpace(RoomName) ||
                string.IsNullOrWhiteSpace(RoomPrice) ||
                string.IsNullOrWhiteSpace(RoomSquare) ||
                string.IsNullOrWhiteSpace(RoomView) ||
                string.IsNullOrWhiteSpace(ExtraInfo) ||
                string.IsNullOrWhiteSpace(selectedImagePath))
            {
                MessageBox.Show("Будь ласка, заповніть усі поля та додайте фото!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!string.IsNullOrEmpty(selectedImagePath) && File.Exists(selectedImagePath))
            {
                string imagesFolder = "images";
                Directory.CreateDirectory(imagesFolder);

                string imageFileName = $"{Guid.NewGuid()}{Path.GetExtension(selectedImagePath)}";
                string savedImagePath = Path.Combine(imagesFolder, imageFileName);

                File.Copy(selectedImagePath, savedImagePath, true);
                RoomImagePath = savedImagePath;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        public void SetData(string name, string price, string square, string view, string info, string imagePath)
        {
            textBox_name.Text = name;
            textBox_price.Text = price;
            textBox_square.Text = square;
            textBox_view.Text = view;
            textBox_info.Text = info;

            if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
            {
                pictureBox_Room.Image = Image.FromFile(imagePath);
                selectedImagePath = imagePath;
            }
        }
    }
}
