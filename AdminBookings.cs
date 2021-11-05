using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Taxi_Booking_System
{
    public partial class AdminBookings : Form
    {
        public static AdminBookings instance;
        int proid;
        public AdminBookings()
        {
            InitializeComponent();
            panel1.Hide();

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Sem5\DotNetLabs\Taxi Booking System\Database1.mdf;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("select * from Bookings ", con);
            

            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds, "Bookings");
            dataGridView1.DataSource = ds.Tables["Bookings"].DefaultView;
            con.Close();

        }

        private void AdminBookings_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Bookings' table. You can move, or remove it, as needed.
            this.bookingsTableAdapter.Fill(this.database1DataSet.Bookings);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
                proid = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Id"].Value);
                panel1.Show();
                


           
                    

            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Sem5\DotNetLabs\Taxi Booking System\Database1.mdf;Integrated Security=True");
            con.Open();
            SqlCommand c = new SqlCommand("update Bookings set carnumber= '"+comboBox1.Text+"', status='Approved' where Id='"+proid+"'"  , con);
            try
            {
                c.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex);
            }
            finally
            {
                con.Close();
                MessageBox.Show("User is assigned car succesfully");
                Form1.instance.resetAdminBooking();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Sem5\DotNetLabs\Taxi Booking System\Database1.mdf;Integrated Security=True");
            con.Open();
            SqlCommand c = new SqlCommand("delete Bookings where Id='" + proid + "'", con);
            try
            {
                c.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex);
            }
            finally
            {
                con.Close();
                MessageBox.Show("Booking Successfully Deleted");
                Form1.instance.resetAdminBooking();
            }
        }
    }
}
