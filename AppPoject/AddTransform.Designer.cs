namespace AppPoject
{
    partial class AddTransform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddTransform));
            this.PnHeaderMain = new System.Windows.Forms.Panel();
            this.LblTitle = new System.Windows.Forms.Label();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.btnTrandform = new Guna.UI2.WinForms.Guna2Button();
            this.DPTransform = new Guna.UI.WinForms.GunaDateTimePicker();
            this.CBStoreFrom = new Guna.UI2.WinForms.Guna2ComboBox();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.lbl = new Guna.UI.WinForms.GunaLabel();
            this.CBStoreTo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.CBProducts = new Guna.UI2.WinForms.Guna2ComboBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.TxtQuantity = new Guna.UI2.WinForms.Guna2TextBox();
            this.PnHeaderMain.SuspendLayout();
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
            this.PnHeaderMain.Size = new System.Drawing.Size(367, 53);
            this.PnHeaderMain.TabIndex = 55;
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.Location = new System.Drawing.Point(12, 9);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(114, 25);
            this.LblTitle.TabIndex = 8;
            this.LblTitle.Text = "Trasform";
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
            this.btnClose.Location = new System.Drawing.Point(313, 9);
            this.btnClose.Name = "btnClose";
            this.btnClose.ShadowDecoration.Parent = this.btnClose;
            this.btnClose.Size = new System.Drawing.Size(42, 38);
            this.btnClose.TabIndex = 6;
            this.btnClose.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel6.Location = new System.Drawing.Point(25, 248);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(62, 21);
            this.gunaLabel6.TabIndex = 57;
            this.gunaLabel6.Text = "Quntity";
            // 
            // btnTrandform
            // 
            this.btnTrandform.CheckedState.Parent = this.btnTrandform;
            this.btnTrandform.CustomImages.Parent = this.btnTrandform;
            this.btnTrandform.Enabled = false;
            this.btnTrandform.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnTrandform.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrandform.ForeColor = System.Drawing.Color.White;
            this.btnTrandform.HoverState.Parent = this.btnTrandform;
            this.btnTrandform.Location = new System.Drawing.Point(87, 365);
            this.btnTrandform.Name = "btnTrandform";
            this.btnTrandform.ShadowDecoration.Parent = this.btnTrandform;
            this.btnTrandform.Size = new System.Drawing.Size(168, 45);
            this.btnTrandform.TabIndex = 54;
            this.btnTrandform.Text = "Transform product";
            this.btnTrandform.Click += new System.EventHandler(this.btnTrandform_Click);
            // 
            // DPTransform
            // 
            this.DPTransform.BaseColor = System.Drawing.Color.White;
            this.DPTransform.BorderColor = System.Drawing.Color.Silver;
            this.DPTransform.BorderSize = 1;
            this.DPTransform.CustomFormat = null;
            this.DPTransform.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.DPTransform.Enabled = false;
            this.DPTransform.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DPTransform.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DPTransform.ForeColor = System.Drawing.Color.Black;
            this.DPTransform.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DPTransform.Location = new System.Drawing.Point(118, 285);
            this.DPTransform.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DPTransform.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DPTransform.Name = "DPTransform";
            this.DPTransform.OnHoverBaseColor = System.Drawing.Color.White;
            this.DPTransform.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DPTransform.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DPTransform.OnPressedColor = System.Drawing.Color.Black;
            this.DPTransform.Size = new System.Drawing.Size(237, 36);
            this.DPTransform.TabIndex = 53;
            this.DPTransform.Text = "29/03/2022";
            this.DPTransform.Value = new System.DateTime(2022, 3, 29, 20, 42, 32, 477);
            // 
            // CBStoreFrom
            // 
            this.CBStoreFrom.BackColor = System.Drawing.Color.Transparent;
            this.CBStoreFrom.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CBStoreFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBStoreFrom.FocusedColor = System.Drawing.Color.Empty;
            this.CBStoreFrom.FocusedState.Parent = this.CBStoreFrom;
            this.CBStoreFrom.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CBStoreFrom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.CBStoreFrom.FormattingEnabled = true;
            this.CBStoreFrom.HoverState.Parent = this.CBStoreFrom;
            this.CBStoreFrom.ItemHeight = 30;
            this.CBStoreFrom.ItemsAppearance.Parent = this.CBStoreFrom;
            this.CBStoreFrom.Location = new System.Drawing.Point(120, 83);
            this.CBStoreFrom.Name = "CBStoreFrom";
            this.CBStoreFrom.ShadowDecoration.Parent = this.CBStoreFrom;
            this.CBStoreFrom.Size = new System.Drawing.Size(237, 36);
            this.CBStoreFrom.TabIndex = 48;
            this.CBStoreFrom.SelectedIndexChanged += new System.EventHandler(this.CBStoreFrom_SelectedIndexChanged);
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel5.Location = new System.Drawing.Point(30, 296);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(46, 21);
            this.gunaLabel5.TabIndex = 52;
            this.gunaLabel5.Text = "Date ";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(23, 92);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(87, 21);
            this.lbl.TabIndex = 49;
            this.lbl.Text = "Store From";
            // 
            // CBStoreTo
            // 
            this.CBStoreTo.BackColor = System.Drawing.Color.Transparent;
            this.CBStoreTo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CBStoreTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBStoreTo.FocusedColor = System.Drawing.Color.Empty;
            this.CBStoreTo.FocusedState.Parent = this.CBStoreTo;
            this.CBStoreTo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CBStoreTo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.CBStoreTo.FormattingEnabled = true;
            this.CBStoreTo.HoverState.Parent = this.CBStoreTo;
            this.CBStoreTo.ItemHeight = 30;
            this.CBStoreTo.ItemsAppearance.Parent = this.CBStoreTo;
            this.CBStoreTo.Location = new System.Drawing.Point(120, 136);
            this.CBStoreTo.Name = "CBStoreTo";
            this.CBStoreTo.ShadowDecoration.Parent = this.CBStoreTo;
            this.CBStoreTo.Size = new System.Drawing.Size(237, 36);
            this.CBStoreTo.TabIndex = 50;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(23, 144);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(65, 21);
            this.gunaLabel2.TabIndex = 51;
            this.gunaLabel2.Text = "Store To";
            // 
            // CBProducts
            // 
            this.CBProducts.BackColor = System.Drawing.Color.Transparent;
            this.CBProducts.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CBProducts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBProducts.FocusedColor = System.Drawing.Color.Empty;
            this.CBProducts.FocusedState.Parent = this.CBProducts;
            this.CBProducts.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CBProducts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.CBProducts.FormattingEnabled = true;
            this.CBProducts.HoverState.Parent = this.CBProducts;
            this.CBProducts.ItemHeight = 30;
            this.CBProducts.ItemsAppearance.Parent = this.CBProducts;
            this.CBProducts.Location = new System.Drawing.Point(120, 188);
            this.CBProducts.Name = "CBProducts";
            this.CBProducts.ShadowDecoration.Parent = this.CBProducts;
            this.CBProducts.Size = new System.Drawing.Size(237, 36);
            this.CBProducts.TabIndex = 58;
            this.CBProducts.SelectedIndexChanged += new System.EventHandler(this.CBProducts_SelectedIndexChanged);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(25, 197);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(71, 21);
            this.gunaLabel1.TabIndex = 59;
            this.gunaLabel1.Text = "Products";
            // 
            // TxtQuantity
            // 
            this.TxtQuantity.BackColor = System.Drawing.Color.Cornsilk;
            this.TxtQuantity.BorderColor = System.Drawing.Color.Blue;
            this.TxtQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtQuantity.DefaultText = "";
            this.TxtQuantity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtQuantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtQuantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtQuantity.DisabledState.Parent = this.TxtQuantity;
            this.TxtQuantity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtQuantity.FillColor = System.Drawing.Color.Snow;
            this.TxtQuantity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtQuantity.FocusedState.Parent = this.TxtQuantity;
            this.TxtQuantity.ForeColor = System.Drawing.Color.Fuchsia;
            this.TxtQuantity.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtQuantity.HoverState.Parent = this.TxtQuantity;
            this.TxtQuantity.IconRightOffset = new System.Drawing.Point(3, 0);
            this.TxtQuantity.Location = new System.Drawing.Point(118, 233);
            this.TxtQuantity.Name = "TxtQuantity";
            this.TxtQuantity.PasswordChar = '\0';
            this.TxtQuantity.PlaceholderForeColor = System.Drawing.Color.Fuchsia;
            this.TxtQuantity.PlaceholderText = "Ex:300.00";
            this.TxtQuantity.SelectedText = "";
            this.TxtQuantity.ShadowDecoration.Parent = this.TxtQuantity;
            this.TxtQuantity.Size = new System.Drawing.Size(237, 36);
            this.TxtQuantity.TabIndex = 61;
            // 
            // AddTransform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(367, 466);
            this.Controls.Add(this.TxtQuantity);
            this.Controls.Add(this.CBProducts);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.PnHeaderMain);
            this.Controls.Add(this.gunaLabel6);
            this.Controls.Add(this.btnTrandform);
            this.Controls.Add(this.DPTransform);
            this.Controls.Add(this.CBStoreFrom);
            this.Controls.Add(this.gunaLabel5);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.CBStoreTo);
            this.Controls.Add(this.gunaLabel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddTransform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transform";
            this.Load += new System.EventHandler(this.Transform_Load);
            this.PnHeaderMain.ResumeLayout(false);
            this.PnHeaderMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PnHeaderMain;
        private System.Windows.Forms.Label LblTitle;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI2.WinForms.Guna2Button btnTrandform;
        private Guna.UI.WinForms.GunaDateTimePicker DPTransform;
        private Guna.UI2.WinForms.Guna2ComboBox CBStoreFrom;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaLabel lbl;
        private Guna.UI2.WinForms.Guna2ComboBox CBStoreTo;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI2.WinForms.Guna2ComboBox CBProducts;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI2.WinForms.Guna2TextBox TxtQuantity;
    }
}