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
    public partial class frmGoal : Form
    {
        public frmGoal()
        {
            InitializeComponent();
            IDIncrement();
        }
        public static string M_ID, G_ID;
        Fitness_Tracker_DDOOCP_DataSetTableAdapters.GoalTableAdapter objtGoal = new Fitness_Tracker_DDOOCP_DataSetTableAdapters.GoalTableAdapter();
        DataTable dtGoal = new DataTable();

        public void IDIncrement()
        {
            DataTable dt = new DataTable();
            dt = objtGoal.GetData();
            if (dt.Rows.Count == 0)
            {
                lblGoalID.Text = "G_001";
            }
            else
            {
                int size = dt.Rows.Count - 1; //to get the last ID from Goal table
                string oldID = dt.Rows[size][0].ToString();
                int newID = Convert.ToInt32(oldID.Substring(2, 3));

                if (newID >= 1 && newID < 9)
                {
                    lblGoalID.Text = "G_00" + (newID + 1);
                }
                else if (newID >= 9 && newID < 99)
                {
                    lblGoalID.Text = "G_0" + (newID + 1);
                }
                else if (newID >= 99 && newID < 999)
                {
                    lblGoalID.Text = "G_" + (newID + 1);
                }
            }
        }

        private void lblDuration_Click(object sender, EventArgs e)
        {

        }

        private void lblUserName_Click(object sender, EventArgs e)
        {

        }
        public void ClearTextBox()
        {
            txtTargetWeightLoss.Clear();
            txtTargetCalories.Clear();
            txtDuration.Clear();
            dtpGoalStartDate.Value = DateTime.Today;
            dtpGoalEndDate.Value = DateTime.Today;
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearTextBox();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMemberHomePage MH = new frmMemberHomePage();
            MH.Show();
            this.Hide();
        }

        private void frmGoal_Load(object sender, EventArgs e)
        {
            lblMemberID.Text = frmMemberLogin.MemberID;
            IDIncrement();
            
        }
        private void dtpGoalEndDate_ValueChanged(object sender, EventArgs e)
        {
            DateTime StartDate, EndDate;
            TimeSpan Duration;
            StartDate = dtpGoalStartDate.Value;
            EndDate = dtpGoalEndDate.Value;
            Duration = EndDate - StartDate;
            txtDuration.Text = Math.Floor(Duration.TotalDays).ToString();
        }
        private void txtTargetWeightLoss_TextChanged(object sender, EventArgs e)
        {
            string input = txtTargetWeightLoss.Text;

            if (input.Any(char.IsLetter))
            {
                MessageBox.Show("Please enter vailid numeric number!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTargetWeightLoss.Clear();
                txtTargetCalories.Clear();
            }
            else if (!string.IsNullOrEmpty(txtTargetWeightLoss.Text) && txtTargetWeightLoss.Text.All(char.IsDigit))
            {
                int TWL = Convert.ToInt32(txtTargetWeightLoss.Text);
                int targetCalories = TWL * 3500;
                txtTargetCalories.Text = targetCalories.ToString();
            } 
            else
            {
                txtTargetCalories.Clear();
            } 
        } 

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            if (txtTargetWeightLoss.Text == "")
            {
                MessageBox.Show("Please Enter Target Weight Loss!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTargetWeightLoss.Focus();
                return;
            }

            if (txtDuration.Text == "")
            {
                MessageBox.Show("End Date cannot be Today! Please ensure to give proper duration!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int TWL = Convert.ToInt32(txtTargetWeightLoss.Text);
            if ( TWL < 10)
            {
                MessageBox.Show("Target Weight Loss should be at least 10lb!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTargetWeightLoss.Clear();
                txtTargetWeightLoss.Focus();
                return;
            }
            else
            {
                int TC = Convert.ToInt32(txtTargetCalories.Text);
                string G_ID = lblGoalID.Text;
                string M_ID = lblMemberID.Text;
                int Duration = Convert.ToInt32(txtDuration.Text);

                objtGoal.Insert(G_ID, M_ID, TWL, TC, dtpGoalStartDate.Value, dtpGoalEndDate.Value, Duration );
                MessageBox.Show("Successfully Saved!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearTextBox();
                txtTargetWeightLoss.Focus();
            }
        }  
    } 
}

