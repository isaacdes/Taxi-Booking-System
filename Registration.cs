using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;



namespace Taxi_Booking_System
{
    public partial class Registration : Form
    {
        public static Registration instace;
        public Registration()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            
            this.Close();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-HRD2S2U;Initial Catalog=TaxiBookingSystem;Integrated Security=True");


            con.Open();
            String query = "insert into Customers(name,password)values('"+name.Text+"', '"+password.Text+"')";
            SqlCommand command = new SqlCommand();
            command.Connection = con;
            command.CommandType = CommandType.Text;
            command.CommandText = query;
            
            try
            {
                
                command.ExecuteNonQuery();

                string msg = LastIdNumber();
                MessageBox.Show(" Your Login Id is: " + msg, "Success", MessageBoxButtons.OK);
                
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Failed To Register : " + ex , "Error", MessageBoxButtons.OK);
                
            }
            finally
            {
                con.Close();
            }

        }

        private string LastIdNumber()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-HRD2S2U;Initial Catalog=TaxiBookingSystem;Integrated Security=True");

            con.Open();
            SqlCommand command = new SqlCommand("select top 1 Id from Customers order by Id desc", con);
            SqlDataReader reader = command.ExecuteReader();
            String response = "";
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    response = reader["Id"].ToString();
                }
                reader.Close();
            }
            con.Close();
            return response;
        }
    }
}
