namespace googleClassroom
{
    partial class TeacherMainPage
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
            titlepanel = new Panel();
            teachername = new Label();
            logOut = new Button();
            label1 = new Label();
            panel1 = new Panel();
            remove = new TextBox();
            class_code = new TextBox();
            openClass = new Button();
            removeBtn = new Button();
            label2 = new Label();
            classes = new ListView();
            code = new ColumnHeader();
            created = new ColumnHeader();
            classSections = new ColumnHeader();
            classCode = new TextBox();
            ClassSection = new TextBox();
            className = new TextBox();
            addClass = new Button();
            titlepanel.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // titlepanel
            // 
            titlepanel.BackColor = Color.SeaGreen;
            titlepanel.Controls.Add(teachername);
            titlepanel.Controls.Add(logOut);
            titlepanel.Controls.Add(label1);
            titlepanel.Dock = DockStyle.Top;
            titlepanel.Location = new Point(0, 0);
            titlepanel.Name = "titlepanel";
            titlepanel.Size = new Size(800, 84);
            titlepanel.TabIndex = 0;
            // 
            // teachername
            // 
            teachername.AutoSize = true;
            teachername.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            teachername.ForeColor = Color.White;
            teachername.Location = new Point(442, 28);
            teachername.Name = "teachername";
            teachername.Size = new Size(135, 28);
            teachername.TabIndex = 3;
            teachername.Text = "Teacher portal";
            teachername.Click += teachername_Click;
            // 
            // logOut
            // 
            logOut.BackColor = Color.DarkSlateGray;
            logOut.ForeColor = Color.AliceBlue;
            logOut.Location = new Point(682, 19);
            logOut.Name = "logOut";
            logOut.Size = new Size(94, 46);
            logOut.TabIndex = 2;
            logOut.Text = "Log Out";
            logOut.UseVisualStyleBackColor = false;
            logOut.Click += button1_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(28, 24);
            label1.Name = "label1";
            label1.Size = new Size(90, 32);
            label1.TabIndex = 0;
            label1.Text = "Classes";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.Controls.Add(remove);
            panel1.Controls.Add(class_code);
            panel1.Controls.Add(openClass);
            panel1.Controls.Add(removeBtn);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(classes);
            panel1.Controls.Add(classCode);
            panel1.Controls.Add(ClassSection);
            panel1.Controls.Add(className);
            panel1.Controls.Add(addClass);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 84);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 516);
            panel1.TabIndex = 1;
            // 
            // remove
            // 
            remove.Location = new Point(578, 52);
            remove.Name = "remove";
            remove.PlaceholderText = "*Enter Class Code";
            remove.Size = new Size(198, 31);
            remove.TabIndex = 12;
            // 
            // class_code
            // 
            class_code.Location = new Point(539, 308);
            class_code.Name = "class_code";
            class_code.PlaceholderText = "*Enter Unique Class Code";
            class_code.Size = new Size(237, 31);
            class_code.TabIndex = 11;
            // 
            // openClass
            // 
            openClass.BackColor = Color.SeaGreen;
            openClass.ForeColor = Color.White;
            openClass.Location = new Point(556, 354);
            openClass.Name = "openClass";
            openClass.Size = new Size(198, 46);
            openClass.TabIndex = 10;
            openClass.Text = "Open Class";
            openClass.UseVisualStyleBackColor = false;
            openClass.Click += openClass_Click;
            // 
            // removeBtn
            // 
            removeBtn.BackColor = Color.Firebrick;
            removeBtn.ForeColor = Color.White;
            removeBtn.Location = new Point(578, 94);
            removeBtn.Name = "removeBtn";
            removeBtn.Size = new Size(198, 44);
            removeBtn.TabIndex = 9;
            removeBtn.Text = "Remove Class";
            removeBtn.UseVisualStyleBackColor = false;
            removeBtn.Click += removeBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 14);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 7;
            label2.Text = "Add Class";
            // 
            // classes
            // 
            classes.Activation = ItemActivation.OneClick;
            classes.Columns.AddRange(new ColumnHeader[] { code, created, classSections });
            classes.FullRowSelect = true;
            classes.GridLines = true;
            classes.HotTracking = true;
            classes.HoverSelection = true;
            classes.Location = new Point(28, 236);
            classes.MultiSelect = false;
            classes.Name = "classes";
            classes.Size = new Size(496, 268);
            classes.TabIndex = 5;
            classes.UseCompatibleStateImageBehavior = false;
            classes.View = View.Details;
            classes.SelectedIndexChanged += classes_SelectedIndexChanged;
            // 
            // code
            // 
            code.Text = "Class_Code";
            code.Width = 150;
            // 
            // created
            // 
            created.Text = "Class_Names";
            created.Width = 200;
            // 
            // classSections
            // 
            classSections.Text = "Class_Section";
            classSections.Width = 140;
            // 
            // classCode
            // 
            classCode.ForeColor = Color.Gray;
            classCode.Location = new Point(28, 136);
            classCode.Name = "classCode";
            classCode.PlaceholderText = "*Unique Class Code";
            classCode.Size = new Size(351, 31);
            classCode.TabIndex = 4;
            // 
            // ClassSection
            // 
            ClassSection.ForeColor = Color.Gray;
            ClassSection.Location = new Point(28, 94);
            ClassSection.Name = "ClassSection";
            ClassSection.PlaceholderText = "*Class Section";
            ClassSection.Size = new Size(351, 31);
            ClassSection.TabIndex = 3;
            // 
            // className
            // 
            className.ForeColor = Color.Gray;
            className.Location = new Point(28, 52);
            className.Name = "className";
            className.PlaceholderText = "*Class Name";
            className.Size = new Size(351, 31);
            className.TabIndex = 2;
            // 
            // addClass
            // 
            addClass.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            addClass.BackColor = Color.SeaGreen;
            addClass.ForeColor = Color.WhiteSmoke;
            addClass.Location = new Point(28, 176);
            addClass.Name = "addClass";
            addClass.Size = new Size(163, 45);
            addClass.TabIndex = 0;
            addClass.Text = "Add Class";
            addClass.UseVisualStyleBackColor = false;
            addClass.Click += addClass_Click;
            // 
            // TeacherMainPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 600);
            Controls.Add(panel1);
            Controls.Add(titlepanel);
            Name = "TeacherMainPage";
            Text = "Google Classroom-Teacher Main Page";
            Load += TeacherMainPage_Load_1;
            titlepanel.ResumeLayout(false);
            titlepanel.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel titlepanel;
        private Label label1;
        private Button logOut;
        private Panel panel1;
        private Button addClass;
        private TextBox classCode;
        private TextBox ClassSection;
        private TextBox className;
        private Label teachername;
        private ListView classes;
        private ColumnHeader code;
        private ColumnHeader created;
        private ColumnHeader classSections;
        private Button removeBtn;
        private Label label2;
        private TextBox cc;
        private Button openClass;
        private TextBox class_code;
        private TextBox remove;
    }
}