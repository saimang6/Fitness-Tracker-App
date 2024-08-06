namespace Fitness_Tracker_DDOOCP
{
    partial class frmGoal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGoal));
            this.gbGoalInfo = new System.Windows.Forms.GroupBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.dtpGoalEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpGoalStartDate = new System.Windows.Forms.DateTimePicker();
            this.txtTargetCalories = new System.Windows.Forms.TextBox();
            this.txtTargetWeightLoss = new System.Windows.Forms.TextBox();
            this.lblMemberID = new System.Windows.Forms.Label();
            this.lblGoalID = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblTargetCalories = new System.Windows.Forms.Label();
            this.lblTargetWeight = new System.Windows.Forms.Label();
            this.lblMember = new System.Windows.Forms.Label();
            this.lblGoal = new System.Windows.Forms.Label();
            this.gbGoalInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbGoalInfo
            // 
            this.gbGoalInfo.BackColor = System.Drawing.Color.Transparent;
            this.gbGoalInfo.Controls.Add(this.btnBack);
            this.gbGoalInfo.Controls.Add(this.btnClear);
            this.gbGoalInfo.Controls.Add(this.btnSave);
            this.gbGoalInfo.Controls.Add(this.txtDuration);
            this.gbGoalInfo.Controls.Add(this.dtpGoalEndDate);
            this.gbGoalInfo.Controls.Add(this.dtpGoalStartDate);
            this.gbGoalInfo.Controls.Add(this.txtTargetCalories);
            this.gbGoalInfo.Controls.Add(this.txtTargetWeightLoss);
            this.gbGoalInfo.Controls.Add(this.lblMemberID);
            this.gbGoalInfo.Controls.Add(this.lblGoalID);
            this.gbGoalInfo.Controls.Add(this.lblDuration);
            this.gbGoalInfo.Controls.Add(this.lblEndDate);
            this.gbGoalInfo.Controls.Add(this.lblStartDate);
            this.gbGoalInfo.Controls.Add(this.lblTargetCalories);
            this.gbGoalInfo.Controls.Add(this.lblTargetWeight);
            this.gbGoalInfo.Controls.Add(this.lblMember);
            this.gbGoalInfo.Controls.Add(this.lblGoal);
            this.gbGoalInfo.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbGoalInfo.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.gbGoalInfo.Location = new System.Drawing.Point(30, 33);
            this.gbGoalInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbGoalInfo.Name = "gbGoalInfo";
            this.gbGoalInfo.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbGoalInfo.Size = new System.Drawing.Size(807, 641);
            this.gbGoalInfo.TabIndex = 0;
            this.gbGoalInfo.TabStop = false;
            this.gbGoalInfo.Text = "Goal Information";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Location = new System.Drawing.Point(633, 544);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(133, 53);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "<<Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Location = new System.Drawing.Point(480, 544);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(133, 53);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Location = new System.Drawing.Point(329, 544);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(133, 53);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtDuration
            // 
            this.txtDuration.Location = new System.Drawing.Point(329, 466);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(437, 42);
            this.txtDuration.TabIndex = 7;
            // 
            // dtpGoalEndDate
            // 
            this.dtpGoalEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpGoalEndDate.Location = new System.Drawing.Point(329, 400);
            this.dtpGoalEndDate.Name = "dtpGoalEndDate";
            this.dtpGoalEndDate.Size = new System.Drawing.Size(437, 42);
            this.dtpGoalEndDate.TabIndex = 6;
            this.dtpGoalEndDate.ValueChanged += new System.EventHandler(this.dtpGoalEndDate_ValueChanged);
            // 
            // dtpGoalStartDate
            // 
            this.dtpGoalStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpGoalStartDate.Location = new System.Drawing.Point(329, 326);
            this.dtpGoalStartDate.Name = "dtpGoalStartDate";
            this.dtpGoalStartDate.Size = new System.Drawing.Size(437, 42);
            this.dtpGoalStartDate.TabIndex = 5;
            // 
            // txtTargetCalories
            // 
            this.txtTargetCalories.Location = new System.Drawing.Point(329, 258);
            this.txtTargetCalories.Name = "txtTargetCalories";
            this.txtTargetCalories.Size = new System.Drawing.Size(437, 42);
            this.txtTargetCalories.TabIndex = 4;
            //this.txtTargetCalories.TextChanged += new System.EventHandler(this.txtTargetCalories_TextChanged);
            // 
            // txtTargetWeightLoss
            // 
            this.txtTargetWeightLoss.Location = new System.Drawing.Point(329, 185);
            this.txtTargetWeightLoss.Name = "txtTargetWeightLoss";
            this.txtTargetWeightLoss.Size = new System.Drawing.Size(433, 42);
            this.txtTargetWeightLoss.TabIndex = 3;
            this.txtTargetWeightLoss.TextChanged += new System.EventHandler(this.txtTargetWeightLoss_TextChanged);
            // 
            // lblMemberID
            // 
            this.lblMemberID.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lblMemberID.Location = new System.Drawing.Point(329, 124);
            this.lblMemberID.Name = "lblMemberID";
            this.lblMemberID.Size = new System.Drawing.Size(433, 30);
            this.lblMemberID.TabIndex = 2;
            this.lblMemberID.Click += new System.EventHandler(this.lblUserName_Click);
            // 
            // lblGoalID
            // 
            this.lblGoalID.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lblGoalID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblGoalID.Location = new System.Drawing.Point(329, 60);
            this.lblGoalID.Name = "lblGoalID";
            this.lblGoalID.Size = new System.Drawing.Size(433, 30);
            this.lblGoalID.TabIndex = 1;
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Location = new System.Drawing.Point(38, 466);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(204, 35);
            this.lblDuration.TabIndex = 0;
            this.lblDuration.Text = "Duration (Days):";
            this.lblDuration.Click += new System.EventHandler(this.lblDuration_Click);
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(38, 400);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(129, 35);
            this.lblEndDate.TabIndex = 0;
            this.lblEndDate.Text = "End Date:";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(38, 333);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(142, 35);
            this.lblStartDate.TabIndex = 0;
            this.lblStartDate.Text = "Start Date:";
            // 
            // lblTargetCalories
            // 
            this.lblTargetCalories.AutoSize = true;
            this.lblTargetCalories.Location = new System.Drawing.Point(38, 258);
            this.lblTargetCalories.Name = "lblTargetCalories";
            this.lblTargetCalories.Size = new System.Drawing.Size(195, 35);
            this.lblTargetCalories.TabIndex = 0;
            this.lblTargetCalories.Text = "Target Calories:";
            // 
            // lblTargetWeight
            // 
            this.lblTargetWeight.AutoSize = true;
            this.lblTargetWeight.Location = new System.Drawing.Point(38, 190);
            this.lblTargetWeight.Name = "lblTargetWeight";
            this.lblTargetWeight.Size = new System.Drawing.Size(286, 35);
            this.lblTargetWeight.TabIndex = 0;
            this.lblTargetWeight.Text = "Target Weight Loss (lb):";
            // 
            // lblMember
            // 
            this.lblMember.AutoSize = true;
            this.lblMember.Location = new System.Drawing.Point(38, 120);
            this.lblMember.Name = "lblMember";
            this.lblMember.Size = new System.Drawing.Size(154, 35);
            this.lblMember.TabIndex = 0;
            this.lblMember.Text = "Member ID:";
            // 
            // lblGoal
            // 
            this.lblGoal.AutoSize = true;
            this.lblGoal.Location = new System.Drawing.Point(38, 60);
            this.lblGoal.Name = "lblGoal";
            this.lblGoal.Size = new System.Drawing.Size(108, 35);
            this.lblGoal.TabIndex = 0;
            this.lblGoal.Text = "Goal ID:";
            // 
            // frmGoal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Fitness_Tracker_DDOOCP.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1163, 773);
            this.Controls.Add(this.gbGoalInfo);
            this.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmGoal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Goal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmGoal_Load);
            this.gbGoalInfo.ResumeLayout(false);
            this.gbGoalInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbGoalInfo;
        private System.Windows.Forms.Label lblMember;
        private System.Windows.Forms.Label lblGoal;
        private System.Windows.Forms.Label lblTargetWeight;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblTargetCalories;
        private System.Windows.Forms.Label lblGoalID;
        private System.Windows.Forms.TextBox txtTargetWeightLoss;
        private System.Windows.Forms.Label lblMemberID;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.DateTimePicker dtpGoalEndDate;
        private System.Windows.Forms.DateTimePicker dtpGoalStartDate;
        private System.Windows.Forms.TextBox txtTargetCalories;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnBack;
    }
}