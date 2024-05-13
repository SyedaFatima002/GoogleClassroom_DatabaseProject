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

namespace googleClassroom
{
    public partial class Comment : Form
    {
        SqlConnection cn = new SqlConnection();
        DBConnector dbcon = new DBConnector();
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        SqlDataReader dr;
        private int postid;
        private int userid;

        public Comment(int classpost, int userid)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            this.KeyPreview = true;
            postid = classpost;
            this.userid = userid;
        }

        private void ReturnBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LoadComment()
        {

            try
            {
                cn.Open();
                cmd = new SqlCommand("displayComment", cn);
                cmd.Parameters.AddWithValue("@postid", postid);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);


                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow dr = dt.Rows[i];
                    ListViewItem listitem = new ListViewItem(dr["comment_id"].ToString());
                    listitem.SubItems.Add(dr["comment_desc"].ToString());
                    listitem.SubItems.Add(dr["fullname"].ToString());
                    comments.Items.Add(listitem);
                }
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Comment_Load(object sender, EventArgs e)
        {
            LoadComment();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string count = "";
            int commentid = 0;
            using (cmd = new SqlCommand("select dbo.getCommentCount()", cn))
            {
                cn.Open();
                count = cmd.ExecuteScalar().ToString();
                int temp = int.Parse(count);
                commentid = temp + 1;
                count = commentid.ToString();

                cn.Close();
            }

            cn.Open();
            comments.Items.Clear();
            SqlCommand cmd2 = new SqlCommand("insert into Comment(comment_id, comment_desc, userid, classpost_id) values (@comment_id, @comment_desc, @userid, @classpost_id)", cn);
            cmd2.Parameters.AddWithValue("@comment_id", commentid);
            cmd2.Parameters.AddWithValue("@comment_desc", addComment.Text);
            cmd2.Parameters.AddWithValue("@userid", userid);
            cmd2.Parameters.AddWithValue("@classpost_id", postid);
            cmd2.ExecuteNonQuery();


            cn.Close();

            LoadComment();

            addComment.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            comments.Items.Clear();

            cn.Open();
            SqlCommand cmd2 = new SqlCommand("delete from Comment where comment_id=@comment_id", cn);
            cmd2.Parameters.AddWithValue("@comment_id", removeC.Text);
            cmd2.ExecuteNonQuery();

            
            cn.Close();

            LoadComment();
            removeC.Clear();
        }
    }
}
