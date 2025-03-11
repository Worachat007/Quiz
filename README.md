# class Diagrem
![image](https://github.com/user-attachments/assets/2c0b2e70-8e90-4f3f-89dc-877390647b10)








 
📌 อธิบายโค้ด Form1.cs
โค้ดนี้เป็นส่วนหนึ่งของโปรแกรม Windows Forms Application (WinForms) ที่เกี่ยวข้องกับระบบการจัดการนักเรียนและที่ปรึกษา (Advisor) ซึ่งสามารถเพิ่มข้อมูลนักเรียนและที่ปรึกษา รวมถึงแสดงนักเรียนที่ได้คะแนนสูงสุด (Top Student) ได้อัตโนมัติ

🔹 1. รายการเก็บข้อมูล
csharp
คัดลอก
แก้ไข
private List<Student> studentsList = new List<Student>();
private List<Advisor> advisorsList = new List<Advisor>();
ใช้ List<Student> เก็บข้อมูลของนักเรียนทั้งหมด
ใช้ List<Advisor> เก็บข้อมูลของที่ปรึกษาทั้งหมด
🔹 2. เมธอด Form1() (Constructor)
csharp
คัดลอก
แก้ไข
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
InitializeComponent(); → โหลด UI และควบคุมฟอร์ม
ตั้งค่าให้ช่องข้อมูลสามารถแก้ไขได้ (ReadOnly = false)
เรียกใช้ RefreshAdvisorComboBoxes(); เพื่ออัปเดต ComboBox ที่ใช้เลือกที่ปรึกษา
UpdateTopStudentDisplay(); → เรียกใช้ฟังก์ชันเพื่อแสดง Top Student ทันทีที่โปรแกรมเริ่มต้น
🔹 3. เมธอด Add_Advisor_Click (เพิ่มที่ปรึกษา)
csharp
คัดลอก
แก้ไข
private void Add_Advisor_Click(object sender, EventArgs e)
{
    if (string.IsNullOrEmpty(Ad_name.Text) || string.IsNullOrEmpty(Ad_major.Text))
    {
        MessageBox.Show("Please enter all required fields", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
    }

    Advisor newAdvisor = new Advisor(Ad_name.Text, Ad_major.Text);
    advisorsList.Add(newAdvisor);

    RefreshAdvisorComboBoxes();

    Ad_name.Clear();
    Ad_major.Clear();

    MessageBox.Show("Advisor added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
}
✨ การทำงาน
ตรวจสอบว่ากรอกข้อมูลครบหรือไม่
ถ้าครบแล้ว สร้าง Advisor ใหม่ และเพิ่มเข้าไปใน advisorsList
อัปเดต ComboBox ให้มีรายชื่อที่ปรึกษาใหม่
ล้างค่าช่องกรอกข้อมูล (Clear())
แจ้งเตือนว่าเพิ่มที่ปรึกษาสำเร็จ ✅
🔹 4. เมธอด RefreshAdvisorComboBoxes (อัปเดตรายชื่อที่ปรึกษา)
csharp
คัดลอก
แก้ไข
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
✨ การทำงาน
ล้างค่าทุกอย่างใน ComboBox ก่อน
วนลูปผ่าน advisorsList แล้วเพิ่มแต่ละที่ปรึกษาเข้าไปใน
st_Advisor → ใช้เลือกที่ปรึกษาตอนเพิ่มนักเรียน
Ad_students → ใช้เลือกที่ปรึกษาสำหรับดูข้อมูลนักเรียนที่ดีที่สุด
🔹 5. เมธอด Add_student_Click (เพิ่มนักเรียน)
csharp
คัดลอก
แก้ไข
private void Add_student_Click(object sender, EventArgs e)
{
    if (string.IsNullOrEmpty(st_id.Text) || string.IsNullOrEmpty(st_name.Text) ||
        string.IsNullOrEmpty(st_major.Text) || st_Advisor.SelectedItem == null)
    {
        MessageBox.Show("Please enter all required fields", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
    }

    double grade;
    if (!double.TryParse(st_get.Text, out grade) || grade < 0 || grade > 4.0)
    {
        MessageBox.Show("Please enter a valid grade between 0.0-4.0", "Invalid Grade", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
    }

    Student newStudent = new Student(st_id.Text, st_name.Text, st_major.Text, grade);
    studentsList.Add(newStudent);

    Advisor selectedAdvisor = (Advisor)st_Advisor.SelectedItem;
    selectedAdvisor.AddStudent(newStudent);

    st_id.Clear();
    st_name.Clear();
    st_major.Clear();
    st_get.Clear();
    st_Advisor.SelectedIndex = -1;

    // อัปเดตการแสดงผล Top Student
    UpdateTopStudentDisplay();

    MessageBox.Show("Student added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
}
✨ การทำงาน
ตรวจสอบว่ากรอกข้อมูลครบและเกรดอยู่ในช่วง 0.0 - 4.0 หรือไม่
ถ้าข้อมูลถูกต้อง
สร้างนักเรียนใหม่ (Student)
เพิ่มนักเรียนเข้า studentsList
เพิ่มนักเรียนเข้า Advisor ที่เลือก
ล้างค่าช่องกรอกข้อมูล
อัปเดตการแสดงผล Top Student (UpdateTopStudentDisplay()) 📊
แจ้งเตือนว่าเพิ่มนักเรียนสำเร็จ ✅
🔹 6. เมธอด UpdateTopStudentDisplay (แสดง Top Student อัตโนมัติ)
csharp
คัดลอก
แก้ไข
private void UpdateTopStudentDisplay()
{
    LFS_Top.Text = "";
    Score_top.Text = "";

    Student topStudent = studentsList.OrderByDescending(s => s.Grade).FirstOrDefault();

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
✨ การทำงาน
ล้างค่าของ LFS_Top และ Score_top
ค้นหานักเรียนที่มี คะแนนสูงสุด (OrderByDescending(s => s.Grade).FirstOrDefault())
ถ้าไม่มีนักเรียน → แสดง "No students available"
ถ้ามี → แสดงชื่อและคะแนนของนักเรียนที่เกรดสูงสุด อัตโนมัติ
🔹 7. เมธอด Ad_students_SelectedIndexChanged (เลือกที่ปรึกษาแล้วอัปเดต Top Student)
csharp
คัดลอก
แก้ไข
private void Ad_students_SelectedIndexChanged(object sender, EventArgs e)
{
    UpdateTopStudentDisplay();
}
✨ การทำงาน
เมื่อเลือกที่ปรึกษาจาก Ad_students → ระบบจะอัปเดต Top Student ใหม่อัตโนมัติ 🏆
🎯 สรุปฟีเจอร์ที่ปรับปรุง
Top Student อัปเดตอัตโนมัติ ไม่ต้องกดปุ่ม ✅
เพิ่มนักเรียนแล้ว Top Student เปลี่ยนทันที 📊
ไม่ต้องเลือกที่ปรึกษาใน Ad_students ก็แสดง Top Student ได้ 🎯
💡 ตอนนี้ระบบจะอัปเดตนักเรียนที่ได้เกรดสูงสุด โดยอัตโนมัติ ทุกครั้งที่เพิ่มข้อมูลใหม่ 🚀
