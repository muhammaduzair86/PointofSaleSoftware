
namespace PointofSaleSoftware.Screens.ProductsF
{
    partial class btn_Save_Sales
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
            this.txtInvoiceNumber = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.InvoiceDate = new MetroFramework.Controls.MetroDateTime();
            this.CustomerName = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtGrandTotal = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtDiscount = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txtNet = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.txtCash = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.txtBalance = new MetroFramework.Controls.MetroTextBox();
            this.dgv_SaleDet = new System.Windows.Forms.DataGridView();
            this.DetailID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvoiceNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SaleDet)).BeginInit();
            this.SuspendLayout();
            // 
            // txtInvoiceNumber
            // 
            // 
            // 
            // 
            this.txtInvoiceNumber.CustomButton.Image = null;
            this.txtInvoiceNumber.CustomButton.Location = new System.Drawing.Point(122, 2);
            this.txtInvoiceNumber.CustomButton.Name = "";
            this.txtInvoiceNumber.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtInvoiceNumber.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtInvoiceNumber.CustomButton.TabIndex = 1;
            this.txtInvoiceNumber.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtInvoiceNumber.CustomButton.UseSelectable = true;
            this.txtInvoiceNumber.CustomButton.Visible = false;
            this.txtInvoiceNumber.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
            this.txtInvoiceNumber.Lines = new string[0];
            this.txtInvoiceNumber.Location = new System.Drawing.Point(7, 85);
            this.txtInvoiceNumber.MaxLength = 32767;
            this.txtInvoiceNumber.Name = "txtInvoiceNumber";
            this.txtInvoiceNumber.PasswordChar = '\0';
            this.txtInvoiceNumber.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtInvoiceNumber.SelectedText = "";
            this.txtInvoiceNumber.SelectionLength = 0;
            this.txtInvoiceNumber.SelectionStart = 0;
            this.txtInvoiceNumber.ShortcutsEnabled = true;
            this.txtInvoiceNumber.Size = new System.Drawing.Size(150, 30);
            this.txtInvoiceNumber.TabIndex = 0;
            this.txtInvoiceNumber.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtInvoiceNumber.UseSelectable = true;
            this.txtInvoiceNumber.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtInvoiceNumber.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(-1, 58);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(148, 25);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Invoice Number";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(162, 58);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(119, 25);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Invoice Date";
            // 
            // InvoiceDate
            // 
            this.InvoiceDate.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.InvoiceDate.FontSize = MetroFramework.MetroDateTimeSize.Small;
            this.InvoiceDate.Location = new System.Drawing.Point(163, 85);
            this.InvoiceDate.MinimumSize = new System.Drawing.Size(0, 25);
            this.InvoiceDate.Name = "InvoiceDate";
            this.InvoiceDate.Size = new System.Drawing.Size(165, 25);
            this.InvoiceDate.TabIndex = 4;
            this.InvoiceDate.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // CustomerName
            // 
            this.CustomerName.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.CustomerName.FormatString = "d";
            this.CustomerName.FormattingEnabled = true;
            this.CustomerName.ItemHeight = 19;
            this.CustomerName.Location = new System.Drawing.Point(334, 85);
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Size = new System.Drawing.Size(193, 25);
            this.CustomerName.TabIndex = 5;
            this.CustomerName.Theme = MetroFramework.MetroThemeStyle.Light;
            this.CustomerName.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(334, 57);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(93, 25);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "Customer";
            // 
            // txtGrandTotal
            // 
            // 
            // 
            // 
            this.txtGrandTotal.CustomButton.Image = null;
            this.txtGrandTotal.CustomButton.Location = new System.Drawing.Point(59, 2);
            this.txtGrandTotal.CustomButton.Name = "";
            this.txtGrandTotal.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtGrandTotal.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtGrandTotal.CustomButton.TabIndex = 1;
            this.txtGrandTotal.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtGrandTotal.CustomButton.UseSelectable = true;
            this.txtGrandTotal.CustomButton.Visible = false;
            this.txtGrandTotal.Enabled = false;
            this.txtGrandTotal.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
            this.txtGrandTotal.Lines = new string[0];
            this.txtGrandTotal.Location = new System.Drawing.Point(536, 58);
            this.txtGrandTotal.MaxLength = 32767;
            this.txtGrandTotal.Name = "txtGrandTotal";
            this.txtGrandTotal.PasswordChar = '\0';
            this.txtGrandTotal.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtGrandTotal.SelectedText = "";
            this.txtGrandTotal.SelectionLength = 0;
            this.txtGrandTotal.SelectionStart = 0;
            this.txtGrandTotal.ShortcutsEnabled = true;
            this.txtGrandTotal.Size = new System.Drawing.Size(87, 30);
            this.txtGrandTotal.TabIndex = 7;
            this.txtGrandTotal.TabStop = false;
            this.txtGrandTotal.UseSelectable = true;
            this.txtGrandTotal.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtGrandTotal.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(536, 36);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(87, 19);
            this.metroLabel4.TabIndex = 8;
            this.metroLabel4.Text = "Grand Total";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.Location = new System.Drawing.Point(629, 36);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(66, 19);
            this.metroLabel5.TabIndex = 10;
            this.metroLabel5.Text = "Discount";
            // 
            // txtDiscount
            // 
            // 
            // 
            // 
            this.txtDiscount.CustomButton.Image = null;
            this.txtDiscount.CustomButton.Location = new System.Drawing.Point(59, 2);
            this.txtDiscount.CustomButton.Name = "";
            this.txtDiscount.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtDiscount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDiscount.CustomButton.TabIndex = 1;
            this.txtDiscount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDiscount.CustomButton.UseSelectable = true;
            this.txtDiscount.CustomButton.Visible = false;
            this.txtDiscount.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
            this.txtDiscount.Lines = new string[0];
            this.txtDiscount.Location = new System.Drawing.Point(629, 58);
            this.txtDiscount.MaxLength = 32767;
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.PasswordChar = '\0';
            this.txtDiscount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDiscount.SelectedText = "";
            this.txtDiscount.SelectionLength = 0;
            this.txtDiscount.SelectionStart = 0;
            this.txtDiscount.ShortcutsEnabled = true;
            this.txtDiscount.Size = new System.Drawing.Size(87, 30);
            this.txtDiscount.TabIndex = 9;
            this.txtDiscount.UseSelectable = true;
            this.txtDiscount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDiscount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel6.Location = new System.Drawing.Point(722, 36);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(33, 19);
            this.metroLabel6.TabIndex = 12;
            this.metroLabel6.Text = "Net";
            // 
            // txtNet
            // 
            // 
            // 
            // 
            this.txtNet.CustomButton.Image = null;
            this.txtNet.CustomButton.Location = new System.Drawing.Point(59, 2);
            this.txtNet.CustomButton.Name = "";
            this.txtNet.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtNet.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNet.CustomButton.TabIndex = 1;
            this.txtNet.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNet.CustomButton.UseSelectable = true;
            this.txtNet.CustomButton.Visible = false;
            this.txtNet.Enabled = false;
            this.txtNet.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
            this.txtNet.Lines = new string[0];
            this.txtNet.Location = new System.Drawing.Point(722, 58);
            this.txtNet.MaxLength = 32767;
            this.txtNet.Name = "txtNet";
            this.txtNet.PasswordChar = '\0';
            this.txtNet.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNet.SelectedText = "";
            this.txtNet.SelectionLength = 0;
            this.txtNet.SelectionStart = 0;
            this.txtNet.ShortcutsEnabled = true;
            this.txtNet.Size = new System.Drawing.Size(87, 30);
            this.txtNet.TabIndex = 11;
            this.txtNet.TabStop = false;
            this.txtNet.UseSelectable = true;
            this.txtNet.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNet.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel7.Location = new System.Drawing.Point(536, 92);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(40, 19);
            this.metroLabel7.TabIndex = 14;
            this.metroLabel7.Text = "Cash";
            // 
            // txtCash
            // 
            // 
            // 
            // 
            this.txtCash.CustomButton.Image = null;
            this.txtCash.CustomButton.Location = new System.Drawing.Point(59, 2);
            this.txtCash.CustomButton.Name = "";
            this.txtCash.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtCash.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCash.CustomButton.TabIndex = 1;
            this.txtCash.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCash.CustomButton.UseSelectable = true;
            this.txtCash.CustomButton.Visible = false;
            this.txtCash.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
            this.txtCash.Lines = new string[0];
            this.txtCash.Location = new System.Drawing.Point(536, 114);
            this.txtCash.MaxLength = 32767;
            this.txtCash.Name = "txtCash";
            this.txtCash.PasswordChar = '\0';
            this.txtCash.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCash.SelectedText = "";
            this.txtCash.SelectionLength = 0;
            this.txtCash.SelectionStart = 0;
            this.txtCash.ShortcutsEnabled = true;
            this.txtCash.Size = new System.Drawing.Size(87, 30);
            this.txtCash.TabIndex = 13;
            this.txtCash.UseSelectable = true;
            this.txtCash.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCash.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel8.Location = new System.Drawing.Point(629, 92);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(61, 19);
            this.metroLabel8.TabIndex = 16;
            this.metroLabel8.Text = "Balance";
            // 
            // txtBalance
            // 
            // 
            // 
            // 
            this.txtBalance.CustomButton.Image = null;
            this.txtBalance.CustomButton.Location = new System.Drawing.Point(59, 2);
            this.txtBalance.CustomButton.Name = "";
            this.txtBalance.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtBalance.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBalance.CustomButton.TabIndex = 1;
            this.txtBalance.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBalance.CustomButton.UseSelectable = true;
            this.txtBalance.CustomButton.Visible = false;
            this.txtBalance.Enabled = false;
            this.txtBalance.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
            this.txtBalance.Lines = new string[0];
            this.txtBalance.Location = new System.Drawing.Point(629, 114);
            this.txtBalance.MaxLength = 32767;
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.PasswordChar = '\0';
            this.txtBalance.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBalance.SelectedText = "";
            this.txtBalance.SelectionLength = 0;
            this.txtBalance.SelectionStart = 0;
            this.txtBalance.ShortcutsEnabled = true;
            this.txtBalance.Size = new System.Drawing.Size(87, 30);
            this.txtBalance.TabIndex = 15;
            this.txtBalance.TabStop = false;
            this.txtBalance.UseSelectable = true;
            this.txtBalance.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBalance.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // dgv_SaleDet
            // 
            this.dgv_SaleDet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_SaleDet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DetailID,
            this.InvoiceNumber,
            this.StockID,
            this.Price,
            this.Quantity,
            this.TotalPrice});
            this.dgv_SaleDet.Location = new System.Drawing.Point(7, 149);
            this.dgv_SaleDet.Name = "dgv_SaleDet";
            this.dgv_SaleDet.Size = new System.Drawing.Size(871, 321);
            this.dgv_SaleDet.TabIndex = 21;
            // 
            // DetailID
            // 
            this.DetailID.DataPropertyName = "DetailID";
            this.DetailID.HeaderText = "DetailID";
            this.DetailID.Name = "DetailID";
            this.DetailID.Visible = false;
            // 
            // InvoiceNumber
            // 
            this.InvoiceNumber.DataPropertyName = "InvoiceNumber";
            this.InvoiceNumber.HeaderText = "InvoiceNumber";
            this.InvoiceNumber.Name = "InvoiceNumber";
            this.InvoiceNumber.Visible = false;
            // 
            // StockID
            // 
            this.StockID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StockID.DataPropertyName = "StockID";
            this.StockID.FillWeight = 250F;
            this.StockID.HeaderText = "Product";
            this.StockID.Name = "StockID";
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            // 
            // TotalPrice
            // 
            this.TotalPrice.DataPropertyName = "Amount";
            this.TotalPrice.HeaderText = "Amount";
            this.TotalPrice.Name = "TotalPrice";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(723, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 30);
            this.button1.TabIndex = 22;
            this.button1.Text = "Save Record";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Save_Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 493);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgv_SaleDet);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.txtBalance);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.txtCash);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.txtNet);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.txtGrandTotal);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.CustomerName);
            this.Controls.Add(this.InvoiceDate);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtInvoiceNumber);
            this.Name = "btn_Save_Sales";
            this.Text = "Sales Invoice";
            this.Load += new System.EventHandler(this.frmSales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SaleDet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtInvoiceNumber;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroDateTime InvoiceDate;
        private MetroFramework.Controls.MetroComboBox CustomerName;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtGrandTotal;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txtDiscount;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox txtNet;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox txtCash;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox txtBalance;
        private System.Windows.Forms.DataGridView dgv_SaleDet;
        private System.Windows.Forms.DataGridViewTextBoxColumn DetailID;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceNumber;
        private System.Windows.Forms.DataGridViewComboBoxColumn StockID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
        private System.Windows.Forms.Button button1;
    }
}