namespace Fitness_Tracker_DDOOCP
{
    partial class frmActivity
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmActivity));
            this.gbActibityInfo = new System.Windows.Forms.GroupBox();
            this.txtMET = new System.Windows.Forms.TextBox();
            this.lblMET = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.dgvActivity = new System.Windows.Forms.DataGridView();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtMetric3Name = new System.Windows.Forms.TextBox();
            this.txtMetric2Name = new System.Windows.Forms.TextBox();
            this.txtMetric1Name = new System.Windows.Forms.TextBox();
            this.txtActivityName = new System.Windows.Forms.TextBox();
            this.lblActivityID = new System.Windows.Forms.Label();
            this.lblMetric3 = new System.Windows.Forms.Label();
            this.lblMetric2 = new System.Windows.Forms.Label();
            this.lblMetric1 = new System.Windows.Forms.Label();
            this.lblActivityName = new System.Windows.Forms.Label();
            this.lblActivity = new System.Windows.Forms.Label();
            this.gbActibityInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivity)).BeginInit();
            this.SuspendLayout();
            // 
            // gbActibityInfo
            // 
            this.gbActibityInfo.BackColor = System.Drawing.Color.Transparent;
            this.gbActibityInfo.Controls.Add(this.txtMET);
            this.gbActibityInfo.Controls.Add(this.lblMET);
            this.gbActibityInfo.Controls.Add(this.btnHome);
            this.gbActibityInfo.Controls.Add(this.dgvActivity);
            this.gbActibityInfo.Controls.Add(this.btnClear);
            this.gbActibityInfo.Controls.Add(this.btnDelete);
            this.gbActibityInfo.Controls.Add(this.btnUpdate);
            this.gbActibityInfo.Controls.Add(this.btnSave);
            this.gbActibityInfo.Controls.Add(this.txtMetric3Name);
            this.gbActibityInfo.Controls.Add(this.txtMetric2Name);
            this.gbActibityInfo.Controls.Add(this.txtMetric1Name);
            this.gbActibityInfo.Controls.Add(this.txtActivityName);
            this.gbActibityInfo.Controls.Add(this.lblActivityID);
            this.gbActibityInfo.Controls.Add(this.lblMetric3);
            this.gbActibityInfo.Controls.Add(this.lblMetric2);
            this.gbActibityInfo.Controls.Add(this.lblMetric1);
            this.gbActibityInfo.Controls.Add(this.lblActivityName);
            this.gbActibityInfo.Controls.Add(this.lblActivity);
            this.gbActibityInfo.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.gbActibityInfo.Location = new System.Drawing.Point(34, 34);
            this.gbActibityInfo.Name = "gbActibityInfo";
            this.gbActibityInfo.Size = new System.Drawing.Size(845, 730);
            this.gbActibityInfo.TabIndex = 0;
            this.gbActibityInfo.TabStop = false;
            this.gbActibityInfo.Text = "Activity Information";
            // 
            // txtMET
            // 
            this.txtMET.Location = new System.Drawing.Point(245, 462);
            this.txtMET.Name = "txtMET";
            this.txtMET.Size = new System.Drawing.Size(372, 42);
            this.txtMET.TabIndex = 13;
            // 
            // lblMET
            // 
            this.lblMET.AutoSize = true;
            this.lblMET.Location = new System.Drawing.Point(49, 462);
            this.lblMET.Name = "lblMET";
            this.lblMET.Size = new System.Drawing.Size(74, 35);
            this.lblMET.TabIndex = 12;
            this.lblMET.Text = "MET:";
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.Location = new System.Drawing.Point(659, 453);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(139, 51);
            this.btnHome.TabIndex = 11;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // dgvActivity
            // 
            this.dgvActivity.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvActivity.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvActivity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvActivity.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvActivity.Location = new System.Drawing.Point(55, 539);
            this.dgvActivity.Name = "dgvActivity";
            this.dgvActivity.RowTemplate.Height = 28;
            this.dgvActivity.Size = new System.Drawing.Size(743, 150);
            this.dgvActivity.TabIndex = 10;
            this.dgvActivity.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvActivity_CellMouseClick);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Location = new System.Drawing.Point(659, 377);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(139, 51);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Location = new System.Drawing.Point(659, 293);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(139, 51);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Location = new System.Drawing.Point(659, 213);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(139, 51);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Location = new System.Drawing.Point(659, 134);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(139, 51);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtMetric3Name
            // 
            this.txtMetric3Name.Location = new System.Drawing.Point(245, 386);
            this.txtMetric3Name.Name = "txtMetric3Name";
            this.txtMetric3Name.Size = new System.Drawing.Size(372, 42);
            this.txtMetric3Name.TabIndex = 5;
            // 
            // txtMetric2Name
            // 
            this.txtMetric2Name.Location = new System.Drawing.Point(245, 302);
            this.txtMetric2Name.Name = "txtMetric2Name";
            this.txtMetric2Name.Size = new System.Drawing.Size(372, 42);
            this.txtMetric2Name.TabIndex = 4;
            // 
            // txtMetric1Name
            // 
            this.txtMetric1Name.Location = new System.Drawing.Point(245, 222);
            this.txtMetric1Name.Name = "txtMetric1Name";
            this.txtMetric1Name.Size = new System.Drawing.Size(372, 42);
            this.txtMetric1Name.TabIndex = 3;
            // 
            // txtActivityName
            // 
            this.txtActivityName.Location = new System.Drawing.Point(245, 134);
            this.txtActivityName.Name = "txtActivityName";
            this.txtActivityName.Size = new System.Drawing.Size(372, 42);
            this.txtActivityName.TabIndex = 2;
            // 
            // lblActivityID
            // 
            this.lblActivityID.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lblActivityID.Location = new System.Drawing.Point(245, 64);
            this.lblActivityID.Name = "lblActivityID";
            this.lblActivityID.Size = new System.Drawing.Size(372, 30);
            this.lblActivityID.TabIndex = 1;
            // 
            // lblMetric3
            // 
            this.lblMetric3.AutoSize = true;
            this.lblMetric3.Location = new System.Drawing.Point(43, 386);
            this.lblMetric3.Name = "lblMetric3";
            this.lblMetric3.Size = new System.Drawing.Size(195, 35);
            this.lblMetric3.TabIndex = 0;
            this.lblMetric3.Text = "Metric 3 Name:";
            // 
            // lblMetric2
            // 
            this.lblMetric2.AutoSize = true;
            this.lblMetric2.Location = new System.Drawing.Point(43, 302);
            this.lblMetric2.Name = "lblMetric2";
            this.lblMetric2.Size = new System.Drawing.Size(195, 35);
            this.lblMetric2.TabIndex = 0;
            this.lblMetric2.Text = "Metric 2 Name:";
            // 
            // lblMetric1
            // 
            this.lblMetric1.AutoSize = true;
            this.lblMetric1.Location = new System.Drawing.Point(43, 222);
            this.lblMetric1.Name = "lblMetric1";
            this.lblMetric1.Size = new System.Drawing.Size(195, 35);
            this.lblMetric1.TabIndex = 0;
            this.lblMetric1.Text = "Metric 1 Name:";
            // 
            // lblActivityName
            // 
            this.lblActivityName.AutoSize = true;
            this.lblActivityName.Location = new System.Drawing.Point(43, 134);
            this.lblActivityName.Name = "lblActivityName";
            this.lblActivityName.Size = new System.Drawing.Size(186, 35);
            this.lblActivityName.TabIndex = 0;
            this.lblActivityName.Text = "Activity Name:";
            // 
            // lblActivity
            // 
            this.lblActivity.AutoSize = true;
            this.lblActivity.Location = new System.Drawing.Point(43, 64);
            this.lblActivity.Name = "lblActivity";
            this.lblActivity.Size = new System.Drawing.Size(142, 35);
            this.lblActivity.TabIndex = 0;
            this.lblActivity.Text = "Activity ID:";
            // 
            // frmActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 35F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Fitness_Tracker_DDOOCP.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1158, 808);
            this.Controls.Add(this.gbActibityInfo);
            this.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmActivity";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Activity";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmActivity_Load);
            this.gbActibityInfo.ResumeLayout(false);
            this.gbActibityInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbActibityInfo;
        private System.Windows.Forms.Label lblActivityID;
        private System.Windows.Forms.Label lblActivity;
        private System.Windows.Forms.TextBox txtActivityName;
        private System.Windows.Forms.Label lblActivityName;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtMetric3Name;
        private System.Windows.Forms.TextBox txtMetric2Name;
        private System.Windows.Forms.TextBox txtMetric1Name;
        private System.Windows.Forms.Label lblMetric3;
        private System.Windows.Forms.Label lblMetric2;
        private System.Windows.Forms.Label lblMetric1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView dgvActivity;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.TextBox txtMET;
        private System.Windows.Forms.Label lblMET;
    }
}