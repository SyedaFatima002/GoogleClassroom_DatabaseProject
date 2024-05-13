namespace googleClassroom
{
    partial class SignUp
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
            infopanel = new Panel();
            confirmpassword = new TextBox();
            password = new TextBox();
            username = new TextBox();
            email = new TextBox();
            name = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            button1 = new Button();
            SignUpTeacher = new Button();
            panel1 = new Panel();
            label1 = new Label();
            infopanel.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // infopanel
            // 
            infopanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            infopanel.BackColor = Color.Gainsboro;
            infopanel.Controls.Add(confirmpassword);
            infopanel.Controls.Add(password);
            infopanel.Controls.Add(username);
            infopanel.Controls.Add(email);
            infopanel.Controls.Add(name);
            infopanel.Controls.Add(label6);
            infopanel.Controls.Add(label5);
            infopanel.Controls.Add(label4);
            infopanel.Controls.Add(label3);
            infopanel.Controls.Add(label2);
            infopanel.Controls.Add(button1);
            infopanel.Controls.Add(SignUpTeacher);
            infopanel.Location = new Point(0, 84);
            infopanel.Name = "infopanel";
            infopanel.Size = new Size(549, 366);
            infopanel.TabIndex = 1;
            // 
            // confirmpassword
            // 
            confirmpassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            confirmpassword.Location = new Point(50, 245);
            confirmpassword.Name = "confirmpassword";
            confirmpassword.Size = new Size(439, 31);
            confirmpassword.TabIndex = 16;
            // 
            // password
            // 
            password.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            password.Location = new Point(50, 183);
            password.Name = "password";
            password.Size = new Size(439, 31);
            password.TabIndex = 15;
            password.WordWrap = false;
            // 
            // username
            // 
            username.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            username.Location = new Point(50, 107);
            username.Name = "username";
            username.Size = new Size(439, 31);
            username.TabIndex = 14;
            username.TextChanged += username_TextChanged;
            // 
            // email
            // 
            email.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            email.Location = new Point(277, 36);
            email.Name = "email";
            email.Size = new Size(212, 31);
            email.TabIndex = 13;
            // 
            // name
            // 
            name.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            name.Location = new Point(50, 36);
            name.Name = "name";
            name.Size = new Size(212, 31);
            name.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(53, 217);
            label6.Name = "label6";
            label6.Size = new Size(209, 25);
            label6.TabIndex = 11;
            label6.Text = "*Re-Enter your password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(50, 150);
            label5.Name = "label5";
            label5.Size = new Size(183, 25);
            label5.TabIndex = 10;
            label5.Text = "*Enter your password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(50, 79);
            label4.Name = "label4";
            label4.Size = new Size(183, 25);
            label4.TabIndex = 9;
            label4.Text = "*Enter your username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(277, 7);
            label3.Name = "label3";
            label3.Size = new Size(132, 25);
            label3.TabIndex = 8;
            label3.Text = "*Email Address";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 7);
            label2.Name = "label2";
            label2.Size = new Size(99, 25);
            label2.TabIndex = 7;
            label2.Text = "*Full Name";
            // 
            // button1
            // 
            button1.BackColor = Color.MediumSeaGreen;
            button1.ForeColor = Color.White;
            button1.Location = new Point(277, 295);
            button1.Name = "button1";
            button1.Size = new Size(176, 48);
            button1.TabIndex = 6;
            button1.Text = "Sign Up as Student";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // SignUpTeacher
            // 
            SignUpTeacher.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            SignUpTeacher.BackColor = Color.SeaGreen;
            SignUpTeacher.ForeColor = SystemColors.ButtonHighlight;
            SignUpTeacher.Location = new Point(86, 295);
            SignUpTeacher.Name = "SignUpTeacher";
            SignUpTeacher.Size = new Size(176, 48);
            SignUpTeacher.TabIndex = 5;
            SignUpTeacher.Text = "Sign Up as Teacher";
            SignUpTeacher.UseVisualStyleBackColor = false;
            SignUpTeacher.Click += SignUpTeacher_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.SeaGreen;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(549, 88);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(172, 41);
            label1.Name = "label1";
            label1.Size = new Size(177, 32);
            label1.TabIndex = 0;
            label1.Text = "Create Account";
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(549, 450);
            Controls.Add(panel1);
            Controls.Add(infopanel);
            Name = "SignUp";
            Text = "Google Classroom-SignUp";
            infopanel.ResumeLayout(false);
            infopanel.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel infopanel;
        private Button SignUpTeacher;
        private Button button1;
        private Panel panel1;
        private Label label1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox confirmpassword;
        private TextBox password;
        private TextBox username;
        private TextBox email;
        private TextBox name;
    }
}