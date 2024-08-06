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
    public partial class frmAdminLogin : Form
    {
        Fitness_Tracker_DDOOCP_DataSetTableAdapters.AdminTableAdapter objtAdmin = new Fitness_Tracker_DDOOCP_DataSetTableAdapters.AdminTableAdapter();
        private int LoginAttempt = 0;
        //public static string MemberID, UserName;
        public static string AdminID, UserName, FullName, Email, Contact;

        public frmAdminLogin()
        {
            InitializeComponent();
        }

        private void linkAdminRegistration_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAdminRegister AR = new frmAdminRegister();
            AR.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (LoginAttempt >= 3)
            {
                MessageBox.Show("You have reached limited login attempt 3 times! Please try again later!",
                    "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if (txtAdminUserName.Text == "")
            {
                MessageBox.Show("Please Enter UserName!","Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAdminUserName.Focus();
            }
            else if (txtAdminPassword.Text == "")
            {
                MessageBox.Show("Please Enter Password!","Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAdminPassword.Focus();
            }
            else 
            {
                DataTable dt = new DataTable();
                dt = objtAdmin.AdminLogin(txtAdminUserName.Text, txtAdminPassword.Text);
                if (dt.Rows.Count == 1)
                {
                    MessageBox.Show("Login Successful!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvAdmin.DataSource = dt;
                    AdminID = dgvAdmin[0, 0].Value.ToString();
                    UserName = dgvAdmin[1, 0].Value.ToString();
                    FullName = dgvAdmin[3, 0].Value.ToString();
                    Email = dgvAdmin[4, 0].Value.ToString();
                    Contact = dgvAdmin[5, 0].Value.ToString();
                    frmAdminHomePage AMH = new frmAdminHomePage();
                    AMH.Show();
                    this.Hide();
                }
                else
                {
                    LoginAttempt += 1;
                    if (LoginAttempt >= 3)
                    {
                        MessageBox.Show("You have reached the limited login attempt 3 times! Please try again later.",
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
            txtAdminUserName.Clear();
            txtAdminPassword.Clear();
        }

        private void dgvAdmin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
