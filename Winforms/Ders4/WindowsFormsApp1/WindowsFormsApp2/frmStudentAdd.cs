using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class frmStudentAdd : Form
    {
        public List<string> ClassroomList = null;
        public Student StudentInfo = null;

        public frmStudentAdd()
        {
            InitializeComponent();
        }

        private void frmStudentAdd_Load(object sender, System.EventArgs e)
        {
            cmbStudentClass.Items.AddRange(ClassroomList.ToArray());
        }

        private void btnOk_Click(object sender, System.EventArgs e)
        {
            StudentInfo = new Student();

            StudentInfo.Name = txtStudentName.Text;
            StudentInfo.Surname = txtStudentSurname.Text;
            StudentInfo.ClassName = cmbStudentClass.Text;

            this.DialogResult = DialogResult.OK;

            this.Close();
        }
    }
}
