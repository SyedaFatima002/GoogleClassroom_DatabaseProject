namespace googleClassroom
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            titlepanel = new Panel();
            loginlabel = new Label();
            titlelabel = new Label();
            loginpanel = new Panel();
            SignUplinkLabel = new LinkLabel();
            label1 = new Label();
            Loginbutton = new Button();
            password = new TextBox();
            username = new TextBox();
            label2 = new Label();
            label3 = new Label();
            titlepanel.SuspendLayout();
            loginpanel.SuspendLayout();
            SuspendLayout();
            // 
            // titlepanel
            // 
            titlepanel.BackColor = Color.SeaGreen;
            titlepanel.Controls.Add(loginlabel);
            titlepanel.Controls.Add(titlelabel);
            titlepanel.Dock = DockStyle.Top;
            titlepanel.Location = new Point(0, 0);
            titlepanel.Name = "titlepanel";
            titlepanel.Size = new Size(548, 170);
            titlepanel.TabIndex = 0;
            // 
            // loginlabel
            // 
            loginlabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            loginlabel.AutoSize = true;
            loginlabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            loginlabel.ForeColor = Color.White;
            loginlabel.Location = new Point(223, 104);
            loginlabel.Name = "loginlabel";
            loginlabel.Size = new Size(85, 38);
            loginlabel.TabIndex = 1;
            loginlabel.Text = "Login";
            // 
            // titlelabel
            // 
            titlelabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            titlelabel.AutoSize = true;
            titlelabel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            titlelabel.ForeColor = Color.White;
            titlelabel.Location = new Point(45, 40);
            titlelabel.Name = "titlelabel";
            titlelabel.Size = new Size(463, 45);
            titlelabel.TabIndex = 0;
            titlelabel.Text = "Welcome to Google Classroom";
            titlelabel.Click += titlelabel_Click;
            // 
            // loginpanel
            // 
            loginpanel.BackColor = Color.Gainsboro;
            loginpanel.Controls.Add(label3);
            loginpanel.Controls.Add(label2);
            loginpanel.Controls.Add(SignUplinkLabel);
            loginpanel.Controls.Add(label1);
            loginpanel.Controls.Add(Loginbutton);
            loginpanel.Controls.Add(password);
            loginpanel.Controls.Add(username);
            loginpanel.Dock = DockStyle.Fill;
            loginpanel.Location = new Point(0, 170);
            loginpanel.Name = "loginpanel";
            loginpanel.Size = new Size(548, 280);
            loginpanel.TabIndex = 1;
            // 
            // SignUplinkLabel
            // 
            SignUplinkLabel.AutoSize = true;
            SignUplinkLabel.Location = new Point(316, 215);
            SignUplinkLabel.Name = "SignUplinkLabel";
            SignUplinkLabel.Size = new Size(80, 25);
            SignUplinkLabel.TabIndex = 4;
            SignUplinkLabel.TabStop = true;
            SignUplinkLabel.Text = " Sign Up";
            SignUplinkLabel.LinkClicked += SignUplinkLabel_LinkClicked;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(127, 215);
            label1.Name = "label1";
            label1.Size = new Size(197, 25);
            label1.TabIndex = 3;
            label1.Text = "Don't have an account?";
            // 
            // Loginbutton
            // 
            Loginbutton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Loginbutton.BackColor = Color.MediumSeaGreen;
            Loginbutton.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Loginbutton.ForeColor = Color.White;
            Loginbutton.Location = new Point(186, 158);
            Loginbutton.Name = "Loginbutton";
            Loginbutton.Size = new Size(157, 48);
            Loginbutton.TabIndex = 2;
            Loginbutton.Text = "Login";
            Loginbutton.UseVisualStyleBackColor = false;
            Loginbutton.Click += Loginbutton_Click;
            // 
            // password
            // 
            password.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            password.BorderStyle = BorderStyle.None;
            password.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            password.ForeColor = Color.Gray;
            password.Location = new Point(127, 117);
            password.Name = "password";
            password.Size = new Size(269, 27);
            password.TabIndex = 1;
            // 
            // username
            // 
            username.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            username.BorderStyle = BorderStyle.None;
            username.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            username.ForeColor = Color.Gray;
            username.Location = new Point(127, 43);
            username.Name = "username";
            username.Size = new Size(269, 27);
            username.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(127, 12);
            label2.Name = "label2";
            label2.Size = new Size(103, 28);
            label2.TabIndex = 5;
            label2.Text = "Username:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(127, 80);
            label3.Name = "label3";
            label3.Size = new Size(93, 28);
            label3.TabIndex = 6;
            label3.Text = "Password";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(548, 450);
            Controls.Add(loginpanel);
            Controls.Add(titlepanel);
            Name = "Login";
            Text = "Google Classroom-Login";
            Load += Login_Load;
            titlepanel.ResumeLayout(false);
            titlepanel.PerformLayout();
            loginpanel.ResumeLayout(false);
            loginpanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel titlepanel;
        private Label titlelabel;
        private Label loginlabel;
        private Panel loginpanel;
        private TextBox username;
        private TextBox password;
        private Button Loginbutton;
        private LinkLabel SignUplinkLabel;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}