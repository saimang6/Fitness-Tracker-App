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
    public partial class frmActivity : Form
    {
        public frmActivity()
        {
            InitializeComponent();
            IDIncrement();
        }
        Fitness_Tracker_DDOOCP_DataSetTableAdapters.ActivityTableAdapter objtActivity = new Fitness_Tracker_DDOOCP_DataSetTableAdapters.ActivityTableAdapter();
        DataTable dt = new DataTable();


        public void IDIncrement()
        {
            DataTable dt = new DataTable();
            dt = objtActivity.GetData();
            if (dt.Rows.Count == 0)
            {
                lblActivityID.Text = "Av_001";
            }
            else
            {
                int size = dt.Rows.Count - 1; //to get the last ID
                string oldID = dt.Rows[size][0].ToString();
                int newID = Convert.ToInt32(oldID.Substring(3, 3));

                if (newID >= 1 && newID < 9)
                {
                    lblActivityID.Text = "Av_00" + (newID + 1);
                }
                else if (newID >= 9 && newID < 99)
                {
                    lblActivityID.Text = "Av_0" + (newID + 1);
                }
                else if (newID >= 99 && newID < 999)
                {
                    lblActivityID.Text = "Av_" + (newID + 1);
                }
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            frmAdminHomePage AMH = new frmAdminHomePage();
            AMH.Show();
            this.Hide();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtActivityName.Clear();
            txtMetric1Name.Clear();
            txtMetric2Name.Clear();
            txtMetric3Name.Clear();
            txtMET.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            objtActivity.Insert(
                lblActivityID.Text,
                txtActivityName.Text,
                txtMetric1Name.Text,
                txtMetric2Name.Text,
                txtMetric3Name.Text,
                txtMET.Text
                );
            MessageBox.Show("Successfully Saved Activity!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            DataTable dt = objtActivity.GetData();
            dgvActivity.DataSource = dt;
            dgvActivity.Refresh();
            IDIncrement();
        }

        private void frmActivity_Load(object sender, EventArgs e)
        {
            dgvActivity.DataSource = objtActivity.GetData();
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;

        }

        private void dgvActivity_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = this.dgvActivity.Rows[e.RowIndex];
            lblActivityID.Text = row.Cells[0].Value.ToString();
            txtActivityName.Text = row.Cells[1].Value.ToString();
            txtMetric1Name.Text = row.Cells[2].Value.ToString();
            txtMetric2Name.Text = row.Cells[3].Value.ToString();
            txtMetric3Name.Text = row.Cells[4].Value.ToString();
            txtMET.Text = row.Cells[5].Value.ToString();

            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            objtActivity.UpdateActivity(
                lblActivityID.Text,
                txtActivityName.Text,
                txtMetric1Name.Text,
                txtMetric2Name.Text,
                txtMetric3Name.Text,
                txtMET.Text.ToString()
                );

            MessageBox.Show("Successfully Updated Activity!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dt = objtActivity.GetData();
            dgvActivity.DataSource = dt;
            dgvActivity.Refresh();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            objtActivity.DeleteActivity(lblActivityID.Text);
            MessageBox.Show("Successfully Deleted Activity!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dt = objtActivity.GetData();
            dgvActivity.DataSource = dt;
            dgvActivity.Refresh();
        }   
    }
}
