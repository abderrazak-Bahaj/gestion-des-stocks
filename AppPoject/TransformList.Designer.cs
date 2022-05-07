namespace AppPoject
{
    partial class TransformList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransformList));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PnHeaderMain = new System.Windows.Forms.Panel();
            this.LblTitle = new System.Windows.Forms.Label();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnVider = new Guna.UI2.WinForms.Guna2ImageButton();
            this.DPDateTransform = new Guna.UI.WinForms.GunaDateTimePicker();
            this.BtnSearch = new Guna.UI2.WinForms.Guna2ImageButton();
            this.DGVTransform = new Guna.UI.WinForms.GunaDataGridView();
            this.PnHeaderMain.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVTransform)).BeginInit();
            this.SuspendLayout();
            // 
            // PnHeaderMain
            // 
            this.PnHeaderMain.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PnHeaderMain.Controls.Add(this.LblTitle);
            this.PnHeaderMain.Controls.Add(this.btnClose);
            this.PnHeaderMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnHeaderMain.Location = new System.Drawing.Point(0, 0);
            this.PnHeaderMain.Name = "PnHeaderMain";
            this.PnHeaderMain.Size = new System.Drawing.Size(800, 53);
            this.PnHeaderMain.TabIndex = 56;
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.Location = new System.Drawing.Point(12, 9);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(169, 25);
            this.LblTitle.TabIndex = 8;
            this.LblTitle.Text = "Transform list";
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
            this.btnClose.Location = new System.Drawing.Point(746, 9);
            this.btnClose.Name = "btnClose";
            this.btnClose.ShadowDecoration.Parent = this.btnClose;
            this.btnClose.Size = new System.Drawing.Size(42, 38);
            this.btnClose.TabIndex = 6;
            this.btnClose.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.BtnVider);
            this.panel1.Controls.Add(this.DPDateTransform);
            this.panel1.Controls.Add(this.BtnSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 47);
            this.panel1.TabIndex = 57;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(86, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Search by Month and year";
            // 
            // BtnVider
            // 
            this.BtnVider.CheckedState.Parent = this.BtnVider;
            this.BtnVider.HoverState.ImageSize = new System.Drawing.Size(36, 36);
            this.BtnVider.HoverState.Parent = this.BtnVider;
            this.BtnVider.Image = global::AppPoject.Properties.Resources.vider;
            this.BtnVider.ImageSize = new System.Drawing.Size(40, 40);
            this.BtnVider.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnVider.Location = new System.Drawing.Point(587, 3);
            this.BtnVider.Name = "BtnVider";
            this.BtnVider.PressedState.ImageSize = new System.Drawing.Size(40, 40);
            this.BtnVider.PressedState.Parent = this.BtnVider;
            this.BtnVider.Size = new System.Drawing.Size(47, 42);
            this.BtnVider.TabIndex = 61;
            this.BtnVider.Click += new System.EventHandler(this.BtnVider_Click);
            // 
            // DPDateTransform
            // 
            this.DPDateTransform.BaseColor = System.Drawing.Color.White;
            this.DPDateTransform.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.DPDateTransform.BorderSize = 1;
            this.DPDateTransform.CustomFormat = "yyyy-MM";
            this.DPDateTransform.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.DPDateTransform.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DPDateTransform.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DPDateTransform.ForeColor = System.Drawing.Color.Black;
            this.DPDateTransform.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DPDateTransform.Location = new System.Drawing.Point(294, 5);
            this.DPDateTransform.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DPDateTransform.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DPDateTransform.Name = "DPDateTransform";
            this.DPDateTransform.OnHoverBaseColor = System.Drawing.Color.White;
            this.DPDateTransform.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DPDateTransform.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DPDateTransform.OnPressedColor = System.Drawing.Color.Black;
            this.DPDateTransform.Size = new System.Drawing.Size(172, 36);
            this.DPDateTransform.TabIndex = 60;
            this.DPDateTransform.Text = "2022-03";
            this.DPDateTransform.Value = new System.DateTime(2022, 3, 29, 20, 42, 32, 477);
            // 
            // BtnSearch
            // 
            this.BtnSearch.BackColor = System.Drawing.Color.Transparent;
            this.BtnSearch.CheckedState.Parent = this.BtnSearch;
            this.BtnSearch.HoverState.Image = global::AppPoject.Properties.Resources.search1;
            this.BtnSearch.HoverState.ImageSize = new System.Drawing.Size(38, 38);
            this.BtnSearch.HoverState.Parent = this.BtnSearch;
            this.BtnSearch.Image = global::AppPoject.Properties.Resources.search1;
            this.BtnSearch.ImageSize = new System.Drawing.Size(40, 40);
            this.BtnSearch.Location = new System.Drawing.Point(499, 3);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.PressedState.ImageSize = new System.Drawing.Size(35, 35);
            this.BtnSearch.PressedState.Parent = this.BtnSearch;
            this.BtnSearch.Size = new System.Drawing.Size(47, 42);
            this.BtnSearch.TabIndex = 59;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // DGVTransform
            // 
            this.DGVTransform.AllowUserToAddRows = false;
            this.DGVTransform.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DGVTransform.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVTransform.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVTransform.BackgroundColor = System.Drawing.Color.White;
            this.DGVTransform.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVTransform.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVTransform.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 13.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVTransform.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVTransform.ColumnHeadersHeight = 45;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 13F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVTransform.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGVTransform.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVTransform.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DGVTransform.EnableHeadersVisualStyles = false;
            this.DGVTransform.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVTransform.Location = new System.Drawing.Point(0, 100);
            this.DGVTransform.MultiSelect = false;
            this.DGVTransform.Name = "DGVTransform";
            this.DGVTransform.ReadOnly = true;
            this.DGVTransform.RowHeadersVisible = false;
            this.DGVTransform.RowTemplate.Height = 70;
            this.DGVTransform.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVTransform.Size = new System.Drawing.Size(800, 446);
            this.DGVTransform.TabIndex = 58;
            this.DGVTransform.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.DGVTransform.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DGVTransform.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DGVTransform.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DGVTransform.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DGVTransform.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DGVTransform.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DGVTransform.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVTransform.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DGVTransform.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DGVTransform.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 13.75F, System.Drawing.FontStyle.Bold);
            this.DGVTransform.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DGVTransform.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DGVTransform.ThemeStyle.HeaderStyle.Height = 45;
            this.DGVTransform.ThemeStyle.ReadOnly = true;
            this.DGVTransform.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DGVTransform.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVTransform.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.DGVTransform.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DGVTransform.ThemeStyle.RowsStyle.Height = 70;
            this.DGVTransform.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVTransform.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // TransformList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 546);
            this.Controls.Add(this.DGVTransform);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PnHeaderMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TransformList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TransformList";
            this.Load += new System.EventHandler(this.TransformList_Load);
            this.PnHeaderMain.ResumeLayout(false);
            this.PnHeaderMain.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVTransform)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnHeaderMain;
        private System.Windows.Forms.Label LblTitle;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaDataGridView DGVTransform;
        private Guna.UI2.WinForms.Guna2ImageButton BtnSearch;
        private Guna.UI.WinForms.GunaDateTimePicker DPDateTransform;
        private Guna.UI2.WinForms.Guna2ImageButton BtnVider;
        private System.Windows.Forms.Label label1;
    }
}