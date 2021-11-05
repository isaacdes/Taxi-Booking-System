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
    public partial class Booking : Form
    {
        public static Booking instance;
        String carType = "Mini";
        float cost = 0;
        public Booking()
        {
            InitializeComponent();
            radioButton_Mini.Checked = true;
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cost = 600;
            if (source_comboBox1.SelectedIndex == -1 && destination_comboBox.SelectedIndex == -1)
            {
                string messageBoxText = "Source and Destination cannot be empty ";
                string caption = "error";

                MessageBox.Show(messageBoxText, caption, MessageBoxButtons.OK);
            }
            else
            {
                String source = this.source_comboBox1.SelectedItem.ToString();
                String destination = destination_comboBox.SelectedItem.ToString();

                if (String.Compare(source, destination) == 0)
                {
                    String messageBoxText = "Source and Destination cannot be Same";
                    String caption = "Error";
                    MessageBox.Show(messageBoxText + source + " and " + destination, caption, MessageBoxButtons.OK);

                }
                else
                {
                    if (checkBox1.Checked == true)
                        cost = cost + 10;
                    if (checkBox2.Checked == true)
                        cost = cost + 5;

                    if (radioButton_Micro.Checked == true)
                        cost = cost + 100;
                    if (radioButton_Prime.Checked == true)
                        cost = cost + 150;

                    splitContainer1.Visible = Enabled;

                    String text = " Your Taxi from " + source + " to " + destination + " " + cost + "₹";
                    label_details.Text = text;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();
            
        }

        public void resetForm()
        {
            Controls.Clear();
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int regId = Form1.instance.regnum;
            
            if (radioButton_Micro.Checked == true)
                carType = "Micro";
            else if (radioButton_Prime.Checked == true)
                carType = "Prime";
            
            string addon = "";

            if (checkBox1.Checked == true)
                addon = "Insurance";
            if (checkBox2.Checked == true)
                addon = addon + ", Wifi";

            if (addon == "")
                addon = "None";
            
            String source = this.source_comboBox1.SelectedItem.ToString();
            String destination = destination_comboBox.SelectedItem.ToString();
            
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Sem5\DotNetLabs\Taxi Booking System\Database1.mdf;Integrated Security=True");


                con.Open();
                String query = "insert into Bookings(source, destination, dateOfJourney, carType, AddOns, cost, CustomerId, status)values('" + source + "', '" + destination + "', '"+dateTimePicker1.Text+"' ,'"+carType+"', '"+addon+"' ,'"+cost+"', '"+regId+"', 'In Review')";
                SqlCommand command = new SqlCommand();
                command.Connection = con;
                command.CommandType = CommandType.Text;
                command.CommandText = query;

                try
                {

                    command.ExecuteNonQuery();

                    Form display = new Itinerary(Form1.instance.regName, source, destination, dateTimePicker1.Text, carType, addon, cost);
                    display.ShowDialog();

                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed To Book : " + ex, "Error", MessageBoxButtons.OK);

                }
                finally
                {
                    con.Close();
                }

               
                // Itineary(name, source, destination, date, car type, insurance, wifi)
                
                this.Close();
            
        }
    }
}