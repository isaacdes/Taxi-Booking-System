using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;


namespace Taxi_Booking_System
{
    public partial class Form1 : Form
    {
        String carType = "";
        float cost = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioButton_Mini.Checked = true;
            carType = "Mini";
        }

       

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void label4_Click(object sender, EventArgs e)
        {

        }

       

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private int getCost(string source, string destination)
        {
            return 0;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            cost = 600;
            if (source_comboBox1.SelectedIndex == -1 && destination_comboBox.SelectedIndex == -1 )
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

                    String text = " Your Taxi from " + source + " to " + destination + " " +cost + "₹";
                    label_details.Text = text;
                }
            }
            
            
                
            
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            source_comboBox1.SelectedIndex = -1;
            destination_comboBox.SelectedIndex = -1;
            splitContainer1.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String message = "Your Full Name: ";
            String title = "Confirmation";
            object mycalue;

            mycalue = Microsoft.VisualBasic.Interaction.InputBox(message, title, "");
            if((string)mycalue == "")
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
                Form display = new Itinerary(mycalue.ToString(), source, destination,dateTimePicker1.Text, carType, addon, cost);
                display.ShowDialog();
                this.Close();
            }

            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("C:/Users/Isaac/source/repos/Taxi Booking System/Cars_list.html");
        }
        
    }
}
