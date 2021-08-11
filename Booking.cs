using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taxi_Booking_System
{
    public partial class Booking : Form
    {
        String carType = "";
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
            String message = "Your Full Name: ";
            String title = "Confirmation";
            object mycalue;

            mycalue = Microsoft.VisualBasic.Interaction.InputBox(message, title, "");
            if ((string)mycalue == "")
            {

            }
            else
            {


                if (radioButton_Micro.Checked == true)
                    carType = "Micro";
                else if (radioButton_Prime.Checked == true)
                    carType = "Prime";

                String insurance = "No", wifi = "No";
                string addon = "";

                if (checkBox1.Checked == true)
                    addon = "Insurance";
                if (checkBox2.Checked == true)
                    addon = addon + ", Wifi";

                String source = this.source_comboBox1.SelectedItem.ToString();
                String destination = destination_comboBox.SelectedItem.ToString();
                this.Hide();
                // Itineary(name, source, destination, date, car type, insurance, wifi)
                Form display = new Itinerary(mycalue.ToString(), source, destination, dateTimePicker1.Text, carType, addon, cost);
                display.ShowDialog();
                this.Close();
            }
        }
    }
}