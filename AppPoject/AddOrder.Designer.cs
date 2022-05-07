namespace AppPoject
{
    partial class AddOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddOrder));
            this.PnHeaderMain = new System.Windows.Forms.Panel();
            this.LblTitle = new System.Windows.Forms.Label();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.CBProduct = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lbl = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.CBCostumer = new Guna.UI2.WinForms.Guna2ComboBox();
            this.CBTypePay = new Guna.UI2.WinForms.Guna2ComboBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.CBState = new Guna.UI2.WinForms.Guna2ComboBox();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.DPDateStart = new Guna.UI.WinForms.GunaDateTimePicker();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.DPEnd = new Guna.UI.WinForms.GunaDateTimePicker();
            this.PnGestion = new System.Windows.Forms.Panel();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.TxtQuantity = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.TxtPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.ShadowForm = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.PnHeaderMain.SuspendLayout();
            this.PnGestion.SuspendLayout();
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
            this.PnHeaderMain.Size = new System.Drawing.Size(434, 53);
            this.PnHeaderMain.TabIndex = 2;
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.Location = new System.Drawing.Point(3, 9);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(78, 25);
            this.LblTitle.TabIndex = 8;
            this.LblTitle.Text = "Order";
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
            this.btnClose.Location = new System.Drawing.Point(380, 9);
            this.btnClose.Name = "btnClose";
            this.btnClose.ShadowDecoration.Parent = this.btnClose;
            this.btnClose.Size = new System.Drawing.Size(42, 38);
            this.btnClose.TabIndex = 6;
            this.btnClose.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // CBProduct
            // 
            this.CBProduct.BackColor = System.Drawing.Color.Transparent;
            this.CBProduct.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CBProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBProduct.FocusedColor = System.Drawing.Color.Empty;
            this.CBProduct.FocusedState.Parent = this.CBProduct;
            this.CBProduct.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CBProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.CBProduct.FormattingEnabled = true;
            this.CBProduct.HoverState.Parent = this.CBProduct;
            this.CBProduct.ItemHeight = 30;
            this.CBProduct.ItemsAppearance.Parent = this.CBProduct;
            this.CBProduct.Location = new System.Drawing.Point(121, 94);
            this.CBProduct.Name = "CBProduct";
            this.CBProduct.ShadowDecoration.Parent = this.CBProduct;
            this.CBProduct.Size = new System.Drawing.Size(237, 36);
            this.CBProduct.TabIndex = 30;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(24, 109);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(64, 21);
            this.lbl.TabIndex = 31;
            this.lbl.Text = "Product";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(24, 158);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(69, 21);
            this.gunaLabel2.TabIndex = 35;
            this.gunaLabel2.Text = "Costmer";
            // 
            // CBCostumer
            // 
            this.CBCostumer.BackColor = System.Drawing.Color.Transparent;
            this.CBCostumer.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CBCostumer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBCostumer.FocusedColor = System.Drawing.Color.Empty;
            this.CBCostumer.FocusedState.Parent = this.CBCostumer;
            this.CBCostumer.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CBCostumer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.CBCostumer.FormattingEnabled = true;
            this.CBCostumer.HoverState.Parent = this.CBCostumer;
            this.CBCostumer.ItemHeight = 30;
            this.CBCostumer.ItemsAppearance.Parent = this.CBCostumer;
            this.CBCostumer.Location = new System.Drawing.Point(121, 147);
            this.CBCostumer.Name = "CBCostumer";
            this.CBCostumer.ShadowDecoration.Parent = this.CBCostumer;
            this.CBCostumer.Size = new System.Drawing.Size(237, 36);
            this.CBCostumer.TabIndex = 34;
            // 
            // CBTypePay
            // 
            this.CBTypePay.BackColor = System.Drawing.Color.Transparent;
            this.CBTypePay.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CBTypePay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBTypePay.FocusedColor = System.Drawing.Color.Empty;
            this.CBTypePay.FocusedState.Parent = this.CBTypePay;
            this.CBTypePay.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CBTypePay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.CBTypePay.FormattingEnabled = true;
            this.CBTypePay.HoverState.Parent = this.CBTypePay;
            this.CBTypePay.ItemHeight = 30;
            this.CBTypePay.ItemsAppearance.Parent = this.CBTypePay;
            this.CBTypePay.Location = new System.Drawing.Point(121, 197);
            this.CBTypePay.Name = "CBTypePay";
            this.CBTypePay.ShadowDecoration.Parent = this.CBTypePay;
            this.CBTypePay.Size = new System.Drawing.Size(237, 36);
            this.CBTypePay.TabIndex = 36;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(24, 208);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(71, 21);
            this.gunaLabel1.TabIndex = 37;
            this.gunaLabel1.Text = "Methods";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(28, 259);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(44, 21);
            this.gunaLabel3.TabIndex = 38;
            this.gunaLabel3.Text = "State";
            // 
            // CBState
            // 
            this.CBState.BackColor = System.Drawing.Color.Transparent;
            this.CBState.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CBState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBState.FocusedColor = System.Drawing.Color.Empty;
            this.CBState.FocusedState.Parent = this.CBState;
            this.CBState.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CBState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.CBState.FormattingEnabled = true;
            this.CBState.HoverState.Parent = this.CBState;
            this.CBState.ItemHeight = 30;
            this.CBState.ItemsAppearance.Parent = this.CBState;
            this.CBState.Location = new System.Drawing.Point(121, 247);
            this.CBState.Name = "CBState";
            this.CBState.ShadowDecoration.Parent = this.CBState;
            this.CBState.Size = new System.Drawing.Size(237, 36);
            this.CBState.TabIndex = 39;
            this.CBState.SelectedIndexChanged += new System.EventHandler(this.CBState_SelectedIndexChanged);
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.Location = new System.Drawing.Point(28, 390);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(78, 21);
            this.gunaLabel4.TabIndex = 41;
            this.gunaLabel4.Text = "Date Start";
            // 
            // DPDateStart
            // 
            this.DPDateStart.BaseColor = System.Drawing.Color.White;
            this.DPDateStart.BorderColor = System.Drawing.Color.Silver;
            this.DPDateStart.BorderSize = 1;
            this.DPDateStart.CustomFormat = null;
            this.DPDateStart.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.DPDateStart.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DPDateStart.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DPDateStart.ForeColor = System.Drawing.Color.Black;
            this.DPDateStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DPDateStart.Location = new System.Drawing.Point(121, 384);
            this.DPDateStart.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DPDateStart.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DPDateStart.Name = "DPDateStart";
            this.DPDateStart.OnHoverBaseColor = System.Drawing.Color.White;
            this.DPDateStart.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DPDateStart.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DPDateStart.OnPressedColor = System.Drawing.Color.Black;
            this.DPDateStart.Size = new System.Drawing.Size(237, 36);
            this.DPDateStart.TabIndex = 40;
            this.DPDateStart.Text = "29/03/2022";
            this.DPDateStart.Value = new System.DateTime(2022, 3, 29, 20, 42, 32, 477);
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel5.Location = new System.Drawing.Point(30, 441);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(72, 21);
            this.gunaLabel5.TabIndex = 43;
            this.gunaLabel5.Text = "Date End";
            // 
            // DPEnd
            // 
            this.DPEnd.BaseColor = System.Drawing.Color.White;
            this.DPEnd.BorderColor = System.Drawing.Color.Silver;
            this.DPEnd.BorderSize = 1;
            this.DPEnd.CustomFormat = null;
            this.DPEnd.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.DPEnd.Enabled = false;
            this.DPEnd.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DPEnd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DPEnd.ForeColor = System.Drawing.Color.Black;
            this.DPEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DPEnd.Location = new System.Drawing.Point(121, 432);
            this.DPEnd.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DPEnd.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DPEnd.Name = "DPEnd";
            this.DPEnd.OnHoverBaseColor = System.Drawing.Color.White;
            this.DPEnd.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DPEnd.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DPEnd.OnPressedColor = System.Drawing.Color.Black;
            this.DPEnd.Size = new System.Drawing.Size(237, 36);
            this.DPEnd.TabIndex = 44;
            this.DPEnd.Text = "29/03/2022";
            this.DPEnd.Value = new System.DateTime(2022, 3, 29, 20, 42, 32, 477);
            // 
            // PnGestion
            // 
            this.PnGestion.Controls.Add(this.gunaLabel7);
            this.PnGestion.Controls.Add(this.TxtQuantity);
            this.PnGestion.Controls.Add(this.gunaLabel6);
            this.PnGestion.Controls.Add(this.TxtPrice);
            this.PnGestion.Controls.Add(this.label1);
            this.PnGestion.Controls.Add(this.btnAdd);
            this.PnGestion.Controls.Add(this.CBTypePay);
            this.PnGestion.Controls.Add(this.DPEnd);
            this.PnGestion.Controls.Add(this.CBProduct);
            this.PnGestion.Controls.Add(this.gunaLabel5);
            this.PnGestion.Controls.Add(this.lbl);
            this.PnGestion.Controls.Add(this.gunaLabel4);
            this.PnGestion.Controls.Add(this.CBCostumer);
            this.PnGestion.Controls.Add(this.DPDateStart);
            this.PnGestion.Controls.Add(this.gunaLabel2);
            this.PnGestion.Controls.Add(this.CBState);
            this.PnGestion.Controls.Add(this.gunaLabel1);
            this.PnGestion.Controls.Add(this.gunaLabel3);
            this.PnGestion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnGestion.Location = new System.Drawing.Point(0, 53);
            this.PnGestion.Name = "PnGestion";
            this.PnGestion.Size = new System.Drawing.Size(434, 546);
            this.PnGestion.TabIndex = 45;
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.AutoSize = true;
            this.gunaLabel7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel7.Location = new System.Drawing.Point(30, 348);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(62, 21);
            this.gunaLabel7.TabIndex = 49;
            this.gunaLabel7.Text = "Quntity";
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
            this.TxtQuantity.Location = new System.Drawing.Point(121, 336);
            this.TxtQuantity.Name = "TxtQuantity";
            this.TxtQuantity.PasswordChar = '\0';
            this.TxtQuantity.PlaceholderForeColor = System.Drawing.Color.Fuchsia;
            this.TxtQuantity.PlaceholderText = "Quantity";
            this.TxtQuantity.SelectedText = "";
            this.TxtQuantity.ShadowDecoration.Parent = this.TxtQuantity;
            this.TxtQuantity.Size = new System.Drawing.Size(237, 36);
            this.TxtQuantity.TabIndex = 48;
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel6.Location = new System.Drawing.Point(30, 301);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(77, 21);
            this.gunaLabel6.TabIndex = 47;
            this.gunaLabel6.Text = "Price Unit";
            // 
            // TxtPrice
            // 
            this.TxtPrice.BackColor = System.Drawing.Color.Cornsilk;
            this.TxtPrice.BorderColor = System.Drawing.Color.Blue;
            this.TxtPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtPrice.DefaultText = "";
            this.TxtPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtPrice.DisabledState.Parent = this.TxtPrice;
            this.TxtPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtPrice.FillColor = System.Drawing.Color.Snow;
            this.TxtPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtPrice.FocusedState.Parent = this.TxtPrice;
            this.TxtPrice.ForeColor = System.Drawing.Color.Fuchsia;
            this.TxtPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtPrice.HoverState.Parent = this.TxtPrice;
            this.TxtPrice.IconRightOffset = new System.Drawing.Point(3, 0);
            this.TxtPrice.Location = new System.Drawing.Point(121, 289);
            this.TxtPrice.Name = "TxtPrice";
            this.TxtPrice.PasswordChar = '\0';
            this.TxtPrice.PlaceholderForeColor = System.Drawing.Color.Fuchsia;
            this.TxtPrice.PlaceholderText = "Price";
            this.TxtPrice.SelectedText = "";
            this.TxtPrice.ShadowDecoration.Parent = this.TxtPrice;
            this.TxtPrice.Size = new System.Drawing.Size(237, 36);
            this.TxtPrice.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(115, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 32);
            this.label1.TabIndex = 9;
            this.label1.Text = "Create Order";
            // 
            // btnAdd
            // 
            this.btnAdd.CheckedState.Parent = this.btnAdd;
            this.btnAdd.CustomImages.Parent = this.btnAdd;
            this.btnAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.HoverState.Parent = this.btnAdd;
            this.btnAdd.Location = new System.Drawing.Point(140, 489);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ShadowDecoration.Parent = this.btnAdd;
            this.btnAdd.Size = new System.Drawing.Size(133, 45);
            this.btnAdd.TabIndex = 45;
            this.btnAdd.Text = "Add Order";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // AddOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(434, 599);
            this.Controls.Add(this.PnGestion);
            this.Controls.Add(this.PnHeaderMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddOrder";
            this.Load += new System.EventHandler(this.AddOrder_Load);
            this.PnHeaderMain.ResumeLayout(false);
            this.PnHeaderMain.PerformLayout();
            this.PnGestion.ResumeLayout(false);
            this.PnGestion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnHeaderMain;
        private System.Windows.Forms.Label LblTitle;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2ComboBox CBProduct;
        private Guna.UI.WinForms.GunaLabel lbl;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI2.WinForms.Guna2ComboBox CBCostumer;
        private Guna.UI2.WinForms.Guna2ComboBox CBTypePay;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI2.WinForms.Guna2ComboBox CBState;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaDateTimePicker DPDateStart;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaDateTimePicker DPEnd;
        private System.Windows.Forms.Panel PnGestion;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI2.WinForms.Guna2TextBox TxtPrice;
        private Guna.UI2.WinForms.Guna2ShadowForm ShadowForm;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private Guna.UI2.WinForms.Guna2TextBox TxtQuantity;
    }
}