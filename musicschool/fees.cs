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
    public partial class fees : Form
    {
        public fees()
        {
            InitializeComponent();
            displayFees();
            GetStudents();
            GetCourses();
            displayFees();
        }
        private void GetStudents()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select StNum from StudentTbl", con);
            SqlDataReader Rdr;
            Rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("StNum", typeof(int));
            dt.Load(Rdr);
            stldCb.ValueMember = "StNum";
            stldCb.DataSource = dt;
            con.Close();
        }

        private void FetchStname()
        {
            con.Open();
            String Query = "select * from StudentTbl where StNum='" + stldCb.SelectedValue.ToString() + " ' ";
            SqlCommand cmd = new SqlCommand(Query, con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                StNameTb.Text = dr["StName"].ToString();
            }
            con.Close();
        }
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
        private void FetchCtname()
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

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\SONY\Documents\musicschool.mdf;Integrated Security=True;Connect Timeout=30");
        private void displayFees()
        {
            con.Open();
            String Query = "select * from FeesTable";
            SqlDataAdapter sda = new SqlDataAdapter(Query, con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            PayDGV.DataSource = ds.Tables[0];
            con.Close();

        }
        private void Reset()
        {
            AmountTb.Text = "";
            StNameTb.Text = "";
            CourseTb.Text = "";

        }
        private void payBtn_Click(object sender, EventArgs e)
        {
            if ( CourseTb.Text == "" || StNameTb.Text == "" || AmountTb.Text ==  "")
            {
                MessageBox.Show("missing information");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into FeesTable(Fstudid ,FstudidName ,FCourseld , FCourseldName , FDate , FAmount)values(@FN,@FQ,@FD,@FG,@FA,@FP)", con);
                    cmd.Parameters.AddWithValue("@FN", stldCb.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("FQ", StNameTb.Text);
                    cmd.Parameters.AddWithValue("FD", CourseCb.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@FG", CourseTb.Text);
                    cmd.Parameters.AddWithValue("@FA", payDate.Value.Date); ;
                    cmd.Parameters.AddWithValue("@FP", AmountTb.Text);
                    


                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show(" Succesfull Payment");
                   
                    displayFees();
                    Reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        
    }

        private void stldCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            FetchStname();
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void CourseCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            FetchCtname();
        }

        private void label1_Click(object sender, EventArgs e)
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

        private void label12_Click(object sender, EventArgs e)
        {
            dashboard obj = new dashboard();
            obj.Show();
            this.Hide();
        }
        int key = 0;
        private void PayDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            stldCb.SelectedItem = PayDGV.SelectedRows[0].Cells[1].Value.ToString();
            StNameTb.Text = PayDGV.SelectedRows[0].Cells[2].Value.ToString();
            CourseCb.SelectedItem = PayDGV.SelectedRows[0].Cells[3].Value.ToString();
            CourseTb.Text = PayDGV.SelectedRows[0].Cells[4].Value.ToString();
            payDate.Value = Convert.ToDateTime(PayDGV.SelectedRows[0].Cells[5].Value.ToString());
            AmountTb.Text = PayDGV.SelectedRows[0].Cells[6].Value.ToString();
           



            if (stldCb.Text == "")
            {

                key = 0;
            }
            else
            {
                key = Convert.ToInt32(PayDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void Editbtn_Click(object sender, EventArgs e)
        {
            if (stldCb.Text == "" || StNameTb.Text == "" || CourseCb.SelectedIndex == -1 || CourseTb.Text == "" || stldCb.Text == "" || AmountTb.Text == "")
            {
                MessageBox.Show("missing information");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("update FeesTable set Fstudid=@FD, FstudidName=@FA, FCourseld=@FP, FCourseldName=@FC,FDate=@FCN, FAmount=@FG where FNum = @Fkey", con); 
                    cmd.Parameters.AddWithValue("@FD", stldCb.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@FA", StNameTb.Text);
                    cmd.Parameters.AddWithValue("@FP", CourseCb.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@FC", CourseTb.Text);
                    cmd.Parameters.AddWithValue("@FCN", payDate.Value.Date);
                    cmd.Parameters.AddWithValue("@FG", AmountTb.Text);
                    cmd.Parameters.AddWithValue("@Fkey", key);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Payment Edited");
                    
                    displayFees();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
    }
    

