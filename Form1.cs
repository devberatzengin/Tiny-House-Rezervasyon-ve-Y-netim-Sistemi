using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tiny_House_Rezervasyon_ve_Yönetim_Sistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string email = LoginMailAdressTextBox.Text;
            string password = LoginPasswordTextBox.Text;
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter all text area.");
                return;
            }else
            {
                User user = new User();

                if (user.login(email, password))
                {
                    MessageBox.Show("Login successful");
                    }
                else
                {
                    MessageBox.Show("Login failed");
                }
            }
        }
        private void RegisterButton_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.register(RegisterMailAdressTextBox.Text, RegisterPasswordTextBox.Text);
        }










        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Navbar_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }






        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void RegisterMailAdressTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegisterPasswordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoginMailAdressTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginPasswordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginPasswordLabel_Click(object sender, EventArgs e)
        {

        }

        private void LoginMailAdressLabel_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
