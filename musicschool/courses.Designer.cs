namespace musicschool
{
    partial class courses
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
            this.CoursesDGV = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.editbtn = new System.Windows.Forms.Button();
            this.deletebtn = new System.Windows.Forms.Button();
            this.Savebtn = new System.Windows.Forms.Button();
            this.DurationTb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tCb = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TNameTb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.courseNameTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PriceTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CoursesDGV)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CoursesDGV
            // 
            this.CoursesDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CoursesDGV.Location = new System.Drawing.Point(341, 84);
            this.CoursesDGV.Name = "CoursesDGV";
            this.CoursesDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CoursesDGV.Size = new System.Drawing.Size(647, 230);
            this.CoursesDGV.TabIndex = 57;
            this.CoursesDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CoursesDGV_CellContentClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Location = new System.Drawing.Point(325, 58);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 446);
            this.panel3.TabIndex = 56;
            // 
            // editbtn
            // 
            this.editbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.editbtn.Location = new System.Drawing.Point(103, 483);
            this.editbtn.Name = "editbtn";
            this.editbtn.Size = new System.Drawing.Size(75, 23);
            this.editbtn.TabIndex = 55;
            this.editbtn.Text = "EDIT";
            this.editbtn.UseVisualStyleBackColor = false;
            this.editbtn.Click += new System.EventHandler(this.editbtn_Click);
            // 
            // deletebtn
            // 
            this.deletebtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.deletebtn.Location = new System.Drawing.Point(194, 483);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(75, 23);
            this.deletebtn.TabIndex = 54;
            this.deletebtn.Text = "DELETE";
            this.deletebtn.UseVisualStyleBackColor = false;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // Savebtn
            // 
            this.Savebtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Savebtn.Location = new System.Drawing.Point(22, 483);
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Size = new System.Drawing.Size(75, 23);
            this.Savebtn.TabIndex = 53;
            this.Savebtn.Text = "SAVE";
            this.Savebtn.UseVisualStyleBackColor = false;
            this.Savebtn.Click += new System.EventHandler(this.Savebtn_Click);
            // 
            // DurationTb
            // 
            this.DurationTb.Location = new System.Drawing.Point(17, 425);
            this.DurationTb.Name = "DurationTb";
            this.DurationTb.Size = new System.Drawing.Size(147, 20);
            this.DurationTb.TabIndex = 52;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label7.Location = new System.Drawing.Point(14, 394);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(179, 19);
            this.label7.TabIndex = 51;
            this.label7.Text = "DURATION IN MONTHS";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // tCb
            // 
            this.tCb.FormattingEnabled = true;
            this.tCb.Location = new System.Drawing.Point(17, 214);
            this.tCb.Name = "tCb";
            this.tCb.Size = new System.Drawing.Size(146, 21);
            this.tCb.TabIndex = 49;
            this.tCb.SelectionChangeCommitted += new System.EventHandler(this.tCb_SelectionChangeCommitted);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(14, 263);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(132, 19);
            this.label6.TabIndex = 48;
            this.label6.Text = "TEACHERS NAME";
            // 
            // TNameTb
            // 
            this.TNameTb.Enabled = false;
            this.TNameTb.Location = new System.Drawing.Point(17, 284);
            this.TNameTb.Name = "TNameTb";
            this.TNameTb.Size = new System.Drawing.Size(147, 20);
            this.TNameTb.TabIndex = 46;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(20, 193);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(95, 19);
            this.label4.TabIndex = 45;
            this.label4.Text = "TEACHER ID";
            // 
            // courseNameTb
            // 
            this.courseNameTb.Location = new System.Drawing.Point(16, 146);
            this.courseNameTb.Multiline = true;
            this.courseNameTb.Name = "courseNameTb";
            this.courseNameTb.Size = new System.Drawing.Size(147, 32);
            this.courseNameTb.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(19, 125);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(123, 19);
            this.label1.TabIndex = 41;
            this.label1.Text = "COURSES NAME";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(987, 59);
            this.panel1.TabIndex = 40;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Pink;
            this.panel2.Location = new System.Drawing.Point(421, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(100, 10);
            this.panel2.TabIndex = 60;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::musicschool.Properties.Resources.tst_small_507x507_pad_600x600_f8f8f8_removebg_preview;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(3, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 58);
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(797, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(143, 25);
            this.label12.TabIndex = 24;
            this.label12.Text = "DASHBOARD";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label11.Location = new System.Drawing.Point(273, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 25);
            this.label11.TabIndex = 23;
            this.label11.Text = "LEARNERS";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label10.Location = new System.Drawing.Point(416, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 25);
            this.label10.TabIndex = 22;
            this.label10.Text = "COURSES";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label9.Location = new System.Drawing.Point(555, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 25);
            this.label9.TabIndex = 21;
            this.label9.Text = "TEACHERS";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label8.Location = new System.Drawing.Point(173, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 25);
            this.label8.TabIndex = 20;
            this.label8.Text = "HOME";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(14, 321);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(50, 19);
            this.label2.TabIndex = 58;
            this.label2.Text = "PRICE";
            // 
            // PriceTb
            // 
            this.PriceTb.Location = new System.Drawing.Point(17, 342);
            this.PriceTb.Name = "PriceTb";
            this.PriceTb.Size = new System.Drawing.Size(147, 20);
            this.PriceTb.TabIndex = 59;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DeepPink;
            this.label3.Location = new System.Drawing.Point(70, 84);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(154, 19);
            this.label3.TabIndex = 60;
            this.label3.Text = "MANAGE COURSES";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Location = new System.Drawing.Point(698, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 25);
            this.label13.TabIndex = 61;
            this.label13.Text = "FEES";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // courses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(991, 528);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PriceTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CoursesDGV);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.editbtn);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.Savebtn);
            this.Controls.Add(this.DurationTb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tCb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TNameTb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.courseNameTb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "courses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "courses";
            this.Load += new System.EventHandler(this.courses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CoursesDGV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView CoursesDGV;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button editbtn;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Button Savebtn;
        private System.Windows.Forms.TextBox DurationTb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox tCb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TNameTb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox courseNameTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PriceTb;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label13;
    }
}