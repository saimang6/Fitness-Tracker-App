namespace Fitness_Tracker_DDOOCP
{
    partial class frmProgress
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProgress));
            this.gbProgressMemberInfo = new System.Windows.Forms.GroupBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblTargetWeightLoss = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbProgressInfo = new System.Windows.Forms.GroupBox();
            this.txtTimeTaken = new System.Windows.Forms.TextBox();
            this.lblMET = new System.Windows.Forms.Label();
            this.cbActivity = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblTotalCaloriesBurned = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblTotalActivity = new System.Windows.Forms.Label();
            this.dgvProgress = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.gbProgressMemberInfo.SuspendLayout();
            this.gbProgressInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProgress)).BeginInit();
            this.SuspendLayout();
            // 
            // gbProgressMemberInfo
            // 
            this.gbProgressMemberInfo.BackColor = System.Drawing.Color.Transparent;
            this.gbProgressMemberInfo.Controls.Add(this.btnRemove);
            this.gbProgressMemberInfo.Controls.Add(this.btnAdd);
            this.gbProgressMemberInfo.Controls.Add(this.lblTargetWeightLoss);
            this.gbProgressMemberInfo.Controls.Add(this.lblDuration);
            this.gbProgressMemberInfo.Controls.Add(this.lblWeight);
            this.gbProgressMemberInfo.Controls.Add(this.lblFullName);
            this.gbProgressMemberInfo.Controls.Add(this.label5);
            this.gbProgressMemberInfo.Controls.Add(this.label3);
            this.gbProgressMemberInfo.Controls.Add(this.label2);
            this.gbProgressMemberInfo.Controls.Add(this.label1);
            this.gbProgressMemberInfo.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.gbProgressMemberInfo.Location = new System.Drawing.Point(38, 35);
            this.gbProgressMemberInfo.Name = "gbProgressMemberInfo";
            this.gbProgressMemberInfo.Size = new System.Drawing.Size(495, 461);
            this.gbProgressMemberInfo.TabIndex = 0;
            this.gbProgressMemberInfo.TabStop = false;
            this.gbProgressMemberInfo.Text = "Member Information";
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemove.Location = new System.Drawing.Point(207, 374);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(146, 50);
            this.btnRemove.TabIndex = 6;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Location = new System.Drawing.Point(29, 374);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(146, 50);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblTargetWeightLoss
            // 
            this.lblTargetWeightLoss.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lblTargetWeightLoss.Location = new System.Drawing.Point(216, 230);
            this.lblTargetWeightLoss.Name = "lblTargetWeightLoss";
            this.lblTargetWeightLoss.Size = new System.Drawing.Size(226, 35);
            this.lblTargetWeightLoss.TabIndex = 4;
            // 
            // lblDuration
            // 
            this.lblDuration.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lblDuration.Location = new System.Drawing.Point(216, 305);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(226, 35);
            this.lblDuration.TabIndex = 3;
            // 
            // lblWeight
            // 
            this.lblWeight.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lblWeight.Location = new System.Drawing.Point(216, 150);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(226, 35);
            this.lblWeight.TabIndex = 2;
            // 
            // lblFullName
            // 
            this.lblFullName.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lblFullName.Location = new System.Drawing.Point(216, 77);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(226, 35);
            this.lblFullName.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(286, 35);
            this.label5.TabIndex = 0;
            this.label5.Text = "Target Weight Loss (lb):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 35);
            this.label3.TabIndex = 0;
            this.label3.Text = "Duration (Days):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 35);
            this.label2.TabIndex = 0;
            this.label2.Text = "Weight (lb):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Full Name:";
            // 
            // gbProgressInfo
            // 
            this.gbProgressInfo.BackColor = System.Drawing.Color.Transparent;
            this.gbProgressInfo.Controls.Add(this.txtTimeTaken);
            this.gbProgressInfo.Controls.Add(this.lblMET);
            this.gbProgressInfo.Controls.Add(this.cbActivity);
            this.gbProgressInfo.Controls.Add(this.label10);
            this.gbProgressInfo.Controls.Add(this.label9);
            this.gbProgressInfo.Controls.Add(this.lblStartDate);
            this.gbProgressInfo.Controls.Add(this.label8);
            this.gbProgressInfo.Controls.Add(this.label7);
            this.gbProgressInfo.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.gbProgressInfo.Location = new System.Drawing.Point(562, 35);
            this.gbProgressInfo.Name = "gbProgressInfo";
            this.gbProgressInfo.Size = new System.Drawing.Size(491, 461);
            this.gbProgressInfo.TabIndex = 1;
            this.gbProgressInfo.TabStop = false;
            this.gbProgressInfo.Text = "Progress Information";
            // 
            // txtTimeTaken
            // 
            this.txtTimeTaken.Location = new System.Drawing.Point(200, 150);
            this.txtTimeTaken.Name = "txtTimeTaken";
            this.txtTimeTaken.Size = new System.Drawing.Size(226, 42);
            this.txtTimeTaken.TabIndex = 6;
            // 
            // lblMET
            // 
            this.lblMET.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lblMET.Location = new System.Drawing.Point(200, 305);
            this.lblMET.Name = "lblMET";
            this.lblMET.Size = new System.Drawing.Size(226, 35);
            this.lblMET.TabIndex = 5;
            // 
            // cbActivity
            // 
            this.cbActivity.FormattingEnabled = true;
            this.cbActivity.Location = new System.Drawing.Point(200, 230);
            this.cbActivity.Name = "cbActivity";
            this.cbActivity.Size = new System.Drawing.Size(226, 43);
            this.cbActivity.TabIndex = 4;
            this.cbActivity.SelectedIndexChanged += new System.EventHandler(this.cbActivity_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(33, 311);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 35);
            this.label10.TabIndex = 3;
            this.label10.Text = "MET:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(33, 230);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(202, 35);
            this.label9.TabIndex = 3;
            this.label9.Text = "Choose Activity:";
            // 
            // lblStartDate
            // 
            this.lblStartDate.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lblStartDate.Location = new System.Drawing.Point(200, 77);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(226, 35);
            this.lblStartDate.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(234, 35);
            this.label8.TabIndex = 0;
            this.label8.Text = "Time Taken (mins):";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 35);
            this.label7.TabIndex = 0;
            this.label7.Text = "Start Date:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.label11.Location = new System.Drawing.Point(32, 530);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(271, 35);
            this.label11.TabIndex = 0;
            this.label11.Text = "Total Calories Burned:";
            // 
            // lblTotalCaloriesBurned
            // 
            this.lblTotalCaloriesBurned.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lblTotalCaloriesBurned.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.lblTotalCaloriesBurned.Location = new System.Drawing.Point(295, 530);
            this.lblTotalCaloriesBurned.Name = "lblTotalCaloriesBurned";
            this.lblTotalCaloriesBurned.Size = new System.Drawing.Size(238, 35);
            this.lblTotalCaloriesBurned.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.label12.Location = new System.Drawing.Point(556, 530);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(175, 35);
            this.label12.TabIndex = 0;
            this.label12.Text = "Total Activity:";
            // 
            // lblTotalActivity
            // 
            this.lblTotalActivity.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lblTotalActivity.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.lblTotalActivity.Location = new System.Drawing.Point(737, 530);
            this.lblTotalActivity.Name = "lblTotalActivity";
            this.lblTotalActivity.Size = new System.Drawing.Size(316, 35);
            this.lblTotalActivity.TabIndex = 3;
            // 
            // dgvProgress
            // 
            this.dgvProgress.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProgress.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProgress.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProgress.Location = new System.Drawing.Point(38, 582);
            this.dgvProgress.Name = "dgvProgress";
            this.dgvProgress.RowTemplate.Height = 28;
            this.dgvProgress.Size = new System.Drawing.Size(1015, 150);
            this.dgvProgress.TabIndex = 4;
            this.dgvProgress.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvProgress_CellMouseClick);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.btnSave.Location = new System.Drawing.Point(38, 760);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(168, 47);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.btnBack.Location = new System.Drawing.Point(227, 760);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(168, 47);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "<<Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmProgress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 35F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Fitness_Tracker_DDOOCP.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1203, 872);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgvProgress);
            this.Controls.Add(this.lblTotalActivity);
            this.Controls.Add(this.lblTotalCaloriesBurned);
            this.Controls.Add(this.gbProgressInfo);
            this.Controls.Add(this.gbProgressMemberInfo);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmProgress";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Progress";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmProgress_Load);
            this.gbProgressMemberInfo.ResumeLayout(false);
            this.gbProgressMemberInfo.PerformLayout();
            this.gbProgressInfo.ResumeLayout(false);
            this.gbProgressInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProgress)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbProgressMemberInfo;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblTargetWeightLoss;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gbProgressInfo;
        private System.Windows.Forms.ComboBox cbActivity;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblMET;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTimeTaken;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblTotalCaloriesBurned;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblTotalActivity;
        private System.Windows.Forms.DataGridView dgvProgress;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnBack;
    }
}