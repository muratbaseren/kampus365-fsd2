using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class frmClassrooms : Form
    {
        List<string> classrooms = new List<string>();
        List<Student> students = new List<Student>();

        /*
         Student Listele düğmesine basıldığında;

        1. Seçili sınıf ismi listbox dan alınmalı.
        2. students listesinde seçili sınıf ta olan öğrenciler tespit edilmeli ve ayrı bir liste(List<Student> tipinde) alınmalı.
        3. frmStudentList isimli bir form tasarlanmalı.
        4. frmStudentList formuna yeni oluşturulan öğrenci listesi gönderilmeli
        5. frmStudentList formu show edilmeli ve o sınıfın öğrencileri listelenmeli.

        opsiyonel ==>

        6. frmStudentList formunda bir kaydet düğmesi olmalı ve öğrenci listesi sınıf adıyla olan bir txt dosyaya kaydedilmeli(öğrenci ad ve soyadı satır satır olacak) 
            (örn; Sınıf 3.txt) (Dosya uygulamanın çalıştığı klasörde oluşmalı)

        7. frmStudentList formunda öğrenci adı, soyadı ve sınıf güncellemesi / öğrenci silme yapılabilir.

         */


        public frmClassrooms()
        {
            InitializeComponent();
        }


        public void LoadClassrooms()
        {
            lstClassrooms.Items.Clear();

            foreach (string classroom in classrooms)
            {
                lstClassrooms.Items.Add(classroom);
            }
        }

        private void btnClassroomAdd_Click(object sender, EventArgs e)
        {
            classrooms.Add(txtClassroomName.Text);
            //lstClassrooms.Items.Add(txtClassroomName.Text);

            LoadClassrooms();
        }

        private void btnClassroomSave_Click(object sender, EventArgs e)
        {
            int index = lstClassrooms.SelectedIndex;

            if (index < 0)
            {
                MessageBox.Show("Lütfen güncelleme işlemi için bir sınıf seçiniz.", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                classrooms[index] = txtClassroomName.Text;

                LoadClassrooms();
            }
        }

        private void btnClassroomDelete_Click(object sender, EventArgs e)
        {
            int index = lstClassrooms.SelectedIndex;

            if (index < 0)
            {
                MessageBox.Show("Lütfen silme işlemi için bir sınıf seçiniz.", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Seçili kaydı silmek istediğinize emin misiniz?", "Silme İşlemi", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3);

                if (dialogResult == DialogResult.Yes)
                {
                    classrooms.RemoveAt(index);

                    LoadClassrooms();
                }
            }
        }

        private void mnuCut_Click(object sender, EventArgs e)
        {
            txtClassroomName.Cut();
        }

        private void mnuCopy_Click(object sender, EventArgs e)
        {
            txtClassroomName.Copy();
        }

        private void mnuPaste_Click(object sender, EventArgs e)
        {
            txtClassroomName.Paste();
        }

        private void mnuSave_Click(object sender, EventArgs e)
        {
            string appPath = Application.StartupPath;
            string filePath = appPath + @"\data.txt";

            System.IO.File.WriteAllLines(filePath, classrooms);

            //MessageBox.Show(buttons: MessageBoxButtons.OK, caption: "Bilgilendirme", icon: MessageBoxIcon.Information, text: "Veriler kaydedildi.");

            MessageBox.Show("Veriler kaydedildi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void frmClassrooms_Load(object sender, EventArgs e)
        {
            string appPath = Application.StartupPath;
            string filePath = appPath + @"\data.txt";

            string[] lines = System.IO.File.ReadAllLines(filePath);

            //foreach (string line in lines)
            //{
            //    classrooms.Add(line);
            //}

            classrooms.AddRange(lines);

            LoadClassrooms();
        }

        private void lstClassrooms_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstClassrooms.SelectedIndex > -1)
            {
                string value = lstClassrooms.Items[lstClassrooms.SelectedIndex].ToString();
                txtClassroomName.Text = value;
            }
            else
            {
                txtClassroomName.Clear();
            }
        }

        private void mnuStudentAdd_Click(object sender, EventArgs e)
        {
            frmStudentAdd frmStudentAdd = new frmStudentAdd();
            frmStudentAdd.ClassroomList = classrooms;

            DialogResult result = frmStudentAdd.ShowDialog();

            if (result == DialogResult.OK)
            {
                students.Add(frmStudentAdd.StudentInfo);
            }

        }
    }
}
