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
    public partial class Grading : Form
    {
        SqlConnection cn = new SqlConnection();
        DBConnector dbcon = new DBConnector();
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        SqlDataReader dr;
        private int postid;

        public Grading(int postid)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            this.KeyPreview = true;
            this.postid = postid;
        }

        private void LoadData()
        {
            cn.Open();
            //loading annoucements
            cmd = new SqlCommand("getGrades", cn);
            cmd.Parameters.AddWithValue("@classpost", postid);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);


            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                ListViewItem listitem = new ListViewItem(dr["userid"].ToString());
                listitem.SubItems.Add(dr["fullname"].ToString());
                listitem.SubItems.Add(dr["grade"].ToString());
                gradeSheet.Items.Add(listitem);
            }
            //loading annoucements
            cn.Close();
        }

        private void Grading_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void gradeBtn_Click(object sender, EventArgs e)
        {
            gradeSheet.Items.Clear();
            cn.Open();

            SqlCommand cmd2 = new SqlCommand("update submission set grade=@grade where userid=@userid and classpost_id=@classpost_id", cn);
            cmd2.Parameters.AddWithValue("@grade", char.Parse(grade.Text));
            cmd2.Parameters.AddWithValue("@userid", int.Parse(stuID.Text));
            cmd2.Parameters.AddWithValue("@classpost_id", postid);
            cmd2.ExecuteNonQuery();
            cn.Close();

            LoadData();
            grade.Clear();
            stuID.Clear();
            
        }
    }
}
