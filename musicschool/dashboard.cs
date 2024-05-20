using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace musicschool
{
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
            CountStudent();
            CountTeacher();
            CountCourses();
            SumAmount();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\SONY\Documents\musicschool.mdf;Integrated Security=True;Connect Timeout=30");
       private void CountStudent()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter ("Select Count(*) from StudentTbl", con);
            DataTable dt = new DataTable();
            sda.Fill (dt);
            StudBer.Text = dt.Rows[0][0].ToString() +"  " + "Student";
            con.Close();

        }

        private void SumAmount()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select Sum(FAmount) from FeesTable", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            InAmount.Text = dt.Rows[0][0].ToString() + "  " + "RUPIAH";
            con.Close();

        }


        private void CountTeacher()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from TeachersTbl", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            InNum.Text = dt.Rows[0][0].ToString() + "  " + "Instructors";
            con.Close();

        }

        private void CountCourses()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from CoursesTbl", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            CourseNum.Text = dt.Rows[0][0].ToString() + "  " + "Courses";
            con.Close();

        }


        private void dashboard_Load(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void InNum_Click(object sender, EventArgs e)
        {

        }

        private void StudBer_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            pricelist obj = new pricelist();
            obj.Show();
            this.Hide();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            student obj = new student();
            obj.Show();
            this.Hide();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            courses obj = new courses();
            obj.Show();
            this.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            teachers obj = new teachers();
            obj.Show();
            this.Hide();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            fees obj = new fees();
            obj.Show();
            this.Hide();
        }

        private void CourseNum_Click(object sender, EventArgs e)
        {

        }
    }
}
