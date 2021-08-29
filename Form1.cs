using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using FontAwesome.Sharp;
using System.Runtime.InteropServices;

namespace Taxi_Booking_System
{
    public partial class Form1 : Form
    {
        public static Form1 instance;
     
        //Fields
        private IconButton currenBt;
        private Panel leftBorderBtn;
        private Form currentTaxiForm;

        public int LoginStatus = 0; //Admin =1, Customers=2, Ofline=0


        public Form1()
        {
            InitializeComponent();
            instance = this;
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

        //to set name from login form
        public void setName(string name, int status)
        {
            
            if (status == 1)
                labelName.Text = "Welcome " + name + "(Admin Access)";
            if (status == 2)
                labelName.Text = "Welcome " + name + "(User)";
            LoginStatus = status;

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(255, 101, 47));
            OpenForm(new Dasboard());
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {//Booking button
            if(LoginStatus == 0)
            {
                ActivateButton(sender, Color.FromArgb(255, 101, 47));
                OpenForm(new Deafult());
            }
            else
            {
                ActivateButton(sender, Color.FromArgb(255, 101, 47));
                OpenForm(new Booking());
            }
            
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
            if (LoginStatus == 0)
            {
                ActivateButton(sender, Color.FromArgb(255, 101, 47));
                OpenForm(new Deafult());
                MessageBox.Show("Login/Signup pls", "Login Required", MessageBoxButtons.OK);
            }
            else
            {
                ActivateButton(sender, Color.FromArgb(255, 101, 47));
                OpenForm(new Profile());
            }
            
            
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

        private void iconButtonLogin_Click(object sender, EventArgs e)
        {
            if(labelName.Text != "")
            {
                LoginStatus = 0;
                labelName.Text = "";
                iconButtonLogin.Text = "Login/Signup";
                iconButtonLogin.IconChar = IconChar.UserPlus;
                MessageBox.Show("Succesfully Logged Out", "Logout", MessageBoxButtons.OK);
            }
            else
            {
                
                LoginUI obj = new LoginUI();
                obj.ShowDialog();
            }
            
        }
    }
}
5 