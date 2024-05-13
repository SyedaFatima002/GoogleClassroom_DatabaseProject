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
    public partial class SignUp : Form
    {
        SqlConnection cn = new SqlConnection();
        DBConnector dbcon = new DBConnector();
        SqlCommand cmd;

        public SignUp()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            this.KeyPreview = true;
        }


        private void SignUpTeacher_Click(object sender, EventArgs e)
        {
            try
            {
                //checking is password and confirm password match
                if (password.Text != confirmpassword.Text)
                {
                    MessageBox.Show("Confirm password and password are not the same", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string count = "";
                    int userid;
                    using (cmd=new SqlCommand("select dbo.getUserCount()", cn))
                    {
                        cn.Open();
                        count=cmd.ExecuteScalar().ToString();
                        int temp=int.Parse(count);
                        userid = temp+1;
                        count=userid.ToString();
                        cn.Close();
                    }

                    cn.Open();
                    SqlCommand cmd2 = new SqlCommand("insert into User_(userid, fullname, email, password, username, user_type) values(@userid, @fullname, @email, @password, @username, @user_type )", cn);
                    cmd2.Parameters.AddWithValue("@userid", count);
                    cmd2.Parameters.AddWithValue("@fullname", name.Text);
                    cmd2.Parameters.AddWithValue("@email", email.Text);
                    cmd2.Parameters.AddWithValue ("@password", password.Text);
                    cmd2.Parameters.AddWithValue("@username", username.Text);
                    cmd2.Parameters.AddWithValue("@user_type", "Teacher");
                    cmd2.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Account Created", "Welcome to GCR", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    TeacherMainPage teacherMainPage = new TeacherMainPage(email.Text, userid);
                    this.Hide();
                    teacherMainPage.ShowDialog();
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //checking is password and confirm password match
                if (password.Text != confirmpassword.Text)
                {
                    MessageBox.Show("Confirm password and password are not the same", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string count = "";
                    int userid;
                    using (cmd = new SqlCommand("select dbo.getUserCount()", cn))
                    {
                        cn.Open();
                        count = cmd.ExecuteScalar().ToString();
                        int temp = int.Parse(count);
                        userid = temp + 1;
                        count = userid.ToString();
                        cn.Close();
                    }

                    cn.Open();
                    SqlCommand cmd2 = new SqlCommand("insert into User_(userid, fullname, email, password, username, user_type) values(@userid, @fullname, @email, @password, @username, @user_type )", cn);
                    cmd2.Parameters.AddWithValue("@userid", count);
                    cmd2.Parameters.AddWithValue("@fullname", name.Text);
                    cmd2.Parameters.AddWithValue("@email", email.Text);
                    cmd2.Parameters.AddWithValue("@password", password.Text);
                    cmd2.Parameters.AddWithValue("@username", username.Text);
                    cmd2.Parameters.AddWithValue("@user_type", "Student");
                    cmd2.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Account Created", "Welcome to GCR", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    StudentMainPage studentMainPage = new StudentMainPage(email.Text, int.Parse(count));
                    this.Hide();
                    studentMainPage.ShowDialog();
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
