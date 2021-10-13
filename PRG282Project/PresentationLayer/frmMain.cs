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
using System.IO;
using PRG282Project.CustomExceptions;

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
            try
            {
                int searchNum = int.Parse(txtSearch.Text);
                DataTable dataTable = new DataTable();
                dataTable = handler.searchStudent(searchNum);
                source.DataSource = dataTable;
                dgvStudents.DataSource = source;

                DataGridViewRow row = this.dgvStudents.Rows[0];

                lblSNumberChange.Text = row.Cells["StudentNumber"].Value.ToString();
                lblNameChange.Text = row.Cells["StudentName"].Value.ToString();
                lblSurnameChange.Text = row.Cells["StudentSurname"].Value.ToString();
                lblDobChange.Text = row.Cells["DateofBirth"].Value.ToString();
                lblGenderChange.Text = row.Cells["Gender"].Value.ToString();
                lblPhoneChange.Text = row.Cells["StudentPhoneNumber"].Value.ToString();
                lblAddressChange.Text = row.Cells["StudentAddress"].Value.ToString();

                byte[] img = (byte[])row.Cells["StudentPhoto"].Value;
                MemoryStream ms = new MemoryStream(img);
                pbStudentfoto.Image = Image.FromStream(ms);

                txtStudentNumber.Text = row.Cells["StudentNumber"].Value.ToString();
                txtName.Text = row.Cells["StudentName"].Value.ToString();
                txtSurname.Text = row.Cells["StudentSurname"].Value.ToString();
                txtDob.Text = row.Cells["DateofBirth"].Value.ToString();
                cmbGender.SelectedItem = row.Cells["Gender"].Value.ToString();
                txtPhone.Text = row.Cells["StudentPhoneNumber"].Value.ToString();
                txtAddress.Text = row.Cells["StudentAddress"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            source.DataSource = handler.getStudents();
            dgvStudents.DataSource = source;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int studNumber = int.Parse(txtStudentNumber.Text);
                string studName = txtName.Text;
                string studSurname = txtSurname.Text;
                string studDob = txtDob.Text;
                string studGender = cmbGender.SelectedItem.ToString();
                string phone = txtPhone.Text;
                string address = txtAddress.Text;

                handler.updateStudent(studNumber, studName, studSurname, studGender, studDob, phone, address);
                source.DataSource = handler.getStudents();
                dgvStudents.DataSource = source;

                MessageBox.Show("Student Updated");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvStudents.Rows[e.RowIndex];

                lblSNumberChange.Text = row.Cells["StudentNumber"].Value.ToString();
                lblNameChange.Text = row.Cells["StudentName"].Value.ToString();
                lblSurnameChange.Text = row.Cells["StudentSurname"].Value.ToString();
                lblDobChange.Text = row.Cells["DateofBirth"].Value.ToString();
                lblGenderChange.Text = row.Cells["Gender"].Value.ToString();
                lblPhoneChange.Text = row.Cells["StudentPhoneNumber"].Value.ToString();
                lblAddressChange.Text = row.Cells["StudentAddress"].Value.ToString();

                txtStudentNumber.Text = row.Cells["StudentNumber"].Value.ToString();
                txtName.Text = row.Cells["StudentName"].Value.ToString();
                txtSurname.Text = row.Cells["StudentSurname"].Value.ToString();
                txtDob.Text = row.Cells["DateofBirth"].Value.ToString();
                cmbGender.SelectedItem = row.Cells["Gender"].Value.ToString();
                txtPhone.Text = row.Cells["StudentPhoneNumber"].Value.ToString();
                txtAddress.Text = row.Cells["StudentAddress"].Value.ToString();

                try
                {
                    if (row.Cells["StudentPhoto"].Value.ToString() == "")
                    {
                        throw new NoImageFound("No Image Found");
                    }
                    else 
                    {
                        byte[] img = (byte[])row.Cells["StudentPhoto"].Value;
                        MemoryStream ms = new MemoryStream(img);
                        pbStudentfoto.Image = Image.FromStream(ms);
                    }
                }
                catch (NoImageFound ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            frmAddStudent addS = new frmAddStudent();
            addS.Show();
            this.Hide();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            source.MoveFirst();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            source.MovePrevious();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            source.MoveNext();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            source.MoveLast();
        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            try
            {
                int studentnumber = int.Parse(txtStudentNumber.Text);
                handler.deleteData(studentnumber);
                source.DataSource = handler.getStudents();
                dgvStudents.DataSource = source;
                MessageBox.Show("Student Deleted");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnViewStudent_Click(object sender, EventArgs e)
        {
            source.DataSource = handler.getStudents();
            dgvStudents.DataSource = source;
        }

        private void btnViewModule_Click(object sender, EventArgs e)
        {
            source.DataSource = handler.getModule();
            dgvStudents.DataSource = source;
        }
    }
}
