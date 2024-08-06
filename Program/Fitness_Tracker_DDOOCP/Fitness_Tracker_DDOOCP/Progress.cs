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
    public partial class frmProgress : Form
    {
        public frmProgress()
        {
            InitializeComponent();
        }
        Fitness_Tracker_DDOOCP_DataSetTableAdapters.Member_InfoTableAdapter objtMemberInfo = new Fitness_Tracker_DDOOCP_DataSetTableAdapters.Member_InfoTableAdapter();
        Fitness_Tracker_DDOOCP_DataSetTableAdapters.ActivityTableAdapter objtActivity = new Fitness_Tracker_DDOOCP_DataSetTableAdapters.ActivityTableAdapter();
        Fitness_Tracker_DDOOCP_DataSetTableAdapters.ProgressTableAdapter objtProgress = new Fitness_Tracker_DDOOCP_DataSetTableAdapters.ProgressTableAdapter();
        Fitness_Tracker_DDOOCP_DataSetTableAdapters.ProgressDetailsTableAdapter objtProgressDetails = new Fitness_Tracker_DDOOCP_DataSetTableAdapters.ProgressDetailsTableAdapter();
        Fitness_Tracker_DDOOCP_DataSetTableAdapters.AdminTableAdapter objtAdmin = new Fitness_Tracker_DDOOCP_DataSetTableAdapters.AdminTableAdapter();

        DataTable DT_dgv = new DataTable();
        DataRow dr;
        int remove_variable;
        decimal Total_Cal = 0;
        public static string ProgressID;
        //int p_details;

        public void IDIncrement()
        {
            DataTable dt = new DataTable();
            dt = objtProgress.GetData();

            if (dt.Rows.Count == 0)
            {
                ProgressID = "P_001";
            }
            else
            {
                int size = dt.Rows.Count - 1; //to get the last ID from Progress table;
                string oldID = dt.Rows[size][0].ToString();
                int newID = Convert.ToInt32(oldID.Substring(2, 3));

                if (newID >= 1 && newID < 9)
                {
                    ProgressID = "P_00" + (newID + 1);
                }
                else if (newID >= 9 && newID < 99)
                {
                    ProgressID = "P_0" + (newID + 1);
                }
                else if (newID >= 99 && newID < 999)
                {
                    ProgressID = "P_" + (newID + 1);
                }
            }
        }

        private void ProgressDisplay()
        {
            dr = DT_dgv.NewRow();

            DT_dgv.Columns.Add("Activity Name").ToString();
            DT_dgv.Columns.Add("Duration (Days)").ToString();
            DT_dgv.Columns.Add("Weight (lb)").ToString();
            DT_dgv.Columns.Add("MET").ToString();
            DT_dgv.Columns.Add("Calories Burned").ToString();
            dgvProgress.DataSource = DT_dgv;
            dgvProgress.Refresh();
        }

        private void frmProgress_Load(object sender, EventArgs e)
        {
            IDIncrement();
            btnRemove.Enabled = false;
            ProgressDisplay();

            //Get Data from Member_Info Table
            DataTable dt = new DataTable();
            string m_id = frmMemberLogin.MemberID;
            dt = objtMemberInfo.CheckData(m_id);

            if (dt.Rows.Count > 0)
            {
                lblFullName.Text = dt.Rows[0][1].ToString();
                lblWeight.Text = dt.Rows[0][2].ToString();
                lblTargetWeightLoss.Text = dt.Rows[0][3].ToString();
                lblStartDate.Text = dt.Rows[0][4].ToString();
                lblDuration.Text = dt.Rows[0][5].ToString();
            }

            //Get Data from Activity Table
            DataTable dtAv = new DataTable();
            dtAv = objtActivity.GetData();

            if (dtAv.Rows.Count > 0)
            {
                for (int i = 0; i < dtAv.Rows.Count; i++)
                {
                    cbActivity.Items.Add(dtAv.Rows[i][1].ToString());
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMemberHomePage MH = new frmMemberHomePage();
            MH.Show();
            this.Hide();
        }

        private void cbActivity_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dtAv = new DataTable();
            string Activity_Name;
            Activity_Name = cbActivity.SelectedItem.ToString();
            dtAv = objtActivity.CheckAvName(Activity_Name);

            if (dtAv.Rows.Count > 0)
            {
                lblMET.Text = dtAv.Rows[0][5].ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTimeTaken.Text == "")
                {
                    MessageBox.Show("Please Enter Time Taken!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTimeTaken.Focus();
                }
                else if (cbActivity.SelectedIndex == -1)
                {
                    MessageBox.Show("Please Choose One Activity!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbActivity.Focus();
                }
                else
                {
                    string Member_ID, Member_Name, Av_Name;
                    int Duration, TotalAv = 0;
                    decimal Weight, MET, Cal_Burned;

                    Member_ID = frmMemberLogin.MemberID;
                    Member_Name = lblFullName.Text;
                    Av_Name = cbActivity.SelectedItem.ToString();
                    Duration = Convert.ToInt32(lblDuration.Text);
                    Weight = Convert.ToDecimal(lblWeight.Text);
                    MET = Convert.ToDecimal(lblMET.Text);

                    Cal_Burned = Math.Round((MET * Weight * Duration) / 60, 2);

                    dr = DT_dgv.NewRow();

                    int flag = -1;
                    if (flag == -1)
                    {
                        dr[0] = Av_Name;
                        dr[1] = Duration;
                        dr[2] = Weight;
                        dr[3] = MET;
                        dr[4] = Cal_Burned;

                        DT_dgv.Rows.Add(dr);
                        dgvProgress.DataSource = DT_dgv;
                        dgvProgress.Refresh();

                        for (int i = 0; i < dgvProgress.Rows.Count - 1; i++)
                        {
                            Total_Cal += (Convert.ToDecimal(dgvProgress.Rows[i].Cells["Calories Burned"].Value));
                            TotalAv += 1;
                        }
                        lblTotalCaloriesBurned.Text = Total_Cal.ToString();
                        lblTotalActivity.Text = TotalAv.ToString();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Code!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
       

        private void dgvProgress_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnRemove.Enabled = true;
            remove_variable = dgvProgress.CurrentRow.Index;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int i = dgvProgress.CurrentRow.Index;
            decimal removed_cal = Convert.ToDecimal(dgvProgress["Calories Burned", i].Value);
            decimal current_total_cal = Convert.ToDecimal(lblTotalCaloriesBurned.Text);

            lblTotalCaloriesBurned.Text = Convert.ToString(current_total_cal - removed_cal);
            lblTotalActivity.Text = Convert.ToString(Convert.ToDecimal(lblTotalActivity.Text) - 1);

            this.dgvProgress.Rows.RemoveAt(i);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (DT_dgv.Rows.Count < 0)
            {
                MessageBox.Show("No Activity to Save!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string MemID, P_Status;
                MemID = frmMemberLogin.MemberID;
                DateTime P_Date;
                int Total_Av;
                decimal Total_Cal_Burned, TargetWeightLoss;

                P_Date = Convert.ToDateTime(lblStartDate.Text);
                Total_Av = Convert.ToInt32(lblTotalActivity.Text);
                Total_Cal_Burned = Convert.ToDecimal(lblTotalCaloriesBurned.Text);
                TargetWeightLoss = Convert.ToDecimal(lblTargetWeightLoss.Text);

                // Convert total calories burned to weight(lb)
                decimal weightLoss = Total_Cal_Burned / 3500;

                if (weightLoss >= TargetWeightLoss)
                {
                    P_Status = "Successful";
                    MessageBox.Show("Congratulations! The Progress is Successful!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    P_Status = "Fail";
                    MessageBox.Show("Sorry, The Progress is Fail!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                objtProgress.InsertProgress(ProgressID, P_Date.ToString(), MemID, Total_Av, Total_Cal_Burned.ToString(),P_Status) ;
                MessageBox.Show("Successfully Saved The Progress!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
