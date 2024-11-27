using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KimpackForms
{
    public partial class frmLogin : Form
    {
        private Label lblTitle;

        public frmLogin(Label lblTitle)
        {
            InitializeComponent();
            // Assuming the label is named lblTitle
            lblTitle.Text = "Hệ thống quản lý kimpack";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            lblTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblTitle.AutoSize = false;
            lblTitle.Dock = DockStyle.Top;
            this.lblTitle = lblTitle;
        }

        public frmLogin()
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void picLogo_Click(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
