namespace GUI
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnPOS = new DevExpress.XtraBars.BarButtonItem();
            this.btnGoods = new DevExpress.XtraBars.BarButtonItem();
            this.btnPriceSetting = new DevExpress.XtraBars.BarButtonItem();
            this.btnInventory = new DevExpress.XtraBars.BarButtonItem();
            this.btnGroupOfGoods = new DevExpress.XtraBars.BarButtonItem();
            this.btnAddGroupOfGoods = new DevExpress.XtraBars.BarButtonItem();
            this.btnBrand = new DevExpress.XtraBars.BarButtonItem();
            this.btnAddBrand = new DevExpress.XtraBars.BarButtonItem();
            this.btnInvoice = new DevExpress.XtraBars.BarButtonItem();
            this.btnImportGoods = new DevExpress.XtraBars.BarButtonItem();
            this.btnChangePassword = new DevExpress.XtraBars.BarButtonItem();
            this.btnLogOut = new DevExpress.XtraBars.BarButtonItem();
            this.btnOrder = new DevExpress.XtraBars.BarButtonItem();
            this.btnListOfOrders = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonSell = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonSellGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonGoods = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonGoodsGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonGroupOfGoods = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonBrandGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonTransaction = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonAccount = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ColorScheme = DevExpress.XtraBars.Ribbon.RibbonControlColorScheme.Teal;
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.btnPOS,
            this.btnGoods,
            this.btnPriceSetting,
            this.btnInventory,
            this.btnGroupOfGoods,
            this.btnAddGroupOfGoods,
            this.btnBrand,
            this.btnAddBrand,
            this.btnInvoice,
            this.btnImportGoods,
            this.btnChangePassword,
            this.btnLogOut,
            this.btnOrder,
            this.btnListOfOrders});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 26;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonSell,
            this.ribbonGoods,
            this.ribbonTransaction,
            this.ribbonAccount});
            this.ribbonControl1.Size = new System.Drawing.Size(1262, 183);
            // 
            // btnPOS
            // 
            this.btnPOS.Caption = "POS";
            this.btnPOS.Description = "POS";
            this.btnPOS.Id = 1;
            this.btnPOS.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPOS.ImageOptions.SvgImage")));
            this.btnPOS.LargeWidth = 100;
            this.btnPOS.Name = "btnPOS";
            this.btnPOS.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnPOS.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnPOS_ItemClick);
            // 
            // btnGoods
            // 
            this.btnGoods.Caption = "Hàng hoá";
            this.btnGoods.Id = 9;
            this.btnGoods.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnGoods.ImageOptions.SvgImage")));
            this.btnGoods.Name = "btnGoods";
            this.btnGoods.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btnPriceSetting
            // 
            this.btnPriceSetting.Caption = "Thiết lập giá";
            this.btnPriceSetting.Id = 10;
            this.btnPriceSetting.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPriceSetting.ImageOptions.SvgImage")));
            this.btnPriceSetting.Name = "btnPriceSetting";
            this.btnPriceSetting.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            // 
            // btnInventory
            // 
            this.btnInventory.Caption = "Kiểm kho";
            this.btnInventory.Id = 11;
            this.btnInventory.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnInventory.ImageOptions.SvgImage")));
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            // 
            // btnGroupOfGoods
            // 
            this.btnGroupOfGoods.Caption = "Nhóm hàng";
            this.btnGroupOfGoods.Id = 12;
            this.btnGroupOfGoods.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnGroupOfGoods.ImageOptions.SvgImage")));
            this.btnGroupOfGoods.Name = "btnGroupOfGoods";
            // 
            // btnAddGroupOfGoods
            // 
            this.btnAddGroupOfGoods.Caption = "Thêm Nhóm hàng";
            this.btnAddGroupOfGoods.Id = 13;
            this.btnAddGroupOfGoods.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnAddGroupOfGoods.ImageOptions.SvgImage")));
            this.btnAddGroupOfGoods.Name = "btnAddGroupOfGoods";
            // 
            // btnBrand
            // 
            this.btnBrand.Caption = "Thương hiệu";
            this.btnBrand.Id = 14;
            this.btnBrand.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnBrand.ImageOptions.SvgImage")));
            this.btnBrand.Name = "btnBrand";
            // 
            // btnAddBrand
            // 
            this.btnAddBrand.Caption = "Thêm Thương hiệu";
            this.btnAddBrand.Id = 15;
            this.btnAddBrand.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnAddBrand.ImageOptions.SvgImage")));
            this.btnAddBrand.Name = "btnAddBrand";
            // 
            // btnInvoice
            // 
            this.btnInvoice.Caption = "Hoá đơn";
            this.btnInvoice.Id = 16;
            this.btnInvoice.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnInvoice.ImageOptions.SvgImage")));
            this.btnInvoice.LargeWidth = 100;
            this.btnInvoice.Name = "btnInvoice";
            this.btnInvoice.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btnImportGoods
            // 
            this.btnImportGoods.Caption = "Nhập hàng";
            this.btnImportGoods.Id = 21;
            this.btnImportGoods.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnImportGoods.ImageOptions.SvgImage")));
            this.btnImportGoods.LargeWidth = 100;
            this.btnImportGoods.Name = "btnImportGoods";
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Caption = "Đổi mật khẩu";
            this.btnChangePassword.Id = 22;
            this.btnChangePassword.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnChangePassword.ImageOptions.SvgImage")));
            this.btnChangePassword.LargeWidth = 100;
            this.btnChangePassword.Name = "btnChangePassword";
            // 
            // btnLogOut
            // 
            this.btnLogOut.Caption = "Đăng xuất";
            this.btnLogOut.Id = 23;
            this.btnLogOut.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnLogOut.ImageOptions.SvgImage")));
            this.btnLogOut.LargeWidth = 100;
            this.btnLogOut.Name = "btnLogOut";
            // 
            // btnOrder
            // 
            this.btnOrder.Caption = "Tạo phiếu đặt hàng";
            this.btnOrder.Id = 24;
            this.btnOrder.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnOrder.ImageOptions.SvgImage")));
            this.btnOrder.LargeWidth = 100;
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnOrder_ItemClick);
            // 
            // btnListOfOrders
            // 
            this.btnListOfOrders.Caption = "Danh sách đặt hàng";
            this.btnListOfOrders.Id = 25;
            this.btnListOfOrders.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnListOfOrders.ImageOptions.SvgImage")));
            this.btnListOfOrders.LargeWidth = 100;
            this.btnListOfOrders.Name = "btnListOfOrders";
            this.btnListOfOrders.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnListOfOrders_ItemClick);
            // 
            // ribbonSell
            // 
            this.ribbonSell.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonSellGroup});
            this.ribbonSell.Name = "ribbonSell";
            this.ribbonSell.Text = "Bán hàng";
            // 
            // ribbonSellGroup
            // 
            this.ribbonSellGroup.AllowTextClipping = false;
            this.ribbonSellGroup.ItemLinks.Add(this.btnPOS);
            this.ribbonSellGroup.Name = "ribbonSellGroup";
            // 
            // ribbonGoods
            // 
            this.ribbonGoods.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonGoodsGroup,
            this.ribbonGroupOfGoods,
            this.ribbonBrandGroup});
            this.ribbonGoods.Name = "ribbonGoods";
            this.ribbonGoods.Text = "Hàng hoá";
            // 
            // ribbonGoodsGroup
            // 
            this.ribbonGoodsGroup.ItemLinks.Add(this.btnGoods);
            this.ribbonGoodsGroup.ItemLinks.Add(this.btnPriceSetting);
            this.ribbonGoodsGroup.ItemLinks.Add(this.btnInventory);
            this.ribbonGoodsGroup.Name = "ribbonGoodsGroup";
            this.ribbonGoodsGroup.Text = "Hàng hoá";
            // 
            // ribbonGroupOfGoods
            // 
            this.ribbonGroupOfGoods.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ribbonGroupOfGoods.ImageOptions.SvgImage")));
            this.ribbonGroupOfGoods.ItemLinks.Add(this.btnGroupOfGoods);
            this.ribbonGroupOfGoods.ItemLinks.Add(this.btnAddGroupOfGoods);
            this.ribbonGroupOfGoods.Name = "ribbonGroupOfGoods";
            this.ribbonGroupOfGoods.Text = "Nhóm hàng";
            // 
            // ribbonBrandGroup
            // 
            this.ribbonBrandGroup.ItemLinks.Add(this.btnBrand);
            this.ribbonBrandGroup.ItemLinks.Add(this.btnAddBrand);
            this.ribbonBrandGroup.Name = "ribbonBrandGroup";
            this.ribbonBrandGroup.Text = "Thương hiệu";
            // 
            // ribbonTransaction
            // 
            this.ribbonTransaction.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup5});
            this.ribbonTransaction.Name = "ribbonTransaction";
            this.ribbonTransaction.Text = "Giao dịch";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnInvoice);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.btnOrder);
            this.ribbonPageGroup5.ItemLinks.Add(this.btnListOfOrders);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "Đặt && Nhập hàng";
            // 
            // ribbonAccount
            // 
            this.ribbonAccount.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3,
            this.ribbonPageGroup4});
            this.ribbonAccount.Name = "ribbonAccount";
            this.ribbonAccount.Text = "Tài khoản";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnChangePassword);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnLogOut);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InAllTabPageHeaders;
            this.xtraTabbedMdiManager1.HeaderButtons = DevExpress.XtraTab.TabButtons.Close;
            this.xtraTabbedMdiManager1.HeaderButtonsShowMode = DevExpress.XtraTab.TabButtonShowMode.Always;
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // FormMain
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.ribbonControl1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("FormMain.IconOptions.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pink Cosmetics";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonSell;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonSellGroup;
        public DevExpress.XtraBars.BarButtonItem btnPOS;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonGoods;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonGoodsGroup;
        private DevExpress.XtraBars.BarButtonItem btnGoods;
        private DevExpress.XtraBars.BarButtonItem btnPriceSetting;
        private DevExpress.XtraBars.BarButtonItem btnInventory;
        private DevExpress.XtraBars.BarButtonItem btnGroupOfGoods;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonGroupOfGoods;
        private DevExpress.XtraBars.BarButtonItem btnAddGroupOfGoods;
        private DevExpress.XtraBars.BarButtonItem btnBrand;
        private DevExpress.XtraBars.BarButtonItem btnAddBrand;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonBrandGroup;
        private DevExpress.XtraBars.BarButtonItem btnInvoice;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonTransaction;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnImportGoods;
        private DevExpress.XtraBars.BarButtonItem btnChangePassword;
        private DevExpress.XtraBars.BarButtonItem btnLogOut;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonAccount;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem btnOrder;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        public DevExpress.XtraBars.BarButtonItem btnListOfOrders;
    }
}