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
        public int AccessCode = 0;
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
           ///*
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DatabaseTaxiBookingSystem.mdf;Integrated Security=True");
            
            string query = "select * from Admin where Id='"+username.Text+"' and password='"+password.Text+"'";
            
            con.Open();
            SqlCommand command = new SqlCommand(query, con);
            SqlDataReader reader = command.ExecuteReader();
            if(reader.HasRows)
            {
                while (reader.Read())
                {
                    Form1.instance.setName(reader.GetString(1));
                   
                }
                con.Close();
                this.Close();
            }
            else
            {
                MessageBox.Show("Username/passwrod is wrong ", "Login Error", MessageBoxButtons.OK);
            }

            /*try
            {
                int res = (Int32)command.ExecuteScalar();
                Form1.instance.setName(username.Text);
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Username/passwrod is wrong ", "Login Error", MessageBoxButtons.OK);
            }*/
            
            
           
                
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Registration obj = new Registration();
            
            obj.ShowDialog();
           
        }
    }
}
