using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmMain.Storage
{
    public partial class frmImportPayment : Form
    {
        private String supCode;
        public frmImportPayment()
        {
            InitializeComponent();
        }

        private void frmImportPayment_Load(object sender, EventArgs e)
        {

        }

        public frmImportPayment(String _supCode): this()
        {
            
            txtSupCode.Text = _supCode;
        }
    }
}
