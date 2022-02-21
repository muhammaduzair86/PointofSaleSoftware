﻿
namespace PointofSaleSoftware.Screens.ProductsF
{
    partial class SaleForm
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
            this.dt_InvoiceDate = new MetroFramework.Controls.MetroDateTime();
            this.cbo_Customer = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGrandTotal = new MetroFramework.Controls.MetroTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDiscount = new MetroFramework.Controls.MetroTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNet = new MetroFramework.Controls.MetroTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCash = new MetroFramework.Controls.MetroTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBalance = new MetroFramework.Controls.MetroTextBox();
            this.lbl_Select_Item = new System.Windows.Forms.Label();
            this.dgv_SalesDet = new System.Windows.Forms.DataGridView();
            this.cbo_ProductName = new System.Windows.Forms.ComboBox();
            this.btn_AddProduct = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SalesDet)).BeginInit();
            this.SuspendLayout();
            // 
            // txtInvoiceNumber
            // 
            // 
            // 
            // 
            this.txtInvoiceNumber.CustomButton.Image = null;
            this.txtInvoiceNumber.CustomButton.Location = new System.Drawing.Point(84, 1);
            this.txtInvoiceNumber.CustomButton.Name = "";
            this.txtInvoiceNumber.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtInvoiceNumber.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtInvoiceNumber.CustomButton.TabIndex = 1;
            this.txtInvoiceNumber.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtInvoiceNumber.CustomButton.UseSelectable = true;
            this.txtInvoiceNumber.CustomButton.Visible = false;
            this.txtInvoiceNumber.Lines = new string[0];
            this.txtInvoiceNumber.Location = new System.Drawing.Point(1128, 10);
            this.txtInvoiceNumber.MaxLength = 32767;
            this.txtInvoiceNumber.Name = "txtInvoiceNumber";
            this.txtInvoiceNumber.PasswordChar = '\0';
            this.txtInvoiceNumber.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtInvoiceNumber.SelectedText = "";
            this.txtInvoiceNumber.SelectionLength = 0;
            this.txtInvoiceNumber.SelectionStart = 0;
            this.txtInvoiceNumber.ShortcutsEnabled = true;
            this.txtInvoiceNumber.Size = new System.Drawing.Size(106, 23);
            this.txtInvoiceNumber.TabIndex = 0;
            this.txtInvoiceNumber.UseSelectable = true;
            this.txtInvoiceNumber.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtInvoiceNumber.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // dt_InvoiceDate
            // 
            this.dt_InvoiceDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_InvoiceDate.Location = new System.Drawing.Point(6, 101);
            this.dt_InvoiceDate.MinDate = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.dt_InvoiceDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.dt_InvoiceDate.Name = "dt_InvoiceDate";
            this.dt_InvoiceDate.Size = new System.Drawing.Size(200, 29);
            this.dt_InvoiceDate.TabIndex = 1;
            this.dt_InvoiceDate.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // cbo_Customer
            // 
            this.cbo_Customer.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_Customer.FormattingEnabled = true;
            this.cbo_Customer.ItemHeight = 19;
            this.cbo_Customer.Location = new System.Drawing.Point(6, 165);
            this.cbo_Customer.Name = "cbo_Customer";
            this.cbo_Customer.Size = new System.Drawing.Size(216, 27);
            this.cbo_Customer.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sale Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Customer";
            // 
            // txtGrandTotal
            // 
            // 
            // 
            // 
            this.txtGrandTotal.CustomButton.Image = null;
            this.txtGrandTotal.CustomButton.Location = new System.Drawing.Point(132, 2);
            this.txtGrandTotal.CustomButton.Name = "";
            this.txtGrandTotal.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtGrandTotal.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtGrandTotal.CustomButton.TabIndex = 1;
            this.txtGrandTotal.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtGrandTotal.CustomButton.UseSelectable = true;
            this.txtGrandTotal.CustomButton.Visible = false;
            this.txtGrandTotal.Enabled = false;
            this.txtGrandTotal.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtGrandTotal.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtGrandTotal.Lines = new string[0];
            this.txtGrandTotal.Location = new System.Drawing.Point(6, 225);
            this.txtGrandTotal.MaxLength = 32767;
            this.txtGrandTotal.Name = "txtGrandTotal";
            this.txtGrandTotal.PasswordChar = '\0';
            this.txtGrandTotal.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtGrandTotal.SelectedText = "";
            this.txtGrandTotal.SelectionLength = 0;
            this.txtGrandTotal.SelectionStart = 0;
            this.txtGrandTotal.ShortcutsEnabled = true;
            this.txtGrandTotal.Size = new System.Drawing.Size(160, 30);
            this.txtGrandTotal.TabIndex = 5;
            this.txtGrandTotal.TabStop = false;
            this.txtGrandTotal.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtGrandTotal.UseSelectable = true;
            this.txtGrandTotal.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtGrandTotal.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Grand Total";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Discount";
            // 
            // txtDiscount
            // 
            // 
            // 
            // 
            this.txtDiscount.CustomButton.Image = null;
            this.txtDiscount.CustomButton.Location = new System.Drawing.Point(132, 2);
            this.txtDiscount.CustomButton.Name = "";
            this.txtDiscount.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtDiscount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDiscount.CustomButton.TabIndex = 1;
            this.txtDiscount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDiscount.CustomButton.UseSelectable = true;
            this.txtDiscount.CustomButton.Visible = false;
            this.txtDiscount.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtDiscount.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtDiscount.Lines = new string[0];
            this.txtDiscount.Location = new System.Drawing.Point(6, 288);
            this.txtDiscount.MaxLength = 32767;
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.PasswordChar = '\0';
            this.txtDiscount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDiscount.SelectedText = "";
            this.txtDiscount.SelectionLength = 0;
            this.txtDiscount.SelectionStart = 0;
            this.txtDiscount.ShortcutsEnabled = true;
            this.txtDiscount.Size = new System.Drawing.Size(160, 30);
            this.txtDiscount.TabIndex = 7;
            this.txtDiscount.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDiscount.UseSelectable = true;
            this.txtDiscount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDiscount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 330);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "Net";
            // 
            // txtNet
            // 
            // 
            // 
            // 
            this.txtNet.CustomButton.Image = null;
            this.txtNet.CustomButton.Location = new System.Drawing.Point(132, 2);
            this.txtNet.CustomButton.Name = "";
            this.txtNet.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtNet.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNet.CustomButton.TabIndex = 1;
            this.txtNet.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNet.CustomButton.UseSelectable = true;
            this.txtNet.CustomButton.Visible = false;
            this.txtNet.Enabled = false;
            this.txtNet.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtNet.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtNet.Lines = new string[0];
            this.txtNet.Location = new System.Drawing.Point(6, 352);
            this.txtNet.MaxLength = 32767;
            this.txtNet.Name = "txtNet";
            this.txtNet.PasswordChar = '\0';
            this.txtNet.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNet.SelectedText = "";
            this.txtNet.SelectionLength = 0;
            this.txtNet.SelectionStart = 0;
            this.txtNet.ShortcutsEnabled = true;
            this.txtNet.Size = new System.Drawing.Size(160, 30);
            this.txtNet.TabIndex = 9;
            this.txtNet.TabStop = false;
            this.txtNet.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNet.UseSelectable = true;
            this.txtNet.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNet.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 395);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 19);
            this.label6.TabIndex = 12;
            this.label6.Text = "Cash Tendered";
            // 
            // txtCash
            // 
            // 
            // 
            // 
            this.txtCash.CustomButton.Image = null;
            this.txtCash.CustomButton.Location = new System.Drawing.Point(132, 2);
            this.txtCash.CustomButton.Name = "";
            this.txtCash.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtCash.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCash.CustomButton.TabIndex = 1;
            this.txtCash.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCash.CustomButton.UseSelectable = true;
            this.txtCash.CustomButton.Visible = false;
            this.txtCash.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtCash.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtCash.Lines = new string[0];
            this.txtCash.Location = new System.Drawing.Point(6, 417);
            this.txtCash.MaxLength = 32767;
            this.txtCash.Name = "txtCash";
            this.txtCash.PasswordChar = '\0';
            this.txtCash.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCash.SelectedText = "";
            this.txtCash.SelectionLength = 0;
            this.txtCash.SelectionStart = 0;
            this.txtCash.ShortcutsEnabled = true;
            this.txtCash.Size = new System.Drawing.Size(160, 30);
            this.txtCash.TabIndex = 11;
            this.txtCash.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCash.UseSelectable = true;
            this.txtCash.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCash.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 463);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 19);
            this.label7.TabIndex = 14;
            this.label7.Text = "Balance (If Any)";
            // 
            // txtBalance
            // 
            // 
            // 
            // 
            this.txtBalance.CustomButton.Image = null;
            this.txtBalance.CustomButton.Location = new System.Drawing.Point(132, 2);
            this.txtBalance.CustomButton.Name = "";
            this.txtBalance.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtBalance.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBalance.CustomButton.TabIndex = 1;
            this.txtBalance.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBalance.CustomButton.UseSelectable = true;
            this.txtBalance.CustomButton.Visible = false;
            this.txtBalance.Enabled = false;
            this.txtBalance.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtBalance.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtBalance.Lines = new string[0];
            this.txtBalance.Location = new System.Drawing.Point(6, 485);
            this.txtBalance.MaxLength = 32767;
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.PasswordChar = '\0';
            this.txtBalance.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBalance.SelectedText = "";
            this.txtBalance.SelectionLength = 0;
            this.txtBalance.SelectionStart = 0;
            this.txtBalance.ShortcutsEnabled = true;
            this.txtBalance.Size = new System.Drawing.Size(160, 30);
            this.txtBalance.TabIndex = 13;
            this.txtBalance.TabStop = false;
            this.txtBalance.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBalance.UseSelectable = true;
            this.txtBalance.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBalance.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lbl_Select_Item
            // 
            this.lbl_Select_Item.AutoSize = true;
            this.lbl_Select_Item.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Select_Item.Location = new System.Drawing.Point(213, 14);
            this.lbl_Select_Item.Name = "lbl_Select_Item";
            this.lbl_Select_Item.Size = new System.Drawing.Size(85, 19);
            this.lbl_Select_Item.TabIndex = 16;
            this.lbl_Select_Item.Text = "Select Item";
            // 
            // dgv_SalesDet
            // 
            this.dgv_SalesDet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_SalesDet.Location = new System.Drawing.Point(230, 101);
            this.dgv_SalesDet.Name = "dgv_SalesDet";
            this.dgv_SalesDet.Size = new System.Drawing.Size(1024, 414);
            this.dgv_SalesDet.TabIndex = 17;
            // 
            // cbo_ProductName
            // 
            this.cbo_ProductName.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_ProductName.FormattingEnabled = true;
            this.cbo_ProductName.Location = new System.Drawing.Point(217, 36);
            this.cbo_ProductName.Name = "cbo_ProductName";
            this.cbo_ProductName.Size = new System.Drawing.Size(314, 31);
            this.cbo_ProductName.TabIndex = 18;
            // 
            // btn_AddProduct
            // 
            this.btn_AddProduct.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btn_AddProduct.ForeColor = System.Drawing.Color.Red;
            this.btn_AddProduct.Location = new System.Drawing.Point(677, 9);
            this.btn_AddProduct.Name = "btn_AddProduct";
            this.btn_AddProduct.Size = new System.Drawing.Size(91, 36);
            this.btn_AddProduct.TabIndex = 19;
            this.btn_AddProduct.Text = "Add Product";
            this.btn_AddProduct.UseSelectable = true;
            this.btn_AddProduct.Click += new System.EventHandler(this.btn_AddProduct_Click);
            // 
            // SaleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 538);
            this.Controls.Add(this.btn_AddProduct);
            this.Controls.Add(this.cbo_ProductName);
            this.Controls.Add(this.dgv_SalesDet);
            this.Controls.Add(this.lbl_Select_Item);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtBalance);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCash);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtGrandTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbo_Customer);
            this.Controls.Add(this.dt_InvoiceDate);
            this.Controls.Add(this.txtInvoiceNumber);
            this.Name = "SaleForm";
            this.Text = "SaleForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SaleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SalesDet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroTextBox txtInvoiceNumber;
        private MetroFramework.Controls.MetroDateTime dt_InvoiceDate;
        private System.Windows.Forms.ComboBox cbo_Customer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroTextBox txtGrandTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private MetroFramework.Controls.MetroTextBox txtDiscount;
        private System.Windows.Forms.Label label5;
        private MetroFramework.Controls.MetroTextBox txtNet;
        private System.Windows.Forms.Label label6;
        private MetroFramework.Controls.MetroTextBox txtCash;
        private System.Windows.Forms.Label label7;
        private MetroFramework.Controls.MetroTextBox txtBalance;
        private System.Windows.Forms.Label lbl_Select_Item;
        private System.Windows.Forms.DataGridView dgv_SalesDet;
        private System.Windows.Forms.ComboBox cbo_ProductName;
        private MetroFramework.Controls.MetroButton btn_AddProduct;
    }
}