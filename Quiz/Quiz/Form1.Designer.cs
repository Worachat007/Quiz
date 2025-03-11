namespace Quiz
{
    partial class Form1
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
            Add_student = new Button();
            Add_Advisor = new Button();
            groupBox1 = new GroupBox();
            Ad_students = new ComboBox();
            Ad_major = new TextBox();
            Ad_name = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            groupBox2 = new GroupBox();
            st_major = new TextBox();
            st_Advisor = new ComboBox();
            st_get = new TextBox();
            st_name = new TextBox();
            st_id = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox3 = new GroupBox();
            Show_Top = new Button();
            Score_top = new TextBox();
            LFS_Top = new TextBox();
            label11 = new Label();
            label10 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // Add_student
            // 
            Add_student.Font = new Font("Lucida Bright", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Add_student.Location = new Point(140, 266);
            Add_student.Name = "Add_student";
            Add_student.Size = new Size(172, 52);
            Add_student.TabIndex = 21;
            Add_student.Text = "Add_Student";
            Add_student.UseVisualStyleBackColor = true;
            Add_student.Click += Add_student_Click;
            // 
            // Add_Advisor
            // 
            Add_Advisor.Location = new Point(59, 251);
            Add_Advisor.Name = "Add_Advisor";
            Add_Advisor.Size = new Size(241, 40);
            Add_Advisor.TabIndex = 22;
            Add_Advisor.Text = "Add_Advisor";
            Add_Advisor.UseVisualStyleBackColor = true;
            Add_Advisor.Click += Add_Advisor_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Ad_students);
            groupBox1.Controls.Add(Ad_major);
            groupBox1.Controls.Add(Ad_name);
            groupBox1.Controls.Add(Add_Advisor);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Font = new Font("Lucida Bright", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(50, 37);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(348, 333);
            groupBox1.TabIndex = 24;
            groupBox1.TabStop = false;
            groupBox1.Text = "Advisor";
            // 
            // Ad_students
            // 
            Ad_students.Font = new Font("Lucida Bright", 7.8F);
            Ad_students.FormattingEnabled = true;
            Ad_students.Location = new Point(148, 164);
            Ad_students.Name = "Ad_students";
            Ad_students.Size = new Size(185, 23);
            Ad_students.TabIndex = 25;
            // 
            // Ad_major
            // 
            Ad_major.CharacterCasing = CharacterCasing.Upper;
            Ad_major.Font = new Font("Lucida Bright", 7.8F);
            Ad_major.Location = new Point(144, 105);
            Ad_major.Name = "Ad_major";
            Ad_major.Size = new Size(189, 23);
            Ad_major.TabIndex = 21;
            // 
            // Ad_name
            // 
            Ad_name.Font = new Font("Lucida Bright", 7.8F);
            Ad_name.Location = new Point(144, 52);
            Ad_name.Name = "Ad_name";
            Ad_name.Size = new Size(189, 23);
            Ad_name.TabIndex = 20;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Lucida Bright", 7.8F);
            label9.Location = new Point(6, 167);
            label9.Name = "label9";
            label9.Size = new Size(108, 15);
            label9.TabIndex = 19;
            label9.Text = "List of students";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Lucida Bright", 7.8F);
            label8.Location = new Point(31, 105);
            label8.Name = "label8";
            label8.Size = new Size(43, 15);
            label8.TabIndex = 18;
            label8.Text = "Major";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Lucida Bright", 7.8F);
            label7.Location = new Point(31, 55);
            label7.Name = "label7";
            label7.Size = new Size(42, 15);
            label7.TabIndex = 17;
            label7.Text = "Name";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(st_major);
            groupBox2.Controls.Add(st_Advisor);
            groupBox2.Controls.Add(st_get);
            groupBox2.Controls.Add(Add_student);
            groupBox2.Controls.Add(st_name);
            groupBox2.Controls.Add(st_id);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Font = new Font("Lucida Bright", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(492, 37);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(343, 333);
            groupBox2.TabIndex = 25;
            groupBox2.TabStop = false;
            groupBox2.Text = "Student";
            // 
            // st_major
            // 
            st_major.CharacterCasing = CharacterCasing.Upper;
            st_major.Font = new Font("Lucida Bright", 7.8F);
            st_major.Location = new Point(146, 141);
            st_major.Name = "st_major";
            st_major.Size = new Size(166, 23);
            st_major.TabIndex = 26;
            // 
            // st_Advisor
            // 
            st_Advisor.Font = new Font("Lucida Bright", 7.8F);
            st_Advisor.FormattingEnabled = true;
            st_Advisor.Location = new Point(146, 183);
            st_Advisor.Name = "st_Advisor";
            st_Advisor.Size = new Size(166, 23);
            st_Advisor.TabIndex = 30;
            // 
            // st_get
            // 
            st_get.Font = new Font("Lucida Bright", 7.8F);
            st_get.Location = new Point(146, 232);
            st_get.Name = "st_get";
            st_get.Size = new Size(166, 23);
            st_get.TabIndex = 28;
            // 
            // st_name
            // 
            st_name.Font = new Font("Lucida Bright", 7.8F);
            st_name.Location = new Point(146, 96);
            st_name.Name = "st_name";
            st_name.Size = new Size(166, 23);
            st_name.TabIndex = 27;
            // 
            // st_id
            // 
            st_id.Font = new Font("Lucida Bright", 7.8F);
            st_id.Location = new Point(146, 50);
            st_id.Name = "st_id";
            st_id.Size = new Size(166, 23);
            st_id.TabIndex = 26;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Lucida Bright", 7.8F);
            label6.Location = new Point(48, 235);
            label6.Name = "label6";
            label6.Size = new Size(30, 15);
            label6.TabIndex = 25;
            label6.Text = "Get";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Lucida Bright", 7.8F);
            label5.Location = new Point(35, 186);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 24;
            label5.Text = "Advisor";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Lucida Bright", 7.8F);
            label4.Location = new Point(35, 141);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 23;
            label4.Text = "Major";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Bright", 7.8F);
            label3.Location = new Point(35, 96);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 22;
            label3.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Bright", 7.8F);
            label2.Location = new Point(45, 58);
            label2.Name = "label2";
            label2.Size = new Size(20, 15);
            label2.TabIndex = 21;
            label2.Text = "ID";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(Show_Top);
            groupBox3.Controls.Add(Score_top);
            groupBox3.Controls.Add(LFS_Top);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(label10);
            groupBox3.Font = new Font("Lucida Bright", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(947, 53);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(320, 333);
            groupBox3.TabIndex = 26;
            groupBox3.TabStop = false;
            groupBox3.Text = "Top_Sec";
            // 
            // Show_Top
            // 
            Show_Top.Location = new Point(49, 253);
            Show_Top.Name = "Show_Top";
            Show_Top.Size = new Size(207, 40);
            Show_Top.TabIndex = 26;
            Show_Top.Text = "Show_Top";
            Show_Top.UseVisualStyleBackColor = true;
            //Show_Top.Click += Show_Top_Click;
            // 
            // Score_top
            // 
            Score_top.Font = new Font("Lucida Bright", 7.8F);
            Score_top.Location = new Point(40, 192);
            Score_top.Name = "Score_top";
            Score_top.ReadOnly = true;
            Score_top.Size = new Size(241, 23);
            Score_top.TabIndex = 22;
            // 
            // LFS_Top
            // 
            LFS_Top.Font = new Font("Lucida Bright", 7.8F);
            LFS_Top.Location = new Point(40, 105);
            LFS_Top.Name = "LFS_Top";
            LFS_Top.ReadOnly = true;
            LFS_Top.Size = new Size(241, 23);
            LFS_Top.TabIndex = 21;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Lucida Bright", 7.8F);
            label11.Location = new Point(40, 154);
            label11.Name = "label11";
            label11.Size = new Size(74, 15);
            label11.TabIndex = 20;
            label11.Text = "Top_Score";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Lucida Bright", 7.8F);
            label10.Location = new Point(40, 68);
            label10.Name = "label10";
            label10.Size = new Size(108, 15);
            label10.TabIndex = 19;
            label10.Text = "List of students";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1380, 568);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button Add_student;
        private Button Add_Advisor;
        private GroupBox groupBox1;
        private ComboBox Ad_students;
        private TextBox Ad_major;
        private TextBox Ad_name;
        private Label label9;
        private Label label8;
        private Label label7;
        private GroupBox groupBox2;
        private ComboBox st_Advisor;
        private TextBox st_get;
        private TextBox st_name;
        private TextBox st_id;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private GroupBox groupBox3;
        private TextBox Score_top;
        private TextBox LFS_Top;
        private Label label11;
        private Label label10;
        private Button Show_Top;
        private TextBox st_major;
    }
}
