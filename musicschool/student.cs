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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace musicschool
{
    public partial class student : Form
    {
        public student()
        {
            InitializeComponent();
            GetCourses();
            displayStudent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\SONY\Documents\musicschool.mdf;Integrated Security=True;Connect Timeout=30");
        private void GetCourses()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select CNum from CoursesTbl", con);
            SqlDataReader Rdr;
            Rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("CNum", typeof(int));
            dt.Load(Rdr);
            CourseCb.ValueMember = "CNum";
            CourseCb.DataSource = dt;
            con.Close();
        }

        private void FetchCname()
        {
            con.Open();
            String Query = "select * from CoursesTbl where CNum='" + CourseCb.SelectedValue.ToString() + " ' ";
            SqlCommand cmd = new SqlCommand(Query, con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                CourseTb.Text = dr["CName"].ToString();
            }
            con.Close();
        }

        
        private void savebtn_Click(object sender, EventArgs e)
        {
            if (StNameTb.Text == "" || StAddTb.Text == "" || GenCb.SelectedIndex == -1 || StNameTb.Text == "" || PhoneTb.Text == "" || StRemarkTb.Text == "")
            {
                MessageBox.Show("missing information");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into StudentTbl(StName,StDOB, StAddreess, StPhone, StCourse,StCName, StGender, StRemarks )values(@SN,@SD,@SA,@SP,@SC,@SCN, @SG, @SR)", con);
                    cmd.Parameters.AddWithValue("@SN", StNameTb.Text);
                    cmd.Parameters.AddWithValue("SD", StDOB.Value.Date);
                    cmd.Parameters.AddWithValue("SA", StAddTb.Text);
                    cmd.Parameters.AddWithValue("@SP", PhoneTb.Text);
                    cmd.Parameters.AddWithValue("@SC", CourseCb.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@SCN", CourseTb.Text);
                    cmd.Parameters.AddWithValue("@SG", GenCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@SR", StRemarkTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Student Added");
                    con.Close();
                    displayStudent();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }


        private void displayStudent()
        {
            con.Open();
            String Query = "select * from StudentTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            StudentDGV.DataSource = ds.Tables[0];
            con.Close();

        }
        private void CourseCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
           FetchCname();
        }
        int key = 0;
        private void StudentDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
      
            StNameTb.Text = StudentDGV.SelectedRows[0].Cells[1].Value.ToString();
            StDOB.Value = Convert.ToDateTime(StudentDGV.SelectedRows[0].Cells[2].Value.ToString());
            StAddTb.Text = StudentDGV.SelectedRows[0].Cells[3].Value.ToString();
            PhoneTb.Text = StudentDGV.SelectedRows[0].Cells[4].Value.ToString();
            GenCb.Text = StudentDGV.SelectedRows[0].Cells[5].Value.ToString();
            CourseTb.Text = StudentDGV.SelectedRows[0].Cells[6].Value.ToString();
            GenCb.Text = StudentDGV.SelectedRows[0].Cells[7].Value.ToString();
            StRemarkTb.Text = StudentDGV.SelectedRows[0].Cells[8].Value.ToString();



            if (StNameTb.Text == "")
            {

                key = 0;
            }
            else
            {
                key = Convert.ToInt32(StudentDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("select the Student to be deleted");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("delete from StudentTbl where StNum=@Skey", con);
                    cmd.Parameters.AddWithValue("@Skey", key);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Student deleted");

                    displayStudent();
                }
                catch (Exception ex)



                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void editbtn_Click(object sender, EventArgs e)
        {

            if (StNameTb.Text == "" || StAddTb.Text == "" || GenCb.SelectedIndex == -1 || StNameTb.Text == "" || PhoneTb.Text == "" || StRemarkTb.Text == "")
            {
                MessageBox.Show("missing information");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("update StudentTbl set StName=@SN,StDOB=@SD, StAddreess=@SA, StPhone=@SP, StCourse=@SC,StCName=@SCN, StGender=@SG, StRemarks=@SR where StNum = @Skey", con); ;
                    cmd.Parameters.AddWithValue("@SN", StNameTb.Text);
                    cmd.Parameters.AddWithValue("SD", StDOB.Value.Date);
                    cmd.Parameters.AddWithValue("SA", StAddTb.Text);
                    cmd.Parameters.AddWithValue("@SP", PhoneTb.Text);
                    cmd.Parameters.AddWithValue("@SC", CourseCb.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@SCN", CourseTb.Text);
                    cmd.Parameters.AddWithValue("@SG", GenCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@SR", StRemarkTb.Text);
                    cmd.Parameters.AddWithValue("@Skey", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Student Edited");
                    con.Close();
                    displayStudent();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            pricelist obj = new   pricelist();
            obj.Show();
            this.Hide();

        }

        private void label11_Click(object sender, EventArgs e)
        {
            student obj = new   student();
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

        private void label12_Click(object sender, EventArgs e)
        {
            dashboard obj = new dashboard();
            obj.Show();
            this.Hide();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {
            fees obj = new fees();
            obj.Show();
            this.Hide();
        }

        private void student_Load(object sender, EventArgs e)
        {

        }
    }
}
