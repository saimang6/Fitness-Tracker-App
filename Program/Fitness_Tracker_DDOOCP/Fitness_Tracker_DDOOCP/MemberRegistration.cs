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
    public partial class frmMemberRegister : Form
    {
        public frmMemberRegister()
        {
            InitializeComponent();
            IDIncrement();
            
        }
        Fitness_Tracker_DDOOCP_DataSetTableAdapters.MemberTableAdapter objtMember = new Fitness_Tracker_DDOOCP_DataSetTableAdapters.MemberTableAdapter();
        DataTable dtMember = new DataTable();

        public void IDIncrement()
        {
            DataTable dt = new DataTable();
            dt = objtMember.GetData();

            if (dt.Rows.Count == 0)
            {
                lblMemberID.Text = "M_001";
            }
            else
            {
                int size = dt.Rows.Count - 1; //to get the last ID from Member Table;
                string oldID = dt.Rows[size][0].ToString();
                int newID = Convert.ToInt32(oldID.Substring(2,3));

                if (newID >= 1 && newID < 9)
                {
                    lblMemberID.Text = "M_00" + (newID + 1);
                }
                else if(newID >= 9 && newID < 99)
                {
                    lblMemberID.Text = "M_0" + (newID + 1);
                }
                else if (newID >= 99 && newID < 999)
                {
                    lblMemberID.Text = "M_" + (newID + 1);
                }
            }
            
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MemberPhoto_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
        public void ClearTextBox()
        {
            lblMemberID.Text = "";
            txtMemberUserName.Clear();
            txtMemberPassword.Clear();
            txtMemberFullName.Clear();
            txtNRIC.Clear();
            dateTimePickerDOB.Value = DateTime.Today;
            txtMemberEmail.Clear();
            txtContact.Clear();
            txtWeight.Clear();
            txtHeight.Clear();
            dateTimePickerJoinDate.Value = DateTime.Today;
            radioMale.Checked = false;
            radioFemale.Checked = false;
            MemberPhoto.Image = null;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblMemberID.Text = "";
            txtMemberUserName.Clear();
            txtMemberPassword.Clear();
            txtMemberFullName.Clear();
            txtNRIC.Clear();
            dateTimePickerDOB.Value = DateTime.Today;
            txtMemberEmail.Clear();
            txtContact.Clear();
            txtWeight.Clear();
            txtHeight.Clear();
            dateTimePickerJoinDate.Value = DateTime.Today;
            radioMale.Checked = false;
            radioFemale.Checked = false;
            IDIncrement();

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            dateTimePickerDOB.MinDate = new DateTime(1970, 1, 1);
            dateTimePickerDOB.MaxDate = DateTime.Today;
            int age = DateTime.Today.Year - dateTimePickerDOB.Value.Year;
            string password = txtMemberPassword.Text;
            dateTimePickerJoinDate.MinDate = new DateTime(1970, 1, 1);
            

            if (txtMemberUserName.Text == "")
            {
                MessageBox.Show("Please Enter User Name!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMemberUserName.Focus();
            }
            else if (!txtMemberUserName.Text.Any(char.IsNumber))
            {
                MessageBox.Show("Use Name should contain numbers!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMemberUserName.Focus();
            }
            else if (!txtMemberUserName.Text.Any(char.IsLetter))
            {
                MessageBox.Show("Use Name should contain letters!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMemberUserName.Focus();
            }
            else if (txtMemberFullName.Text == "")
            {
                MessageBox.Show("Please Enter Your Full Name!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMemberFullName.Focus();
            }
            else if (txtNRIC.Text == "")
            {
                MessageBox.Show("Please Enter Your NRIC Number!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNRIC.Focus();
            }
            else if (age < 18 || age > 40)
            {
                MessageBox.Show("We apologize, registration is only open to individuals between age 18 and 40!",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }
            else if (txtMemberEmail.Text == "")
            {
                MessageBox.Show("Please Provide Email Address!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMemberEmail.Focus();
            }
            else if (txtContact.Text == "")
            {
                MessageBox.Show("Please Enter Contact Number!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtContact.Focus();
            }
            else if (txtMemberPassword.Text == "")
            {
                MessageBox.Show("Please Create Password!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMemberPassword.Focus();
            }
            else if (password.Length < 6)
            {
                MessageBox.Show("Password cannot be less than 6 characters!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMemberPassword.Focus();
            }
            else if (password.Length > 12)
            {
                MessageBox.Show("Password cannot be more than 12 characters!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMemberPassword.Focus();
            }
            else if (!password.Any(char.IsUpper))
            {
                MessageBox.Show("Password should contain at least One(1) Uppercase Letter!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMemberPassword.Focus();
            }
            else if (!password.Any(char.IsLower))
            {
                MessageBox.Show("Password should contain at least One(1) Lowercase Letter!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMemberPassword.Focus();
            }
            else if (!password.Any(char.IsNumber))
            {
                MessageBox.Show("Password should contain numbers!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMemberPassword.Focus();
            }
            else if (txtWeight.Text.Any(char.IsLetter))
            {
                MessageBox.Show("Weight cannot have letters. Please enter a valid numeric weight!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtWeight.Focus();
            }
            else if (txtWeight.Text == "")
            {
                MessageBox.Show("Please Provide Weight(lb)!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtWeight.Focus();
            }
            else if (Convert.ToDecimal(txtWeight.Text) < 45 || Convert.ToDecimal(txtWeight.Text) > 600)
            {
                MessageBox.Show("Sorry, weight must be between 45lb and 600lb", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtWeight.Focus();
                return;
            }
            else if (txtHeight.Text == "")
            {
                MessageBox.Show("Please Provide Height(cm)!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHeight.Focus();
            }
            else if (txtHeight.Text.Any(char.IsLetter))
            {
                MessageBox.Show("Height cannot have letters. Please enter a valid numeric height!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHeight.Focus();
            }
            else if (Convert.ToDecimal(txtHeight.Text) < 120 || Convert.ToDecimal(txtHeight.Text) > 220)
            {
                MessageBox.Show("Sorry, height must be between 120cm and 220cm", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHeight.Focus();
                return;
            }
            else if (!radioMale.Checked && !radioFemale.Checked)
            {
                MessageBox.Show("Please Select Gender!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
            else
            {
                if (MemberPhoto.Image == null)
                {
                    // Show a message box if the image is missing
                    MessageBox.Show("Please input an image!", "Image Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Exit the method if no image is provided  
                }

                // Define the location and path to save the image
                string loc = "C:\\207284_SawSai_DDOOCP_GA\\Program\\Fitness_Tracker_DDOOCP\\Fitness_Tracker_DDOOCP\\bin\\Debug\\images\\Member_Photos";
                string path = Path.Combine(loc, txtMemberUserName.Text + ".jpg");

                // Save the image
                Image a = MemberPhoto.Image;
                a.Save(path);

                Member_Model_Class MM = new Member_Model_Class();
                MM.MemberID = lblMemberID.Text;
                MM.UserName = txtMemberUserName.Text;
                MM.Password = txtMemberPassword.Text;
                MM.FullName = txtMemberFullName.Text;
                MM.NRIC = txtNRIC.Text;
                MM.DateOfBirth = dateTimePickerDOB.Value;
                MM.Email = txtMemberEmail.Text;
                MM.Contact = txtContact.Text;
                MM.Weight = Convert.ToDecimal(txtWeight.Text);
                MM.Height = Convert.ToDecimal(txtHeight.Text);
                MM.JoinDate = dateTimePickerJoinDate.Value;
                MM.SetGender(radioMale, radioFemale);

                objtMember.InsertMemberRegister(
                    MM.MemberID,
                    MM.UserName,
                    MM.Password,
                    MM.FullName,
                    MM.NRIC,
                    MM.DateOfBirth.ToString(),
                    MM.Email,
                    MM.Contact,
                    MM.Weight,
                    MM.Height,
                    MM.JoinDate.ToString(),
                    MM.Gender,
                    path
                   );
                
                /*
                objtMember.Insert(
                    MM.MemberID,
                    MM.UserName,
                    MM.Password,
                    MM.FullName,
                    MM.NRIC,
                    MM.DateOfBirth,
                    MM.Email,
                    MM.Contact,
                    MM.Weight,
                    MM.Height,
                    MM.JoinDate,
                    gender
                   );
                 */

                /*
                // Convert weight and height from text to decimal
                decimal weight = Convert.ToDecimal(txtWeight.Text);
                decimal height = Convert.ToDecimal(txtHeight.Text);

                objtMember.Insert(
                    lblMemberID.Text,
                    txtMemberUserName.Text,
                    txtMemberPassword.Text,
                    txtMemberFullName.Text,
                    txtNRIC.Text,
                    dateTimePickerDOB.Value,
                    txtMemberEmail.Text,
                    txtContact.Text,
                    weight,
                    height,
                    dateTimePickerJoinDate.Value,
                    lblGender.Text
                );*/

                MessageBox.Show("Successfully Registered!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                IDIncrement();
                ClearTextBox();
                txtMemberUserName.Focus();
            }
        }

        private void MemberPhoto_Click_1(object sender, EventArgs e)
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

        private void gbMemberInfo_Enter(object sender, EventArgs e)
        {
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmMemberLogin ML = new frmMemberLogin();
            ML.Show();
            this.Hide();
        }
    }
}
