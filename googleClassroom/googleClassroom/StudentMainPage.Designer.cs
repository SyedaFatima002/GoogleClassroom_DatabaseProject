namespace googleClassroom
{
    partial class StudentMainPage
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
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            openClassBtn = new Button();
            openClass = new TextBox();
            remove = new Button();
            removeClass = new TextBox();
            StudentClasses = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            classCodeStudent = new TextBox();
            addClassStudent = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SeaGreen;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 84);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkSlateGray;
            button1.ForeColor = Color.White;
            button1.Location = new Point(660, 23);
            button1.Name = "button1";
            button1.Size = new Size(112, 41);
            button1.TabIndex = 2;
            button1.Text = "Log Out";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(422, 28);
            label2.Name = "label2";
            label2.Size = new Size(149, 28);
            label2.TabIndex = 1;
            label2.Text = "[Student Name]";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(23, 28);
            label1.Name = "label1";
            label1.Size = new Size(90, 32);
            label1.TabIndex = 0;
            label1.Text = "Classes";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gainsboro;
            panel2.Controls.Add(openClassBtn);
            panel2.Controls.Add(openClass);
            panel2.Controls.Add(remove);
            panel2.Controls.Add(removeClass);
            panel2.Controls.Add(StudentClasses);
            panel2.Controls.Add(classCodeStudent);
            panel2.Controls.Add(addClassStudent);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 84);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 422);
            panel2.TabIndex = 1;
            // 
            // openClassBtn
            // 
            openClassBtn.BackColor = Color.SeaGreen;
            openClassBtn.ForeColor = Color.White;
            openClassBtn.Location = new Point(347, 102);
            openClassBtn.Name = "openClassBtn";
            openClassBtn.Size = new Size(153, 42);
            openClassBtn.TabIndex = 6;
            openClassBtn.Text = "Open Class";
            openClassBtn.UseVisualStyleBackColor = false;
            openClassBtn.Click += openClassBtn_Click;
            // 
            // openClass
            // 
            openClass.ForeColor = Color.Gray;
            openClass.Location = new Point(23, 102);
            openClass.Name = "openClass";
            openClass.PlaceholderText = "*Enter Class Code to Open";
            openClass.Size = new Size(292, 31);
            openClass.TabIndex = 5;
            // 
            // remove
            // 
            remove.BackColor = Color.DarkRed;
            remove.ForeColor = Color.White;
            remove.Location = new Point(347, 58);
            remove.Name = "remove";
            remove.Size = new Size(153, 42);
            remove.TabIndex = 4;
            remove.Text = "Remove Class";
            remove.UseVisualStyleBackColor = false;
            remove.Click += remove_Click;
            // 
            // removeClass
            // 
            removeClass.ForeColor = Color.Gray;
            removeClass.Location = new Point(23, 58);
            removeClass.Name = "removeClass";
            removeClass.PlaceholderText = "*Enter Code of Class to Remove";
            removeClass.Size = new Size(292, 31);
            removeClass.TabIndex = 3;
            // 
            // StudentClasses
            // 
            StudentClasses.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            StudentClasses.GridLines = true;
            StudentClasses.Location = new Point(23, 162);
            StudentClasses.Name = "StudentClasses";
            StudentClasses.Size = new Size(749, 248);
            StudentClasses.TabIndex = 2;
            StudentClasses.UseCompatibleStateImageBehavior = false;
            StudentClasses.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Class Code";
            columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Class Name";
            columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Class Section";
            columnHeader3.Width = 200;
            // 
            // classCodeStudent
            // 
            classCodeStudent.ForeColor = Color.Gray;
            classCodeStudent.Location = new Point(23, 21);
            classCodeStudent.Name = "classCodeStudent";
            classCodeStudent.PlaceholderText = "*Enter Unique Class Code";
            classCodeStudent.Size = new Size(292, 31);
            classCodeStudent.TabIndex = 1;
            // 
            // addClassStudent
            // 
            addClassStudent.BackColor = Color.SeaGreen;
            addClassStudent.ForeColor = Color.White;
            addClassStudent.Location = new Point(347, 15);
            addClassStudent.Name = "addClassStudent";
            addClassStudent.Size = new Size(153, 42);
            addClassStudent.TabIndex = 0;
            addClassStudent.Text = "Add Class";
            addClassStudent.UseVisualStyleBackColor = false;
            addClassStudent.Click += addClassStudent_Click;
            // 
            // StudentMainPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 506);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "StudentMainPage";
            Text = "Google Classroom: Student Main Page";
            Load += StudentMainPage_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Button button1;
        private Panel panel2;
        private Button addClassStudent;
        private ListView StudentClasses;
        private TextBox classCodeStudent;
        private Button remove;
        private TextBox removeClass;
        private Button openClassBtn;
        private TextBox openClass;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
    }
}