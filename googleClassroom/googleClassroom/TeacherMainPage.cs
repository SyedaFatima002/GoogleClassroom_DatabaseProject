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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace googleClassroom
{
    public partial class TeacherMainPage : Form
    {
        SqlConnection cn = new SqlConnection();
        DBConnector dbcon = new DBConnector();
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        private string email;
        private int id;
        private string ClassCode;//to open class or see students

        public TeacherMainPage(string teacherEmail, int teachID)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            this.KeyPreview = true;
            email = teacherEmail;
            id = teachID;
        }


        private void button1_Click(object sender, EventArgs e)//log out button
        {
            Close();
        }

        private void LoadData() //to display classes
        {
            try
            {
                cn.Open();
                cmd = new SqlCommand("Select class_code, class_name, class_section from Class where teacher_id=@teacher_id", cn);
                cmd.Parameters.AddWithValue("@teacher_id", id);
                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow dr = dt.Rows[i];
                    ListViewItem listitem = new ListViewItem(dr["class_code"].ToString());
                    listitem.SubItems.Add(dr["class_name"].ToString());
                    listitem.SubItems.Add(dr["class_section"].ToString());
                    classes.Items.Add(listitem);
                }
                cn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //for updating the name label on load and loading data
        private void TeacherMainPage_Load_1(object sender, EventArgs e)
        {
            teachername.Text = email;
            LoadData();

        }

        private void addClass_Click(object sender, EventArgs e)//to add class to db and in list view
        {

            try
            {
                classes.Items.Clear();
                cn.Open();
                SqlCommand cmd2 = new SqlCommand("insert into Class(class_code, class_name, class_section, teacher_id) values (@class_code, @class_name, @class_section, @teacher_id)", cn);
                cmd2.Parameters.AddWithValue("@class_code", classCode.Text);
                cmd2.Parameters.AddWithValue("@class_name", className.Text);
                cmd2.Parameters.AddWithValue("@class_section", ClassSection.Text);
                cmd2.Parameters.AddWithValue("@teacher_id", id);
                cmd2.ExecuteNonQuery();
                cn.Close();

                LoadData();

                classCode.Clear();
                className.Clear();
                ClassSection.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                classes.Items.Clear();
                cn.Open();
                SqlCommand cmd2 = new SqlCommand("delete from Class where class_code=@class_code and teacher_id=@teacher_id", cn);
                cmd2.Parameters.AddWithValue("@class_code", remove.Text);
                cmd2.Parameters.AddWithValue("@teacher_id", id);
                cmd2.ExecuteNonQuery();
                cn.Close();

                LoadData();

                remove.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void classes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void openClass_Click(object sender, EventArgs e)
        {
            ClassCode = class_code.Text;

            TeacherClassPage teacherClassPage = new TeacherClassPage(ClassCode, id);
            teacherClassPage.ShowDialog();
        }

        private void teachername_Click(object sender, EventArgs e)
        {

        }

        private void TeacherMainPage_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
