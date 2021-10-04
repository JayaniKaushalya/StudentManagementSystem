using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FINAL_PROJECT
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string email = txtemail.Text;
            string pass = txtpassword.Text;
            if (email == "student@hilbun.lk" && pass == "hilbun123"){
                MessageBox.Show("Hello !!!..");
                this.Hide();
                MainMenu obj = new MainMenu();
                obj.Show();
            }
            else{
                MessageBox.Show("fail ..."); 
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
