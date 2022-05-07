namespace AppPoject.Components
{
    partial class UCUser
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCUser));
            this.PnGery = new System.Windows.Forms.Panel();
            this.btnRest = new Guna.UI2.WinForms.Guna2Button();
            this.BtnRemove = new Guna.UI2.WinForms.Guna2ImageButton();
            this.BtnAdd = new Guna.UI2.WinForms.Guna2ImageButton();
            this.BtnEdit = new Guna.UI2.WinForms.Guna2ImageButton();
            this.BtnVider = new Guna.UI2.WinForms.Guna2ImageButton();
            this.lbl = new Guna.UI.WinForms.GunaLabel();
            this.CBTypeUser = new Guna.UI2.WinForms.Guna2ComboBox();
            this.DPDateBurth = new Guna.UI.WinForms.GunaDateTimePicker();
            this.TxtAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.TxtLastname = new Guna.UI2.WinForms.Guna2TextBox();
            this.TxtFirstname = new Guna.UI2.WinForms.Guna2TextBox();
            this.TxtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.TxtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.DGVUsers = new Guna.UI.WinForms.GunaDataGridView();
            this.PnHeader = new System.Windows.Forms.Panel();
            this.TxtSearchBar = new Guna.UI2.WinForms.Guna2TextBox();
            this.PnDVG = new System.Windows.Forms.Panel();
            this.PnGery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVUsers)).BeginInit();
            this.PnHeader.SuspendLayout();
            this.PnDVG.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnGery
            // 
            this.PnGery.Controls.Add(this.btnRest);
            this.PnGery.Controls.Add(this.BtnRemove);
            this.PnGery.Controls.Add(this.BtnAdd);
            this.PnGery.Controls.Add(this.BtnEdit);
            this.PnGery.Controls.Add(this.BtnVider);
            this.PnGery.Controls.Add(this.lbl);
            this.PnGery.Controls.Add(this.CBTypeUser);
            this.PnGery.Controls.Add(this.DPDateBurth);
            this.PnGery.Controls.Add(this.TxtAddress);
            this.PnGery.Controls.Add(this.TxtLastname);
            this.PnGery.Controls.Add(this.TxtFirstname);
            this.PnGery.Controls.Add(this.TxtPassword);
            this.PnGery.Controls.Add(this.TxtEmail);
            this.PnGery.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnGery.Location = new System.Drawing.Point(0, 0);
            this.PnGery.Name = "PnGery";
            this.PnGery.Size = new System.Drawing.Size(1004, 143);
            this.PnGery.TabIndex = 1;
            // 
            // btnRest
            // 
            this.btnRest.BorderColor = System.Drawing.Color.Blue;
            this.btnRest.CheckedState.Parent = this.btnRest;
            this.btnRest.CustomBorderColor = System.Drawing.Color.Blue;
            this.btnRest.CustomBorderThickness = new System.Windows.Forms.Padding(1);
            this.btnRest.CustomImages.Parent = this.btnRest;
            this.btnRest.FillColor = System.Drawing.Color.White;
            this.btnRest.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRest.ForeColor = System.Drawing.Color.Black;
            this.btnRest.HoverState.Parent = this.btnRest;
            this.btnRest.Location = new System.Drawing.Point(35, 101);
            this.btnRest.Name = "btnRest";
            this.btnRest.ShadowDecoration.Parent = this.btnRest;
            this.btnRest.Size = new System.Drawing.Size(405, 36);
            this.btnRest.TabIndex = 35;
            this.btnRest.Text = "Rest password for user";
            this.btnRest.Visible = false;
            this.btnRest.Click += new System.EventHandler(this.btnRest_Click);
            // 
            // BtnRemove
            // 
            this.BtnRemove.CheckedState.Parent = this.BtnRemove;
            this.BtnRemove.Enabled = false;
            this.BtnRemove.HoverState.ImageSize = new System.Drawing.Size(36, 36);
            this.BtnRemove.HoverState.Parent = this.BtnRemove;
            this.BtnRemove.Image = global::AppPoject.Properties.Resources.remove_user;
            this.BtnRemove.ImageSize = new System.Drawing.Size(40, 40);
            this.BtnRemove.Location = new System.Drawing.Point(893, 53);
            this.BtnRemove.Name = "BtnRemove";
            this.BtnRemove.PressedState.ImageSize = new System.Drawing.Size(35, 35);
            this.BtnRemove.PressedState.Parent = this.BtnRemove;
            this.BtnRemove.Size = new System.Drawing.Size(47, 42);
            this.BtnRemove.TabIndex = 34;
            this.BtnRemove.Click += new System.EventHandler(this.BtnRemove_Click_1);
            // 
            // BtnAdd
            // 
            this.BtnAdd.CheckedState.Parent = this.BtnAdd;
            this.BtnAdd.HoverState.ImageSize = new System.Drawing.Size(36, 36);
            this.BtnAdd.HoverState.Parent = this.BtnAdd;
            this.BtnAdd.Image = global::AppPoject.Properties.Resources.adduser;
            this.BtnAdd.ImageSize = new System.Drawing.Size(40, 40);
            this.BtnAdd.Location = new System.Drawing.Point(775, 52);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.PressedState.ImageSize = new System.Drawing.Size(35, 35);
            this.BtnAdd.PressedState.Parent = this.BtnAdd;
            this.BtnAdd.Size = new System.Drawing.Size(47, 42);
            this.BtnAdd.TabIndex = 33;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click_1);
            // 
            // BtnEdit
            // 
            this.BtnEdit.CheckedState.Parent = this.BtnEdit;
            this.BtnEdit.Enabled = false;
            this.BtnEdit.HoverState.ImageSize = new System.Drawing.Size(36, 36);
            this.BtnEdit.HoverState.Parent = this.BtnEdit;
            this.BtnEdit.Image = global::AppPoject.Properties.Resources.edituser;
            this.BtnEdit.ImageSize = new System.Drawing.Size(40, 40);
            this.BtnEdit.Location = new System.Drawing.Point(839, 52);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.PressedState.ImageSize = new System.Drawing.Size(35, 35);
            this.BtnEdit.PressedState.Parent = this.BtnEdit;
            this.BtnEdit.Size = new System.Drawing.Size(47, 42);
            this.BtnEdit.TabIndex = 32;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click_1);
            // 
            // BtnVider
            // 
            this.BtnVider.CheckedState.Parent = this.BtnVider;
            this.BtnVider.HoverState.ImageSize = new System.Drawing.Size(36, 36);
            this.BtnVider.HoverState.Parent = this.BtnVider;
            this.BtnVider.Image = global::AppPoject.Properties.Resources.vider;
            this.BtnVider.ImageSize = new System.Drawing.Size(40, 40);
            this.BtnVider.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnVider.Location = new System.Drawing.Point(948, 52);
            this.BtnVider.Name = "BtnVider";
            this.BtnVider.PressedState.ImageSize = new System.Drawing.Size(40, 40);
            this.BtnVider.PressedState.Parent = this.BtnVider;
            this.BtnVider.Size = new System.Drawing.Size(47, 42);
            this.BtnVider.TabIndex = 31;
            this.BtnVider.Click += new System.EventHandler(this.BtnVider_Click);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(520, 60);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(84, 21);
            this.lbl.TabIndex = 30;
            this.lbl.Text = "Date burth";
            // 
            // CBTypeUser
            // 
            this.CBTypeUser.BackColor = System.Drawing.Color.Transparent;
            this.CBTypeUser.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CBTypeUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBTypeUser.FocusedColor = System.Drawing.Color.Empty;
            this.CBTypeUser.FocusedState.Parent = this.CBTypeUser;
            this.CBTypeUser.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CBTypeUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.CBTypeUser.FormattingEnabled = true;
            this.CBTypeUser.HoverState.Parent = this.CBTypeUser;
            this.CBTypeUser.ItemHeight = 30;
            this.CBTypeUser.ItemsAppearance.Parent = this.CBTypeUser;
            this.CBTypeUser.Location = new System.Drawing.Point(277, 53);
            this.CBTypeUser.Name = "CBTypeUser";
            this.CBTypeUser.ShadowDecoration.Parent = this.CBTypeUser;
            this.CBTypeUser.Size = new System.Drawing.Size(237, 36);
            this.CBTypeUser.TabIndex = 29;
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
            this.DPDateBurth.Location = new System.Drawing.Point(609, 53);
            this.DPDateBurth.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DPDateBurth.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DPDateBurth.Name = "DPDateBurth";
            this.DPDateBurth.OnHoverBaseColor = System.Drawing.Color.White;
            this.DPDateBurth.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DPDateBurth.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DPDateBurth.OnPressedColor = System.Drawing.Color.Black;
            this.DPDateBurth.Size = new System.Drawing.Size(144, 36);
            this.DPDateBurth.TabIndex = 28;
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
            this.TxtAddress.Location = new System.Drawing.Point(519, 11);
            this.TxtAddress.Name = "TxtAddress";
            this.TxtAddress.PasswordChar = '\0';
            this.TxtAddress.PlaceholderForeColor = System.Drawing.Color.Fuchsia;
            this.TxtAddress.PlaceholderText = "Address";
            this.TxtAddress.SelectedText = "";
            this.TxtAddress.ShadowDecoration.Parent = this.TxtAddress;
            this.TxtAddress.Size = new System.Drawing.Size(234, 36);
            this.TxtAddress.TabIndex = 27;
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
            this.TxtLastname.Location = new System.Drawing.Point(277, 11);
            this.TxtLastname.Name = "TxtLastname";
            this.TxtLastname.PasswordChar = '\0';
            this.TxtLastname.PlaceholderForeColor = System.Drawing.Color.Fuchsia;
            this.TxtLastname.PlaceholderText = "Last Name";
            this.TxtLastname.SelectedText = "";
            this.TxtLastname.ShadowDecoration.Parent = this.TxtLastname;
            this.TxtLastname.Size = new System.Drawing.Size(236, 36);
            this.TxtLastname.TabIndex = 26;
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
            this.TxtFirstname.Location = new System.Drawing.Point(35, 11);
            this.TxtFirstname.Name = "TxtFirstname";
            this.TxtFirstname.PasswordChar = '\0';
            this.TxtFirstname.PlaceholderForeColor = System.Drawing.Color.Fuchsia;
            this.TxtFirstname.PlaceholderText = "First Name";
            this.TxtFirstname.SelectedText = "";
            this.TxtFirstname.ShadowDecoration.Parent = this.TxtFirstname;
            this.TxtFirstname.Size = new System.Drawing.Size(236, 36);
            this.TxtFirstname.TabIndex = 25;
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
            this.TxtPassword.IconRight = global::AppPoject.Properties.Resources.icons8_user_locked_128px;
            this.TxtPassword.IconRightOffset = new System.Drawing.Point(3, 0);
            this.TxtPassword.Location = new System.Drawing.Point(36, 53);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.PasswordChar = '*';
            this.TxtPassword.PlaceholderForeColor = System.Drawing.Color.Fuchsia;
            this.TxtPassword.PlaceholderText = "Password for User";
            this.TxtPassword.SelectedText = "";
            this.TxtPassword.ShadowDecoration.BorderRadius = 10;
            this.TxtPassword.ShadowDecoration.Parent = this.TxtPassword;
            this.TxtPassword.Size = new System.Drawing.Size(235, 36);
            this.TxtPassword.TabIndex = 24;
            this.TxtPassword.UseSystemPasswordChar = true;
            // 
            // TxtEmail
            // 
            this.TxtEmail.BackColor = System.Drawing.Color.Cornsilk;
            this.TxtEmail.BorderColor = System.Drawing.Color.Blue;
            this.TxtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtEmail.DefaultText = "";
            this.TxtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtEmail.DisabledState.Parent = this.TxtEmail;
            this.TxtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtEmail.FillColor = System.Drawing.Color.Snow;
            this.TxtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtEmail.FocusedState.Parent = this.TxtEmail;
            this.TxtEmail.ForeColor = System.Drawing.Color.Fuchsia;
            this.TxtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtEmail.HoverState.Parent = this.TxtEmail;
            this.TxtEmail.IconRight = global::AppPoject.Properties.Resources.email;
            this.TxtEmail.IconRightOffset = new System.Drawing.Point(3, 0);
            this.TxtEmail.Location = new System.Drawing.Point(759, 11);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.PasswordChar = '\0';
            this.TxtEmail.PlaceholderForeColor = System.Drawing.Color.Fuchsia;
            this.TxtEmail.PlaceholderText = "E-mail";
            this.TxtEmail.SelectedText = "";
            this.TxtEmail.ShadowDecoration.Parent = this.TxtEmail;
            this.TxtEmail.Size = new System.Drawing.Size(236, 36);
            this.TxtEmail.TabIndex = 23;
            // 
            // DGVUsers
            // 
            this.DGVUsers.AllowUserToAddRows = false;
            this.DGVUsers.AllowUserToDeleteRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.DGVUsers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.DGVUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVUsers.BackgroundColor = System.Drawing.Color.White;
            this.DGVUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVUsers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVUsers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 13.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.DGVUsers.ColumnHeadersHeight = 45;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 13F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVUsers.DefaultCellStyle = dataGridViewCellStyle12;
            this.DGVUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVUsers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DGVUsers.EnableHeadersVisualStyles = false;
            this.DGVUsers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVUsers.Location = new System.Drawing.Point(0, 0);
            this.DGVUsers.MultiSelect = false;
            this.DGVUsers.Name = "DGVUsers";
            this.DGVUsers.ReadOnly = true;
            this.DGVUsers.RowHeadersVisible = false;
            this.DGVUsers.RowTemplate.Height = 30;
            this.DGVUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVUsers.Size = new System.Drawing.Size(1004, 351);
            this.DGVUsers.TabIndex = 1;
            this.DGVUsers.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.DGVUsers.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DGVUsers.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DGVUsers.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DGVUsers.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DGVUsers.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DGVUsers.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DGVUsers.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVUsers.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DGVUsers.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DGVUsers.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 13.75F, System.Drawing.FontStyle.Bold);
            this.DGVUsers.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DGVUsers.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DGVUsers.ThemeStyle.HeaderStyle.Height = 45;
            this.DGVUsers.ThemeStyle.ReadOnly = true;
            this.DGVUsers.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DGVUsers.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVUsers.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.DGVUsers.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DGVUsers.ThemeStyle.RowsStyle.Height = 30;
            this.DGVUsers.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVUsers.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DGVUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVUsers_CellClick);
            // 
            // PnHeader
            // 
            this.PnHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(235)))), ((int)(((byte)(239)))));
            this.PnHeader.Controls.Add(this.TxtSearchBar);
            this.PnHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnHeader.Location = new System.Drawing.Point(0, 143);
            this.PnHeader.Name = "PnHeader";
            this.PnHeader.Size = new System.Drawing.Size(1004, 53);
            this.PnHeader.TabIndex = 5;
            // 
            // TxtSearchBar
            // 
            this.TxtSearchBar.BorderRadius = 18;
            this.TxtSearchBar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtSearchBar.DefaultText = "";
            this.TxtSearchBar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtSearchBar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtSearchBar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtSearchBar.DisabledState.Parent = this.TxtSearchBar;
            this.TxtSearchBar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtSearchBar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtSearchBar.FocusedState.Parent = this.TxtSearchBar;
            this.TxtSearchBar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtSearchBar.ForeColor = System.Drawing.Color.Blue;
            this.TxtSearchBar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtSearchBar.HoverState.Parent = this.TxtSearchBar;
            this.TxtSearchBar.IconLeft = ((System.Drawing.Image)(resources.GetObject("TxtSearchBar.IconLeft")));
            this.TxtSearchBar.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.TxtSearchBar.Location = new System.Drawing.Point(41, 11);
            this.TxtSearchBar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtSearchBar.Name = "TxtSearchBar";
            this.TxtSearchBar.PasswordChar = '\0';
            this.TxtSearchBar.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(154)))), ((int)(((byte)(157)))));
            this.TxtSearchBar.PlaceholderText = "Search user by name";
            this.TxtSearchBar.SelectedText = "";
            this.TxtSearchBar.ShadowDecoration.Parent = this.TxtSearchBar;
            this.TxtSearchBar.Size = new System.Drawing.Size(268, 36);
            this.TxtSearchBar.TabIndex = 10;
            this.TxtSearchBar.TextChanged += new System.EventHandler(this.TxtSearchBar_TextChanged_1);
            // 
            // PnDVG
            // 
            this.PnDVG.Controls.Add(this.DGVUsers);
            this.PnDVG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnDVG.Location = new System.Drawing.Point(0, 196);
            this.PnDVG.Name = "PnDVG";
            this.PnDVG.Size = new System.Drawing.Size(1004, 351);
            this.PnDVG.TabIndex = 6;
            // 
            // UCUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.PnDVG);
            this.Controls.Add(this.PnHeader);
            this.Controls.Add(this.PnGery);
            this.Name = "UCUser";
            this.Size = new System.Drawing.Size(1004, 547);
            this.Load += new System.EventHandler(this.UCUser_Load);
            this.PnGery.ResumeLayout(false);
            this.PnGery.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVUsers)).EndInit();
            this.PnHeader.ResumeLayout(false);
            this.PnDVG.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PnGery;
        private Guna.UI2.WinForms.Guna2ImageButton BtnRemove;
        private Guna.UI2.WinForms.Guna2ImageButton BtnAdd;
        private Guna.UI2.WinForms.Guna2ImageButton BtnEdit;
        private Guna.UI2.WinForms.Guna2ImageButton BtnVider;
        private Guna.UI.WinForms.GunaLabel lbl;
        private Guna.UI2.WinForms.Guna2ComboBox CBTypeUser;
        private Guna.UI.WinForms.GunaDateTimePicker DPDateBurth;
        private Guna.UI2.WinForms.Guna2TextBox TxtAddress;
        private Guna.UI2.WinForms.Guna2TextBox TxtLastname;
        private Guna.UI2.WinForms.Guna2TextBox TxtFirstname;
        private Guna.UI2.WinForms.Guna2TextBox TxtPassword;
        private Guna.UI2.WinForms.Guna2TextBox TxtEmail;
        private Guna.UI.WinForms.GunaDataGridView DGVUsers;
        private Guna.UI2.WinForms.Guna2Button btnRest;
        private System.Windows.Forms.Panel PnHeader;
        private Guna.UI2.WinForms.Guna2TextBox TxtSearchBar;
        private System.Windows.Forms.Panel PnDVG;
    }
}
