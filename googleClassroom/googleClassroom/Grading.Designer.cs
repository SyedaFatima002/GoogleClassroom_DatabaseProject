namespace googleClassroom
{
    partial class Grading
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
            label1 = new Label();
            panel2 = new Panel();
            gradeBtn = new Button();
            grade = new TextBox();
            stuID = new TextBox();
            gradeSheet = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SeaGreen;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 94);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(304, 32);
            label1.Name = "label1";
            label1.Size = new Size(166, 32);
            label1.TabIndex = 0;
            label1.Text = "Grading Sheet";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gainsboro;
            panel2.Controls.Add(gradeBtn);
            panel2.Controls.Add(grade);
            panel2.Controls.Add(stuID);
            panel2.Controls.Add(gradeSheet);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 94);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 356);
            panel2.TabIndex = 1;
            // 
            // gradeBtn
            // 
            gradeBtn.BackColor = Color.LightSeaGreen;
            gradeBtn.ForeColor = Color.White;
            gradeBtn.Location = new Point(410, 189);
            gradeBtn.Name = "gradeBtn";
            gradeBtn.Size = new Size(153, 45);
            gradeBtn.TabIndex = 3;
            gradeBtn.Text = "Grade";
            gradeBtn.UseVisualStyleBackColor = false;
            gradeBtn.Click += gradeBtn_Click;
            // 
            // grade
            // 
            grade.Location = new Point(410, 134);
            grade.Name = "grade";
            grade.PlaceholderText = "*Enter Grade";
            grade.Size = new Size(248, 31);
            grade.TabIndex = 2;
            // 
            // stuID
            // 
            stuID.Location = new Point(410, 83);
            stuID.Name = "stuID";
            stuID.PlaceholderText = "*Enter Student ID";
            stuID.Size = new Size(248, 31);
            stuID.TabIndex = 1;
            // 
            // gradeSheet
            // 
            gradeSheet.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            gradeSheet.GridLines = true;
            gradeSheet.Location = new Point(30, 21);
            gradeSheet.Name = "gradeSheet";
            gradeSheet.Size = new Size(352, 323);
            gradeSheet.TabIndex = 0;
            gradeSheet.UseCompatibleStateImageBehavior = false;
            gradeSheet.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Student ID";
            columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Name";
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Grade";
            columnHeader3.Width = 100;
            // 
            // Grading
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Grading";
            Text = "Grading";
            Load += Grading_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private ListView gradeSheet;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private TextBox stuID;
        private Button gradeBtn;
        private TextBox grade;
    }
}