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
    public partial class frmMemberLogin : Form
    {
        Fitness_Tracker_DDOOCP_DataSetTableAdapters.MemberTableAdapter objtMember = new Fitness_Tracker_DDOOCP_DataSetTableAdapters.MemberTableAdapter();
        //private int LoginAttempt = 0;
        private int LoginAttempt = 0;
        public static string MemberID, UserName, FullName, Email, Contact;
        public frmMemberLogin()
        {
            InitializeComponent();
        }

        private void linkMemberRegistration_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmMemberRegister MR = new frmMemberRegister();
            MR.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (LoginAttempt >= 3)
            {
                MessageBox.Show("You have reached limited login attempt 3 times! Please try again later!",
                   "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if (txtMemberUserName.Text == "")
            {
                MessageBox.Show("Please Enter UserName!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMemberUserName.Focus();
            }
            else if (txtMemberPassword.Text == "")
            {
                MessageBox.Show("Please Enter Password!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMemberPassword.Focus();
            }
            else
            {
                DataTable dt = new DataTable();
                dt = objtMember.MemberLogin(txtMemberUserName.Text, txtMemberPassword.Text);
                if (dt.Rows.Count == 1)
                {
                    MessageBox.Show("Login Successful!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvMember.DataSource = dt;
                    MemberID = dgvMember[0, 0].Value.ToString();
                    UserName = dgvMember[1, 0].Value.ToString();
                    FullName = dgvMember[3, 0].Value.ToString();
                    Email = dgvMember[6, 0].Value.ToString();
                    Contact = dgvMember[7, 0].Value.ToString();

                    //frmAdminHomePage AMH = new frmAdminHomePage();
                    //AMH.Show();
                    frmMemberHomePage MH = new frmMemberHomePage();
                    MH.Show();
                    this.Hide();
                }
                else 
                {
                    LoginAttempt += 1;
                    if (LoginAttempt >= 3)
                    {
                        MessageBox.Show("You have reached limited login attempt 3 times! Please try again later!",
                            "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else
                    {
                        MessageBox.Show("Invalid Login Attempt: " + LoginAttempt, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMemberUserName.Clear();
            txtMemberPassword.Clear();
        }

    }
}
