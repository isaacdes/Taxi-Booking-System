using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Taxi_Booking_System
{
    public partial class Bookings_list : Form
    {
        public static Bookings_list instance;
        public Bookings_list()
        {
            InitializeComponent();

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Sem5\DotNetLabs\Taxi Booking System\Database1.mdf;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("select * from Bookings where CustomerId=@zip", con);
            cmd.Parameters.AddWithValue("@zip", Form1.instance.regnum);

            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds, "Bookings");
            dataGridView1.DataSource = ds.Tables["Bookings"].DefaultView;
            con.Close();
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1.instance.openBooking();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you Sure?", "Delete Record", MessageBoxButtons.YesNo);
            if(dialog == DialogResult.Yes)
            {
                int proid = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Id"].Value);

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
                    Form1.instance.resetBookings();
                }
            }
            else if(dialog == DialogResult.No)
            {
                Form1.instance.resetBookings();
            }
            
            
            
            
        }
    }
}
