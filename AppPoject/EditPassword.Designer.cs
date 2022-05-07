namespace AppPoject
{
    partial class EditPassword
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditPassword));
            this.btnEdit = new Guna.UI2.WinForms.Guna2Button();
            this.TxtNewPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.TxtConfirmNewPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.ShadowForm = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.gunaCirclePictureBox1 = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.TxtCurrentPassword = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEdit
            // 
            this.btnEdit.CheckedState.Parent = this.btnEdit;
            this.btnEdit.CustomImages.Parent = this.btnEdit;
            this.btnEdit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnEdit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.HoverState.Parent = this.btnEdit;
            this.btnEdit.Location = new System.Drawing.Point(115, 430);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.ShadowDecoration.Parent = this.btnEdit;
            this.btnEdit.Size = new System.Drawing.Size(133, 45);
            this.btnEdit.TabIndex = 10;
            this.btnEdit.Text = "Edit";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // TxtNewPassword
            // 
            this.TxtNewPassword.BackColor = System.Drawing.Color.Cornsilk;
            this.TxtNewPassword.BorderColor = System.Drawing.Color.Blue;
            this.TxtNewPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtNewPassword.DefaultText = "";
            this.TxtNewPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtNewPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtNewPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtNewPassword.DisabledState.Parent = this.TxtNewPassword;
            this.TxtNewPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtNewPassword.FillColor = System.Drawing.Color.Snow;
            this.TxtNewPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtNewPassword.FocusedState.Parent = this.TxtNewPassword;
            this.TxtNewPassword.ForeColor = System.Drawing.Color.Fuchsia;
            this.TxtNewPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtNewPassword.HoverState.Parent = this.TxtNewPassword;
            this.TxtNewPassword.IconRight = global::AppPoject.Properties.Resources.password;
            this.TxtNewPassword.IconRightOffset = new System.Drawing.Point(3, 0);
            this.TxtNewPassword.Location = new System.Drawing.Point(50, 322);
            this.TxtNewPassword.Name = "TxtNewPassword";
            this.TxtNewPassword.PasswordChar = '*';
            this.TxtNewPassword.PlaceholderForeColor = System.Drawing.Color.Fuchsia;
            this.TxtNewPassword.PlaceholderText = "New Password";
            this.TxtNewPassword.SelectedText = "";
            this.TxtNewPassword.ShadowDecoration.BorderRadius = 10;
            this.TxtNewPassword.ShadowDecoration.Parent = this.TxtNewPassword;
            this.TxtNewPassword.Size = new System.Drawing.Size(270, 36);
            this.TxtNewPassword.TabIndex = 15;
            this.TxtNewPassword.UseSystemPasswordChar = true;
            // 
            // TxtConfirmNewPassword
            // 
            this.TxtConfirmNewPassword.BackColor = System.Drawing.Color.Cornsilk;
            this.TxtConfirmNewPassword.BorderColor = System.Drawing.Color.Blue;
            this.TxtConfirmNewPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtConfirmNewPassword.DefaultText = "";
            this.TxtConfirmNewPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtConfirmNewPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtConfirmNewPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtConfirmNewPassword.DisabledState.Parent = this.TxtConfirmNewPassword;
            this.TxtConfirmNewPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtConfirmNewPassword.FillColor = System.Drawing.Color.Snow;
            this.TxtConfirmNewPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtConfirmNewPassword.FocusedState.Parent = this.TxtConfirmNewPassword;
            this.TxtConfirmNewPassword.ForeColor = System.Drawing.Color.Fuchsia;
            this.TxtConfirmNewPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtConfirmNewPassword.HoverState.Parent = this.TxtConfirmNewPassword;
            this.TxtConfirmNewPassword.IconRight = global::AppPoject.Properties.Resources.password;
            this.TxtConfirmNewPassword.IconRightOffset = new System.Drawing.Point(3, 0);
            this.TxtConfirmNewPassword.Location = new System.Drawing.Point(50, 376);
            this.TxtConfirmNewPassword.Name = "TxtConfirmNewPassword";
            this.TxtConfirmNewPassword.PasswordChar = '*';
            this.TxtConfirmNewPassword.PlaceholderForeColor = System.Drawing.Color.Fuchsia;
            this.TxtConfirmNewPassword.PlaceholderText = "Confirm New Password";
            this.TxtConfirmNewPassword.SelectedText = "";
            this.TxtConfirmNewPassword.ShadowDecoration.BorderRadius = 10;
            this.TxtConfirmNewPassword.ShadowDecoration.Parent = this.TxtConfirmNewPassword;
            this.TxtConfirmNewPassword.Size = new System.Drawing.Size(270, 36);
            this.TxtConfirmNewPassword.TabIndex = 16;
            this.TxtConfirmNewPassword.UseSystemPasswordChar = true;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.CheckedState.Parent = this.btnClose;
            this.btnClose.CustomImages.Parent = this.btnClose;
            this.btnClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnClose.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Gray;
            this.btnClose.HoverState.FillColor = System.Drawing.Color.Red;
            this.btnClose.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnClose.HoverState.Parent = this.btnClose;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnClose.Location = new System.Drawing.Point(308, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.ShadowDecoration.Parent = this.btnClose;
            this.btnClose.Size = new System.Drawing.Size(42, 38);
            this.btnClose.TabIndex = 14;
            this.btnClose.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // gunaCirclePictureBox1
            // 
            this.gunaCirclePictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.gunaCirclePictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaCirclePictureBox1.Image = global::AppPoject.Properties.Resources.circled_user;
            this.gunaCirclePictureBox1.Location = new System.Drawing.Point(85, 48);
            this.gunaCirclePictureBox1.Name = "gunaCirclePictureBox1";
            this.gunaCirclePictureBox1.Size = new System.Drawing.Size(199, 194);
            this.gunaCirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaCirclePictureBox1.TabIndex = 13;
            this.gunaCirclePictureBox1.TabStop = false;
            this.gunaCirclePictureBox1.UseTransfarantBackground = false;
            // 
            // TxtCurrentPassword
            // 
            this.TxtCurrentPassword.BackColor = System.Drawing.Color.Cornsilk;
            this.TxtCurrentPassword.BorderColor = System.Drawing.Color.Blue;
            this.TxtCurrentPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtCurrentPassword.DefaultText = "";
            this.TxtCurrentPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtCurrentPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtCurrentPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtCurrentPassword.DisabledState.Parent = this.TxtCurrentPassword;
            this.TxtCurrentPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtCurrentPassword.FillColor = System.Drawing.Color.Snow;
            this.TxtCurrentPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtCurrentPassword.FocusedState.Parent = this.TxtCurrentPassword;
            this.TxtCurrentPassword.ForeColor = System.Drawing.Color.Fuchsia;
            this.TxtCurrentPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtCurrentPassword.HoverState.Parent = this.TxtCurrentPassword;
            this.TxtCurrentPassword.IconRight = global::AppPoject.Properties.Resources.password;
            this.TxtCurrentPassword.IconRightOffset = new System.Drawing.Point(3, 0);
            this.TxtCurrentPassword.Location = new System.Drawing.Point(50, 270);
            this.TxtCurrentPassword.Name = "TxtCurrentPassword";
            this.TxtCurrentPassword.PasswordChar = '*';
            this.TxtCurrentPassword.PlaceholderForeColor = System.Drawing.Color.Fuchsia;
            this.TxtCurrentPassword.PlaceholderText = "CurrentPassword";
            this.TxtCurrentPassword.SelectedText = "";
            this.TxtCurrentPassword.ShadowDecoration.BorderRadius = 10;
            this.TxtCurrentPassword.ShadowDecoration.Parent = this.TxtCurrentPassword;
            this.TxtCurrentPassword.Size = new System.Drawing.Size(270, 36);
            this.TxtCurrentPassword.TabIndex = 11;
            this.TxtCurrentPassword.UseSystemPasswordChar = true;
            // 
            // EditPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(362, 536);
            this.Controls.Add(this.TxtConfirmNewPassword);
            this.Controls.Add(this.TxtNewPassword);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gunaCirclePictureBox1);
            this.Controls.Add(this.TxtCurrentPassword);
            this.Controls.Add(this.btnEdit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditPassword";
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI.WinForms.GunaCirclePictureBox gunaCirclePictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox TxtCurrentPassword;
        private Guna.UI2.WinForms.Guna2Button btnEdit;
        private Guna.UI2.WinForms.Guna2TextBox TxtNewPassword;
        private Guna.UI2.WinForms.Guna2TextBox TxtConfirmNewPassword;
        private Guna.UI2.WinForms.Guna2ShadowForm ShadowForm;
    }
}