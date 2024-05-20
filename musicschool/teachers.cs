using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace musicschool
{
    public partial class teachers : Form
    {
        public teachers()
        {
            InitializeComponent();
            displayTeachers();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\SONY\Documents\musicschool.mdf;Integrated Security=True;Connect Timeout=30");
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        private void displayTeachers()
        {
            con.Open();
            String Query = "select * from TeachersTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            TeachersDGV.DataSource = ds.Tables[0];
            con.Close();

        }
        private void Savebtn_Click(object sender, EventArgs e)
        {
            if (TnameTb.Text == "" || TQualCb.SelectedIndex == -1 || TGenCb.SelectedIndex == -1 || TAddTb.Text == "" || TPhone.Text == "")
            {
                MessageBox.Show("missing information");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into teachersTbl(TName,TQualifiqation,TDOB, TGender, TAdd, TPhone)values(@TN,@TQ,@TD,@TG,@TA,@TP)", con);
                    cmd.Parameters.AddWithValue("@TN", TnameTb.Text);
                    cmd.Parameters.AddWithValue("TQ", TQualCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("TD", TDOB.Value.Date);
                    cmd.Parameters.AddWithValue("@TG", TGenCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@TA", TAddTb.Text);
                    cmd.Parameters.AddWithValue("@TP", TPhone.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Teachers Added");
                    con.Close();
                    displayTeachers();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }
        int key = 0; 
        private void TeachersDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TnameTb.Text = TeachersDGV.SelectedRows[0].Cells[1].Value.ToString();
            TQualCb.SelectedItem = TeachersDGV.SelectedRows[0].Cells[2].Value.ToString();
            TDOB.Text = TeachersDGV.SelectedRows[0].Cells[3].Value.ToString();
            TGenCb.Text = TeachersDGV.SelectedRows[0].Cells[4].Value.ToString();
            TAddTb.Text = TeachersDGV.SelectedRows[0].Cells[5].Value.ToString();
            TPhone.Text = TeachersDGV.SelectedRows[0].Cells[6].Value.ToString();



            if (TnameTb.Text == "")
            {

                key = 0;
            }
            else
            {
                key = Convert.ToInt32(TeachersDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void editbtn_Click(object sender, EventArgs e)
        {

            if (TnameTb.Text == "" || TQualCb.SelectedIndex == -1 || TGenCb.SelectedIndex == -1 || TAddTb.Text == "" || TPhone.Text == "")
            {
                MessageBox.Show("missing information");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("update teachersTbl set TName=@TN,TQualifiqation=@TQ,TDOB=@TD, TGender=@TG, TAdd=@TA, TPhone=@TP where TNum = @Tkey", con);
                    cmd.Parameters.AddWithValue("@TN", TnameTb.Text);
                    cmd.Parameters.AddWithValue("TQ", TQualCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("TD", TDOB.Value.Date);
                    cmd.Parameters.AddWithValue("@TG", TGenCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@TA", TAddTb.Text);
                    cmd.Parameters.AddWithValue("@TP", TPhone.Text);
                    cmd.Parameters.AddWithValue("@Tkey", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Teachers Edited");
                    con.Close();
                    displayTeachers();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void TnameTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("select the Teachers to be deleted");
            }else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("delete from TeachersTbl where TNum=@Tkey", con);
                    cmd.Parameters.AddWithValue("@Tkey", key);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Teacher deleted");
                    
                    displayTeachers();
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

        private void label8_Click_1(object sender, EventArgs e)
        {

            pricelist obj = new pricelist();
            obj.Show();
            this.Hide();
        }

        private void label11_Click_1(object sender, EventArgs e)
        {
            student obj = new student();
            obj.Show();
            this.Hide();
        }

        private void label10_Click_1(object sender, EventArgs e)
        {

            courses obj = new courses();
            obj.Show();
            this.Hide();
        }

        private void label9_Click_1(object sender, EventArgs e)
        {
            teachers obj = new teachers();
            obj.Show();
            this.Hide();
        }

        private void label12_Click_1(object sender, EventArgs e)
        {
            dashboard obj = new dashboard();
            obj.Show();
            this.Hide();
        }

        private void label13_Click(object sender, EventArgs e)
        {

            fees obj = new fees();
            obj.Show();
            this.Hide();
        }
    }
}
