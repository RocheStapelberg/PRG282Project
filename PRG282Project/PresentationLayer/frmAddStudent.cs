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
using System.Data.SqlClient;
using System.IO;

namespace PRG282Project.PresentationLayer
{
    
    public partial class frmAddStudent : Form
    {
        DataHandler dhanler = new DataHandler();
        
        public frmAddStudent()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMain main = new frmMain();
            main.Show();
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtsID.Clear();
            txtName.Clear();
            txtSurname.Clear();
            cmbGender.SelectedIndex = 0;
            txtPhone.Clear();
            txtAddress.Clear();
            txtMcode.Clear();
            txtMname.Clear();
            txtMdesc.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = new SqlConnection(@"Server=(local); Initial Catalog=BelgiumStudents; Integrated Security=SSPI;");
                int Snum = int.Parse(txtsID.Text);
                string Name = txtName.Text;
                string surname = txtSurname.Text;
                string dob = dtpDOB.Value.ToString();
                string gender = cmbGender.SelectedItem.ToString();
                string phoneNum = txtPhone.Text;
                string address = txtAddress.Text;

                byte[] images = null;
                FileStream Streem = new FileStream(imgLocation,FileMode.Open,FileAccess.Read);
                BinaryReader brs = new BinaryReader(Streem);
                images = brs.ReadBytes((int)Streem.Length);

                connection.Open();
                string sqlQuery = $"INSERT INTO Student(StudentPhoto) VALUES (@images)";
                cmd = new SqlCommand(sqlQuery, connection);
                cmd.Parameters.Add(new SqlParameter("@images", images));
                int N = cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show(N.ToString()+"Datas Saved Sccessfully");

                dhanler.insertStudent(Snum, Name, surname, gender, dob, phoneNum, address, images);

                string Mcode = txtMcode.Text;
                string Mname = txtMname.Text;
                string Mdesc = txtMdesc.Text;
                string link = txtLink.Text;

                dhanler.insertModule(Mcode, Snum, Mname, Mdesc, link);


                MessageBox.Show("Successfully added the new student");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Something went Wrong");
                
            }
            finally
            {
                txtsID.Clear();
                txtName.Clear();
                txtSurname.Clear();
                cmbGender.SelectedIndex = 0;
                txtPhone.Clear();
                txtAddress.Clear();
                txtMcode.Clear();
                txtMname.Clear();
                txtMdesc.Clear();
            }
            

        }

        SqlConnection connection = new SqlConnection(@"Server=(local); Initial Catalog=BelgiumStudents; Integrated Security=SSPI;");
        string imgLocation = "";
        SqlCommand cmd;
        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if(dialog.ShowDialog()==DialogResult.OK)
            {
                imgLocation = dialog.FileName.ToString();
                pbFoto.ImageLocation = imgLocation;
                MessageBox.Show(pbFoto.ImageLocation.ToString());
            }
        }
    }
}
