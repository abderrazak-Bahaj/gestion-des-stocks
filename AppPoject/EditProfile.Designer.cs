namespace AppPoject
{
    partial class EditProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditProfile));
            this.btnEdit = new Guna.UI2.WinForms.Guna2Button();
            this.DPDateBurth = new Guna.UI.WinForms.GunaDateTimePicker();
            this.TxtAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.TxtLastname = new Guna.UI2.WinForms.Guna2TextBox();
            this.TxtFirstname = new Guna.UI2.WinForms.Guna2TextBox();
            this.TxtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl = new Guna.UI.WinForms.GunaLabel();
            this.ShadowForm = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.gunaCirclePictureBox1 = new Guna.UI.WinForms.GunaCirclePictureBox();
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
            this.btnEdit.Location = new System.Drawing.Point(106, 466);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.ShadowDecoration.Parent = this.btnEdit;
            this.btnEdit.Size = new System.Drawing.Size(133, 45);
            this.btnEdit.TabIndex = 15;
            this.btnEdit.Text = "Edit";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // DPDateBurth
            // 
            this.DPDateBurth.BaseColor = System.Drawing.Color.White;
            this.DPDateBurth.BorderColor = System.Drawing.Color.Silver;
            this.DPDateBurth.BorderSize = 1;
            this.DPDateBurth.CustomFormat = null;
            this.DPDateBurth.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.DPDateBurth.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DPDateBurth.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DPDateBurth.ForeColor = System.Drawing.Color.Black;
            this.DPDateBurth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DPDateBurth.Location = new System.Drawing.Point(179, 411);
            this.DPDateBurth.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DPDateBurth.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DPDateBurth.Name = "DPDateBurth";
            this.DPDateBurth.OnHoverBaseColor = System.Drawing.Color.White;
            this.DPDateBurth.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DPDateBurth.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DPDateBurth.OnPressedColor = System.Drawing.Color.Black;
            this.DPDateBurth.Size = new System.Drawing.Size(144, 36);
            this.DPDateBurth.TabIndex = 33;
            this.DPDateBurth.Text = "29/03/2022";
            this.DPDateBurth.Value = new System.DateTime(2022, 3, 29, 20, 42, 32, 477);
            // 
            // TxtAddress
            // 
            this.TxtAddress.BackColor = System.Drawing.Color.Cornsilk;
            this.TxtAddress.BorderColor = System.Drawing.Color.Blue;
            this.TxtAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtAddress.DefaultText = "";
            this.TxtAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtAddress.DisabledState.Parent = this.TxtAddress;
            this.TxtAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtAddress.FillColor = System.Drawing.Color.Snow;
            this.TxtAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtAddress.FocusedState.Parent = this.TxtAddress;
            this.TxtAddress.ForeColor = System.Drawing.Color.Fuchsia;
            this.TxtAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtAddress.HoverState.Parent = this.TxtAddress;
            this.TxtAddress.IconRight = global::AppPoject.Properties.Resources.address;
            this.TxtAddress.IconRightOffset = new System.Drawing.Point(3, 0);
            this.TxtAddress.Location = new System.Drawing.Point(60, 327);
            this.TxtAddress.Name = "TxtAddress";
            this.TxtAddress.PasswordChar = '\0';
            this.TxtAddress.PlaceholderForeColor = System.Drawing.Color.Fuchsia;
            this.TxtAddress.PlaceholderText = "Address";
            this.TxtAddress.SelectedText = "";
            this.TxtAddress.ShadowDecoration.Parent = this.TxtAddress;
            this.TxtAddress.Size = new System.Drawing.Size(266, 36);
            this.TxtAddress.TabIndex = 32;
            // 
            // TxtLastname
            // 
            this.TxtLastname.BackColor = System.Drawing.Color.Cornsilk;
            this.TxtLastname.BorderColor = System.Drawing.Color.Blue;
            this.TxtLastname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtLastname.DefaultText = "";
            this.TxtLastname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtLastname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtLastname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtLastname.DisabledState.Parent = this.TxtLastname;
            this.TxtLastname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtLastname.FillColor = System.Drawing.Color.Snow;
            this.TxtLastname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtLastname.FocusedState.Parent = this.TxtLastname;
            this.TxtLastname.ForeColor = System.Drawing.Color.Fuchsia;
            this.TxtLastname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtLastname.HoverState.Parent = this.TxtLastname;
            this.TxtLastname.IconRight = global::AppPoject.Properties.Resources.name;
            this.TxtLastname.IconRightOffset = new System.Drawing.Point(3, 0);
            this.TxtLastname.Location = new System.Drawing.Point(59, 285);
            this.TxtLastname.Name = "TxtLastname";
            this.TxtLastname.PasswordChar = '\0';
            this.TxtLastname.PlaceholderForeColor = System.Drawing.Color.Fuchsia;
            this.TxtLastname.PlaceholderText = "Last Name";
            this.TxtLastname.SelectedText = "";
            this.TxtLastname.ShadowDecoration.Parent = this.TxtLastname;
            this.TxtLastname.Size = new System.Drawing.Size(266, 36);
            this.TxtLastname.TabIndex = 31;
            // 
            // TxtFirstname
            // 
            this.TxtFirstname.BackColor = System.Drawing.Color.Cornsilk;
            this.TxtFirstname.BorderColor = System.Drawing.Color.Blue;
            this.TxtFirstname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtFirstname.DefaultText = "";
            this.TxtFirstname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtFirstname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtFirstname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtFirstname.DisabledState.Parent = this.TxtFirstname;
            this.TxtFirstname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtFirstname.FillColor = System.Drawing.Color.Snow;
            this.TxtFirstname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtFirstname.FocusedState.Parent = this.TxtFirstname;
            this.TxtFirstname.ForeColor = System.Drawing.Color.Fuchsia;
            this.TxtFirstname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtFirstname.HoverState.Parent = this.TxtFirstname;
            this.TxtFirstname.IconRight = global::AppPoject.Properties.Resources.name;
            this.TxtFirstname.IconRightOffset = new System.Drawing.Point(3, 0);
            this.TxtFirstname.Location = new System.Drawing.Point(59, 243);
            this.TxtFirstname.Name = "TxtFirstname";
            this.TxtFirstname.PasswordChar = '\0';
            this.TxtFirstname.PlaceholderForeColor = System.Drawing.Color.Fuchsia;
            this.TxtFirstname.PlaceholderText = "First Name";
            this.TxtFirstname.SelectedText = "";
            this.TxtFirstname.ShadowDecoration.Parent = this.TxtFirstname;
            this.TxtFirstname.Size = new System.Drawing.Size(266, 36);
            this.TxtFirstname.TabIndex = 30;
            // 
            // TxtPassword
            // 
            this.TxtPassword.BackColor = System.Drawing.Color.Cornsilk;
            this.TxtPassword.BorderColor = System.Drawing.Color.Blue;
            this.TxtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtPassword.DefaultText = "";
            this.TxtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtPassword.DisabledState.Parent = this.TxtPassword;
            this.TxtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtPassword.FillColor = System.Drawing.Color.Snow;
            this.TxtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtPassword.FocusedState.Parent = this.TxtPassword;
            this.TxtPassword.ForeColor = System.Drawing.Color.Fuchsia;
            this.TxtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtPassword.HoverState.Parent = this.TxtPassword;
            this.TxtPassword.IconRight = global::AppPoject.Properties.Resources.password;
            this.TxtPassword.IconRightOffset = new System.Drawing.Point(3, 0);
            this.TxtPassword.Location = new System.Drawing.Point(60, 369);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.PasswordChar = '*';
            this.TxtPassword.PlaceholderForeColor = System.Drawing.Color.Fuchsia;
            this.TxtPassword.PlaceholderText = "Password";
            this.TxtPassword.SelectedText = "";
            this.TxtPassword.ShadowDecoration.BorderRadius = 10;
            this.TxtPassword.ShadowDecoration.Parent = this.TxtPassword;
            this.TxtPassword.Size = new System.Drawing.Size(266, 36);
            this.TxtPassword.TabIndex = 34;
            this.TxtPassword.UseSystemPasswordChar = true;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(58, 420);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(84, 21);
            this.lbl.TabIndex = 35;
            this.lbl.Text = "Date burth";
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
            this.btnClose.Location = new System.Drawing.Point(325, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.ShadowDecoration.Parent = this.btnClose;
            this.btnClose.Size = new System.Drawing.Size(42, 38);
            this.btnClose.TabIndex = 18;
            this.btnClose.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // gunaCirclePictureBox1
            // 
            this.gunaCirclePictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.gunaCirclePictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaCirclePictureBox1.Image = global::AppPoject.Properties.Resources.circled_user;
            this.gunaCirclePictureBox1.Location = new System.Drawing.Point(94, 34);
            this.gunaCirclePictureBox1.Name = "gunaCirclePictureBox1";
            this.gunaCirclePictureBox1.Size = new System.Drawing.Size(199, 194);
            this.gunaCirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaCirclePictureBox1.TabIndex = 17;
            this.gunaCirclePictureBox1.TabStop = false;
            this.gunaCirclePictureBox1.UseTransfarantBackground = false;
            // 
            // EditProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(379, 527);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.DPDateBurth);
            this.Controls.Add(this.TxtAddress);
            this.Controls.Add(this.TxtLastname);
            this.Controls.Add(this.TxtFirstname);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gunaCirclePictureBox1);
            this.Controls.Add(this.btnEdit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditProfile";
            this.Load += new System.EventHandler(this.EditProfile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI.WinForms.GunaCirclePictureBox gunaCirclePictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnEdit;
        private Guna.UI.WinForms.GunaDateTimePicker DPDateBurth;
        private Guna.UI2.WinForms.Guna2TextBox TxtAddress;
        private Guna.UI2.WinForms.Guna2TextBox TxtLastname;
        private Guna.UI2.WinForms.Guna2TextBox TxtFirstname;
        private Guna.UI2.WinForms.Guna2TextBox TxtPassword;
        private Guna.UI.WinForms.GunaLabel lbl;
        private Guna.UI2.WinForms.Guna2ShadowForm ShadowForm;
    }
}