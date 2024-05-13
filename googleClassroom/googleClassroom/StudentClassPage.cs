using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace googleClassroom
{
    public partial class StudentClassPage : Form
    {
        SqlConnection cn = new SqlConnection();
        DBConnector dbcon = new DBConnector();
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        SqlDataReader dr;
        string classcode;
        int stuID;

        public StudentClassPage(string classcode, int stuID)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            this.KeyPreview = true;
            this.classcode = classcode;
            this.stuID = stuID;
        }

        private void LoadPosts()//displaying annoucement
        {
            try
            {
                cn.Open();
                //loading annoucements
                cmd = new SqlCommand("displayAnnouncement", cn);
                cmd.Parameters.AddWithValue("@code", classcode);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);


                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow dr = dt.Rows[i];
                    ListViewItem listitem = new ListViewItem(dr["classpost_id"].ToString());
                    listitem.SubItems.Add(dr["announcement_desc"].ToString());
                    listitem.SubItems.Add(dr["date_issued"].ToString());
                    listitem.SubItems.Add(dr["fullname"].ToString());
                    announcements.Items.Add(listitem);
                }
                //loading annoucements


                //loading class material
                cmd = new SqlCommand("displayClassMaterial", cn);
                cmd.Parameters.AddWithValue("@code", classcode);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da1 = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da1.Fill(dt);


                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow dr = dt.Rows[i];
                    ListViewItem listitem = new ListViewItem(dr["classpost_id"].ToString());
                    listitem.SubItems.Add(dr["material_desc"].ToString());
                    listitem.SubItems.Add(dr["date_issued"].ToString());
                    listitem.SubItems.Add(dr["fullname"].ToString());
                    ClassMaterials.Items.Add(listitem);
                }
                //loading class material

                //loading assignments
                cmd = new SqlCommand("displayAssignment", cn);
                cmd.Parameters.AddWithValue("@code", classcode);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da2 = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da2.Fill(dt);


                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow dr = dt.Rows[i];
                    ListViewItem listitem = new ListViewItem(dr["classpost_id"].ToString());
                    listitem.SubItems.Add(dr["assignment_desc"].ToString());
                    listitem.SubItems.Add(dr["due_date"].ToString());
                    listitem.SubItems.Add(dr["fullname"].ToString());
                    listitem.SubItems.Add(dr["date_issued"].ToString());
                    AssignmentList.Items.Add(listitem);
                }
                //loading assignments

                //Loading students in class
                cmd = new SqlCommand("getStudentList", cn);
                cmd.Parameters.AddWithValue("@code", classcode);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da3 = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da3.Fill(dt);


                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow dr = dt.Rows[i];
                    ListViewItem listitem = new ListViewItem(dr["fullname"].ToString());
                    listitem.SubItems.Add(dr["email"].ToString());
                    //studentList.Items.Add(listitem);
                }
                //Loading students in class
                cn.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }



        private void StudentClassPage_Load(object sender, EventArgs e)
        {
            string classname = "";
            //updating the label's name to class name
            cn.Open();
            cmd = new SqlCommand("Select class_name from Class where class_code=@class_code", cn);
            cmd.Parameters.AddWithValue("@class_code", classcode);
            dr = cmd.ExecuteReader();
            dr.Read();

            if (dr.HasRows)
            {
                classname = dr["class_name"].ToString();
            }
            cn.Close();

            className.Text = classname;
            //updating the label's name to class name

            LoadPosts();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void remove_Click(object sender, EventArgs e)
        {
            announcements.Items.Clear();

            cn.Open();
            SqlCommand cmd2 = new SqlCommand("delete from Announcement where classpost_id=@classpost_id", cn);
            cmd2.Parameters.AddWithValue("@classpost_id", removeannouncement.Text);
            cmd2.ExecuteNonQuery();

            SqlCommand cmd3 = new SqlCommand("delete from classpost where classpost_id=@classpost_id", cn);
            cmd3.Parameters.AddWithValue("@classpost_id", removeannouncement.Text);
            cmd3.ExecuteNonQuery();


            cn.Close();

            LoadPosts();
            removeannouncement.Clear();
        }

        private void make_Click(object sender, EventArgs e)
        {
            string count = "";
            int classpostid;
            using (cmd = new SqlCommand("select dbo.getClassPostCount()", cn))
            {
                cn.Open();
                count = cmd.ExecuteScalar().ToString();
                int temp = int.Parse(count);
                classpostid = temp + 1;
                count = classpostid.ToString();

                cn.Close();
            }

            cn.Open();
            announcements.Items.Clear();
            SqlCommand cmd2 = new SqlCommand("insert into classpost(classpost_id, class_code, date_issued, userid) values (@classpost_id, @class_code, GETDATE(), @userid)", cn);
            cmd2.Parameters.AddWithValue("@class_code", classcode);
            cmd2.Parameters.AddWithValue("@classpost_id", count);
            cmd2.Parameters.AddWithValue("@userid", stuID);
            cmd2.ExecuteNonQuery();

            SqlCommand cmd3 = new SqlCommand("insert into Announcement(classpost_id, announcement_desc) values (@classpost_id, @announcement_desc)", cn);
            cmd3.Parameters.AddWithValue("@classpost_id", count);
            cmd3.Parameters.AddWithValue("@announcement_desc", annoucementdesc.Text);
            cmd3.ExecuteNonQuery();

            cn.Close();

            LoadPosts();

            annoucementdesc.Clear();
        }

        private void viewComment_Click(object sender, EventArgs e)
        {
            int postID = int.Parse(AComments.Text);
            Comment comment = new Comment(postID, stuID);
            comment.ShowDialog();
        }

        private void ClassMaterials_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void viewCMComment_Click(object sender, EventArgs e)
        {
            int postID = int.Parse(viewCMC.Text);
            Comment comment = new Comment(postID, stuID);
            comment.ShowDialog();
        }

        private void AssignComtBtn_Click(object sender, EventArgs e)
        {
            int postID = int.Parse(CommentAssign.Text);
            Comment comment = new Comment(postID, stuID);
            comment.ShowDialog();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            cn.Open();
            SqlCommand cmd2 = new SqlCommand("insert into submission (userid, classpost_id) values (@userid, @classpost_id)", cn);
            cmd2.Parameters.AddWithValue("@userid", stuID);
            cmd2.Parameters.AddWithValue("@classpost_id", int.Parse(submitted.Text));
            cmd2.ExecuteNonQuery();
            cn.Close();
            submitted.Clear();
        }

        private void SeeGradeBtn_Click(object sender, EventArgs e)
        {
            cn.Open();
            SqlCommand cmd2 = new SqlCommand("select grade from submission where userid=@userid and classpost_id=@classpost_id", cn);
            cmd2.Parameters.AddWithValue("@userid", stuID);
            cmd2.Parameters.AddWithValue("@classpost_id", int.Parse(seegrade.Text));
            dr = cmd2.ExecuteReader();
            dr.Read();

            if (dr.HasRows)
            {
                char grade =char.Parse(dr["grade"].ToString());
                MessageBox.Show(grade.ToString(), "Grade for Assignment", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("You have not submitted this assignment yet", "Grade for Assignment", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            cn.Close();

        }
    }
}
