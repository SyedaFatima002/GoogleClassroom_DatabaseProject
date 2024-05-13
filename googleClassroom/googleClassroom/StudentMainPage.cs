using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace googleClassroom
{
    public partial class StudentMainPage : Form
    {
        SqlConnection cn = new SqlConnection();
        DBConnector dbcon = new DBConnector();
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        private string email;
        private int stuID;
        public StudentMainPage(string email, int id)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            this.KeyPreview = true;
            this.email = email;
            stuID = id;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void LoadData()
        {
            try
            {
                cn.Open();
                cmd = new SqlCommand("getStudentClasses", cn);
                cmd.Parameters.AddWithValue("@userid", stuID);
                cmd.CommandType = CommandType.StoredProcedure;
                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow dr = dt.Rows[i];
                    ListViewItem listitem = new ListViewItem(dr["class_code"].ToString());
                    listitem.SubItems.Add(dr["class_name"].ToString());
                    listitem.SubItems.Add(dr["class_section"].ToString());
                    StudentClasses.Items.Add(listitem);
                }
                cn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void StudentMainPage_Load(object sender, EventArgs e)
        {
            label2.Text = email;
            LoadData();
        }

        private void addClassStudent_Click(object sender, EventArgs e)
        {
            try
            {
                StudentClasses.Items.Clear();
                cn.Open();
                SqlCommand cmd2 = new SqlCommand("insert into std_class(userid, class_code) values (@userid, @class_code)", cn);
                cmd2.Parameters.AddWithValue("@class_code", classCodeStudent.Text);
                cmd2.Parameters.AddWithValue("@userid", stuID);
                cmd2.ExecuteNonQuery();
                cn.Close();

                LoadData();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void remove_Click(object sender, EventArgs e)
        {
            try
            {
                StudentClasses.Items.Clear();
                cn.Open();
                SqlCommand cmd2 = new SqlCommand("delete from std_class where class_code=@class_code and userid=@userid", cn);
                cmd2.Parameters.AddWithValue("@class_code", removeClass.Text);
                cmd2.Parameters.AddWithValue("@userid", stuID);
                cmd2.ExecuteNonQuery();
                cn.Close();

                LoadData();

                removeClass.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void openClassBtn_Click(object sender, EventArgs e)
        {
            StudentClassPage stdClass = new StudentClassPage(openClass.Text, stuID);
            stdClass.ShowDialog();
        }
    }
}
