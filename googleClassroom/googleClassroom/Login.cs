using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Common;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace googleClassroom
{
    public partial class Login : Form
    {
        SqlConnection cn = new SqlConnection();
        DBConnector dbcon = new DBConnector();
        SqlCommand cm = null;
        SqlDataReader dr;

        public Login()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            this.KeyPreview = true;
        }

        private void titlelabel_Click(object sender, EventArgs e)
        {

        }

        private void SignUplinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp signUp = new SignUp();
            this.Hide();
            signUp.ShowDialog();
            Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Loginbutton_Click(object sender, EventArgs e)
        {//letting the person with an account into the system
            string type = "";
            string email = "";
            int id=0;

            try
            {
                bool found = false;
                cn.Open();
                cm = new SqlCommand("Select * from User_ where username=@username and password=@password", cn);
                cm.Parameters.AddWithValue("@username", username.Text);
                cm.Parameters.AddWithValue("@password", password.Text);
                dr = cm.ExecuteReader();
                dr.Read();


                if (dr.HasRows)
                {
                    type = dr["user_type"].ToString();
                    email = dr["email"].ToString();
                    id = int.Parse(dr["userid"].ToString());
                    found = true;
                }

                dr.Close();
                cn.Close();

                if (found)
                {
                    if (type == "Student")
                    {
                        StudentMainPage student = new StudentMainPage(email, id);
                        this.Hide();
                        student.ShowDialog();
                        Close();
                    }
                    else if (type == "Teacher")
                    {
                        TeacherMainPage teacher = new TeacherMainPage(email, id);
                        this.Hide();
                        teacher.ShowDialog();
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect insertion in database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Incorrect Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}