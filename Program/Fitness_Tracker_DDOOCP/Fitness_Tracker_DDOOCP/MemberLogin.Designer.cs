namespace Fitness_Tracker_DDOOCP
{
    partial class frmMemberLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMemberLogin));
            this.gbMemberLogin = new System.Windows.Forms.GroupBox();
            this.dgvMember = new System.Windows.Forms.DataGridView();
            this.linkMemberRegistration = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtMemberPassword = new System.Windows.Forms.TextBox();
            this.txtMemberUserName = new System.Windows.Forms.TextBox();
            this.lblMemberPassword = new System.Windows.Forms.Label();
            this.lblMemberUserName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbMemberLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMember)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbMemberLogin
            // 
            this.gbMemberLogin.BackColor = System.Drawing.Color.Transparent;
            this.gbMemberLogin.Controls.Add(this.dgvMember);
            this.gbMemberLogin.Controls.Add(this.linkMemberRegistration);
            this.gbMemberLogin.Controls.Add(this.label1);
            this.gbMemberLogin.Controls.Add(this.btnClear);
            this.gbMemberLogin.Controls.Add(this.btnLogin);
            this.gbMemberLogin.Controls.Add(this.txtMemberPassword);
            this.gbMemberLogin.Controls.Add(this.txtMemberUserName);
            this.gbMemberLogin.Controls.Add(this.lblMemberPassword);
            this.gbMemberLogin.Controls.Add(this.lblMemberUserName);
            this.gbMemberLogin.Controls.Add(this.pictureBox1);
            this.gbMemberLogin.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMemberLogin.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.gbMemberLogin.Location = new System.Drawing.Point(60, 41);
            this.gbMemberLogin.Name = "gbMemberLogin";
            this.gbMemberLogin.Size = new System.Drawing.Size(603, 628);
            this.gbMemberLogin.TabIndex = 0;
            this.gbMemberLogin.TabStop = false;
            this.gbMemberLogin.Text = "Member Login Form";
            // 
            // dgvMember
            // 
            this.dgvMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMember.Location = new System.Drawing.Point(120, 595);
            this.dgvMember.Name = "dgvMember";
            this.dgvMember.RowTemplate.Height = 28;
            this.dgvMember.Size = new System.Drawing.Size(367, 19);
            this.dgvMember.TabIndex = 9;
            this.dgvMember.Visible = false;
            // 
            // linkMemberRegistration
            // 
            this.linkMemberRegistration.ActiveLinkColor = System.Drawing.Color.White;
            this.linkMemberRegistration.AutoSize = true;
            this.linkMemberRegistration.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkMemberRegistration.LinkColor = System.Drawing.Color.PaleTurquoise;
            this.linkMemberRegistration.Location = new System.Drawing.Point(230, 546);
            this.linkMemberRegistration.Name = "linkMemberRegistration";
            this.linkMemberRegistration.Size = new System.Drawing.Size(226, 29);
            this.linkMemberRegistration.TabIndex = 8;
            this.linkMemberRegistration.TabStop = true;
            this.linkMemberRegistration.Text = "Click Here to Register";
            this.linkMemberRegistration.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkMemberRegistration_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(213, 493);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 35);
            this.label1.TabIndex = 7;
            this.label1.Text = "Don\'t have an account?";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Location = new System.Drawing.Point(325, 405);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(162, 52);
            this.btnClear.TabIndex = 5;
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
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtMemberPassword
            // 
            this.txtMemberPassword.Location = new System.Drawing.Point(120, 326);
            this.txtMemberPassword.Name = "txtMemberPassword";
            this.txtMemberPassword.Size = new System.Drawing.Size(364, 42);
            this.txtMemberPassword.TabIndex = 3;
            this.txtMemberPassword.UseSystemPasswordChar = true;
            // 
            // txtMemberUserName
            // 
            this.txtMemberUserName.Location = new System.Drawing.Point(120, 210);
            this.txtMemberUserName.Name = "txtMemberUserName";
            this.txtMemberUserName.Size = new System.Drawing.Size(364, 42);
            this.txtMemberUserName.TabIndex = 2;
            // 
            // lblMemberPassword
            // 
            this.lblMemberPassword.AutoSize = true;
            this.lblMemberPassword.Location = new System.Drawing.Point(114, 273);
            this.lblMemberPassword.Name = "lblMemberPassword";
            this.lblMemberPassword.Size = new System.Drawing.Size(246, 35);
            this.lblMemberPassword.TabIndex = 1;
            this.lblMemberPassword.Text = "Member Password: ";
            // 
            // lblMemberUserName
            // 
            this.lblMemberUserName.AutoSize = true;
            this.lblMemberUserName.Location = new System.Drawing.Point(114, 164);
            this.lblMemberUserName.Name = "lblMemberUserName";
            this.lblMemberUserName.Size = new System.Drawing.Size(263, 35);
            this.lblMemberUserName.TabIndex = 1;
            this.lblMemberUserName.Text = "Member User Name: ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Fitness_Tracker_DDOOCP.Properties.Resources.Login;
            this.pictureBox1.Location = new System.Drawing.Point(253, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 90);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmMemberLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::Fitness_Tracker_DDOOCP.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1107, 789);
            this.Controls.Add(this.gbMemberLogin);
            this.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMemberLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Member Login";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.gbMemberLogin.ResumeLayout(false);
            this.gbMemberLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMember)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbMemberLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblMemberUserName;
        private System.Windows.Forms.TextBox txtMemberUserName;
        private System.Windows.Forms.Label lblMemberPassword;
        private System.Windows.Forms.TextBox txtMemberPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkMemberRegistration;
        private System.Windows.Forms.DataGridView dgvMember;
    }
}