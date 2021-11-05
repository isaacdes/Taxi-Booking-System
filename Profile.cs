using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Taxi_Booking_System
{
    public partial class Profile : Form

    {
        public static Profile instance;
        int id;
        public Profile()
        {
            InitializeComponent();
            instance = this;

            id = Form1.instance.regnum;
            textBoxFirstName.Text = Form1.instance.labelName.Text;


            SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Sem5\DotNetLabs\Taxi Booking System\Database1.mdf;Integrated Security=True");

            string query = "select * from Customers where Id='" + id + "' ";

            con1.Open();
            SqlCommand command = new SqlCommand(query, con1);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    try
                    {
                        textBoxFirstName.Text = reader.GetString(1);
                        richTextBox1.Text = reader.GetString(3);
                    }
                    catch(Exception ex)
                    {

                    }
                    

                }
            }

            con1.Close();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label_name_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void LoadText_Click(object sender, EventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePAth = String.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "C:/Users/Isaac/Desktop";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if(openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePAth = openFileDialog.FileName;
                    var fileStream = openFileDialog.OpenFile();

                    using(StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                }
            }

            richTextBox1.Text = fileContent;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream stream;
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog.FilterIndex = 2;
            saveFileDialog.RestoreDirectory = true;

            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using(Stream s = File.Open(saveFileDialog.FileName, FileMode.CreateNew))
                {
                    using(StreamWriter sw = new StreamWriter(s))
                    {
                        sw.Write(richTextBox1.Text);
                    }
                }
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            fontDialog.ShowColor = true;
            fontDialog.ShowApply = true;
            fontDialog.ShowEffects = true;
            fontDialog.ShowHelp = true;
            fontDialog.MaxSize = 40;
            fontDialog.MinSize = 2;

            DialogResult result = fontDialog.ShowDialog();
            if(result == DialogResult.OK)
            {
                richTextBox1.Font = fontDialog.Font;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            

            SqlConnection sc = new SqlConnection();
            SqlCommand com = new SqlCommand();

            sc.ConnectionString = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Sem5\DotNetLabs\Taxi Booking System\Database1.mdf;Integrated Security=True");
            sc.Open();
            SqlCommand cmd = new SqlCommand("update Customers set info='"+ richTextBox1.Text + "' where Id='"+id+"'", sc);
            cmd.ExecuteNonQuery();
            sc.Close();



            this.Controls.Clear();
            this.InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("User has been Deleted", "Message", MessageBoxButtons.OK);
            SqlConnection sc = new SqlConnection();
            SqlCommand com = new SqlCommand();

            sc.ConnectionString = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Sem5\DotNetLabs\Taxi Booking System\Database1.mdf;Integrated Security=True");
            sc.Open();

            SqlCommand cmd = new SqlCommand("delete from Customers  where Id='" + id + "'",sc);
            cmd.ExecuteNonQuery();
            MessageBox.Show("User is deleted Succesfully ","Deletion",MessageBoxButtons.OK);
            sc.Close();

            

            this.Controls.Clear();
            this.InitializeComponent();

            Form1.instance.reset();


        }
    }
}
