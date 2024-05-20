using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace musicschool
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            unameTb.Text = "";
            pwTb.Text = "";
        }

        private void logbtn_Click(object sender, EventArgs e)
        {
            if (unameTb.Text == "username"|| pwTb.Text=="")
            {
                MessageBox.Show("Missing Information");
                unameTb.Text = "";
                pwTb.Text = "";

            }else if(unameTb.Text=="kiandra" && pwTb.Text=="courses")
            {
                pricelist obj = new pricelist();
                obj.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Wrong Username Or/And Password");
                unameTb.Text = "";
                pwTb.Text = "";
            }
            
        }

        private void pwTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void Chekbshow_CheckedChanged(object sender, EventArgs e)
        {
            if (Chekbshow.Checked)
            {
               pwTb.UseSystemPasswordChar = true;
                

                

            }else
            {
                pwTb.UseSystemPasswordChar=false;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
