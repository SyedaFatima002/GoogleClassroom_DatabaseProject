namespace googleClassroom
{
    partial class Comment
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            ReturnBtn = new Button();
            label1 = new Label();
            panel2 = new Panel();
            button2 = new Button();
            button1 = new Button();
            removeC = new TextBox();
            addComment = new TextBox();
            comments = new ListView();
            id = new ColumnHeader();
            comm = new ColumnHeader();
            user = new ColumnHeader();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SeaGreen;
            panel1.Controls.Add(ReturnBtn);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(825, 89);
            panel1.TabIndex = 0;
            // 
            // ReturnBtn
            // 
            ReturnBtn.BackColor = Color.DarkGreen;
            ReturnBtn.ForeColor = Color.White;
            ReturnBtn.Location = new Point(644, 30);
            ReturnBtn.Name = "ReturnBtn";
            ReturnBtn.Size = new Size(112, 40);
            ReturnBtn.TabIndex = 1;
            ReturnBtn.Text = "Return";
            ReturnBtn.UseVisualStyleBackColor = false;
            ReturnBtn.Click += ReturnBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(317, 29);
            label1.Name = "label1";
            label1.Size = new Size(130, 32);
            label1.TabIndex = 0;
            label1.Text = "Comments";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gainsboro;
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(removeC);
            panel2.Controls.Add(addComment);
            panel2.Controls.Add(comments);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 89);
            panel2.Name = "panel2";
            panel2.Size = new Size(825, 361);
            panel2.TabIndex = 1;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkRed;
            button2.ForeColor = Color.White;
            button2.Location = new Point(517, 71);
            button2.Name = "button2";
            button2.Size = new Size(204, 34);
            button2.TabIndex = 4;
            button2.Text = "Remove Commment";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.SeaGreen;
            button1.ForeColor = Color.White;
            button1.Location = new Point(511, 19);
            button1.Name = "button1";
            button1.Size = new Size(210, 34);
            button1.TabIndex = 3;
            button1.Text = "Add Comment";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // removeC
            // 
            removeC.Location = new Point(41, 69);
            removeC.Name = "removeC";
            removeC.PlaceholderText = "*Enter ID of Comment you want to delete";
            removeC.Size = new Size(437, 31);
            removeC.TabIndex = 2;
            // 
            // addComment
            // 
            addComment.Location = new Point(41, 16);
            addComment.Name = "addComment";
            addComment.PlaceholderText = "*Enter your Comment";
            addComment.Size = new Size(437, 31);
            addComment.TabIndex = 1;
            // 
            // comments
            // 
            comments.Columns.AddRange(new ColumnHeader[] { id, comm, user });
            comments.GridLines = true;
            comments.Location = new Point(41, 122);
            comments.Name = "comments";
            comments.Size = new Size(737, 201);
            comments.TabIndex = 0;
            comments.UseCompatibleStateImageBehavior = false;
            comments.View = View.Details;
            // 
            // id
            // 
            id.Text = "CommentID";
            id.Width = 110;
            // 
            // comm
            // 
            comm.Text = "Comment";
            comm.Width = 300;
            // 
            // user
            // 
            user.Text = "Commenter Name";
            user.Width = 200;
            // 
            // Comment
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(825, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Comment";
            Text = "Comment";
            Load += Comment_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button ReturnBtn;
        private Label label1;
        private Panel panel2;
        private ListView comments;
        private ColumnHeader id;
        private Button button2;
        private Button button1;
        private TextBox removeC;
        private TextBox addComment;
        private ColumnHeader comm;
        private ColumnHeader user;
    }
}