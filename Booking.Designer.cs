
namespace Taxi_Booking_System
{
    partial class Booking
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Booking));
            this.groupBox_CarType = new System.Windows.Forms.GroupBox();
            this.radioButton_Mini = new System.Windows.Forms.RadioButton();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.radioButton_Micro = new System.Windows.Forms.RadioButton();
            this.radioButton_Prime = new System.Windows.Forms.RadioButton();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label_details = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.destination_comboBox = new System.Windows.Forms.ComboBox();
            this.source_comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox_CarType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_CarType
            // 
            this.groupBox_CarType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox_CarType.Controls.Add(this.radioButton_Mini);
            this.groupBox_CarType.Controls.Add(this.linkLabel1);
            this.groupBox_CarType.Controls.Add(this.radioButton_Micro);
            this.groupBox_CarType.Controls.Add(this.radioButton_Prime);
            this.groupBox_CarType.Font = new System.Drawing.Font("Elephant", 14.25F);
            this.groupBox_CarType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(101)))), ((int)(((byte)(47)))));
            this.groupBox_CarType.Location = new System.Drawing.Point(50, 145);
            this.groupBox_CarType.Name = "groupBox_CarType";
            this.groupBox_CarType.Size = new System.Drawing.Size(154, 164);
            this.groupBox_CarType.TabIndex = 33;
            this.groupBox_CarType.TabStop = false;
            this.groupBox_CarType.Text = "Care Type";
            // 
            // radioButton_Mini
            // 
            this.radioButton_Mini.AutoSize = true;
            this.radioButton_Mini.Checked = true;
            this.radioButton_Mini.Font = new System.Drawing.Font("Elephant", 14.25F);
            this.radioButton_Mini.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.radioButton_Mini.Location = new System.Drawing.Point(30, 31);
            this.radioButton_Mini.Name = "radioButton_Mini";
            this.radioButton_Mini.Size = new System.Drawing.Size(75, 29);
            this.radioButton_Mini.TabIndex = 12;
            this.radioButton_Mini.TabStop = true;
            this.radioButton_Mini.Text = "Mini";
            this.radioButton_Mini.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Elephant", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(167)))), ((int)(((byte)(108)))));
            this.linkLabel1.Location = new System.Drawing.Point(39, 138);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(82, 17);
            this.linkLabel1.TabIndex = 18;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "List of Cars";
            // 
            // radioButton_Micro
            // 
            this.radioButton_Micro.AutoSize = true;
            this.radioButton_Micro.Font = new System.Drawing.Font("Elephant", 14.25F);
            this.radioButton_Micro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.radioButton_Micro.Location = new System.Drawing.Point(30, 71);
            this.radioButton_Micro.Name = "radioButton_Micro";
            this.radioButton_Micro.Size = new System.Drawing.Size(88, 29);
            this.radioButton_Micro.TabIndex = 13;
            this.radioButton_Micro.TabStop = true;
            this.radioButton_Micro.Text = "Micro";
            this.radioButton_Micro.UseVisualStyleBackColor = true;
            // 
            // radioButton_Prime
            // 
            this.radioButton_Prime.AutoSize = true;
            this.radioButton_Prime.Font = new System.Drawing.Font("Elephant", 14.25F);
            this.radioButton_Prime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.radioButton_Prime.Location = new System.Drawing.Point(29, 106);
            this.radioButton_Prime.Name = "radioButton_Prime";
            this.radioButton_Prime.Size = new System.Drawing.Size(89, 29);
            this.radioButton_Prime.TabIndex = 17;
            this.radioButton_Prime.TabStop = true;
            this.radioButton_Prime.Text = "Prime";
            this.radioButton_Prime.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Elephant", 14.25F);
            this.checkBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.checkBox2.Location = new System.Drawing.Point(340, 192);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(73, 29);
            this.checkBox2.TabIndex = 32;
            this.checkBox2.Text = "Wifi";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Elephant", 14.25F);
            this.checkBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.checkBox1.Location = new System.Drawing.Point(340, 158);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(127, 29);
            this.checkBox1.TabIndex = 31;
            this.checkBox1.Text = "Insurance";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(101)))), ((int)(((byte)(47)))));
            this.label8.Location = new System.Drawing.Point(238, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 25);
            this.label8.TabIndex = 30;
            this.label8.Text = "Add on";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.splitContainer1.Location = new System.Drawing.Point(6, 347);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label_details);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.button4);
            this.splitContainer1.Panel2.Controls.Add(this.button3);
            this.splitContainer1.Size = new System.Drawing.Size(1047, 178);
            this.splitContainer1.SplitterDistance = 530;
            this.splitContainer1.TabIndex = 29;
            this.splitContainer1.Visible = false;
            // 
            // label_details
            // 
            this.label_details.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.label_details.Font = new System.Drawing.Font("Elephant", 14.25F);
            this.label_details.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.label_details.Location = new System.Drawing.Point(6, 103);
            this.label_details.Name = "label_details";
            this.label_details.Size = new System.Drawing.Size(498, 32);
            this.label_details.TabIndex = 2;
            this.label_details.Text = "dd";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Elephant", 14.25F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(101)))), ((int)(((byte)(47)))));
            this.label5.Location = new System.Drawing.Point(244, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Fare Details";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Elephant", 14.25F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(101)))), ((int)(((byte)(47)))));
            this.label7.Location = new System.Drawing.Point(141, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(230, 25);
            this.label7.TabIndex = 11;
            this.label7.Text = "Proced With Bookinng";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button4.Font = new System.Drawing.Font("Elephant", 14.25F);
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(167)))), ((int)(((byte)(108)))));
            this.button4.Location = new System.Drawing.Point(25, 103);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(137, 48);
            this.button4.TabIndex = 10;
            this.button4.Text = "Yes";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.Font = new System.Drawing.Font("Elephant", 14.25F);
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(167)))), ((int)(((byte)(108)))));
            this.button3.Location = new System.Drawing.Point(343, 103);
            this.button3.Name = "button3";
            this.button3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button3.Size = new System.Drawing.Size(137, 48);
            this.button3.TabIndex = 9;
            this.button3.Text = "No";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Font = new System.Drawing.Font("Elephant", 14.25F);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(167)))), ((int)(((byte)(108)))));
            this.button1.Location = new System.Drawing.Point(512, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 48);
            this.button1.TabIndex = 27;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(449, 116);
            this.dateTimePicker1.MinDate = new System.DateTime(2021, 8, 8, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(159, 20);
            this.dateTimePicker1.TabIndex = 26;
            this.dateTimePicker1.Value = new System.DateTime(2021, 8, 8, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Elephant", 14.25F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(101)))), ((int)(((byte)(47)))));
            this.label4.Location = new System.Drawing.Point(444, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 25);
            this.label4.TabIndex = 25;
            this.label4.Text = "Date of Journey";
            // 
            // destination_comboBox
            // 
            this.destination_comboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.destination_comboBox.FormattingEnabled = true;
            this.destination_comboBox.Items.AddRange(new object[] {
            "Bangalore",
            "Mysore",
            "Mangalore",
            "Goa",
            "Mumbai",
            "Hyderabad"});
            this.destination_comboBox.Location = new System.Drawing.Point(243, 116);
            this.destination_comboBox.Name = "destination_comboBox";
            this.destination_comboBox.Size = new System.Drawing.Size(121, 21);
            this.destination_comboBox.TabIndex = 24;
            // 
            // source_comboBox1
            // 
            this.source_comboBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.source_comboBox1.FormattingEnabled = true;
            this.source_comboBox1.Items.AddRange(new object[] {
            "Bangalore",
            "Mysore",
            "Mangalore",
            "Goa",
            "Mumbai",
            "Hyderabad"});
            this.source_comboBox1.Location = new System.Drawing.Point(50, 116);
            this.source_comboBox1.Name = "source_comboBox1";
            this.source_comboBox1.Size = new System.Drawing.Size(121, 21);
            this.source_comboBox1.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Elephant", 14.25F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(101)))), ((int)(((byte)(47)))));
            this.label3.Location = new System.Drawing.Point(238, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 25);
            this.label3.TabIndex = 22;
            this.label3.Text = "Destination";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(101)))), ((int)(((byte)(47)))));
            this.label2.Location = new System.Drawing.Point(45, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 25);
            this.label2.TabIndex = 21;
            this.label2.Text = "Source";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1090, 52);
            this.label1.TabIndex = 20;
            this.label1.Text = "Where are you heading ?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(686, 85);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(367, 139);
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // Booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(1090, 546);
            this.Controls.Add(this.groupBox_CarType);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.destination_comboBox);
            this.Controls.Add(this.source_comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Booking";
            this.Text = "Booking";
            this.groupBox_CarType.ResumeLayout(false);
            this.groupBox_CarType.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_CarType;
        private System.Windows.Forms.RadioButton radioButton_Mini;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.RadioButton radioButton_Micro;
        private System.Windows.Forms.RadioButton radioButton_Prime;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox label_details;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox destination_comboBox;
        private System.Windows.Forms.ComboBox source_comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}