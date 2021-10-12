using PRG282Project.DataLayer;
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
            this.Hide();
            frmRegister reg = new frmRegister();
            reg.Show();
            
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            users = handler.GetUsers();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMain Main = new frmMain();
            Main.Show();
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
     