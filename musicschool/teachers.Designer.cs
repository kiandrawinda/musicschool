namespace musicschool
{
    partial class teachers
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
            this.TeachersDGV = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.editbtn = new System.Windows.Forms.Button();
            this.deletebtn = new System.Windows.Forms.Button();
            this.Savebtn = new System.Windows.Forms.Button();
            this.TAddTb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TGenCb = new System.Windows.Forms.ComboBox();
            this.TQualCb = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TPhone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TDOB = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.TnameTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TeachersDGV)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TeachersDGV
            // 
            this.TeachersDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TeachersDGV.Location = new System.Drawing.Point(341, 85);
            this.TeachersDGV.Name = "TeachersDGV";
            this.TeachersDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TeachersDGV.Size = new System.Drawing.Size(646, 230);
            this.TeachersDGV.TabIndex = 39;
            this.TeachersDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TeachersDGV_CellContentClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Location = new System.Drawing.Point(325, 67);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 493);
            this.panel3.TabIndex = 38;
            // 
            // editbtn
            // 
            this.editbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.editbtn.Location = new System.Drawing.Point(113, 537);
            this.editbtn.Name = "editbtn";
            this.editbtn.Size = new System.Drawing.Size(75, 23);
            this.editbtn.TabIndex = 37;
            this.editbtn.Text = "EDIT";
            this.editbtn.UseVisualStyleBackColor = false;
            this.editbtn.Click += new System.EventHandler(this.editbtn_Click);
            // 
            // deletebtn
            // 
            this.deletebtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.deletebtn.Location = new System.Drawing.Point(204, 537);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(75, 23);
            this.deletebtn.TabIndex = 36;
            this.deletebtn.Text = "DELETE";
            this.deletebtn.UseVisualStyleBackColor = false;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // Savebtn
            // 
            this.Savebtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Savebtn.Location = new System.Drawing.Point(32, 537);
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Size = new System.Drawing.Size(75, 23);
            this.Savebtn.TabIndex = 35;
            this.Savebtn.Text = "SAVE";
            this.Savebtn.UseVisualStyleBackColor = false;
            this.Savebtn.Click += new System.EventHandler(this.Savebtn_Click);
            // 
            // TAddTb
            // 
            this.TAddTb.Location = new System.Drawing.Point(30, 481);
            this.TAddTb.Multiline = true;
            this.TAddTb.Name = "TAddTb";
            this.TAddTb.Size = new System.Drawing.Size(147, 46);
            this.TAddTb.TabIndex = 34;
            this.TAddTb.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.label7.Location = new System.Drawing.Point(33, 459);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(76, 19);
            this.label7.TabIndex = 33;
            this.label7.Text = "ADDRESS";
            // 
            // TGenCb
            // 
            this.TGenCb.FormattingEnabled = true;
            this.TGenCb.Items.AddRange(new object[] {
            "FEMALE",
            "MALE"});
            this.TGenCb.Location = new System.Drawing.Point(31, 418);
            this.TGenCb.Name = "TGenCb";
            this.TGenCb.Size = new System.Drawing.Size(146, 21);
            this.TGenCb.TabIndex = 32;
            // 
            // TQualCb
            // 
            this.TQualCb.FormattingEnabled = true;
            this.TQualCb.Items.AddRange(new object[] {
            "PROFESSIONAL",
            "UG",
            "PG"});
            this.TQualCb.Location = new System.Drawing.Point(31, 355);
            this.TQualCb.Name = "TQualCb";
            this.TQualCb.Size = new System.Drawing.Size(146, 21);
            this.TQualCb.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.label6.Location = new System.Drawing.Point(30, 334);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(132, 18);
            this.label6.TabIndex = 30;
            this.label6.Text = "QUALIFIQATION";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.label5.Location = new System.Drawing.Point(29, 397);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(69, 19);
            this.label5.TabIndex = 29;
            this.label5.Text = "GENDER";
            // 
            // TPhone
            // 
            this.TPhone.Location = new System.Drawing.Point(30, 283);
            this.TPhone.Multiline = true;
            this.TPhone.Name = "TPhone";
            this.TPhone.Size = new System.Drawing.Size(147, 32);
            this.TPhone.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.label4.Location = new System.Drawing.Point(34, 262);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(67, 18);
            this.label4.TabIndex = 27;
            this.label4.Text = "PHONE";
            // 
            // TDOB
            // 
            this.TDOB.Location = new System.Drawing.Point(30, 221);
            this.TDOB.Name = "TDOB";
            this.TDOB.Size = new System.Drawing.Size(200, 20);
            this.TDOB.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.label2.Location = new System.Drawing.Point(29, 200);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(133, 18);
            this.label2.TabIndex = 23;
            this.label2.Text = "DATE OF BIRTH";
            // 
            // TnameTb
            // 
            this.TnameTb.Location = new System.Drawing.Point(29, 155);
            this.TnameTb.Multiline = true;
            this.TnameTb.Name = "TnameTb";
            this.TnameTb.Size = new System.Drawing.Size(147, 32);
            this.TnameTb.TabIndex = 22;
            this.TnameTb.TextChanged += new System.EventHandler(this.TnameTb_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.label1.Location = new System.Drawing.Point(32, 128);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(57, 19);
            this.label1.TabIndex = 21;
            this.label1.Text = "NAMA";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleVioletRed;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-6, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(993, 65);
            this.panel1.TabIndex = 20;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Location = new System.Drawing.Point(727, 20);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 25);
            this.label13.TabIndex = 42;
            this.label13.Text = "FEES";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel4.Location = new System.Drawing.Point(589, 48);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(111, 10);
            this.panel4.TabIndex = 40;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(801, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(143, 25);
            this.label12.TabIndex = 30;
            this.label12.Text = "DASHBOARD";
            this.label12.Click += new System.EventHandler(this.label12_Click_1);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(326, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 25);
            this.label11.TabIndex = 32;
            this.label11.Text = "LEARNERS";
            this.label11.Click += new System.EventHandler(this.label11_Click_1);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(459, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 25);
            this.label10.TabIndex = 31;
            this.label10.Text = "COURSES";
            this.label10.Click += new System.EventHandler(this.label10_Click_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(584, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 25);
            this.label9.TabIndex = 29;
            this.label9.Text = "TEACHERS";
            this.label9.Click += new System.EventHandler(this.label9_Click_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(203, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 25);
            this.label8.TabIndex = 28;
            this.label8.Text = "HOME";
            this.label8.Click += new System.EventHandler(this.label8_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::musicschool.Properties.Resources.tst_small_507x507_pad_600x600_f8f8f8_removebg_preview;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 62);
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Location = new System.Drawing.Point(338, 79);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(13, 478);
            this.panel2.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DeepPink;
            this.label3.Location = new System.Drawing.Point(83, 82);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(162, 19);
            this.label3.TabIndex = 40;
            this.label3.Text = "MANAGE TEACHERS";
            // 
            // teachers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(987, 568);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TeachersDGV);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.editbtn);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.Savebtn);
            this.Controls.Add(this.TAddTb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TGenCb);
            this.Controls.Add(this.TQualCb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TPhone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TDOB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TnameTb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "teachers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "teachers";
            ((System.ComponentModel.ISupportInitialize)(this.TeachersDGV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TeachersDGV;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button editbtn;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Button Savebtn;
        private System.Windows.Forms.TextBox TAddTb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox TGenCb;
        private System.Windows.Forms.ComboBox TQualCb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker TDOB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TnameTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label13;
    }
}