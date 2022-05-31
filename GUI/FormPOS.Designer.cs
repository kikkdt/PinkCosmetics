namespace GUI
{
    partial class FormPOS
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPOS));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.TableLayout.ItemTemplateBase itemTemplateBase1 = new DevExpress.XtraEditors.TableLayout.ItemTemplateBase();
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition1 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition2 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TemplatedItemElement templatedItemElement1 = new DevExpress.XtraEditors.TableLayout.TemplatedItemElement();
            DevExpress.XtraEditors.TableLayout.TemplatedItemElement templatedItemElement2 = new DevExpress.XtraEditors.TableLayout.TemplatedItemElement();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition1 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.searchCustomer = new DevExpress.XtraEditors.SearchControl();
            this.listBoxCustomer = new DevExpress.XtraEditors.ListBoxControl();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelCartContainer = new System.Windows.Forms.Panel();
            this.panelRight = new DevExpress.XtraEditors.PanelControl();
            this.tablePanel2 = new DevExpress.Utils.Layout.TablePanel();
            this.cboxBangGia = new System.Windows.Forms.ComboBox();
            this.panelProducts = new System.Windows.Forms.FlowLayoutPanel();
            this.panelSearchCustomer = new System.Windows.Forms.Panel();
            this.searchControl1 = new DevExpress.XtraEditors.SearchControl();
            this.panelBtnPayout = new DevExpress.XtraEditors.PanelControl();
            this.btnPayout = new DevExpress.XtraEditors.SimpleButton();
            this.toolTipController1 = new DevExpress.Utils.ToolTipController(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchCustomer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxCustomer)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelRight)).BeginInit();
            this.panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel2)).BeginInit();
            this.tablePanel2.SuspendLayout();
            this.panelSearchCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelBtnPayout)).BeginInit();
            this.panelBtnPayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 60F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 40F)});
            this.tablePanel1.Controls.Add(this.tableLayoutPanel2);
            this.tablePanel1.Controls.Add(this.tableLayoutPanel1);
            this.tablePanel1.Controls.Add(this.panelRight);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(0, 0);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 60F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F)});
            this.tablePanel1.Size = new System.Drawing.Size(1262, 673);
            this.tablePanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tablePanel1.SetColumn(this.tableLayoutPanel2, 0);
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.searchCustomer, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.listBoxCustomer, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tablePanel1.SetRow(this.tableLayoutPanel2, 0);
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(751, 54);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // searchCustomer
            // 
            this.searchCustomer.Client = this.listBoxCustomer;
            this.searchCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchCustomer.Location = new System.Drawing.Point(3, 3);
            this.searchCustomer.Name = "searchCustomer";
            this.searchCustomer.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchCustomer.Properties.Appearance.Options.UseFont = true;
            editorButtonImageOptions2.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("editorButtonImageOptions2.SvgImage")));
            this.searchCustomer.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton("", -1, true, true, editorButtonImageOptions1, false, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "Xoá", null, null, true),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, serializableAppearanceObject5, "Thêm mới khách hàng", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.searchCustomer.Properties.Client = this.listBoxCustomer;
            this.searchCustomer.Properties.NullValuePrompt = "Tìm kiếm khách hàng";
            this.searchCustomer.Properties.Padding = new System.Windows.Forms.Padding(5);
            this.searchCustomer.Properties.ShowSearchButton = false;
            this.searchCustomer.Size = new System.Drawing.Size(369, 40);
            this.searchCustomer.TabIndex = 0;
            this.searchCustomer.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.SearchCustomer_ButtonClick);
            this.searchCustomer.TextChanged += new System.EventHandler(this.SearchCustomer_TextChanged);
            // 
            // listBoxCustomer
            // 
            this.listBoxCustomer.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxCustomer.Appearance.Options.UseFont = true;
            this.listBoxCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxCustomer.ItemAutoHeight = true;
            this.listBoxCustomer.ItemHeight = 120;
            this.listBoxCustomer.ItemPadding = new System.Windows.Forms.Padding(10);
            this.listBoxCustomer.Location = new System.Drawing.Point(378, 3);
            this.listBoxCustomer.Name = "listBoxCustomer";
            this.listBoxCustomer.Size = new System.Drawing.Size(370, 48);
            this.listBoxCustomer.TabIndex = 1;
            itemTemplateBase1.Columns.Add(tableColumnDefinition1);
            itemTemplateBase1.Columns.Add(tableColumnDefinition2);
            templatedItemElement1.Appearance.Normal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            templatedItemElement1.Appearance.Normal.Options.UseFont = true;
            templatedItemElement1.FieldName = "HoTen";
            templatedItemElement1.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            templatedItemElement1.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            templatedItemElement1.Name = "HoTen";
            templatedItemElement1.Text = "HoTen";
            templatedItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            templatedItemElement2.Appearance.Normal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            templatedItemElement2.Appearance.Normal.Options.UseFont = true;
            templatedItemElement2.ColumnIndex = 1;
            templatedItemElement2.FieldName = "DienThoai";
            templatedItemElement2.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            templatedItemElement2.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            templatedItemElement2.Name = "DienThoai";
            templatedItemElement2.Text = "DienThoai";
            templatedItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            itemTemplateBase1.Elements.Add(templatedItemElement1);
            itemTemplateBase1.Elements.Add(templatedItemElement2);
            itemTemplateBase1.Name = "template1";
            tableRowDefinition1.AutoHeight = true;
            itemTemplateBase1.Rows.Add(tableRowDefinition1);
            this.listBoxCustomer.Templates.Add(itemTemplateBase1);
            this.listBoxCustomer.Visible = false;
            this.listBoxCustomer.SelectedIndexChanged += new System.EventHandler(this.ListBoxCustomer_SelectedIndexChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tablePanel1.SetColumn(this.tableLayoutPanel1, 0);
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panelCartContainer, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 63);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tablePanel1.SetRow(this.tableLayoutPanel1, 1);
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(751, 607);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panelCartContainer
            // 
            this.panelCartContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCartContainer.Location = new System.Drawing.Point(3, 3);
            this.panelCartContainer.Name = "panelCartContainer";
            this.tableLayoutPanel1.SetRowSpan(this.panelCartContainer, 2);
            this.panelCartContainer.Size = new System.Drawing.Size(745, 601);
            this.panelCartContainer.TabIndex = 0;
            // 
            // panelRight
            // 
            this.panelRight.Appearance.BackColor = System.Drawing.Color.White;
            this.panelRight.Appearance.Options.UseBackColor = true;
            this.panelRight.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.tablePanel1.SetColumn(this.panelRight, 1);
            this.panelRight.Controls.Add(this.tablePanel2);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Location = new System.Drawing.Point(760, 63);
            this.panelRight.Name = "panelRight";
            this.tablePanel1.SetRow(this.panelRight, 1);
            this.panelRight.Size = new System.Drawing.Size(499, 607);
            this.panelRight.TabIndex = 0;
            // 
            // tablePanel2
            // 
            this.tablePanel2.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)});
            this.tablePanel2.Controls.Add(this.cboxBangGia);
            this.tablePanel2.Controls.Add(this.panelProducts);
            this.tablePanel2.Controls.Add(this.panelSearchCustomer);
            this.tablePanel2.Controls.Add(this.panelBtnPayout);
            this.tablePanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel2.Location = new System.Drawing.Point(0, 0);
            this.tablePanel2.Name = "tablePanel2";
            this.tablePanel2.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 60F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 60F)});
            this.tablePanel2.Size = new System.Drawing.Size(499, 607);
            this.tablePanel2.TabIndex = 0;
            // 
            // cboxBangGia
            // 
            this.tablePanel2.SetColumn(this.cboxBangGia, 1);
            this.cboxBangGia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboxBangGia.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxBangGia.FormattingEnabled = true;
            this.cboxBangGia.Location = new System.Drawing.Point(253, 3);
            this.cboxBangGia.Name = "cboxBangGia";
            this.tablePanel2.SetRow(this.cboxBangGia, 0);
            this.cboxBangGia.Size = new System.Drawing.Size(244, 36);
            this.cboxBangGia.TabIndex = 4;
            // 
            // panelProducts
            // 
            this.panelProducts.AutoScroll = true;
            this.tablePanel2.SetColumn(this.panelProducts, 0);
            this.tablePanel2.SetColumnSpan(this.panelProducts, 2);
            this.panelProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelProducts.Location = new System.Drawing.Point(3, 63);
            this.panelProducts.Name = "panelProducts";
            this.tablePanel2.SetRow(this.panelProducts, 1);
            this.panelProducts.Size = new System.Drawing.Size(494, 481);
            this.panelProducts.TabIndex = 3;
            // 
            // panelSearchCustomer
            // 
            this.tablePanel2.SetColumn(this.panelSearchCustomer, 0);
            this.panelSearchCustomer.Controls.Add(this.searchControl1);
            this.panelSearchCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSearchCustomer.Location = new System.Drawing.Point(3, 3);
            this.panelSearchCustomer.Name = "panelSearchCustomer";
            this.tablePanel2.SetRow(this.panelSearchCustomer, 0);
            this.panelSearchCustomer.Size = new System.Drawing.Size(244, 54);
            this.panelSearchCustomer.TabIndex = 2;
            // 
            // searchControl1
            // 
            this.searchControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchControl1.Location = new System.Drawing.Point(0, 0);
            this.searchControl1.Name = "searchControl1";
            this.searchControl1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchControl1.Properties.Appearance.Options.UseFont = true;
            this.searchControl1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.searchControl1.Size = new System.Drawing.Size(244, 34);
            this.searchControl1.TabIndex = 0;
            // 
            // panelBtnPayout
            // 
            this.panelBtnPayout.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.tablePanel2.SetColumn(this.panelBtnPayout, 0);
            this.tablePanel2.SetColumnSpan(this.panelBtnPayout, 2);
            this.panelBtnPayout.Controls.Add(this.btnPayout);
            this.panelBtnPayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBtnPayout.Location = new System.Drawing.Point(3, 550);
            this.panelBtnPayout.Name = "panelBtnPayout";
            this.tablePanel2.SetRow(this.panelBtnPayout, 2);
            this.panelBtnPayout.Size = new System.Drawing.Size(494, 54);
            this.panelBtnPayout.TabIndex = 0;
            // 
            // btnPayout
            // 
            this.btnPayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPayout.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayout.Appearance.Options.UseFont = true;
            this.btnPayout.Location = new System.Drawing.Point(147, 0);
            this.btnPayout.Name = "btnPayout";
            this.btnPayout.Size = new System.Drawing.Size(200, 54);
            this.btnPayout.TabIndex = 0;
            this.btnPayout.Text = "THANH TOÁN";
            this.btnPayout.Click += new System.EventHandler(this.BtnPayout_Click);
            // 
            // FormPOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.tablePanel1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormPOS";
            this.Text = "FormPOS";
            this.Resize += new System.EventHandler(this.FormPOS_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchCustomer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxCustomer)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelRight)).EndInit();
            this.panelRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel2)).EndInit();
            this.tablePanel2.ResumeLayout(false);
            this.panelSearchCustomer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelBtnPayout)).EndInit();
            this.panelBtnPayout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.XtraEditors.PanelControl panelRight;
        private DevExpress.Utils.Layout.TablePanel tablePanel2;
        private System.Windows.Forms.Panel panelSearchCustomer;
        private DevExpress.XtraEditors.SearchControl searchControl1;
        private DevExpress.XtraEditors.PanelControl panelBtnPayout;
        private DevExpress.XtraEditors.SimpleButton btnPayout;
        private System.Windows.Forms.FlowLayoutPanel panelProducts;
        private DevExpress.Utils.ToolTipController toolTipController1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox cboxBangGia;
        private System.Windows.Forms.Panel panelCartContainer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevExpress.XtraEditors.SearchControl searchCustomer;
        private DevExpress.XtraEditors.ListBoxControl listBoxCustomer;
    }
}