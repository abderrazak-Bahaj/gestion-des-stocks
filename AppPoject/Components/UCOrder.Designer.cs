namespace AppPoject.Components
{
    partial class UCOrder
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCOrder));
            this.BtnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.BtnEdit = new Guna.UI2.WinForms.Guna2Button();
            this.PnFooter = new System.Windows.Forms.Panel();
            this.CBState = new Guna.UI2.WinForms.Guna2ComboBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.BtnState = new Guna.UI2.WinForms.Guna2Button();
            this.BtnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.PnMain = new System.Windows.Forms.Panel();
            this.DGVOrder = new Guna.UI.WinForms.GunaDataGridView();
            this.PnSearsh = new System.Windows.Forms.Panel();
            this.TxtSearchBar = new Guna.UI2.WinForms.Guna2TextBox();
            this.BtnReport = new Guna.UI2.WinForms.Guna2Button();
            this.PnFooter.SuspendLayout();
            this.PnMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVOrder)).BeginInit();
            this.PnSearsh.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnAdd
            // 
            this.BtnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.BtnAdd.CheckedState.Parent = this.BtnAdd;
            this.BtnAdd.CustomImages.Parent = this.BtnAdd;
            this.BtnAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.BtnAdd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.ForeColor = System.Drawing.Color.White;
            this.BtnAdd.HoverState.Parent = this.BtnAdd;
            this.BtnAdd.Location = new System.Drawing.Point(140, 17);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.ShadowDecoration.Parent = this.BtnAdd;
            this.BtnAdd.Size = new System.Drawing.Size(110, 36);
            this.BtnAdd.TabIndex = 6;
            this.BtnAdd.Text = "Add Order";
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.BtnEdit.CheckedState.Parent = this.BtnEdit;
            this.BtnEdit.CustomImages.Parent = this.BtnEdit;
            this.BtnEdit.Enabled = false;
            this.BtnEdit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.BtnEdit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEdit.ForeColor = System.Drawing.Color.White;
            this.BtnEdit.HoverState.Parent = this.BtnEdit;
            this.BtnEdit.Location = new System.Drawing.Point(256, 17);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.ShadowDecoration.Parent = this.BtnEdit;
            this.BtnEdit.Size = new System.Drawing.Size(110, 36);
            this.BtnEdit.TabIndex = 7;
            this.BtnEdit.Text = "Edit Order";
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // PnFooter
            // 
            this.PnFooter.Controls.Add(this.BtnReport);
            this.PnFooter.Controls.Add(this.CBState);
            this.PnFooter.Controls.Add(this.gunaLabel3);
            this.PnFooter.Controls.Add(this.BtnState);
            this.PnFooter.Controls.Add(this.BtnDelete);
            this.PnFooter.Controls.Add(this.BtnEdit);
            this.PnFooter.Controls.Add(this.BtnAdd);
            this.PnFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnFooter.Location = new System.Drawing.Point(0, 499);
            this.PnFooter.Name = "PnFooter";
            this.PnFooter.Size = new System.Drawing.Size(1018, 69);
            this.PnFooter.TabIndex = 8;
            // 
            // CBState
            // 
            this.CBState.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.CBState.BackColor = System.Drawing.Color.Transparent;
            this.CBState.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CBState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBState.Enabled = false;
            this.CBState.FocusedColor = System.Drawing.Color.Empty;
            this.CBState.FocusedState.Parent = this.CBState;
            this.CBState.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CBState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.CBState.FormattingEnabled = true;
            this.CBState.HoverState.Parent = this.CBState;
            this.CBState.ItemHeight = 30;
            this.CBState.ItemsAppearance.Parent = this.CBState;
            this.CBState.Location = new System.Drawing.Point(674, 17);
            this.CBState.Name = "CBState";
            this.CBState.ShadowDecoration.Parent = this.CBState;
            this.CBState.Size = new System.Drawing.Size(237, 36);
            this.CBState.TabIndex = 41;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(617, 24);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(51, 21);
            this.gunaLabel3.TabIndex = 40;
            this.gunaLabel3.Text = "State :";
            // 
            // BtnState
            // 
            this.BtnState.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.BtnState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.BtnState.BorderThickness = 1;
            this.BtnState.CheckedState.Parent = this.BtnState;
            this.BtnState.CustomImages.Parent = this.BtnState;
            this.BtnState.Enabled = false;
            this.BtnState.FillColor = System.Drawing.Color.White;
            this.BtnState.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.BtnState.HoverState.Parent = this.BtnState;
            this.BtnState.Location = new System.Drawing.Point(912, 17);
            this.BtnState.Name = "BtnState";
            this.BtnState.ShadowDecoration.Parent = this.BtnState;
            this.BtnState.Size = new System.Drawing.Size(103, 36);
            this.BtnState.TabIndex = 9;
            this.BtnState.Text = "Edit State";
            this.BtnState.Click += new System.EventHandler(this.BtnState_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.BtnDelete.CheckedState.Parent = this.BtnDelete;
            this.BtnDelete.CustomImages.Parent = this.BtnDelete;
            this.BtnDelete.Enabled = false;
            this.BtnDelete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.BtnDelete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.ForeColor = System.Drawing.Color.White;
            this.BtnDelete.HoverState.Parent = this.BtnDelete;
            this.BtnDelete.Location = new System.Drawing.Point(376, 17);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.ShadowDecoration.Parent = this.BtnDelete;
            this.BtnDelete.Size = new System.Drawing.Size(110, 36);
            this.BtnDelete.TabIndex = 8;
            this.BtnDelete.Text = "Delete Order";
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // PnMain
            // 
            this.PnMain.Controls.Add(this.DGVOrder);
            this.PnMain.Controls.Add(this.PnSearsh);
            this.PnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnMain.Location = new System.Drawing.Point(0, 0);
            this.PnMain.Name = "PnMain";
            this.PnMain.Size = new System.Drawing.Size(1018, 499);
            this.PnMain.TabIndex = 9;
            // 
            // DGVOrder
            // 
            this.DGVOrder.AllowUserToAddRows = false;
            this.DGVOrder.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DGVOrder.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVOrder.BackgroundColor = System.Drawing.Color.White;
            this.DGVOrder.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVOrder.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVOrder.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 13.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVOrder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVOrder.ColumnHeadersHeight = 45;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 13F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVOrder.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGVOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVOrder.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DGVOrder.EnableHeadersVisualStyles = false;
            this.DGVOrder.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVOrder.Location = new System.Drawing.Point(0, 61);
            this.DGVOrder.MultiSelect = false;
            this.DGVOrder.Name = "DGVOrder";
            this.DGVOrder.ReadOnly = true;
            this.DGVOrder.RowHeadersVisible = false;
            this.DGVOrder.RowTemplate.Height = 30;
            this.DGVOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVOrder.Size = new System.Drawing.Size(1018, 438);
            this.DGVOrder.TabIndex = 3;
            this.DGVOrder.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.DGVOrder.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DGVOrder.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DGVOrder.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DGVOrder.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DGVOrder.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DGVOrder.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DGVOrder.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVOrder.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DGVOrder.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DGVOrder.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 13.75F, System.Drawing.FontStyle.Bold);
            this.DGVOrder.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DGVOrder.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DGVOrder.ThemeStyle.HeaderStyle.Height = 45;
            this.DGVOrder.ThemeStyle.ReadOnly = true;
            this.DGVOrder.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DGVOrder.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVOrder.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.DGVOrder.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DGVOrder.ThemeStyle.RowsStyle.Height = 30;
            this.DGVOrder.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVOrder.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DGVOrder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVOrder_CellClick);
            // 
            // PnSearsh
            // 
            this.PnSearsh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(235)))), ((int)(((byte)(239)))));
            this.PnSearsh.Controls.Add(this.TxtSearchBar);
            this.PnSearsh.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnSearsh.Location = new System.Drawing.Point(0, 0);
            this.PnSearsh.Name = "PnSearsh";
            this.PnSearsh.Size = new System.Drawing.Size(1018, 61);
            this.PnSearsh.TabIndex = 0;
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
            this.TxtSearchBar.Location = new System.Drawing.Point(29, 12);
            this.TxtSearchBar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtSearchBar.Name = "TxtSearchBar";
            this.TxtSearchBar.PasswordChar = '\0';
            this.TxtSearchBar.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(154)))), ((int)(((byte)(157)))));
            this.TxtSearchBar.PlaceholderText = "Search order by Date create EX:2022-01-01";
            this.TxtSearchBar.SelectedText = "";
            this.TxtSearchBar.ShadowDecoration.Parent = this.TxtSearchBar;
            this.TxtSearchBar.Size = new System.Drawing.Size(318, 36);
            this.TxtSearchBar.TabIndex = 11;
            this.TxtSearchBar.TextChanged += new System.EventHandler(this.TxtSearchBar_TextChanged);
            // 
            // BtnReport
            // 
            this.BtnReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.BtnReport.CheckedState.Parent = this.BtnReport;
            this.BtnReport.CustomImages.Parent = this.BtnReport;
            this.BtnReport.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.BtnReport.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReport.ForeColor = System.Drawing.Color.White;
            this.BtnReport.HoverState.Parent = this.BtnReport;
            this.BtnReport.Location = new System.Drawing.Point(12, 17);
            this.BtnReport.Name = "BtnReport";
            this.BtnReport.ShadowDecoration.Parent = this.BtnReport;
            this.BtnReport.Size = new System.Drawing.Size(122, 36);
            this.BtnReport.TabIndex = 42;
            this.BtnReport.Text = "Create Report";
            this.BtnReport.Click += new System.EventHandler(this.BtnReport_Click);
            // 
            // UCOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.PnMain);
            this.Controls.Add(this.PnFooter);
            this.Name = "UCOrder";
            this.Size = new System.Drawing.Size(1018, 568);
            this.Load += new System.EventHandler(this.UCOrder_Load);
            this.PnFooter.ResumeLayout(false);
            this.PnFooter.PerformLayout();
            this.PnMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVOrder)).EndInit();
            this.PnSearsh.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button BtnAdd;
        private Guna.UI2.WinForms.Guna2Button BtnEdit;
        private System.Windows.Forms.Panel PnFooter;
        private Guna.UI2.WinForms.Guna2Button BtnDelete;
        private System.Windows.Forms.Panel PnMain;
        private Guna.UI.WinForms.GunaDataGridView DGVOrder;
        private System.Windows.Forms.Panel PnSearsh;
        private Guna.UI2.WinForms.Guna2TextBox TxtSearchBar;
        private Guna.UI2.WinForms.Guna2Button BtnState;
        private Guna.UI2.WinForms.Guna2ComboBox CBState;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI2.WinForms.Guna2Button BtnReport;
    }
}
