using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taxi_Booking_System
{
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
           
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
                openFileDialog.InitialDirectory = "c:\\";
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
            fontDialog.MinSize = 8;

            DialogResult result = fontDialog.ShowDialog();
            if(result == DialogResult.OK)
            {
                richTextBox1.Font = fontDialog.Font;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank You for Updating the details", "Message", MessageBoxButtons.OK);

            this.Controls.Clear();
            this.InitializeComponent();

        }
    }
}
