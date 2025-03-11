namespace Quiz
{
    public partial class Form1 : Form
    {
        // ��¡���红����Źѡ���¹��з���֡��
        private List<Student> studentsList = new List<Student>();
        private List<Advisor> advisorsList = new List<Advisor>();

        public Form1()
        {
            InitializeComponent();

            // ��Ѻ����Ŵ����ͧ����ö��䢤����
            Ad_name.ReadOnly = false;
            Ad_major.ReadOnly = false;
            st_id.ReadOnly = false;

            // �ѻവ�����ŷ���֡��� ComboBox
            RefreshAdvisorComboBoxes();

            // ������鹡���ʴ��� Top Student
            UpdateTopStudentDisplay();
        }

        private void Add_Advisor_Click(object sender, EventArgs e)
        {
            // ��Ǩ�ͺ��ҡ�͡�����Ťú�������
            if (string.IsNullOrEmpty(Ad_name.Text) || string.IsNullOrEmpty(Ad_major.Text))
            {
                MessageBox.Show("Please enter all required fields", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ���ҧ����֡��������������������¡��
            Advisor newAdvisor = new Advisor(Ad_name.Text, Ad_major.Text);
            advisorsList.Add(newAdvisor);

            // �ѻവ��¡�÷���֡��� ComboBox
            RefreshAdvisorComboBoxes();

            // �������ͧ��͡������
            Ad_name.Clear();
            Ad_major.Clear();

            MessageBox.Show("Advisor added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // ���ʹ�ѻവ�����ŷ���֡��� ComboBox
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
            // ��Ǩ�ͺ��ҡ�͡�����Ťú�������
            if (string.IsNullOrEmpty(st_id.Text) || string.IsNullOrEmpty(st_name.Text) ||
                string.IsNullOrEmpty(st_major.Text) || st_Advisor.SelectedItem == null)
            {
                MessageBox.Show("Please enter all required fields", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ��Ǩ�ͺ����ô����͹����㹪�ǧ 0.0 - 4.0 �������
            double grade;
            if (!double.TryParse(st_get.Text, out grade) || grade < 0 || grade > 4.0)
            {
                MessageBox.Show("Please enter a valid grade between 0.0-4.0", "Invalid Grade", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ���ҧ�ѡ���¹������������������¡��
            Student newStudent = new Student(st_id.Text, st_name.Text, st_major.Text, grade);
            studentsList.Add(newStudent);

            // �����ѡ���¹����㹷���֡�ҷ�����͡
            Advisor selectedAdvisor = (Advisor)st_Advisor.SelectedItem;
            selectedAdvisor.AddStudent(newStudent);

            // �������ͧ��͡������
            st_id.Clear();
            st_name.Clear();
            st_major.Clear();
            st_get.Clear();
            st_Advisor.SelectedIndex = -1;

            // �ѻവ����ʴ��� Top Student
            UpdateTopStudentDisplay();

            MessageBox.Show("Student added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void UpdateTopStudentDisplay()
        {
            // ���絤�ҡ�͹�ʴ�������
            LFS_Top.Text = "";
            Score_top.Text = "";

            // �� Top Student �ҡ�ء����֡��
            Student topStudent = studentsList.OrderByDescending(s => s.Grade).FirstOrDefault();

            // �ʴ��Źѡ���¹������ô�٧�ش
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

        // ���� event handler ����Ѻ Ad_students.SelectedIndexChanged
        private void Ad_students_SelectedIndexChanged(object sender, EventArgs e)
        {
            // �ѻവ����ʴ��� Top Student
            UpdateTopStudentDisplay();
        }
    }
}