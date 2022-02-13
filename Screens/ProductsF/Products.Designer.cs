namespace PointofSaleSoftware.Screens.ProductsF
{
    partial class Products
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
            this.txt_ProductName = new System.Windows.Forms.TextBox();
            this.lbl_ProductName = new System.Windows.Forms.Label();
            this.txt_PurchasePrice = new System.Windows.Forms.TextBox();
            this.txt_SalePrice = new System.Windows.Forms.TextBox();
            this.lbl_PurchasePrice = new System.Windows.Forms.Label();
            this.lbl_SalesPrice = new System.Windows.Forms.Label();
            this.combo_Category = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.combo_Supplier = new System.Windows.Forms.Label();
            this.cbo_Supplier = new System.Windows.Forms.ComboBox();
            this.dgv_Products = new System.Windows.Forms.DataGridView();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.zeewan_posDataSet = new PointofSaleSoftware.zeewan_posDataSet();
            this.suppliersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.suppliersTableAdapter = new PointofSaleSoftware.zeewan_posDataSetTableAdapters.SuppliersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Products)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zeewan_posDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_ProductName
            // 
            this.txt_ProductName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ProductName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ProductName.Location = new System.Drawing.Point(160, 82);
            this.txt_ProductName.Name = "txt_ProductName";
            this.txt_ProductName.Size = new System.Drawing.Size(194, 27);
            this.txt_ProductName.TabIndex = 0;
            // 
            // lbl_ProductName
            // 
            this.lbl_ProductName.AutoSize = true;
            this.lbl_ProductName.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ProductName.Location = new System.Drawing.Point(14, 79);
            this.lbl_ProductName.Name = "lbl_ProductName";
            this.lbl_ProductName.Size = new System.Drawing.Size(123, 23);
            this.lbl_ProductName.TabIndex = 1;
            this.lbl_ProductName.Text = "Product Name";
            // 
            // txt_PurchasePrice
            // 
            this.txt_PurchasePrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_PurchasePrice.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PurchasePrice.Location = new System.Drawing.Point(160, 240);
            this.txt_PurchasePrice.Name = "txt_PurchasePrice";
            this.txt_PurchasePrice.Size = new System.Drawing.Size(194, 27);
            this.txt_PurchasePrice.TabIndex = 2;
            // 
            // txt_SalePrice
            // 
            this.txt_SalePrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_SalePrice.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SalePrice.Location = new System.Drawing.Point(160, 296);
            this.txt_SalePrice.Name = "txt_SalePrice";
            this.txt_SalePrice.Size = new System.Drawing.Size(194, 27);
            this.txt_SalePrice.TabIndex = 3;
            // 
            // lbl_PurchasePrice
            // 
            this.lbl_PurchasePrice.AutoSize = true;
            this.lbl_PurchasePrice.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PurchasePrice.Location = new System.Drawing.Point(14, 237);
            this.lbl_PurchasePrice.Name = "lbl_PurchasePrice";
            this.lbl_PurchasePrice.Size = new System.Drawing.Size(126, 23);
            this.lbl_PurchasePrice.TabIndex = 4;
            this.lbl_PurchasePrice.Text = "Purchase Price";
            // 
            // lbl_SalesPrice
            // 
            this.lbl_SalesPrice.AutoSize = true;
            this.lbl_SalesPrice.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SalesPrice.Location = new System.Drawing.Point(14, 296);
            this.lbl_SalesPrice.Name = "lbl_SalesPrice";
            this.lbl_SalesPrice.Size = new System.Drawing.Size(95, 23);
            this.lbl_SalesPrice.TabIndex = 5;
            this.lbl_SalesPrice.Text = "Sales Price";
            // 
            // combo_Category
            // 
            this.combo_Category.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_Category.FormattingEnabled = true;
            this.combo_Category.Location = new System.Drawing.Point(160, 128);
            this.combo_Category.Name = "combo_Category";
            this.combo_Category.Size = new System.Drawing.Size(194, 27);
            this.combo_Category.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Category";
            // 
            // combo_Supplier
            // 
            this.combo_Supplier.AutoSize = true;
            this.combo_Supplier.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_Supplier.Location = new System.Drawing.Point(14, 179);
            this.combo_Supplier.Name = "combo_Supplier";
            this.combo_Supplier.Size = new System.Drawing.Size(76, 23);
            this.combo_Supplier.TabIndex = 9;
            this.combo_Supplier.Text = "Supplier";
            // 
            // cbo_Supplier
            // 
            this.cbo_Supplier.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_Supplier.FormattingEnabled = true;
            this.cbo_Supplier.Location = new System.Drawing.Point(160, 179);
            this.cbo_Supplier.Name = "cbo_Supplier";
            this.cbo_Supplier.Size = new System.Drawing.Size(194, 27);
            this.cbo_Supplier.TabIndex = 8;
            // 
            // dgv_Products
            // 
            this.dgv_Products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Products.Location = new System.Drawing.Point(360, 21);
            this.dgv_Products.Name = "dgv_Products";
            this.dgv_Products.Size = new System.Drawing.Size(600, 478);
            this.dgv_Products.TabIndex = 10;
            // 
            // btn_Add
            // 
            this.btn_Add.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Location = new System.Drawing.Point(18, 348);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(91, 29);
            this.btn_Add.TabIndex = 11;
            this.btn_Add.Text = "Add New";
            this.btn_Add.UseVisualStyleBackColor = true;
            // 
            // btn_Update
            // 
            this.btn_Update.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.Location = new System.Drawing.Point(142, 348);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(91, 29);
            this.btn_Update.TabIndex = 12;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            // 
            // btn_Close
            // 
            this.btn_Close.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.Location = new System.Drawing.Point(142, 410);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(91, 29);
            this.btn_Close.TabIndex = 14;
            this.btn_Close.Text = "Close Form";
            this.btn_Close.UseVisualStyleBackColor = true;
            // 
            // btn_Clear
            // 
            this.btn_Clear.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.Location = new System.Drawing.Point(18, 410);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(91, 29);
            this.btn_Clear.TabIndex = 13;
            this.btn_Clear.Text = "Clear Form";
            this.btn_Clear.UseVisualStyleBackColor = true;
            // 
            // zeewan_posDataSet
            // 
            this.zeewan_posDataSet.DataSetName = "zeewan_posDataSet";
            this.zeewan_posDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // suppliersBindingSource
            // 
            this.suppliersBindingSource.DataMember = "Suppliers";
            this.suppliersBindingSource.DataSource = this.zeewan_posDataSet;
            // 
            // suppliersTableAdapter
            // 
            this.suppliersTableAdapter.ClearBeforeFill = true;
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 531);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.dgv_Products);
            this.Controls.Add(this.combo_Supplier);
            this.Controls.Add(this.cbo_Supplier);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combo_Category);
            this.Controls.Add(this.lbl_SalesPrice);
            this.Controls.Add(this.lbl_PurchasePrice);
            this.Controls.Add(this.txt_SalePrice);
            this.Controls.Add(this.txt_PurchasePrice);
            this.Controls.Add(this.lbl_ProductName);
            this.Controls.Add(this.txt_ProductName);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.suppliersBindingSource, "Supp_ID", true));
            this.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.suppliersBindingSource, "Supp_Name", true));
            this.Name = "Products";
            this.Text = "Products";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Products_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Products)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zeewan_posDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_ProductName;
        private System.Windows.Forms.Label lbl_ProductName;
        private System.Windows.Forms.TextBox txt_PurchasePrice;
        private System.Windows.Forms.TextBox txt_SalePrice;
        private System.Windows.Forms.Label lbl_PurchasePrice;
        private System.Windows.Forms.Label lbl_SalesPrice;
        private System.Windows.Forms.ComboBox combo_Category;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label combo_Supplier;
        private System.Windows.Forms.ComboBox cbo_Supplier;
        private System.Windows.Forms.DataGridView dgv_Products;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_Clear;
        private zeewan_posDataSet zeewan_posDataSet;
        private System.Windows.Forms.BindingSource suppliersBindingSource;
        private zeewan_posDataSetTableAdapters.SuppliersTableAdapter suppliersTableAdapter;
    }
}