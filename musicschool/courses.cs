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
    public partial class courses : Form
    {
        public courses()
        {
            InitializeComponent();
            GetTeachers();
            displayCourses();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void GetTeachers()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select TNum from TeachersTbl", con);
            SqlDataReader Rdr;
            Rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("TNum", typeof(int));
            dt.Load(Rdr);
            tCb.ValueMember = "TNum";
            tCb.DataSource = dt;
            con.Close();
        }

        private void FetchTname()
        {
            con.Open();
            String Query = "select * from TeachersTbl where TNum='" + tCb.SelectedValue.ToString() + " ' ";
            SqlCommand cmd = new SqlCommand(Query, con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                TNameTb.Text = dr["TName"].ToString();
            }
            con.Close();
        }


        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\SONY\Documents\musicschool.mdf;Integrated Security=True;Connect Timeout=30");
        private void displayCourses()
        {
            con.Open();
            String Query = "select * from CoursesTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            CoursesDGV.DataSource = ds.Tables[0];
            con.Close();

        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            if (courseNameTb.Text == "" || tCb.SelectedIndex == -1 || TNameTb.Text == "" || PriceTb.Text == "" || DurationTb.Text == "")
            {
                MessageBox.Show("missing information");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into CoursesTbl(CName,CTid,CTName, Cprice, Cduration)values(@CN,@CTI,@CTN,@CP,@CD)", con);
                    cmd.Parameters.AddWithValue("@CN", courseNameTb.Text);
                    cmd.Parameters.AddWithValue("CTI", tCb.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("CTN", TNameTb.Text);
                    cmd.Parameters.AddWithValue("@CP", PriceTb.Text);
                    cmd.Parameters.AddWithValue("@CD", DurationTb.Text);

                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Courses Added");

                    displayCourses();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void tCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            FetchTname();
        }
        int key = 0;
        private void CoursesDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            courseNameTb.Text = CoursesDGV.SelectedRows[0].Cells[1].Value.ToString();
            tCb.SelectedItem = CoursesDGV.SelectedRows[0].Cells[2].Value.ToString();
            //TDOB.Text = CoursesDGV.SelectedRows[0].Cells[3].Value.ToString();
            TNameTb.Text = CoursesDGV.SelectedRows[0].Cells[3].Value.ToString();
            PriceTb.Text = CoursesDGV.SelectedRows[0].Cells[4].Value.ToString();
            DurationTb.Text = CoursesDGV.SelectedRows[0].Cells[5].Value.ToString();



            if (courseNameTb.Text == "")
            {

                key = 0;
            }
            else
            {
                key = Convert.ToInt32(CoursesDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            if (courseNameTb.Text == "" || tCb.SelectedIndex == -1 || TNameTb.Text == "" || PriceTb.Text == "" || DurationTb.Text == "")
            {
                MessageBox.Show("missing information");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("update CoursesTbl set CName=@CN,CTid=@CTI,CTName=@CTN, Cprice=@CP, CDuration=@CD where CNum = @Ckey", con);
                    cmd.Parameters.AddWithValue("@CN", courseNameTb.Text);
                    cmd.Parameters.AddWithValue("CTI", tCb.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("CTN", TNameTb.Text);
                    cmd.Parameters.AddWithValue("@CP", PriceTb.Text);
                    cmd.Parameters.AddWithValue("@CD", DurationTb.Text);
                    cmd.Parameters.AddWithValue("@Ckey", key);

                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Courses Edited");

                    displayCourses();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("select the Courses to be deleted");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("delete from CoursesTbl where CNum=@Ckey", con);
                    cmd.Parameters.AddWithValue("@Ckey", key);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Courses deleted");
                    
                    displayCourses();
                }
                catch (Exception ex)



                {
                    MessageBox.Show(ex.Message);
                }
            }
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

        private void label12_Click(object sender, EventArgs e)
        {

            dashboard obj = new dashboard();
            obj.Show();
            this.Hide();
        }

        private void courses_Load(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {
            fees obj = new fees();
            obj.Show();
            this.Hide();
        }
    }
    }

