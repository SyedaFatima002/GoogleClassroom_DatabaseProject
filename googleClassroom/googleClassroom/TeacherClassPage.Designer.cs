namespace googleClassroom
{
    partial class TeacherClassPage
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
            titlePanel = new Panel();
            button1 = new Button();
            classnamelabel = new Label();
            tabs = new Panel();
            Class = new TabControl();
            Announcement = new TabPage();
            panel1 = new Panel();
            announcements = new ListView();
            ID = new ColumnHeader();
            assdesc = new ColumnHeader();
            date = new ColumnHeader();
            user = new ColumnHeader();
            viewComment = new Button();
            remove = new Button();
            makeAssign = new Button();
            AComments = new TextBox();
            removeannouncement = new TextBox();
            annoucementdesc = new TextBox();
            classMaterial = new TabPage();
            panel2 = new Panel();
            ClassMaterials = new ListView();
            classmaterialID = new ColumnHeader();
            Cm = new ColumnHeader();
            dateposted = new ColumnHeader();
            poster = new ColumnHeader();
            viewCMComment = new Button();
            removeCMbtn = new Button();
            addCM = new Button();
            viewCMC = new TextBox();
            removeCM = new TextBox();
            addMaterial = new TextBox();
            assignment = new TabPage();
            panel3 = new Panel();
            counter = new Button();
            submitted = new TextBox();
            assignDate = new TextBox();
            gradingBtn = new Button();
            grading = new TextBox();
            AssignmentList = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            AssignComtBtn = new Button();
            assignRemove = new Button();
            addAss = new Button();
            CommentAssign = new TextBox();
            removeAssign = new TextBox();
            assignmentDesc = new TextBox();
            getStudentList = new TabPage();
            panel4 = new Panel();
            gradeView = new ListView();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            SeeGrades = new Button();
            postid = new TextBox();
            label2 = new Label();
            label1 = new Label();
            studentList = new ListView();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            titlePanel.SuspendLayout();
            tabs.SuspendLayout();
            Class.SuspendLayout();
            Announcement.SuspendLayout();
            panel1.SuspendLayout();
            classMaterial.SuspendLayout();
            panel2.SuspendLayout();
            assignment.SuspendLayout();
            panel3.SuspendLayout();
            getStudentList.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // titlePanel
            // 
            titlePanel.BackColor = Color.SeaGreen;
            titlePanel.Controls.Add(button1);
            titlePanel.Controls.Add(classnamelabel);
            titlePanel.Dock = DockStyle.Top;
            titlePanel.Location = new Point(0, 0);
            titlePanel.Name = "titlePanel";
            titlePanel.Size = new Size(947, 84);
            titlePanel.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkGreen;
            button1.ForeColor = Color.White;
            button1.Location = new Point(807, 24);
            button1.Name = "button1";
            button1.Size = new Size(112, 47);
            button1.TabIndex = 1;
            button1.Text = "Return";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // classnamelabel
            // 
            classnamelabel.AutoSize = true;
            classnamelabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            classnamelabel.ForeColor = Color.White;
            classnamelabel.Location = new Point(4, 24);
            classnamelabel.Name = "classnamelabel";
            classnamelabel.Size = new Size(152, 32);
            classnamelabel.TabIndex = 0;
            classnamelabel.Text = "[Class Name]";
            // 
            // tabs
            // 
            tabs.BackColor = Color.Gainsboro;
            tabs.Controls.Add(Class);
            tabs.Dock = DockStyle.Fill;
            tabs.Location = new Point(0, 84);
            tabs.Name = "tabs";
            tabs.Size = new Size(947, 659);
            tabs.TabIndex = 1;
            // 
            // Class
            // 
            Class.Controls.Add(Announcement);
            Class.Controls.Add(classMaterial);
            Class.Controls.Add(assignment);
            Class.Controls.Add(getStudentList);
            Class.Dock = DockStyle.Fill;
            Class.Location = new Point(0, 0);
            Class.Name = "Class";
            Class.SelectedIndex = 0;
            Class.Size = new Size(947, 659);
            Class.TabIndex = 0;
            // 
            // Announcement
            // 
            Announcement.BackColor = Color.LightGray;
            Announcement.Controls.Add(panel1);
            Announcement.Location = new Point(4, 34);
            Announcement.Name = "Announcement";
            Announcement.Size = new Size(939, 621);
            Announcement.TabIndex = 0;
            Announcement.Text = "Announcement Page";
            // 
            // panel1
            // 
            panel1.Controls.Add(announcements);
            panel1.Controls.Add(viewComment);
            panel1.Controls.Add(remove);
            panel1.Controls.Add(makeAssign);
            panel1.Controls.Add(AComments);
            panel1.Controls.Add(removeannouncement);
            panel1.Controls.Add(annoucementdesc);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(939, 621);
            panel1.TabIndex = 0;
            // 
            // announcements
            // 
            announcements.Columns.AddRange(new ColumnHeader[] { ID, assdesc, date, user });
            announcements.GridLines = true;
            announcements.Location = new Point(24, 182);
            announcements.Name = "announcements";
            announcements.Size = new Size(889, 345);
            announcements.TabIndex = 6;
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
            viewComment.Location = new Point(717, 105);
            viewComment.Name = "viewComment";
            viewComment.Size = new Size(196, 38);
            viewComment.TabIndex = 5;
            viewComment.Text = "View Comments";
            viewComment.UseVisualStyleBackColor = false;
            viewComment.Click += viewComment_Click;
            // 
            // remove
            // 
            remove.BackColor = Color.DarkRed;
            remove.ForeColor = Color.White;
            remove.Location = new Point(717, 62);
            remove.Name = "remove";
            remove.Size = new Size(196, 37);
            remove.TabIndex = 4;
            remove.Text = "Remove";
            remove.UseVisualStyleBackColor = false;
            remove.Click += remove_Click;
            // 
            // makeAssign
            // 
            makeAssign.BackColor = Color.SeaGreen;
            makeAssign.ForeColor = Color.White;
            makeAssign.Location = new Point(717, 16);
            makeAssign.Name = "makeAssign";
            makeAssign.Size = new Size(196, 40);
            makeAssign.TabIndex = 3;
            makeAssign.Text = "Make Annoucement";
            makeAssign.UseVisualStyleBackColor = false;
            makeAssign.Click += make_Click;
            // 
            // AComments
            // 
            AComments.Location = new Point(24, 109);
            AComments.Name = "AComments";
            AComments.PlaceholderText = "*Enter Assignment ID to View Comments";
            AComments.Size = new Size(687, 31);
            AComments.TabIndex = 2;
            // 
            // removeannouncement
            // 
            removeannouncement.Location = new Point(24, 65);
            removeannouncement.Name = "removeannouncement";
            removeannouncement.PlaceholderText = "*Enter Assignment ID you want to remove";
            removeannouncement.Size = new Size(687, 31);
            removeannouncement.TabIndex = 1;
            // 
            // annoucementdesc
            // 
            annoucementdesc.Location = new Point(24, 16);
            annoucementdesc.Multiline = true;
            annoucementdesc.Name = "annoucementdesc";
            annoucementdesc.PlaceholderText = "*Add Annoucement";
            annoucementdesc.Size = new Size(687, 40);
            annoucementdesc.TabIndex = 0;
            // 
            // classMaterial
            // 
            classMaterial.Controls.Add(panel2);
            classMaterial.Location = new Point(4, 34);
            classMaterial.Name = "classMaterial";
            classMaterial.Size = new Size(939, 621);
            classMaterial.TabIndex = 1;
            classMaterial.Text = "Class Materials";
            classMaterial.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gainsboro;
            panel2.Controls.Add(ClassMaterials);
            panel2.Controls.Add(viewCMComment);
            panel2.Controls.Add(removeCMbtn);
            panel2.Controls.Add(addCM);
            panel2.Controls.Add(viewCMC);
            panel2.Controls.Add(removeCM);
            panel2.Controls.Add(addMaterial);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(939, 621);
            panel2.TabIndex = 0;
            // 
            // ClassMaterials
            // 
            ClassMaterials.Columns.AddRange(new ColumnHeader[] { classmaterialID, Cm, dateposted, poster });
            ClassMaterials.GridLines = true;
            ClassMaterials.Location = new Point(18, 169);
            ClassMaterials.Name = "ClassMaterials";
            ClassMaterials.Size = new Size(904, 296);
            ClassMaterials.TabIndex = 13;
            ClassMaterials.UseCompatibleStateImageBehavior = false;
            ClassMaterials.View = View.Details;
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
            viewCMComment.Location = new Point(711, 106);
            viewCMComment.Name = "viewCMComment";
            viewCMComment.Size = new Size(196, 38);
            viewCMComment.TabIndex = 12;
            viewCMComment.Text = "View Comments";
            viewCMComment.UseVisualStyleBackColor = false;
            viewCMComment.Click += viewCMComment_Click;
            // 
            // removeCMbtn
            // 
            removeCMbtn.BackColor = Color.DarkRed;
            removeCMbtn.ForeColor = Color.White;
            removeCMbtn.Location = new Point(711, 63);
            removeCMbtn.Name = "removeCMbtn";
            removeCMbtn.Size = new Size(196, 37);
            removeCMbtn.TabIndex = 11;
            removeCMbtn.Text = "Remove";
            removeCMbtn.UseVisualStyleBackColor = false;
            removeCMbtn.Click += removeCMbtn_Click;
            // 
            // addCM
            // 
            addCM.BackColor = Color.SeaGreen;
            addCM.ForeColor = Color.White;
            addCM.Location = new Point(711, 17);
            addCM.Name = "addCM";
            addCM.Size = new Size(196, 40);
            addCM.TabIndex = 10;
            addCM.Text = "Add Class Material";
            addCM.UseVisualStyleBackColor = false;
            addCM.Click += addCM_Click;
            // 
            // viewCMC
            // 
            viewCMC.Location = new Point(18, 110);
            viewCMC.Name = "viewCMC";
            viewCMC.PlaceholderText = "*Enter Class Material ID to View Comments";
            viewCMC.Size = new Size(687, 31);
            viewCMC.TabIndex = 9;
            // 
            // removeCM
            // 
            removeCM.Location = new Point(18, 69);
            removeCM.Name = "removeCM";
            removeCM.PlaceholderText = "*Enter Class Material ID you want to remove";
            removeCM.Size = new Size(687, 31);
            removeCM.TabIndex = 8;
            // 
            // addMaterial
            // 
            addMaterial.Location = new Point(18, 17);
            addMaterial.Multiline = true;
            addMaterial.Name = "addMaterial";
            addMaterial.PlaceholderText = "*Add Class Material";
            addMaterial.Size = new Size(687, 40);
            addMaterial.TabIndex = 7;
            // 
            // assignment
            // 
            assignment.Controls.Add(panel3);
            assignment.Location = new Point(4, 34);
            assignment.Name = "assignment";
            assignment.Size = new Size(939, 621);
            assignment.TabIndex = 2;
            assignment.Text = "Assignments";
            assignment.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Gainsboro;
            panel3.Controls.Add(counter);
            panel3.Controls.Add(submitted);
            panel3.Controls.Add(assignDate);
            panel3.Controls.Add(gradingBtn);
            panel3.Controls.Add(grading);
            panel3.Controls.Add(AssignmentList);
            panel3.Controls.Add(AssignComtBtn);
            panel3.Controls.Add(assignRemove);
            panel3.Controls.Add(addAss);
            panel3.Controls.Add(CommentAssign);
            panel3.Controls.Add(removeAssign);
            panel3.Controls.Add(assignmentDesc);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(939, 621);
            panel3.TabIndex = 0;
            // 
            // counter
            // 
            counter.BackColor = Color.Black;
            counter.ForeColor = Color.White;
            counter.Location = new Point(719, 220);
            counter.Name = "counter";
            counter.Size = new Size(196, 38);
            counter.TabIndex = 20;
            counter.Text = "Check Submissions";
            counter.UseVisualStyleBackColor = false;
            counter.Click += counter_Click;
            // 
            // submitted
            // 
            submitted.Location = new Point(26, 220);
            submitted.Name = "submitted";
            submitted.PlaceholderText = "*Enter Assignment ID to see submitted status";
            submitted.Size = new Size(687, 31);
            submitted.TabIndex = 19;
            // 
            // assignDate
            // 
            assignDate.Location = new Point(486, 27);
            assignDate.Name = "assignDate";
            assignDate.PlaceholderText = "*Add Due Date (yy-mm-dd)";
            assignDate.Size = new Size(227, 31);
            assignDate.TabIndex = 18;
            // 
            // gradingBtn
            // 
            gradingBtn.BackColor = Color.Goldenrod;
            gradingBtn.ForeColor = Color.White;
            gradingBtn.Location = new Point(719, 165);
            gradingBtn.Name = "gradingBtn";
            gradingBtn.Size = new Size(196, 38);
            gradingBtn.TabIndex = 17;
            gradingBtn.Text = "Grade Assignment";
            gradingBtn.UseVisualStyleBackColor = false;
            gradingBtn.Click += gradingBtn_Click;
            // 
            // grading
            // 
            grading.Location = new Point(26, 169);
            grading.Name = "grading";
            grading.PlaceholderText = "*Enter Assignment ID to Grade Assignment";
            grading.Size = new Size(687, 31);
            grading.TabIndex = 16;
            // 
            // AssignmentList
            // 
            AssignmentList.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader5, columnHeader4 });
            AssignmentList.GridLines = true;
            AssignmentList.Location = new Point(26, 283);
            AssignmentList.Name = "AssignmentList";
            AssignmentList.Size = new Size(889, 311);
            AssignmentList.TabIndex = 15;
            AssignmentList.UseCompatibleStateImageBehavior = false;
            AssignmentList.View = View.Details;
            AssignmentList.SelectedIndexChanged += AssignmentList_SelectedIndexChanged;
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
            AssignComtBtn.Location = new Point(719, 111);
            AssignComtBtn.Name = "AssignComtBtn";
            AssignComtBtn.Size = new Size(196, 38);
            AssignComtBtn.TabIndex = 14;
            AssignComtBtn.Text = "View Comments";
            AssignComtBtn.UseVisualStyleBackColor = false;
            AssignComtBtn.Click += AssignComtBtn_Click;
            // 
            // assignRemove
            // 
            assignRemove.BackColor = Color.DarkRed;
            assignRemove.ForeColor = Color.White;
            assignRemove.Location = new Point(719, 68);
            assignRemove.Name = "assignRemove";
            assignRemove.Size = new Size(196, 37);
            assignRemove.TabIndex = 13;
            assignRemove.Text = "Remove";
            assignRemove.UseVisualStyleBackColor = false;
            assignRemove.Click += assignRemove_Click;
            // 
            // addAss
            // 
            addAss.BackColor = Color.SeaGreen;
            addAss.ForeColor = Color.White;
            addAss.Location = new Point(719, 22);
            addAss.Name = "addAss";
            addAss.Size = new Size(196, 40);
            addAss.TabIndex = 12;
            addAss.Text = "Add Assignment";
            addAss.UseVisualStyleBackColor = false;
            addAss.Click += addAss_Click;
            // 
            // CommentAssign
            // 
            CommentAssign.Location = new Point(26, 115);
            CommentAssign.Name = "CommentAssign";
            CommentAssign.PlaceholderText = "*Enter Assignment ID to View Comments";
            CommentAssign.Size = new Size(687, 31);
            CommentAssign.TabIndex = 11;
            // 
            // removeAssign
            // 
            removeAssign.Location = new Point(26, 71);
            removeAssign.Name = "removeAssign";
            removeAssign.PlaceholderText = "*Enter Assignment ID you want to remove";
            removeAssign.Size = new Size(687, 31);
            removeAssign.TabIndex = 10;
            // 
            // assignmentDesc
            // 
            assignmentDesc.Location = new Point(26, 22);
            assignmentDesc.Multiline = true;
            assignmentDesc.Name = "assignmentDesc";
            assignmentDesc.PlaceholderText = "*Add Assignment";
            assignmentDesc.Size = new Size(454, 40);
            assignmentDesc.TabIndex = 9;
            // 
            // getStudentList
            // 
            getStudentList.Controls.Add(panel4);
            getStudentList.Location = new Point(4, 34);
            getStudentList.Name = "getStudentList";
            getStudentList.Padding = new Padding(3);
            getStudentList.Size = new Size(939, 621);
            getStudentList.TabIndex = 3;
            getStudentList.Text = "Student List and Grades";
            getStudentList.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Gainsboro;
            panel4.Controls.Add(gradeView);
            panel4.Controls.Add(SeeGrades);
            panel4.Controls.Add(postid);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(label1);
            panel4.Controls.Add(studentList);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(3, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(933, 615);
            panel4.TabIndex = 0;
            // 
            // gradeView
            // 
            gradeView.Columns.AddRange(new ColumnHeader[] { columnHeader8, columnHeader9 });
            gradeView.GridLines = true;
            gradeView.Location = new Point(556, 89);
            gradeView.Name = "gradeView";
            gradeView.Size = new Size(259, 511);
            gradeView.TabIndex = 5;
            gradeView.UseCompatibleStateImageBehavior = false;
            gradeView.View = View.Details;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Student Name";
            columnHeader8.Width = 150;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Grade";
            columnHeader9.Width = 100;
            // 
            // SeeGrades
            // 
            SeeGrades.BackColor = Color.SteelBlue;
            SeeGrades.ForeColor = Color.White;
            SeeGrades.Location = new Point(780, 49);
            SeeGrades.Name = "SeeGrades";
            SeeGrades.Size = new Size(130, 34);
            SeeGrades.TabIndex = 4;
            SeeGrades.Text = "See Grades";
            SeeGrades.UseVisualStyleBackColor = false;
            SeeGrades.Click += SeeGrades_Click;
            // 
            // postid
            // 
            postid.Location = new Point(478, 51);
            postid.Name = "postid";
            postid.PlaceholderText = "*Enter Assignment ID To Get Grades";
            postid.Size = new Size(296, 31);
            postid.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(478, 20);
            label2.Name = "label2";
            label2.Size = new Size(99, 28);
            label2.TabIndex = 2;
            label2.Text = "Grade List";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(22, 20);
            label1.Name = "label1";
            label1.Size = new Size(114, 28);
            label1.TabIndex = 1;
            label1.Text = "Student List";
            // 
            // studentList
            // 
            studentList.Columns.AddRange(new ColumnHeader[] { columnHeader6, columnHeader7 });
            studentList.GridLines = true;
            studentList.Location = new Point(22, 84);
            studentList.Name = "studentList";
            studentList.Size = new Size(404, 515);
            studentList.TabIndex = 0;
            studentList.UseCompatibleStateImageBehavior = false;
            studentList.View = View.Details;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Student Name";
            columnHeader6.Width = 200;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Student Email";
            columnHeader7.Width = 200;
            // 
            // TeacherClassPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(947, 743);
            Controls.Add(tabs);
            Controls.Add(titlePanel);
            Name = "TeacherClassPage";
            Text = "Google Classroom- Teacher: Class";
            Load += TeacherClassPage_Load;
            titlePanel.ResumeLayout(false);
            titlePanel.PerformLayout();
            tabs.ResumeLayout(false);
            Class.ResumeLayout(false);
            Announcement.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            classMaterial.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            assignment.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            getStudentList.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel titlePanel;
        private Label classnamelabel;
        private Button button1;
        private Panel tabs;
        private TabControl Class;
        private TabPage Announcement;
        private TabPage classMaterial;
        private TabPage assignment;
        private TabPage getStudentList;
        private Panel panel1;
        private Button viewComment;
        private Button remove;
        private Button makeAssign;
        private TextBox AComments;
        private TextBox removeannouncement;
        private TextBox annoucementdesc;
        private ListView announcements;
        private ColumnHeader ID;
        private ColumnHeader assdesc;
        private ColumnHeader date;
        private ColumnHeader user;
        private Panel panel2;
        private ListView ClassMaterials;
        private ColumnHeader classmaterialID;
        private ColumnHeader Cm;
        private ColumnHeader dateposted;
        private ColumnHeader poster;
        private Button viewCMComment;
        private Button removeCMbtn;
        private Button addCM;
        private TextBox viewCMC;
        private TextBox removeCM;
        private TextBox addMaterial;
        private Panel panel3;
        private Button gradingBtn;
        private TextBox grading;
        private ListView AssignmentList;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Button AssignComtBtn;
        private Button assignRemove;
        private Button addAss;
        private TextBox CommentAssign;
        private TextBox removeAssign;
        private TextBox assignmentDesc;
        private ColumnHeader columnHeader5;
        private TextBox assignDate;
        private Button counter;
        private TextBox submitted;
        private Panel panel4;
        private ListView studentList;
        private Label label1;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ListView gradeView;
        private Button SeeGrades;
        private TextBox postid;
        private Label label2;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
    }
}