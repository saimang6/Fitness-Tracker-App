using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Fitness_Tracker_DDOOCP
{
    public partial class frmAdminRegister : Form
    {
        public frmAdminRegister()
        {
            InitializeComponent();
            IDIncrement();
        }
        Fitness_Tracker_DDOOCP_DataSetTableAdapters.AdminTableAdapter objtAdmin = new Fitness_Tracker_DDOOCP_DataSetTableAdapters.AdminTableAdapter();
        DataTable dtAdmin = new DataTable();

        public void IDIncrement()
        {
            DataTable dt = new DataTable();
            dt = objtAdmin.GetData();
            if (dt.Rows.Count == 0)
            {
                lblAdminID.Text = "Am_001";
            }
            else
            {
                int size = dt.Rows.Count - 1; //to get the last ID from Admin table
                string oldID = dt.Rows[size][0].ToString();
                int newID = Convert.ToInt32(oldID.Substring(3,3));

                if (newID >= 1 && newID < 9)
                {
                    lblAdminID.Text = "Am_00" + (newID + 1);
                }
                else if (newID >= 9 && newID < 99)
                {
                    lblAdminID.Text = "Am_0" + (newID + 1);
                }
                else if (newID >= 99 && newID < 999)
                {
                    lblAdminID.Text = "Am_" + (newID + 1);
                }
            }

        }
        public void ClearTextBox()
        {
            lblAdminID.Text = "";
            txtAdminUserName.Clear();
            txtAdminPassword.Clear();
            txtAdminFullName.Clear();
            txtAdminFullName.Clear();
            txtAdminEmail.Clear();
            txtAdminContact.Clear();
            AdminPhoto.Image = null;
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            lblAdminID.Text = "";
            txtAdminUserName.Clear();
            txtAdminPassword.Clear();
            txtAdminFullName.Clear();
            txtAdminFullName.Clear();
            txtAdminEmail.Clear();
            txtAdminContact.Clear();
            IDIncrement();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string password = txtAdminPassword.Text;
            if (txtAdminUserName.Text == "")
            {
                MessageBox.Show("Please Provide User Name!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAdminUserName.Focus();
            }
            else if(!txtAdminUserName.Text.Any(char.IsNumber))
            {
                MessageBox.Show("Use Name should contain numbers!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAdminUserName.Focus();
            }
            else if (!txtAdminUserName.Text.Any(char.IsLetter))
            {
                MessageBox.Show("Use Name should contain letters!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAdminUserName.Focus();
            }
            else if (txtAdminFullName.Text == "")
            {
                MessageBox.Show("Please Provide Admin Full Name!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAdminFullName.Focus();
            }
            else if (txtAdminPassword.Text == "")
            {
                MessageBox.Show("Please Provide Password!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAdminPassword.Focus();
            }
            else if (txtAdminEmail.Text == "")
            {
                MessageBox.Show("Please Provide Admin Email!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAdminEmail.Focus();
            }
            else if (txtAdminContact.Text == "")
            {
                MessageBox.Show("Please Provide Admin Contact!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAdminContact.Focus();
            }
            else if (password.Length < 6 )
            {
                MessageBox.Show("Password cannot be less than 6 characters!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAdminPassword.Focus();
            }
            else if (password.Length > 12)
            {
                MessageBox.Show("Password cannot be more than 12 characters!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAdminPassword.Focus();
            }
            else if (!password.Any(char.IsUpper))
            {
                MessageBox.Show("Password should contain at least One(1) Uppercase Letter!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAdminPassword.Focus();
            }
            else if (!password.Any(char.IsLower))
            {
                MessageBox.Show("Password should contain at least One(1) Lowercase Letter!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAdminPassword.Focus();
            }
            else if (!password.Any(char.IsNumber))
            {
                MessageBox.Show("Password should contain numbers!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAdminPassword.Focus();
            }
            else
            {
                if (AdminPhoto.Image == null)
                {
                    // Show a message box if the image is missing
                    MessageBox.Show("Please input an image.", "Image Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Exit the method if no image is provided
                }

                // Define the location and path to save the image
                string loc = "C:\\207284_SawSai_DDOOCP_GA\\Program\\Fitness_Tracker_DDOOCP\\Fitness_Tracker_DDOOCP\\bin\\Debug\\images\\Admin_Photos";
                string path = Path.Combine(loc, txtAdminUserName.Text + ".jpg");
                
                // Save the image
                Image a = AdminPhoto.Image;
                a.Save(path);
                
                //string loc = "C:\\207284_SawSai_DDOOCP_GA\\Program\\Fitness_Tracker_DDOOCP\\Fitness_Tracker_DDOOCP\\bin\\Debug\\images\\Admin_Photos";
                //string path = Path.Combine(loc, txtAdminUserName.Text + ".jpg");
                //Image a = AdminPhoto.Image;
                //a.Save(path);

                Admin_Model_Class AM = new Admin_Model_Class();
                AM.AdminID = lblAdminID.Text;
                AM.UserName = txtAdminUserName.Text;
                AM.Password = txtAdminPassword.Text;
                AM.FullName = txtAdminFullName.Text;
                AM.Email = txtAdminEmail.Text;
                AM.Contact = txtAdminContact.Text;
                //objtAdmin.Insert(AM.AdminID, AM.UserName, AM.Password, AM.FullName, AM.Email);

                objtAdmin.InsertAdminRegister(AM.AdminID, AM.UserName, AM.Password, AM.FullName, AM.Email, AM.Contact, path );


                //objtAdmin.Insert(lblAdminID.Text, txtAdminUserName.Text, txtAdminPassword.Text, txtAdminFullName.Text, txtAdminEmail.Text);
                MessageBox.Show("Successfully Registered!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                IDIncrement();
                ClearTextBox();
                txtAdminUserName.Focus();
            }
        }

        private void lblAdminFullName_Click(object sender, EventArgs e)
        {

        }

        private void AdminPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            PictureBox pb = sender as PictureBox;

            if (pb != null)
            {
                open.Filter = "(*.jpg;*.jpeg;*.png) | *.jpg;*.jpeg;*.png";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    pb.Image = Image.FromFile(open.FileName);
                }
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            frmAdminHomePage AMH = new frmAdminHomePage();
            AMH.Show();
            this.Hide();
        }
    }
}
