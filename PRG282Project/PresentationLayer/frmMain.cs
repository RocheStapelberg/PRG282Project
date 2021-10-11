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

        
    }
}
