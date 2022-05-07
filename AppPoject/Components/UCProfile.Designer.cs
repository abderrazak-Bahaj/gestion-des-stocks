namespace AppPoject.Components
{
    partial class UCProfile
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PBUser = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.LblFirstName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LblLastName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbl_address = new System.Windows.Forms.Label();
            this.LblEmail = new System.Windows.Forms.Label();
            this.LblDateBurth = new System.Windows.Forms.Label();
            this.LblTypeUser = new System.Windows.Forms.Label();
            this.btnEditProfile = new Guna.UI2.WinForms.Guna2Button();
            this.BtnEditPassword = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.PBUser)).BeginInit();
            this.SuspendLayout();
            // 
            // PBUser
            // 
            this.PBUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PBUser.BaseColor = System.Drawing.Color.White;
            this.PBUser.Image = global::AppPoject.Properties.Resources.circled_user;
            this.PBUser.Location = new System.Drawing.Point(50, 34);
            this.PBUser.Name = "PBUser";
            this.PBUser.Size = new System.Drawing.Size(196, 184);
            this.PBUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBUser.TabIndex = 0;
            this.PBUser.TabStop = false;
            this.PBUser.UseTransfarantBackground = false;
            // 
            // LblFirstName
            // 
            this.LblFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblFirstName.BackColor = System.Drawing.Color.Transparent;
            this.LblFirstName.Location = new System.Drawing.Point(272, 44);
            this.LblFirstName.Name = "LblFirstName";
            this.LblFirstName.Size = new System.Drawing.Size(154, 40);
            this.LblFirstName.TabIndex = 1;
            this.LblFirstName.Text = "FirstName";
            // 
            // LblLastName
            // 
            this.LblLastName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblLastName.BackColor = System.Drawing.Color.Transparent;
            this.LblLastName.Location = new System.Drawing.Point(272, 104);
            this.LblLastName.Name = "LblLastName";
            this.LblLastName.Size = new System.Drawing.Size(141, 40);
            this.LblLastName.TabIndex = 3;
            this.LblLastName.Text = "lastName";
            // 
            // lbl_address
            // 
            this.lbl_address.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_address.AutoSize = true;
            this.lbl_address.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_address.Location = new System.Drawing.Point(267, 220);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(90, 28);
            this.lbl_address.TabIndex = 4;
            this.lbl_address.Text = "address";
            // 
            // LblEmail
            // 
            this.LblEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblEmail.AutoSize = true;
            this.LblEmail.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmail.Location = new System.Drawing.Point(267, 177);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(68, 28);
            this.LblEmail.TabIndex = 5;
            this.LblEmail.Text = "Email";
            // 
            // LblDateBurth
            // 
            this.LblDateBurth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblDateBurth.AutoSize = true;
            this.LblDateBurth.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDateBurth.Location = new System.Drawing.Point(267, 266);
            this.LblDateBurth.Name = "LblDateBurth";
            this.LblDateBurth.Size = new System.Drawing.Size(121, 28);
            this.LblDateBurth.TabIndex = 6;
            this.LblDateBurth.Text = "Date Burth";
            // 
            // LblTypeUser
            // 
            this.LblTypeUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblTypeUser.AutoSize = true;
            this.LblTypeUser.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTypeUser.Location = new System.Drawing.Point(90, 233);
            this.LblTypeUser.Name = "LblTypeUser";
            this.LblTypeUser.Size = new System.Drawing.Size(106, 28);
            this.LblTypeUser.TabIndex = 7;
            this.LblTypeUser.Text = "TypeUser";
            // 
            // btnEditProfile
            // 
            this.btnEditProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditProfile.CheckedState.Parent = this.btnEditProfile;
            this.btnEditProfile.CustomImages.Parent = this.btnEditProfile;
            this.btnEditProfile.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnEditProfile.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditProfile.ForeColor = System.Drawing.Color.White;
            this.btnEditProfile.HoverState.Parent = this.btnEditProfile;
            this.btnEditProfile.Location = new System.Drawing.Point(255, 371);
            this.btnEditProfile.Name = "btnEditProfile";
            this.btnEditProfile.ShadowDecoration.Parent = this.btnEditProfile;
            this.btnEditProfile.Size = new System.Drawing.Size(133, 45);
            this.btnEditProfile.TabIndex = 8;
            this.btnEditProfile.Text = "Edit Profile";
            this.btnEditProfile.Click += new System.EventHandler(this.btnEditProfile_Click);
            // 
            // BtnEditPassword
            // 
            this.BtnEditPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEditPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.BtnEditPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.BtnEditPassword.BorderThickness = 1;
            this.BtnEditPassword.CheckedState.Parent = this.BtnEditPassword;
            this.BtnEditPassword.CustomImages.Parent = this.BtnEditPassword;
            this.BtnEditPassword.FillColor = System.Drawing.Color.White;
            this.BtnEditPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.BtnEditPassword.HoverState.Parent = this.BtnEditPassword;
            this.BtnEditPassword.Location = new System.Drawing.Point(415, 371);
            this.BtnEditPassword.Name = "BtnEditPassword";
            this.BtnEditPassword.ShadowDecoration.Parent = this.BtnEditPassword;
            this.BtnEditPassword.Size = new System.Drawing.Size(133, 45);
            this.BtnEditPassword.TabIndex = 9;
            this.BtnEditPassword.Text = "Edit Password";
            this.BtnEditPassword.Click += new System.EventHandler(this.BtnEditPassword_Click);
            // 
            // UCProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.BtnEditPassword);
            this.Controls.Add(this.btnEditProfile);
            this.Controls.Add(this.LblTypeUser);
            this.Controls.Add(this.LblDateBurth);
            this.Controls.Add(this.LblEmail);
            this.Controls.Add(this.lbl_address);
            this.Controls.Add(this.LblLastName);
            this.Controls.Add(this.LblFirstName);
            this.Controls.Add(this.PBUser);
            this.Name = "UCProfile";
            this.Size = new System.Drawing.Size(797, 547);
            this.Load += new System.EventHandler(this.UCProfile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PBUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaCirclePictureBox PBUser;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblFirstName;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblLastName;
        private System.Windows.Forms.Label lbl_address;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.Label LblDateBurth;
        private System.Windows.Forms.Label LblTypeUser;
        private Guna.UI2.WinForms.Guna2Button btnEditProfile;
        private Guna.UI2.WinForms.Guna2Button BtnEditPassword;
    }
}
