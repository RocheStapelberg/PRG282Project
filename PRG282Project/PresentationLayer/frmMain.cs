using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PRG282Project.DataLayer;

namespace PRG282Project.PresentationLayer
{
    public partial class frmMain : Form
    {
        DataHandler handler = new DataHandler();
        BindingSource source = new BindingSource();

        public frmMain()
        {
            InitializeComponent();
            source.DataSource = handler.getStudents();
            dgvStudents.DataSource = source;

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int searchNum = int.Parse(txtSearch.Text);
            DataTable dataTable = new DataTable();
            dataTable = handler.searchStudent(searchNum);
            dgvStudents.DataSource = dataTable;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            source.DataSource = handler.getStudents();
            dgvStudents.DataSource = source;
        }

        //int studentNum, string name, string surname, string gender, string dateOfBirth, string phone, string address
        //@StudentNumber, @StudentName, @StudentSurname, @DateofBirth, @Gender, @StudentPhoneNumber, @StudentAddress
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int studNumber = int.Parse(txtStudentNumber.Text);
            string studName = txtName.Text;
            string studSurname = txtSurname.Text;
            string studDob = txtDob.Text;
            string studGender = cmbGender.SelectedItem.ToString();
            string phone = txtPhone.Text;
            string address = txtAddress.Text;

            handler.updateStudent(studNumber, studName, studSurname, studDob, studGender, phone, address);

        }

        private void dgvStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvStudents.Rows[e.RowIndex];

                txtStudentNumber.Text = row.Cells["StudentNumber"].Value.ToString();
                txtName.Text = row.Cells["StudentName"].Value.ToString();
                txtSurname.Text = row.Cells["StudentSurname"].Value.ToString();
                txtDob.Text = row.Cells["DateofBirth"].Value.ToString();
                cmbGender.SelectedItem = row.Cells["Gender"].Value.ToString();
                txtPhone.Text = row.Cells["StudentPhoneNumber"].Value.ToString();
                txtAddress.Text = row.Cells["StudentAddress"].Value.ToString();
            }
        }
    }
}
