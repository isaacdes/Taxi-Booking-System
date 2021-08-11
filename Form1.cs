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
using FontAwesome.Sharp;
using System.Runtime.InteropServices;

namespace Taxi_Booking_System
{
    public partial class Form1 : Form
    {
     
        //Fields
        private IconButton currenBt;
        private Panel leftBorderBtn;
        private Form currentTaxiForm;


        public Form1()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7,60);
            panelLEftEdge.Controls.Add(leftBorderBtn);
            OpenForm(new Dasboard());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ActivateButton(object senderBtn, Color color)
        {
            //to change the color of the button saying that it is clicked
            if(senderBtn != null)
            {
                DisableButton();
                currenBt = (IconButton)senderBtn;
                currenBt.BackColor = Color.FromArgb(27,27,27);
                currenBt.ForeColor = color;
                currenBt.TextAlign = ContentAlignment.MiddleCenter;
                currenBt.IconColor = color;
                currenBt.TextImageRelation = TextImageRelation.TextBeforeImage;
                currenBt.ImageAlign = ContentAlignment.MiddleRight;

                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0,currenBt.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                //icon plus title
                currentIconChange.IconChar = currenBt.IconChar;
                labelTitle.Text = currenBt.Text.ToString();

            }
        }

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(255, 101, 47);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }
        private void DisableButton()
        {
            // to disable the last clicked button

            if(currenBt != null)
            {
               
                currenBt.BackColor = Color.FromArgb(16, 16, 16);
                currenBt.ForeColor = Color.FromArgb(255, 228, 0);
                currenBt.TextAlign = ContentAlignment.MiddleLeft;
                currenBt.IconColor = Color.FromArgb(255, 228, 0);
                currenBt.TextImageRelation = TextImageRelation.ImageBeforeText; ;
                currenBt.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(255, 101, 47));
            OpenForm(new Dasboard());
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(255, 101, 47));
            OpenForm(new Booking());
        }

     
        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            currentIconChange.IconChar = IconChar.None;
            labelTitle.Text = "";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            currentTaxiForm.Close();
            OpenForm(new Dasboard());
            Reset();
        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        public void OpenForm(Form taxi)
        {
            if(currentTaxiForm != null)
            {
                currentTaxiForm.Close();
            }
            currentTaxiForm = taxi;
            taxi.TopLevel = false;
            taxi.FormBorderStyle = FormBorderStyle.None;
            taxi.Dock = DockStyle.Fill;
            panelForms.Controls.Add(taxi);
            panelForms.Tag = taxi;
            taxi.BringToFront();
            taxi.Show();
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(255, 101, 47));
            OpenForm(new Profile());
            
        }

        private void iconButton3_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(255, 101, 47));
            OpenForm(new Feedback());
        }

        private void iconButton4_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(255, 101, 47));
            Application.Exit();
        }

        
    }

        /*

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
     */
    }

