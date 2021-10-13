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
                int Snum = int.Parse(txtsID.Text);
                string Name = txtName.Text;
                string surname = txtSurname.Text;
                string dob = dtpDOB.Value.ToString();
                string gender = cmbGender.SelectedItem.ToString();
                string phoneNum = txtPhone.Text;
                string address = txtAddress.Text;

                byte[] images = null;
                FileStream stream = new FileStream(imgLocation,FileMode.Open,FileAccess.Read);
                BinaryReader brs = new BinaryReader(stream);
                images = brs.ReadBytes((int)stream.Length);

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

        string imgLocation = String.Empty;
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
