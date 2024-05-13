namespace googleClassroom
{
    partial class StudentClassPage
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
            button1 = new Button();
            className = new Label();
            panel2 = new Panel();
            classTabs = new TabControl();
            clasaTabs = new TabPage();
            panel3 = new Panel();
            announcements = new ListView();
            ID = new ColumnHeader();
            assdesc = new ColumnHeader();
            date = new ColumnHeader();
            user = new ColumnHeader();
            viewComment = new Button();
            remove = new Button();
            make = new Button();
            AComments = new TextBox();
            removeannouncement = new TextBox();
            annoucementdesc = new TextBox();
            tabPage2 = new TabPage();
            panel4 = new Panel();
            ClassMaterials = new ListView();
            classmaterialID = new ColumnHeader();
            Cm = new ColumnHeader();
            dateposted = new ColumnHeader();
            poster = new ColumnHeader();
            viewCMComment = new Button();
            viewCMC = new TextBox();
            tabPage1 = new TabPage();
            panel5 = new Panel();
            submit = new Button();
            SeeGradeBtn = new Button();
            seegrade = new TextBox();
            submitted = new TextBox();
            AssignmentList = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            AssignComtBtn = new Button();
            CommentAssign = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            classTabs.SuspendLayout();
            clasaTabs.SuspendLayout();
            panel3.SuspendLayout();
            tabPage2.SuspendLayout();
            panel4.SuspendLayout();
            tabPage1.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SeaGreen;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(className);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(970, 84);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkSlateGray;
            button1.ForeColor = Color.White;
            button1.Location = new Point(821, 17);
            button1.Name = "button1";
            button1.Size = new Size(112, 43);
            button1.TabIndex = 1;
            button1.Text = "Return";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // className
            // 
            className.AutoSize = true;
            className.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            className.ForeColor = Color.White;
            className.Location = new Point(30, 28);
            className.Name = "className";
            className.Size = new Size(152, 32);
            className.TabIndex = 0;
            className.Text = "[Class Name]";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gainsboro;
            panel2.Controls.Add(classTabs);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 84);
            panel2.Name = "panel2";
            panel2.Size = new Size(970, 617);
            panel2.TabIndex = 1;
            // 
            // classTabs
            // 
            classTabs.Controls.Add(clasaTabs);
            classTabs.Controls.Add(tabPage2);
            classTabs.Controls.Add(tabPage1);
            classTabs.Dock = DockStyle.Fill;
            classTabs.Location = new Point(0, 0);
            classTabs.Name = "classTabs";
            classTabs.SelectedIndex = 0;
            classTabs.Size = new Size(970, 617);
            classTabs.TabIndex = 0;
            // 
            // clasaTabs
            // 
            clasaTabs.Controls.Add(panel3);
            clasaTabs.Location = new Point(4, 34);
            clasaTabs.Name = "clasaTabs";
            clasaTabs.Padding = new Padding(3);
            clasaTabs.Size = new Size(962, 579);
            clasaTabs.TabIndex = 0;
            clasaTabs.Text = "Annoucement Page";
            clasaTabs.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Gainsboro;
            panel3.Controls.Add(announcements);
            panel3.Controls.Add(viewComment);
            panel3.Controls.Add(remove);
            panel3.Controls.Add(make);
            panel3.Controls.Add(AComments);
            panel3.Controls.Add(removeannouncement);
            panel3.Controls.Add(annoucementdesc);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(956, 573);
            panel3.TabIndex = 0;
            // 
            // announcements
            // 
            announcements.Columns.AddRange(new ColumnHeader[] { ID, assdesc, date, user });
            announcements.GridLines = true;
            announcements.Location = new Point(37, 190);
            announcements.Name = "announcements";
            announcements.Size = new Size(889, 345);
            announcements.TabIndex = 13;
            announcements.UseCompatibleStateImageBehavior = false;
            announcements.View = View.Details;
            // 
            // ID
            // 
            ID.Text = "Ann. ID";
            ID.Width = 100;
            // 
            // assdesc
            // 
            assdesc.Text = "Annoucement";
            assdesc.Width = 450;
            // 
            // date
            // 
            date.Text = "Date";
            date.Width = 150;
            // 
            // user
            // 
            user.Text = "Name";
            user.Width = 200;
            // 
            // viewComment
            // 
            viewComment.BackColor = Color.SteelBlue;
            viewComment.ForeColor = Color.White;
            viewComment.Location = new Point(730, 113);
            viewComment.Name = "viewComment";
            viewComment.Size = new Size(196, 38);
            viewComment.TabIndex = 12;
            viewComment.Text = "View Comments";
            viewComment.UseVisualStyleBackColor = false;
            viewComment.Click += viewComment_Click;
            // 
            // remove
            // 
            remove.BackColor = Color.DarkRed;
            remove.ForeColor = Color.White;
            remove.Location = new Point(730, 70);
            remove.Name = "remove";
            remove.Size = new Size(196, 37);
            remove.TabIndex = 11;
            remove.Text = "Remove";
            remove.UseVisualStyleBackColor = false;
            remove.Click += remove_Click;
            // 
            // make
            // 
            make.BackColor = Color.SeaGreen;
            make.ForeColor = Color.White;
            make.Location = new Point(730, 24);
            make.Name = "make";
            make.Size = new Size(196, 40);
            make.TabIndex = 10;
            make.Text = "Make Annoucement";
            make.UseVisualStyleBackColor = false;
            make.Click += make_Click;
            // 
            // AComments
            // 
            AComments.Location = new Point(37, 117);
            AComments.Name = "AComments";
            AComments.PlaceholderText = "*Enter Assignment ID to View Comments";
            AComments.Size = new Size(687, 31);
            AComments.TabIndex = 9;
            // 
            // removeannouncement
            // 
            removeannouncement.Location = new Point(37, 73);
            removeannouncement.Name = "removeannouncement";
            removeannouncement.PlaceholderText = "*Enter Assignment ID you want to remove";
            removeannouncement.Size = new Size(687, 31);
            removeannouncement.TabIndex = 8;
            // 
            // annoucementdesc
            // 
            annoucementdesc.Location = new Point(37, 24);
            annoucementdesc.Multiline = true;
            annoucementdesc.Name = "annoucementdesc";
            annoucementdesc.PlaceholderText = "*Add Annoucement";
            annoucementdesc.Size = new Size(687, 40);
            annoucementdesc.TabIndex = 7;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(panel4);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(962, 579);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Class Material";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Gainsboro;
            panel4.Controls.Add(ClassMaterials);
            panel4.Controls.Add(viewCMComment);
            panel4.Controls.Add(viewCMC);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(3, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(956, 573);
            panel4.TabIndex = 0;
            // 
            // ClassMaterials
            // 
            ClassMaterials.Columns.AddRange(new ColumnHeader[] { classmaterialID, Cm, dateposted, poster });
            ClassMaterials.GridLines = true;
            ClassMaterials.Location = new Point(23, 86);
            ClassMaterials.Name = "ClassMaterials";
            ClassMaterials.Size = new Size(904, 460);
            ClassMaterials.TabIndex = 16;
            ClassMaterials.UseCompatibleStateImageBehavior = false;
            ClassMaterials.View = View.Details;
            ClassMaterials.SelectedIndexChanged += ClassMaterials_SelectedIndexChanged;
            // 
            // classmaterialID
            // 
            classmaterialID.Text = "CM ID";
            classmaterialID.Width = 100;
            // 
            // Cm
            // 
            Cm.Text = "Description";
            Cm.Width = 450;
            // 
            // dateposted
            // 
            dateposted.Text = "Date";
            dateposted.Width = 150;
            // 
            // poster
            // 
            poster.Text = "Name";
            poster.Width = 200;
            // 
            // viewCMComment
            // 
            viewCMComment.BackColor = Color.SteelBlue;
            viewCMComment.ForeColor = Color.White;
            viewCMComment.Location = new Point(716, 23);
            viewCMComment.Name = "viewCMComment";
            viewCMComment.Size = new Size(196, 38);
            viewCMComment.TabIndex = 15;
            viewCMComment.Text = "View Comments";
            viewCMComment.UseVisualStyleBackColor = false;
            viewCMComment.Click += viewCMComment_Click;
            // 
            // viewCMC
            // 
            viewCMC.Location = new Point(23, 27);
            viewCMC.Name = "viewCMC";
            viewCMC.PlaceholderText = "*Enter Class Material ID to View Comments";
            viewCMC.Size = new Size(687, 31);
            viewCMC.TabIndex = 14;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(panel5);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Size = new Size(962, 579);
            tabPage1.TabIndex = 2;
            tabPage1.Text = "Assignments";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Gainsboro;
            panel5.Controls.Add(submit);
            panel5.Controls.Add(SeeGradeBtn);
            panel5.Controls.Add(seegrade);
            panel5.Controls.Add(submitted);
            panel5.Controls.Add(AssignmentList);
            panel5.Controls.Add(AssignComtBtn);
            panel5.Controls.Add(CommentAssign);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(962, 579);
            panel5.TabIndex = 0;
            // 
            // submit
            // 
            submit.BackColor = Color.SeaGreen;
            submit.ForeColor = Color.White;
            submit.Location = new Point(733, 99);
            submit.Name = "submit";
            submit.Size = new Size(196, 38);
            submit.TabIndex = 22;
            submit.Text = "Submit";
            submit.UseVisualStyleBackColor = false;
            submit.Click += submit_Click;
            // 
            // SeeGradeBtn
            // 
            SeeGradeBtn.BackColor = Color.SeaGreen;
            SeeGradeBtn.ForeColor = Color.White;
            SeeGradeBtn.Location = new Point(733, 146);
            SeeGradeBtn.Name = "SeeGradeBtn";
            SeeGradeBtn.Size = new Size(196, 38);
            SeeGradeBtn.TabIndex = 21;
            SeeGradeBtn.Text = "View Grade";
            SeeGradeBtn.UseVisualStyleBackColor = false;
            SeeGradeBtn.Click += SeeGradeBtn_Click;
            // 
            // seegrade
            // 
            seegrade.Location = new Point(37, 150);
            seegrade.Name = "seegrade";
            seegrade.PlaceholderText = "*Enter Assignment ID to View Grade";
            seegrade.Size = new Size(687, 31);
            seegrade.TabIndex = 20;
            // 
            // submitted
            // 
            submitted.Location = new Point(37, 102);
            submitted.Name = "submitted";
            submitted.PlaceholderText = "*Enter Assignment ID You want to submit";
            submitted.Size = new Size(687, 31);
            submitted.TabIndex = 19;
            // 
            // AssignmentList
            // 
            AssignmentList.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader5, columnHeader4 });
            AssignmentList.GridLines = true;
            AssignmentList.Location = new Point(37, 199);
            AssignmentList.Name = "AssignmentList";
            AssignmentList.Size = new Size(889, 311);
            AssignmentList.TabIndex = 18;
            AssignmentList.UseCompatibleStateImageBehavior = false;
            AssignmentList.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Ass. ID";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Assignment";
            columnHeader2.Width = 300;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Due Date";
            columnHeader3.Width = 150;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Date Issued";
            columnHeader5.Width = 120;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Name";
            columnHeader4.Width = 100;
            // 
            // AssignComtBtn
            // 
            AssignComtBtn.BackColor = Color.SteelBlue;
            AssignComtBtn.ForeColor = Color.White;
            AssignComtBtn.Location = new Point(730, 48);
            AssignComtBtn.Name = "AssignComtBtn";
            AssignComtBtn.Size = new Size(196, 38);
            AssignComtBtn.TabIndex = 17;
            AssignComtBtn.Text = "View Comments";
            AssignComtBtn.UseVisualStyleBackColor = false;
            AssignComtBtn.Click += AssignComtBtn_Click;
            // 
            // CommentAssign
            // 
            CommentAssign.Location = new Point(37, 52);
            CommentAssign.Name = "CommentAssign";
            CommentAssign.PlaceholderText = "*Enter Assignment ID to View Comments";
            CommentAssign.Size = new Size(687, 31);
            CommentAssign.TabIndex = 16;
            // 
            // StudentClassPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(970, 701);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "StudentClassPage";
            Text = "Google Classroom: Class";
            Load += StudentClassPage_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            classTabs.ResumeLayout(false);
            clasaTabs.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            tabPage2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            tabPage1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label className;
        private Button button1;
        private Panel panel2;
        private TabControl classTabs;
        private TabPage clasaTabs;
        private TabPage tabPage2;
        private TabPage tabPage1;
        private Panel panel3;
        private ListView announcements;
        private ColumnHeader ID;
        private ColumnHeader assdesc;
        private ColumnHeader date;
        private ColumnHeader user;
        private Button viewComment;
        private Button remove;
        private Button make;
        private TextBox AComments;
        private TextBox removeannouncement;
        private TextBox annoucementdesc;
        private Panel panel4;
        private ListView ClassMaterials;
        private ColumnHeader classmaterialID;
        private ColumnHeader Cm;
        private ColumnHeader dateposted;
        private ColumnHeader poster;
        private Button viewCMComment;
        private TextBox viewCMC;
        private Panel panel5;
        private ListView AssignmentList;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader4;
        private Button AssignComtBtn;
        private TextBox CommentAssign;
        private Button submit;
        private Button SeeGradeBtn;
        private TextBox seegrade;
        private TextBox submitted;
    }
}