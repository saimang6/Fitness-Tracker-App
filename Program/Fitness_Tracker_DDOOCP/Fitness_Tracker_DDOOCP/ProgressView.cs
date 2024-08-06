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
    public partial class frmProgressView : Form
    {
        public frmProgressView()
        {
            InitializeComponent();
        }
        Fitness_Tracker_DDOOCP_DataSetTableAdapters.ProgressTableAdapter objtProgress = new Fitness_Tracker_DDOOCP_DataSetTableAdapters.ProgressTableAdapter();
        DataTable dtP = new DataTable();

        private void frmProgressView_Load(object sender, EventArgs e)
        {
            dtP = objtProgress.GetData();
            dgvMemberProgress.DataSource = dtP;
            dgvMemberProgress.Refresh();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmAdminHomePage AMH = new frmAdminHomePage();
            AMH.Show();
            this.Hide();
        }  
    }
}
