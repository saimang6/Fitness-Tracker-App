using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fitness_Tracker_DDOOCP
{
    public partial class frmAdminHomePage : Form
    {
        public frmAdminHomePage()
        {
            InitializeComponent();
        }

        private void btnMemberReg_Click(object sender, EventArgs e)
        {
            frmMemberRegister MR = new frmMemberRegister();
            MR.Show();
            this.Hide();
        }

        private void btnAdminReg_Click(object sender, EventArgs e)
        {
            frmAdminRegister AR = new frmAdminRegister();
            AR.Show();
            this.Hide();

        }

        private void btnActivity_Click(object sender, EventArgs e)
        {
            frmActivity AV = new frmActivity();
            AV.Show();
            this.Hide();
        }

        private void lblUserName_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmAdminLogin AL = new frmAdminLogin();
            AL.Show();
            this.Hide();
        }

        private void frmAdminHomePage_Load(object sender, EventArgs e)
        {
            lblAdminID.Text = frmAdminLogin.AdminID;
            lblUserName.Text = frmAdminLogin.UserName;
            lblFullName.Text = frmAdminLogin.FullName;
            lblEmail.Text = frmAdminLogin.Email;
            lblContact.Text = frmAdminLogin.Contact;
        }

        private void btnProgress_Click(object sender, EventArgs e)
        {
            frmProgressView PV = new frmProgressView();
            PV.Show();
            this.Hide();
        }
    }
}
