﻿namespace AppPoject.Components
{
    partial class UCCostumer
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCCostumer));
            this.PnDGV = new System.Windows.Forms.Panel();
            this.DGVCostumers = new Guna.UI.WinForms.GunaDataGridView();
            this.BtnAdd = new Guna.UI2.WinForms.Guna2ImageButton();
            this.PnHeader = new System.Windows.Forms.Panel();
            this.TxtSearchBar = new Guna.UI2.WinForms.Guna2TextBox();
            this.TxtAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.TxtName = new Guna.UI2.WinForms.Guna2TextBox();
            this.TxtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.PnGery = new System.Windows.Forms.Panel();
            this.BtnRemove = new Guna.UI2.WinForms.Guna2ImageButton();
            this.BtnEdit = new Guna.UI2.WinForms.Guna2ImageButton();
            this.BtnVider = new Guna.UI2.WinForms.Guna2ImageButton();
            this.PnDGV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCostumers)).BeginInit();
            this.PnHeader.SuspendLayout();
            this.PnGery.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnDGV
            // 
            this.PnDGV.Controls.Add(this.DGVCostumers);
            this.PnDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnDGV.Location = new System.Drawing.Point(0, 111);
            this.PnDGV.Name = "PnDGV";
            this.PnDGV.Size = new System.Drawing.Size(1036, 438);
            this.PnDGV.TabIndex = 6;
            // 
            // DGVCostumers
            // 
            this.DGVCostumers.AllowUserToAddRows = false;
            this.DGVCostumers.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DGVCostumers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVCostumers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVCostumers.BackgroundColor = System.Drawing.Color.White;
            this.DGVCostumers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVCostumers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVCostumers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 13.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVCostumers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVCostumers.ColumnHeadersHeight = 45;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 13F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVCostumers.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGVCostumers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVCostumers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DGVCostumers.EnableHeadersVisualStyles = false;
            this.DGVCostumers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVCostumers.Location = new System.Drawing.Point(0, 0);
            this.DGVCostumers.MultiSelect = false;
            this.DGVCostumers.Name = "DGVCostumers";
            this.DGVCostumers.ReadOnly = true;
            this.DGVCostumers.RowHeadersVisible = false;
            this.DGVCostumers.RowTemplate.Height = 30;
            this.DGVCostumers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVCostumers.Size = new System.Drawing.Size(1036, 438);
            this.DGVCostumers.TabIndex = 1;
            this.DGVCostumers.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.DGVCostumers.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DGVCostumers.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DGVCostumers.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DGVCostumers.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DGVCostumers.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DGVCostumers.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DGVCostumers.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVCostumers.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DGVCostumers.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DGVCostumers.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 13.75F, System.Drawing.FontStyle.Bold);
            this.DGVCostumers.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DGVCostumers.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DGVCostumers.ThemeStyle.HeaderStyle.Height = 45;
            this.DGVCostumers.ThemeStyle.ReadOnly = true;
            this.DGVCostumers.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DGVCostumers.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVCostumers.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.DGVCostumers.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DGVCostumers.ThemeStyle.RowsStyle.Height = 30;
            this.DGVCostumers.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVCostumers.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DGVCostumers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVCostumers_CellClick);
            // 
            // BtnAdd
            // 
            this.BtnAdd.CheckedState.Parent = this.BtnAdd;
            this.BtnAdd.HoverState.ImageSize = new System.Drawing.Size(36, 36);
            this.BtnAdd.HoverState.Parent = this.BtnAdd;
            this.BtnAdd.Image = global::AppPoject.Properties.Resources.adduser;
            this.BtnAdd.ImageSize = new System.Drawing.Size(40, 40);
            this.BtnAdd.Location = new System.Drawing.Point(784, 5);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.PressedState.ImageSize = new System.Drawing.Size(35, 35);
            this.BtnAdd.PressedState.Parent = this.BtnAdd;
            this.BtnAdd.Size = new System.Drawing.Size(47, 42);
            this.BtnAdd.TabIndex = 33;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // PnHeader
            // 
            this.PnHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(235)))), ((int)(((byte)(239)))));
            this.PnHeader.Controls.Add(this.TxtSearchBar);
            this.PnHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnHeader.Location = new System.Drawing.Point(0, 58);
            this.PnHeader.Name = "PnHeader";
            this.PnHeader.Size = new System.Drawing.Size(1036, 53);
            this.PnHeader.TabIndex = 4;
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
            this.TxtSearchBar.PlaceholderText = "Search Costumer by name";
            this.TxtSearchBar.SelectedText = "";
            this.TxtSearchBar.ShadowDecoration.Parent = this.TxtSearchBar;
            this.TxtSearchBar.Size = new System.Drawing.Size(268, 36);
            this.TxtSearchBar.TabIndex = 10;
            this.TxtSearchBar.TextChanged += new System.EventHandler(this.TxtSearchBar_TextChanged);
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
            this.TxtAddress.Location = new System.Drawing.Point(510, 11);
            this.TxtAddress.Name = "TxtAddress";
            this.TxtAddress.PasswordChar = '\0';
            this.TxtAddress.PlaceholderForeColor = System.Drawing.Color.Fuchsia;
            this.TxtAddress.PlaceholderText = "Address";
            this.TxtAddress.SelectedText = "";
            this.TxtAddress.ShadowDecoration.Parent = this.TxtAddress;
            this.TxtAddress.Size = new System.Drawing.Size(234, 36);
            this.TxtAddress.TabIndex = 27;
            // 
            // TxtName
            // 
            this.TxtName.BackColor = System.Drawing.Color.Cornsilk;
            this.TxtName.BorderColor = System.Drawing.Color.Blue;
            this.TxtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtName.DefaultText = "";
            this.TxtName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtName.DisabledState.Parent = this.TxtName;
            this.TxtName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtName.FillColor = System.Drawing.Color.Snow;
            this.TxtName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtName.FocusedState.Parent = this.TxtName;
            this.TxtName.ForeColor = System.Drawing.Color.Fuchsia;
            this.TxtName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtName.HoverState.Parent = this.TxtName;
            this.TxtName.IconRight = global::AppPoject.Properties.Resources.name;
            this.TxtName.IconRightOffset = new System.Drawing.Point(3, 0);
            this.TxtName.Location = new System.Drawing.Point(23, 11);
            this.TxtName.Name = "TxtName";
            this.TxtName.PasswordChar = '\0';
            this.TxtName.PlaceholderForeColor = System.Drawing.Color.Fuchsia;
            this.TxtName.PlaceholderText = "Name";
            this.TxtName.SelectedText = "";
            this.TxtName.ShadowDecoration.Parent = this.TxtName;
            this.TxtName.Size = new System.Drawing.Size(236, 36);
            this.TxtName.TabIndex = 26;
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
            this.TxtEmail.Location = new System.Drawing.Point(268, 11);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.PasswordChar = '\0';
            this.TxtEmail.PlaceholderForeColor = System.Drawing.Color.Fuchsia;
            this.TxtEmail.PlaceholderText = "E-mail";
            this.TxtEmail.SelectedText = "";
            this.TxtEmail.ShadowDecoration.Parent = this.TxtEmail;
            this.TxtEmail.Size = new System.Drawing.Size(236, 36);
            this.TxtEmail.TabIndex = 23;
            // 
            // PnGery
            // 
            this.PnGery.Controls.Add(this.BtnRemove);
            this.PnGery.Controls.Add(this.BtnAdd);
            this.PnGery.Controls.Add(this.BtnEdit);
            this.PnGery.Controls.Add(this.BtnVider);
            this.PnGery.Controls.Add(this.TxtAddress);
            this.PnGery.Controls.Add(this.TxtName);
            this.PnGery.Controls.Add(this.TxtEmail);
            this.PnGery.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnGery.Location = new System.Drawing.Point(0, 0);
            this.PnGery.Name = "PnGery";
            this.PnGery.Size = new System.Drawing.Size(1036, 58);
            this.PnGery.TabIndex = 5;
            // 
            // BtnRemove
            // 
            this.BtnRemove.CheckedState.Parent = this.BtnRemove;
            this.BtnRemove.Enabled = false;
            this.BtnRemove.HoverState.ImageSize = new System.Drawing.Size(36, 36);
            this.BtnRemove.HoverState.Parent = this.BtnRemove;
            this.BtnRemove.Image = global::AppPoject.Properties.Resources.remove_user;
            this.BtnRemove.ImageSize = new System.Drawing.Size(40, 40);
            this.BtnRemove.Location = new System.Drawing.Point(910, 5);
            this.BtnRemove.Name = "BtnRemove";
            this.BtnRemove.PressedState.ImageSize = new System.Drawing.Size(35, 35);
            this.BtnRemove.PressedState.Parent = this.BtnRemove;
            this.BtnRemove.Size = new System.Drawing.Size(47, 42);
            this.BtnRemove.TabIndex = 34;
            this.BtnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.CheckedState.Parent = this.BtnEdit;
            this.BtnEdit.Enabled = false;
            this.BtnEdit.HoverState.ImageSize = new System.Drawing.Size(36, 36);
            this.BtnEdit.HoverState.Parent = this.BtnEdit;
            this.BtnEdit.Image = global::AppPoject.Properties.Resources.edituser;
            this.BtnEdit.ImageSize = new System.Drawing.Size(40, 40);
            this.BtnEdit.Location = new System.Drawing.Point(849, 4);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.PressedState.ImageSize = new System.Drawing.Size(35, 35);
            this.BtnEdit.PressedState.Parent = this.BtnEdit;
            this.BtnEdit.Size = new System.Drawing.Size(47, 42);
            this.BtnEdit.TabIndex = 32;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnVider
            // 
            this.BtnVider.CheckedState.Parent = this.BtnVider;
            this.BtnVider.HoverState.ImageSize = new System.Drawing.Size(36, 36);
            this.BtnVider.HoverState.Parent = this.BtnVider;
            this.BtnVider.Image = global::AppPoject.Properties.Resources.vider;
            this.BtnVider.ImageSize = new System.Drawing.Size(40, 40);
            this.BtnVider.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnVider.Location = new System.Drawing.Point(963, 3);
            this.BtnVider.Name = "BtnVider";
            this.BtnVider.PressedState.ImageSize = new System.Drawing.Size(40, 40);
            this.BtnVider.PressedState.Parent = this.BtnVider;
            this.BtnVider.Size = new System.Drawing.Size(47, 42);
            this.BtnVider.TabIndex = 31;
            this.BtnVider.Click += new System.EventHandler(this.BtnVider_Click);
            // 
            // UCCostumer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.PnDGV);
            this.Controls.Add(this.PnHeader);
            this.Controls.Add(this.PnGery);
            this.Name = "UCCostumer";
            this.Size = new System.Drawing.Size(1036, 549);
            this.Load += new System.EventHandler(this.UCCostumer_Load);
            this.PnDGV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVCostumers)).EndInit();
            this.PnHeader.ResumeLayout(false);
            this.PnGery.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnDGV;
        private Guna.UI.WinForms.GunaDataGridView DGVCostumers;
        private Guna.UI2.WinForms.Guna2ImageButton BtnRemove;
        private Guna.UI2.WinForms.Guna2ImageButton BtnAdd;
        private Guna.UI2.WinForms.Guna2ImageButton BtnEdit;
        private Guna.UI2.WinForms.Guna2ImageButton BtnVider;
        private Guna.UI2.WinForms.Guna2TextBox TxtSearchBar;
        private System.Windows.Forms.Panel PnHeader;
        private Guna.UI2.WinForms.Guna2TextBox TxtAddress;
        private Guna.UI2.WinForms.Guna2TextBox TxtName;
        private Guna.UI2.WinForms.Guna2TextBox TxtEmail;
        private System.Windows.Forms.Panel PnGery;
    }
}
