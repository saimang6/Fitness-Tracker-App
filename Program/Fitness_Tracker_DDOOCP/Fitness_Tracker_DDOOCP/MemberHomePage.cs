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
    public partial class frmMemberHomePage : Form
    {
        public frmMemberHomePage()
        {
            InitializeComponent();
        }

        private void btnMemberReg_Click(object sender, EventArgs e)
        {
            frmMemberRegister MR = new frmMemberRegister();
            MR.Show();
            this.Hide();
        }

        private void btnGoal_Click(object sender, EventArgs e)
        {
            frmGoal G = new frmGoal();
            G.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmMemberLogin ML = new frmMemberLogin();
            ML.Show();
            this.Hide();
        }

        private void frmMemberHomePage_Load(object sender, EventArgs e)
        {
            lblMemberID.Text = frmMemberLogin.MemberID;
            lblUserName.Text = frmMemberLogin.UserName;
            lblFullName.Text = frmMemberLogin.FullName;
            lblEmail.Text = frmMemberLogin.Email;
            lblContact.Text = frmMemberLogin.Contact;
        }

        private void btnProgress_Click(object sender, EventArgs e)
        {
            frmProgress P = new frmProgress();
            P.Show();
            this.Hide();
        }
    }
}
