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
    public partial class Itinerary : Form
    {
        public Itinerary(string name, string source, string destination, string date, string cartype, string addon, float cost)
        {
            InitializeComponent();

            label_name.Text = name;
            label_date.Text = date;
            label_source.Text = source;
            label_destination.Text = destination;
            label_cost.Text = cost.ToString() + "₹";
            label_carType.Text = cartype;
            label_addOns.Text = addon;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank You for Booking With Us", "Successfull Booking", MessageBoxButtons.OK);

            
            this.Close();
            Booking obj = new Booking();
            obj.resetForm();
            
          
        }
    }
}
