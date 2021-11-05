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
using System.Configuration;

namespace Taxi_Booking_System
{
    public partial class LoginUI : Form
    {
        public int AccessCode = 0;
        public static LoginUI instance;

        //static string constring = ConfigurationManager.ConnectionStrings["Taxi_Booking_System.Properties.Settings.DatabaseTaxiBookingSystemConnectionString" ].ConnectionString;
        //SqlConnection con = new SqlConnection(constring);


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

            SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Sem5\DotNetLabs\Taxi Booking System\Database1.mdf;Integrated Security=True");

            string query = "select * from AdminTable where Id='"+username.Text+"' and password='"+password.Text+"'";
            
            con1.Open();
            SqlCommand command = new SqlCommand(query, con1);
            SqlDataReader reader = command.ExecuteReader();
            if(reader.HasRows)
            {
                while (reader.Read())
                {
                    Form1.instance.setName(reader.GetString(1), 1, Int32.Parse(username.Text));
                   
                }
               
                
                Form1.instance.iconButtonLogin.Text = "Logout";
                Form1.instance.iconButtonLogin.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
                this.Close();
            }
            else
            {
                reader.Close();
                string query2 = "select * from Customers where Id='" + username.Text + "' and password='" + password.Text + "'";
                
                SqlCommand command2 = new SqlCommand(query2, con1);
                SqlDataReader reader2 = command2.ExecuteReader();
                if (reader2.HasRows)
                {
                    while (reader2.Read())
                    {
                        Form1.instance.setName(reader2.GetString(1), 2, Int32.Parse(username.Text));
                       

                    }
                    
                    
                    Form1.instance.iconButtonLogin.Text = "Logout";
                    Form1.instance.iconButtonLogin.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
                    this.Close();
                }
                else
                {
                    reader2.Close();



                    MessageBox.Show("Username/passwrod is wrong ", "Login Error", MessageBoxButtons.OK);
                    
                }
                
                
                con1.Close();
                
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
