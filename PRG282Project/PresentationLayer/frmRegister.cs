using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG282Project.PresentationLayer
{
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmLogin log = new frmLogin();
            log.Show();
            this.Hide();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            try
            {
                string username = txtUsername.Text;
                string password = txtPassword.Text;
                if(txtConfirm.Text == password)
                {
                    //UserLogic.RegisterUser(username, password, users);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                MessageBox.Show("User Registered");
            }
        }
    }
}
