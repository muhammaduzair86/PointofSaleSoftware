
namespace PointofSaleSoftware
{
    partial class POS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(POS));
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipItem toolTipItem1 = new DevExpress.Utils.ToolTipItem();
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btn_RibbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btn_RibbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpg_Purchases = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpg_Sales = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btn_RibbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpg_Customers = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpg_Suppliers = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbg_Products = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 3;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.btn_RibbonPage1,
            this.btn_RibbonPage2,
            this.btn_RibbonPage3});
            this.ribbon.Size = new System.Drawing.Size(876, 158);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // btn_RibbonPage1
            // 
            this.btn_RibbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3});
            this.btn_RibbonPage1.Name = "btn_RibbonPage1";
            this.btn_RibbonPage1.Text = "Parameters";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPageGroup1.ImageOptions.Image")));
            this.ribbonPageGroup1.ItemsLayout = DevExpress.XtraBars.Ribbon.RibbonPageGroupItemsLayout.OneRow;
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.State = DevExpress.XtraBars.Ribbon.RibbonPageGroupState.Expanded;
            this.ribbonPageGroup1.Text = "Customers";
            this.ribbonPageGroup1.CaptionButtonClick += new DevExpress.XtraBars.Ribbon.RibbonPageGroupEventHandler(this.ribbonPageGroup1_CaptionButtonClick);
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPageGroup2.ImageOptions.Image")));
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Suppliers";
            this.ribbonPageGroup2.CaptionButtonClick += new DevExpress.XtraBars.Ribbon.RibbonPageGroupEventHandler(this.ribbonPageGroup2_CaptionButtonClick);
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPageGroup3.ImageOptions.Image")));
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Products";
            this.ribbonPageGroup3.CaptionButtonClick += new DevExpress.XtraBars.Ribbon.RibbonPageGroupEventHandler(this.ribbonPageGroup3_CaptionButtonClick);
            // 
            // btn_RibbonPage2
            // 
            this.btn_RibbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpg_Purchases,
            this.rpg_Sales});
            this.btn_RibbonPage2.Name = "btn_RibbonPage2";
            this.btn_RibbonPage2.Text = "Transactions";
            // 
            // rpg_Purchases
            // 
            this.rpg_Purchases.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("rpg_Purchases.ImageOptions.Image")));
            this.rpg_Purchases.ImageOptions.ImageIndex = 0;
            this.rpg_Purchases.ImageOptions.SvgImageSize = new System.Drawing.Size(2, 2);
            this.rpg_Purchases.Name = "rpg_Purchases";
            toolTipItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            superToolTip1.Items.Add(toolTipItem1);
            this.rpg_Purchases.SuperTip = superToolTip1;
            this.rpg_Purchases.Text = "Purchases";
            this.rpg_Purchases.CaptionButtonClick += new DevExpress.XtraBars.Ribbon.RibbonPageGroupEventHandler(this.rpg_Purchases_CaptionButtonClick);
            // 
            // rpg_Sales
            // 
            this.rpg_Sales.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("rpg_Sales.ImageOptions.Image")));
            this.rpg_Sales.Name = "rpg_Sales";
            this.rpg_Sales.Text = "Sales";
            // 
            // btn_RibbonPage3
            // 
            this.btn_RibbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpg_Customers,
            this.rpg_Suppliers,
            this.rbg_Products});
            this.btn_RibbonPage3.Name = "btn_RibbonPage3";
            this.btn_RibbonPage3.Text = "Reports";
            // 
            // rpg_Customers
            // 
            this.rpg_Customers.Name = "rpg_Customers";
            this.rpg_Customers.Text = "Customers";
            // 
            // rpg_Suppliers
            // 
            this.rpg_Suppliers.Name = "rpg_Suppliers";
            this.rpg_Suppliers.Text = "Suppliers";
            // 
            // rbg_Products
            // 
            this.rbg_Products.Name = "rbg_Products";
            this.rbg_Products.Text = "Products";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 425);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(876, 24);
            // 
            // POS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 449);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("POS.IconOptions.SvgImage")));
            this.Name = "POS";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Point of Sale Software";
            this.Load += new System.EventHandler(this.POS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage btn_RibbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPage btn_RibbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpg_Purchases;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpg_Sales;
        private DevExpress.XtraBars.Ribbon.RibbonPage btn_RibbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpg_Customers;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpg_Suppliers;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbg_Products;
    }
}