namespace Quiz
{
    public partial class Form1 : Form
    {
        // รายการเก็บข้อมูลนักเรียนและที่ปรึกษา
        private List<Student> studentsList = new List<Student>();
        private List<Advisor> advisorsList = new List<Advisor>();

        public Form1()
        {
            InitializeComponent();

            // ปรับให้ฟิลด์ที่ต้องสามารถแก้ไขค่าได้
            Ad_name.ReadOnly = false;
            Ad_major.ReadOnly = false;
            st_id.ReadOnly = false;

            // อัปเดตข้อมูลที่ปรึกษาใน ComboBox
            RefreshAdvisorComboBoxes();

            // เริ่มต้นการแสดงผล Top Student
            UpdateTopStudentDisplay();
        }

        private void Add_Advisor_Click(object sender, EventArgs e)
        {
            // ตรวจสอบว่ากรอกข้อมูลครบหรือไม่
            if (string.IsNullOrEmpty(Ad_name.Text) || string.IsNullOrEmpty(Ad_major.Text))
            {
                MessageBox.Show("Please enter all required fields", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // สร้างที่ปรึกษาใหม่และเพิ่มเข้าไปในรายการ
            Advisor newAdvisor = new Advisor(Ad_name.Text, Ad_major.Text);
            advisorsList.Add(newAdvisor);

            // อัปเดตรายการที่ปรึกษาใน ComboBox
            RefreshAdvisorComboBoxes();

            // เคลียร์ช่องกรอกข้อมูล
            Ad_name.Clear();
            Ad_major.Clear();

            MessageBox.Show("Advisor added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // เมธอดอัปเดตข้อมูลที่ปรึกษาใน ComboBox
        private void RefreshAdvisorComboBoxes()
        {
            st_Advisor.Items.Clear();
            Ad_students.Items.Clear();

            foreach (Advisor advisor in advisorsList)
            {
                st_Advisor.Items.Add(advisor);
                Ad_students.Items.Add(advisor);
            }
        }

        private void Add_student_Click(object sender, EventArgs e)
        {
            // ตรวจสอบว่ากรอกข้อมูลครบหรือไม่
            if (string.IsNullOrEmpty(st_id.Text) || string.IsNullOrEmpty(st_name.Text) ||
                string.IsNullOrEmpty(st_major.Text) || st_Advisor.SelectedItem == null)
            {
                MessageBox.Show("Please enter all required fields", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ตรวจสอบว่าเกรดที่ป้อนอยู่ในช่วง 0.0 - 4.0 หรือไม่
            double grade;
            if (!double.TryParse(st_get.Text, out grade) || grade < 0 || grade > 4.0)
            {
                MessageBox.Show("Please enter a valid grade between 0.0-4.0", "Invalid Grade", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // สร้างนักเรียนใหม่และเพิ่มเข้าไปในรายการ
            Student newStudent = new Student(st_id.Text, st_name.Text, st_major.Text, grade);
            studentsList.Add(newStudent);

            // เพิ่มนักเรียนเข้าไปในที่ปรึกษาที่เลือก
            Advisor selectedAdvisor = (Advisor)st_Advisor.SelectedItem;
            selectedAdvisor.AddStudent(newStudent);

            // เคลียร์ช่องกรอกข้อมูล
            st_id.Clear();
            st_name.Clear();
            st_major.Clear();
            st_get.Clear();
            st_Advisor.SelectedIndex = -1;

            // อัปเดตการแสดงผล Top Student
            UpdateTopStudentDisplay();

            MessageBox.Show("Student added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void UpdateTopStudentDisplay()
        {
            // รีเซ็ตค่าก่อนแสดงผลใหม่
            LFS_Top.Text = "";
            Score_top.Text = "";

            // หา Top Student จากทุกที่ปรึกษา
            Student topStudent = studentsList.OrderByDescending(s => s.Grade).FirstOrDefault();

            // แสดงผลนักเรียนที่มีเกรดสูงสุด
            if (topStudent == null)
            {
                LFS_Top.Text = "No students available";
                Score_top.Text = "-";
            }
            else
            {
                LFS_Top.Text = $"{topStudent.StudentID} - {topStudent.Name}";
                Score_top.Text = topStudent.Grade.ToString("F2");
            }
        }

        // เพิ่ม event handler สำหรับ Ad_students.SelectedIndexChanged
        private void Ad_students_SelectedIndexChanged(object sender, EventArgs e)
        {
            // อัปเดตการแสดงผล Top Student
            UpdateTopStudentDisplay();
        }
    }
}