namespace PointofSaleSoftware.Screens.ProductsF
{
    partial class frmPurchase
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
            this.txtPurchaseID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpPurchaseDate = new System.Windows.Forms.DateTimePicker();
            this.cmbSupplierID = new MetroFramework.Controls.MetroComboBox();
            this.dgv_Purd = new System.Windows.Forms.DataGridView();
            this.cmbProductID = new System.Windows.Forms.ComboBox();
            this.txtPurQty = new System.Windows.Forms.TextBox();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.btn_AddProduct = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.btnRemoveProduct = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Purd)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPurchaseID
            // 
            this.txtPurchaseID.Location = new System.Drawing.Point(98, 71);
            this.txtPurchaseID.Name = "txtPurchaseID";
            this.txtPurchaseID.ReadOnly = true;
            this.txtPurchaseID.Size = new System.Drawing.Size(100, 20);
            this.txtPurchaseID.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Purchase ID:";
            // 
            // dtpPurchaseDate
            // 
            this.dtpPurchaseDate.CustomFormat = "dd-MM-yyyy";
            this.dtpPurchaseDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPurchaseDate.Location = new System.Drawing.Point(204, 72);
            this.dtpPurchaseDate.Name = "dtpPurchaseDate";
            this.dtpPurchaseDate.Size = new System.Drawing.Size(102, 20);
            this.dtpPurchaseDate.TabIndex = 2;
            // 
            // cmbSupplierID
            // 
            this.cmbSupplierID.FormattingEnabled = true;
            this.cmbSupplierID.ItemHeight = 23;
            this.cmbSupplierID.Location = new System.Drawing.Point(312, 63);
            this.cmbSupplierID.Name = "cmbSupplierID";
            this.cmbSupplierID.Size = new System.Drawing.Size(156, 29);
            this.cmbSupplierID.TabIndex = 3;
            this.cmbSupplierID.UseSelectable = true;
            // 
            // dgv_Purd
            // 
            this.dgv_Purd.AllowUserToAddRows = false;
            this.dgv_Purd.AllowUserToDeleteRows = false;
            this.dgv_Purd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Purd.Location = new System.Drawing.Point(8, 165);
            this.dgv_Purd.Name = "dgv_Purd";
            this.dgv_Purd.Size = new System.Drawing.Size(752, 176);
            this.dgv_Purd.TabIndex = 4;
            this.dgv_Purd.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Purd_CellValidated);
            this.dgv_Purd.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Purd_CellValueChanged);
            this.dgv_Purd.SelectionChanged += new System.EventHandler(this.dgv_Purd_SelectionChanged);
            // 
            // cmbProductID
            // 
            this.cmbProductID.FormattingEnabled = true;
            this.cmbProductID.Location = new System.Drawing.Point(24, 125);
            this.cmbProductID.Name = "cmbProductID";
            this.cmbProductID.Size = new System.Drawing.Size(121, 21);
            this.cmbProductID.TabIndex = 5;
            // 
            // txtPurQty
            // 
            this.txtPurQty.Location = new System.Drawing.Point(152, 125);
            this.txtPurQty.Name = "txtPurQty";
            this.txtPurQty.Size = new System.Drawing.Size(100, 20);
            this.txtPurQty.TabIndex = 6;
            this.txtPurQty.TextChanged += new System.EventHandler(this.txtPurQty_TextChanged);
            // 
            // txtRate
            // 
            this.txtRate.Location = new System.Drawing.Point(258, 125);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(100, 20);
            this.txtRate.TabIndex = 7;
            this.txtRate.TextChanged += new System.EventHandler(this.txtPurQty_TextChanged);
            // 
            // txtAmount
            // 
            this.txtAmount.Enabled = false;
            this.txtAmount.Location = new System.Drawing.Point(368, 126);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(100, 20);
            this.txtAmount.TabIndex = 8;
            // 
            // btn_AddProduct
            // 
            this.btn_AddProduct.Location = new System.Drawing.Point(495, 122);
            this.btn_AddProduct.Name = "btn_AddProduct";
            this.btn_AddProduct.Size = new System.Drawing.Size(75, 23);
            this.btn_AddProduct.TabIndex = 9;
            this.btn_AddProduct.Text = "Add Product";
            this.btn_AddProduct.UseVisualStyleBackColor = true;
            this.btn_AddProduct.Click += new System.EventHandler(this.btn_AddProduct_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(599, 404);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Enabled = false;
            this.txtTotalAmount.Location = new System.Drawing.Point(574, 359);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.Size = new System.Drawing.Size(100, 20);
            this.txtTotalAmount.TabIndex = 11;
            // 
            // btnRemoveProduct
            // 
            this.btnRemoveProduct.Location = new System.Drawing.Point(8, 347);
            this.btnRemoveProduct.Name = "btnRemoveProduct";
            this.btnRemoveProduct.Size = new System.Drawing.Size(149, 23);
            this.btnRemoveProduct.TabIndex = 12;
            this.btnRemoveProduct.Text = "Remove Product";
            this.btnRemoveProduct.UseVisualStyleBackColor = true;
            this.btnRemoveProduct.Click += new System.EventHandler(this.btnRemoveProduct_Click);
            // 
            // frmPurchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRemoveProduct);
            this.Controls.Add(this.txtTotalAmount);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btn_AddProduct);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.txtPurQty);
            this.Controls.Add(this.cmbProductID);
            this.Controls.Add(this.dgv_Purd);
            this.Controls.Add(this.cmbSupplierID);
            this.Controls.Add(this.dtpPurchaseDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPurchaseID);
            this.Name = "frmPurchase";
            this.Text = "Purchase";
            this.Load += new System.EventHandler(this.frmPurchase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Purd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPurchaseID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpPurchaseDate;
        private MetroFramework.Controls.MetroComboBox cmbSupplierID;
        private System.Windows.Forms.DataGridView dgv_Purd;
        private System.Windows.Forms.ComboBox cmbProductID;
        private System.Windows.Forms.TextBox txtPurQty;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button btn_AddProduct;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.Button btnRemoveProduct;
    }
}