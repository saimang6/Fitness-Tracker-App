namespace Fitness_Tracker_DDOOCP
{
    partial class frmAdminLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminLogin));
            this.gbAdminLogin = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvAdmin = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.linkAdminRegistration = new System.Windows.Forms.LinkLabel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtAdminPassword = new System.Windows.Forms.TextBox();
            this.txtAdminUserName = new System.Windows.Forms.TextBox();
            this.lblAdminPassword = new System.Windows.Forms.Label();
            this.lblAdminUserName = new System.Windows.Forms.Label();
            this.gbAdminLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // gbAdminLogin
            // 
            this.gbAdminLogin.BackColor = System.Drawing.Color.Transparent;
            this.gbAdminLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.gbAdminLogin.Controls.Add(this.pictureBox1);
            this.gbAdminLogin.Controls.Add(this.dgvAdmin);
            this.gbAdminLogin.Controls.Add(this.label1);
            this.gbAdminLogin.Controls.Add(this.linkAdminRegistration);
            this.gbAdminLogin.Controls.Add(this.btnClear);
            this.gbAdminLogin.Controls.Add(this.btnLogin);
            this.gbAdminLogin.Controls.Add(this.txtAdminPassword);
            this.gbAdminLogin.Controls.Add(this.txtAdminUserName);
            this.gbAdminLogin.Controls.Add(this.lblAdminPassword);
            this.gbAdminLogin.Controls.Add(this.lblAdminUserName);
            this.gbAdminLogin.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAdminLogin.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.gbAdminLogin.Location = new System.Drawing.Point(60, 41);
            this.gbAdminLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbAdminLogin.Name = "gbAdminLogin";
            this.gbAdminLogin.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbAdminLogin.Size = new System.Drawing.Size(603, 628);
            this.gbAdminLogin.TabIndex = 0;
            this.gbAdminLogin.TabStop = false;
            this.gbAdminLogin.Text = "Admin Login Form";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Fitness_Tracker_DDOOCP.Properties.Resources.Login;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(253, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 90);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // dgvAdmin
            // 
            this.dgvAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdmin.Location = new System.Drawing.Point(120, 595);
            this.dgvAdmin.Name = "dgvAdmin";
            this.dgvAdmin.RowTemplate.Height = 28;
            this.dgvAdmin.Size = new System.Drawing.Size(367, 19);
            this.dgvAdmin.TabIndex = 7;
            this.dgvAdmin.Visible = false;
            this.dgvAdmin.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAdmin_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(213, 493);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 35);
            this.label1.TabIndex = 6;
            this.label1.Text = "Don\'t have an account?";
            // 
            // linkAdminRegistration
            // 
            this.linkAdminRegistration.ActiveLinkColor = System.Drawing.Color.White;
            this.linkAdminRegistration.AutoSize = true;
            this.linkAdminRegistration.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkAdminRegistration.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkAdminRegistration.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.linkAdminRegistration.LinkColor = System.Drawing.Color.PaleTurquoise;
            this.linkAdminRegistration.Location = new System.Drawing.Point(230, 546);
            this.linkAdminRegistration.Name = "linkAdminRegistration";
            this.linkAdminRegistration.Size = new System.Drawing.Size(226, 29);
            this.linkAdminRegistration.TabIndex = 5;
            this.linkAdminRegistration.TabStop = true;
            this.linkAdminRegistration.Text = "Click Here to Register";
            this.linkAdminRegistration.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkAdminRegistration_LinkClicked);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Location = new System.Drawing.Point(325, 405);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(162, 52);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Location = new System.Drawing.Point(120, 405);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(162, 52);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtAdminPassword
            // 
            this.txtAdminPassword.Location = new System.Drawing.Point(120, 326);
            this.txtAdminPassword.Name = "txtAdminPassword";
            this.txtAdminPassword.Size = new System.Drawing.Size(364, 42);
            this.txtAdminPassword.TabIndex = 2;
            this.txtAdminPassword.UseSystemPasswordChar = true;
            // 
            // txtAdminUserName
            // 
            this.txtAdminUserName.Location = new System.Drawing.Point(120, 210);
            this.txtAdminUserName.Name = "txtAdminUserName";
            this.txtAdminUserName.Size = new System.Drawing.Size(364, 42);
            this.txtAdminUserName.TabIndex = 1;
            // 
            // lblAdminPassword
            // 
            this.lblAdminPassword.AutoSize = true;
            this.lblAdminPassword.Location = new System.Drawing.Point(114, 273);
            this.lblAdminPassword.Name = "lblAdminPassword";
            this.lblAdminPassword.Size = new System.Drawing.Size(217, 35);
            this.lblAdminPassword.TabIndex = 0;
            this.lblAdminPassword.Text = "Admin Password:";
            // 
            // lblAdminUserName
            // 
            this.lblAdminUserName.AutoSize = true;
            this.lblAdminUserName.Location = new System.Drawing.Point(114, 164);
            this.lblAdminUserName.Name = "lblAdminUserName";
            this.lblAdminUserName.Size = new System.Drawing.Size(234, 35);
            this.lblAdminUserName.TabIndex = 0;
            this.lblAdminUserName.Text = "Admin User Name:";
            // 
            // frmAdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::Fitness_Tracker_DDOOCP.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1242, 788);
            this.Controls.Add(this.gbAdminLogin);
            this.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmAdminLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Login";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.gbAdminLogin.ResumeLayout(false);
            this.gbAdminLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAdminLogin;
        private System.Windows.Forms.TextBox txtAdminUserName;
        private System.Windows.Forms.Label lblAdminPassword;
        private System.Windows.Forms.Label lblAdminUserName;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtAdminPassword;
        private System.Windows.Forms.LinkLabel linkAdminRegistration;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvAdmin;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}