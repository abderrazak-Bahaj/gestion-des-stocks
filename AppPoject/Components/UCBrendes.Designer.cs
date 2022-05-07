﻿namespace AppPoject.Components
{
    partial class UCBrendes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCBrendes));
            this.PnDGV = new System.Windows.Forms.Panel();
            this.DGVBrandes = new Guna.UI.WinForms.GunaDataGridView();
            this.BtnRemove = new Guna.UI2.WinForms.Guna2ImageButton();
            this.BtnAdd = new Guna.UI2.WinForms.Guna2ImageButton();
            this.BtnEdit = new Guna.UI2.WinForms.Guna2ImageButton();
            this.BtnVider = new Guna.UI2.WinForms.Guna2ImageButton();
            this.TxtSearchBar = new Guna.UI2.WinForms.Guna2TextBox();
            this.PnHeader = new System.Windows.Forms.Panel();
            this.TxtName = new Guna.UI2.WinForms.Guna2TextBox();
            this.PnGery = new System.Windows.Forms.Panel();
            this.PnDGV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVBrandes)).BeginInit();
            this.PnHeader.SuspendLayout();
            this.PnGery.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnDGV
            // 
            this.PnDGV.Controls.Add(this.DGVBrandes);
            this.PnDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnDGV.Location = new System.Drawing.Point(0, 124);
            this.PnDGV.Name = "PnDGV";
            this.PnDGV.Size = new System.Drawing.Size(795, 412);
            this.PnDGV.TabIndex = 9;
            // 
            // DGVBrandes
            // 
            this.DGVBrandes.AllowUserToAddRows = false;
            this.DGVBrandes.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DGVBrandes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVBrandes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVBrandes.BackgroundColor = System.Drawing.Color.White;
            this.DGVBrandes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVBrandes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVBrandes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 13.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVBrandes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVBrandes.ColumnHeadersHeight = 45;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 13F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVBrandes.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGVBrandes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVBrandes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DGVBrandes.EnableHeadersVisualStyles = false;
            this.DGVBrandes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVBrandes.Location = new System.Drawing.Point(0, 0);
            this.DGVBrandes.MultiSelect = false;
            this.DGVBrandes.Name = "DGVBrandes";
            this.DGVBrandes.ReadOnly = true;
            this.DGVBrandes.RowHeadersVisible = false;
            this.DGVBrandes.RowTemplate.Height = 30;
            this.DGVBrandes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVBrandes.Size = new System.Drawing.Size(795, 412);
            this.DGVBrandes.TabIndex = 1;
            this.DGVBrandes.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.DGVBrandes.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DGVBrandes.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DGVBrandes.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DGVBrandes.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DGVBrandes.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DGVBrandes.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DGVBrandes.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVBrandes.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DGVBrandes.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DGVBrandes.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 13.75F, System.Drawing.FontStyle.Bold);
            this.DGVBrandes.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DGVBrandes.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DGVBrandes.ThemeStyle.HeaderStyle.Height = 45;
            this.DGVBrandes.ThemeStyle.ReadOnly = true;
            this.DGVBrandes.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DGVBrandes.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVBrandes.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.DGVBrandes.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DGVBrandes.ThemeStyle.RowsStyle.Height = 30;
            this.DGVBrandes.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVBrandes.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DGVBrandes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVBrandes_CellClick);
            // 
            // BtnRemove
            // 
            this.BtnRemove.CheckedState.Parent = this.BtnRemove;
            this.BtnRemove.Enabled = false;
            this.BtnRemove.HoverState.ImageSize = new System.Drawing.Size(36, 36);
            this.BtnRemove.HoverState.Parent = this.BtnRemove;
            this.BtnRemove.Image = global::AppPoject.Properties.Resources.delete;
            this.BtnRemove.ImageSize = new System.Drawing.Size(40, 40);
            this.BtnRemove.Location = new System.Drawing.Point(576, 14);
            this.BtnRemove.Name = "BtnRemove";
            this.BtnRemove.PressedState.ImageSize = new System.Drawing.Size(35, 35);
            this.BtnRemove.PressedState.Parent = this.BtnRemove;
            this.BtnRemove.Size = new System.Drawing.Size(47, 42);
            this.BtnRemove.TabIndex = 34;
            this.BtnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.CheckedState.Parent = this.BtnAdd;
            this.BtnAdd.HoverState.ImageSize = new System.Drawing.Size(36, 36);
            this.BtnAdd.HoverState.Parent = this.BtnAdd;
            this.BtnAdd.Image = global::AppPoject.Properties.Resources.add;
            this.BtnAdd.ImageSize = new System.Drawing.Size(40, 40);
            this.BtnAdd.Location = new System.Drawing.Point(438, 11);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.PressedState.ImageSize = new System.Drawing.Size(35, 35);
            this.BtnAdd.PressedState.Parent = this.BtnAdd;
            this.BtnAdd.Size = new System.Drawing.Size(47, 42);
            this.BtnAdd.TabIndex = 33;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.CheckedState.Parent = this.BtnEdit;
            this.BtnEdit.Enabled = false;
            this.BtnEdit.HoverState.ImageSize = new System.Drawing.Size(36, 36);
            this.BtnEdit.HoverState.Parent = this.BtnEdit;
            this.BtnEdit.Image = global::AppPoject.Properties.Resources.edit;
            this.BtnEdit.ImageSize = new System.Drawing.Size(40, 40);
            this.BtnEdit.Location = new System.Drawing.Point(510, 11);
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
            this.BtnVider.Location = new System.Drawing.Point(640, 13);
            this.BtnVider.Name = "BtnVider";
            this.BtnVider.PressedState.ImageSize = new System.Drawing.Size(40, 40);
            this.BtnVider.PressedState.Parent = this.BtnVider;
            this.BtnVider.Size = new System.Drawing.Size(47, 42);
            this.BtnVider.TabIndex = 31;
            this.BtnVider.Click += new System.EventHandler(this.BtnVider_Click);
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
            this.TxtSearchBar.PlaceholderText = "Search brandes by name";
            this.TxtSearchBar.SelectedText = "";
            this.TxtSearchBar.ShadowDecoration.Parent = this.TxtSearchBar;
            this.TxtSearchBar.Size = new System.Drawing.Size(268, 36);
            this.TxtSearchBar.TabIndex = 10;
            this.TxtSearchBar.TextChanged += new System.EventHandler(this.TxtSearchBar_TextChanged);
            // 
            // PnHeader
            // 
            this.PnHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(235)))), ((int)(((byte)(239)))));
            this.PnHeader.Controls.Add(this.TxtSearchBar);
            this.PnHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnHeader.Location = new System.Drawing.Point(0, 71);
            this.PnHeader.Name = "PnHeader";
            this.PnHeader.Size = new System.Drawing.Size(795, 53);
            this.PnHeader.TabIndex = 7;
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
            this.TxtName.IconRightOffset = new System.Drawing.Point(3, 0);
            this.TxtName.Location = new System.Drawing.Point(158, 17);
            this.TxtName.Name = "TxtName";
            this.TxtName.PasswordChar = '\0';
            this.TxtName.PlaceholderForeColor = System.Drawing.Color.Fuchsia;
            this.TxtName.PlaceholderText = "Name brendes";
            this.TxtName.SelectedText = "";
            this.TxtName.ShadowDecoration.Parent = this.TxtName;
            this.TxtName.Size = new System.Drawing.Size(236, 36);
            this.TxtName.TabIndex = 25;
            // 
            // PnGery
            // 
            this.PnGery.Controls.Add(this.BtnRemove);
            this.PnGery.Controls.Add(this.BtnAdd);
            this.PnGery.Controls.Add(this.BtnEdit);
            this.PnGery.Controls.Add(this.BtnVider);
            this.PnGery.Controls.Add(this.TxtName);
            this.PnGery.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnGery.Location = new System.Drawing.Point(0, 0);
            this.PnGery.Name = "PnGery";
            this.PnGery.Size = new System.Drawing.Size(795, 71);
            this.PnGery.TabIndex = 8;
            // 
            // UCBrendes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.PnDGV);
            this.Controls.Add(this.PnHeader);
            this.Controls.Add(this.PnGery);
            this.Name = "UCBrendes";
            this.Size = new System.Drawing.Size(795, 536);
            this.Load += new System.EventHandler(this.UCBrendes_Load);
            this.PnDGV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVBrandes)).EndInit();
            this.PnHeader.ResumeLayout(false);
            this.PnGery.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnDGV;
        private Guna.UI.WinForms.GunaDataGridView DGVBrandes;
        private Guna.UI2.WinForms.Guna2ImageButton BtnRemove;
        private Guna.UI2.WinForms.Guna2ImageButton BtnAdd;
        private Guna.UI2.WinForms.Guna2ImageButton BtnEdit;
        private Guna.UI2.WinForms.Guna2ImageButton BtnVider;
        private Guna.UI2.WinForms.Guna2TextBox TxtSearchBar;
        private System.Windows.Forms.Panel PnHeader;
        private Guna.UI2.WinForms.Guna2TextBox TxtName;
        private System.Windows.Forms.Panel PnGery;
    }
}
