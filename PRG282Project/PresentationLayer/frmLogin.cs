using PRG282Project.DataLayer;
using PRG282Project.LogicLayer;
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
    public partial class frmLogin : Form
    {
        List<User> users = new List<User>();
        FileHandler handler = new FileHandler();

        public frmLogin()
        {
            InitializeComponent();
            handler.CreateFile();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                string username = txtUsername.Text;
                string password = txtPassword.Text;
                UserLogic.RegisterUser(username, password, users);
              
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

        private void frmLogin_Load(object sender, EventArgs e)
        {
            users = handler.GetUsers();
        }
    }
}
     