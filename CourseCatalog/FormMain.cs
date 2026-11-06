using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CourseCatalog
{
    public partial class FormMain : Form
    {
        private List<OnlineCourse> courses = new List<OnlineCourse>();
        private int nextId = 1;

        public FormMain()
        {
            InitializeComponent();
        }

        private void RefreshList()
        {
            lstCourses.Items.Clear();
            foreach (OnlineCourse course in courses)
                course.Display(lstCourses);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text) ||
                string.IsNullOrWhiteSpace(txtCertNumber.Text))
            {
                MessageBox.Show("Заполните название курса и номер сертификата.",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var cert = new OnlineCourse.AccessCertificate(
                txtCertNumber.Text.Trim(), (int)numCertDays.Value);

            courses.Add(new OnlineCourse(nextId++, txtTitle.Text.Trim(), numPrice.Value, cert));
            RefreshList();

            txtTitle.Clear();
            txtCertNumber.Clear();
            txtTitle.Focus();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            courses.Sort(); // использует IComparable.CompareTo
            RefreshList();
        }

        private void btnClone_Click(object sender, EventArgs e)
        {
            int index = lstCourses.SelectedIndex;
            if (index < 0)
            {
                MessageBox.Show("Выберите курс в списке.",
                    "Нет выбора", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            OnlineCourse original = courses[index];
            OnlineCourse copy = (OnlineCourse)original.Clone();

            bool independent = !ReferenceEquals(original.Certificate, copy.Certificate);
            MessageBox.Show(
                "Копия создана. Сертификат — независимый экземпляр: " + (independent ? "да" : "нет"),
                "Глубокое копирование");

            courses.Add(copy);
            RefreshList();
        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
