﻿using System;
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
    public partial class frmAddStudent : Form
    {
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
            
        }
    }
}
