using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Taxi_Booking_System
{
    public partial class LoginUI : Form
    {
        public static LoginUI instance;
        public LoginUI()
        {

            string name = string.Empty;
            InitializeComponent();
            instance = this;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel_dragnDrop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if(username.Text == "userId")
            {
                username.Text = "";

            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if(password.Text == "password")
            {
                password.Text = "";
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (password.Text == "")
            {
                password.Text = "password";
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (username.Text == "")
            {
                username.Text = "userId";

            }
        }

       

        private void button1_Click(object sender, EventArgs e)
        {

             
            if(username.Text == "isaac" && password.Text == "1234")
            {
                Form1.instance.setName(username.Text);
                this.Close();           
            }
            else
            {
                MessageBox.Show("Username/passwrod is wrong", "Login Error",MessageBoxButtons.OK);
            }
        }
    }
}
