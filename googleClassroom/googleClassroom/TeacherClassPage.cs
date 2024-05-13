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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace googleClassroom
{
    public partial class TeacherClassPage : Form
    {
        SqlConnection cn = new SqlConnection();
        DBConnector dbcon = new DBConnector();
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        SqlDataReader dr;
        private string classcode;
        private int id;

        public TeacherClassPage(string classcode, int teachID)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            this.KeyPreview = true;
            this.classcode = classcode;
            id = teachID;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
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
                    studentList.Items.Add(listitem);
                }
                //Loading students in class
                cn.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void TeacherClassPage_Load(object sender, EventArgs e)
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

            classnamelabel.Text = classname;
            //updating the label's name to class name

            LoadPosts();
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
            cmd2.Parameters.AddWithValue("@userid", id);
            cmd2.ExecuteNonQuery();

            SqlCommand cmd3 = new SqlCommand("insert into Announcement(classpost_id, announcement_desc) values (@classpost_id, @announcement_desc)", cn);
            cmd3.Parameters.AddWithValue("@classpost_id", count);
            cmd3.Parameters.AddWithValue("@announcement_desc", annoucementdesc.Text);
            cmd3.ExecuteNonQuery();

            cn.Close();

            LoadPosts();

            annoucementdesc.Clear();
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

        private void viewComment_Click(object sender, EventArgs e)
        {
            int postID = int.Parse(AComments.Text);
            Comment comment = new Comment(postID, id);
            comment.ShowDialog();
        }

        private void addCM_Click(object sender, EventArgs e)
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
            ClassMaterials.Items.Clear();
            SqlCommand cmd2 = new SqlCommand("insert into classpost(classpost_id, class_code, date_issued, userid) values (@classpost_id, @class_code, GETDATE(), @userid)", cn);
            cmd2.Parameters.AddWithValue("@class_code", classcode);
            cmd2.Parameters.AddWithValue("@classpost_id", count);
            cmd2.Parameters.AddWithValue("@userid", id);
            cmd2.ExecuteNonQuery();

            SqlCommand cmd3 = new SqlCommand("insert into ClassMaterial(classpost_id, material_desc) values (@classpost_id, @material_desc)", cn);
            cmd3.Parameters.AddWithValue("@classpost_id", count);
            cmd3.Parameters.AddWithValue("@material_desc", addMaterial.Text);
            cmd3.ExecuteNonQuery();

            cn.Close();

            LoadPosts();

            addMaterial.Clear();
        }

        private void removeCMbtn_Click(object sender, EventArgs e)
        {
            ClassMaterials.Items.Clear();

            cn.Open();
            SqlCommand cmd2 = new SqlCommand("delete from ClassMaterial where classpost_id=@classpost_id", cn);
            cmd2.Parameters.AddWithValue("@classpost_id", removeCM.Text);
            cmd2.ExecuteNonQuery();

            SqlCommand cmd3 = new SqlCommand("delete from classpost where classpost_id=@classpost_id", cn);
            cmd3.Parameters.AddWithValue("@classpost_id", removeCM.Text);
            cmd3.ExecuteNonQuery();


            cn.Close();

            LoadPosts();
            removeCM.Clear();
        }

        private void viewCMComment_Click(object sender, EventArgs e)
        {
            int postID = int.Parse(viewCMC.Text);
            Comment comment = new Comment(postID, id);
            comment.ShowDialog();
        }

        private void addAss_Click(object sender, EventArgs e)
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
            AssignmentList.Items.Clear();
            SqlCommand cmd2 = new SqlCommand("insert into classpost(classpost_id, class_code, date_issued, userid) values (@classpost_id, @class_code, GETDATE(), @userid)", cn);
            cmd2.Parameters.AddWithValue("@class_code", classcode);
            cmd2.Parameters.AddWithValue("@classpost_id", count);
            cmd2.Parameters.AddWithValue("@userid", id);
            cmd2.ExecuteNonQuery();

            SqlCommand cmd3 = new SqlCommand("insert into Assignment(classpost_id, assignment_desc, due_date) values (@classpost_id, @assignment_desc, @due_date)", cn);
            cmd3.Parameters.AddWithValue("@classpost_id", count);
            cmd3.Parameters.AddWithValue("@assignment_desc", assignmentDesc.Text);
            cmd3.Parameters.AddWithValue("@due_date", assignDate.Text);
            cmd3.ExecuteNonQuery();

            cn.Close();

            assignmentDesc.Clear();
            assignDate.Clear();

            LoadPosts();
        }

        private void assignRemove_Click(object sender, EventArgs e)
        {
            AssignmentList.Items.Clear();

            cn.Open();
            SqlCommand cmd2 = new SqlCommand("delete from Assignment where classpost_id=@classpost_id", cn);
            cmd2.Parameters.AddWithValue("@classpost_id", removeAssign.Text);
            cmd2.ExecuteNonQuery();

            SqlCommand cmd3 = new SqlCommand("delete from classpost where classpost_id=@classpost_id", cn);
            cmd3.Parameters.AddWithValue("@classpost_id", removeAssign.Text);
            cmd3.ExecuteNonQuery();


            cn.Close();

            LoadPosts();
            removeAssign.Clear();
        }

        private void AssignComtBtn_Click(object sender, EventArgs e)
        {
            int postID = int.Parse(CommentAssign.Text);
            Comment comment = new Comment(postID, id);
            comment.ShowDialog();
        }

        private void counter_Click(object sender, EventArgs e)
        {
            string count = "";
            using (cmd = new SqlCommand("select dbo.getSubmittedStatus(@postid)", cn))
            {
                cn.Open();
                cmd.Parameters.AddWithValue("@postid", int.Parse(submitted.Text));
                count = cmd.ExecuteScalar().ToString();

                cn.Close();
            }

            string output = count;
            output += " students have submitted";

            MessageBox.Show(output, "Total Submissions", MessageBoxButtons.OK, MessageBoxIcon.Information);
            submitted.Clear();
        }

        private void SeeGrades_Click(object sender, EventArgs e)
        {
            cn.Open();
            cmd = new SqlCommand("getGradeList", cn);
            cmd.Parameters.AddWithValue("@postid", postid.Text);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da3 = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da3.Fill(dt);


            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                ListViewItem listitem = new ListViewItem(dr["fullname"].ToString());
                listitem.SubItems.Add(dr["grade"].ToString());
                gradeView.Items.Add(listitem);
            }
            cn.Close();
        }

        private void AssignmentList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gradingBtn_Click(object sender, EventArgs e)
        {
            Grading grade=new Grading(int.Parse(grading.Text));
            grade.ShowDialog();
        }
    }
}
