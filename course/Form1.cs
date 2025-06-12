using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using System.Windows.Controls;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace course
{
    public partial class Form1: Form
    {

        private System.Windows.Forms.ToolTip toolTip1;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        { 
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Будь ласка, введіть логін і пароль!");
                return;
            }
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "Data", "users.json");

            if (File.Exists(filePath))
            {
                string jsonData = File.ReadAllText(filePath);
                var users = JsonConvert.DeserializeObject<List<User>>(jsonData);
                var user = users.Find(u => u.Username == username && u.Password == password);

                if (user != null)
                {
                    Form2 adminForm = new Form2();
                    adminForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Невірний пароль або логін!");
                }
            }
        }
        private void pictureBoxShow_MouseHover_1(object sender, EventArgs e)
        {
            if (toolTip1 != null)
            {
                toolTip1.SetToolTip(pictureBoxShow, "Show password");
            }
        }

        private void pictureBoxHide_MouseHover_1(object sender, EventArgs e)
        {
            if (toolTip1 != null) 
            {
                toolTip1.SetToolTip(pictureBoxHide, "Hide password");
            }
        }
        private void pictureBoxShow_Click_1(object sender, EventArgs e)
        {
            pictureBoxShow.Hide();
            textBox2.UseSystemPasswordChar = true;
            pictureBoxHide.Show();
        }

        private void pictureBoxHide_Click_1(object sender, EventArgs e)
        {
            pictureBoxHide.Hide();
            textBox2.UseSystemPasswordChar = false;
            pictureBoxShow.Show();
        }
    }
}
