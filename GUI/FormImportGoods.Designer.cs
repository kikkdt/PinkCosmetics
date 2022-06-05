namespace GUI
{
    partial class FormImportGoods
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.TenSP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaPhieuDat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.STT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaSanPham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoLuongDat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemSpinEditSoLuongDat = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.SoLuongNhap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemSpinEditSoLuongNhap = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.GiaNhap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemSpinEditGiaNhap = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.ThanhTien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnDone = new DevExpress.XtraEditors.SimpleButton();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEditSoLuongDat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEditSoLuongNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEditGiaNhap)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.gridControl, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1278, 680);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // gridControl
            // 
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(1);
            this.gridControl.Location = new System.Drawing.Point(5, 4);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gridControl.Name = "gridControl";
            this.gridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemSpinEditSoLuongDat,
            this.repositoryItemSpinEditGiaNhap,
            this.repositoryItemSpinEditSoLuongNhap});
            this.gridControl.Size = new System.Drawing.Size(1268, 602);
            this.gridControl.TabIndex = 3;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.AutoFillColumn = this.TenSP;
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaPhieuDat,
            this.STT,
            this.MaSanPham,
            this.TenSP,
            this.SoLuongDat,
            this.SoLuongNhap,
            this.GiaNhap,
            this.ThanhTien});
            this.gridView.DetailHeight = 525;
            this.gridView.GridControl = this.gridControl;
            this.gridView.GroupPanelText = " ";
            this.gridView.Name = "gridView";
            this.gridView.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.gridView.RowHeight = 52;
            this.gridView.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.GridView_CellValueChanged);
            this.gridView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.GridView_CustomColumnDisplayText);
            // 
            // TenSP
            // 
            this.TenSP.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenSP.AppearanceCell.Options.UseFont = true;
            this.TenSP.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenSP.AppearanceHeader.Options.UseFont = true;
            this.TenSP.Caption = "Tên sản phẩm";
            this.TenSP.FieldName = "TenSP";
            this.TenSP.MinWidth = 300;
            this.TenSP.Name = "TenSP";
            this.TenSP.OptionsColumn.AllowEdit = false;
            this.TenSP.Visible = true;
            this.TenSP.VisibleIndex = 2;
            this.TenSP.Width = 385;
            // 
            // MaPhieuDat
            // 
            this.MaPhieuDat.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaPhieuDat.AppearanceCell.Options.UseFont = true;
            this.MaPhieuDat.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaPhieuDat.AppearanceHeader.Options.UseFont = true;
            this.MaPhieuDat.Caption = "Mã phiếu đặt";
            this.MaPhieuDat.FieldName = "MaPhieuDat";
            this.MaPhieuDat.MinWidth = 39;
            this.MaPhieuDat.Name = "MaPhieuDat";
            this.MaPhieuDat.Width = 148;
            // 
            // STT
            // 
            this.STT.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STT.AppearanceCell.Options.UseFont = true;
            this.STT.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STT.AppearanceHeader.Options.UseFont = true;
            this.STT.Caption = "STT";
            this.STT.FieldName = "STT";
            this.STT.MaxWidth = 130;
            this.STT.MinWidth = 130;
            this.STT.Name = "STT";
            this.STT.OptionsColumn.AllowEdit = false;
            this.STT.Visible = true;
            this.STT.VisibleIndex = 0;
            this.STT.Width = 130;
            // 
            // MaSanPham
            // 
            this.MaSanPham.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaSanPham.AppearanceCell.Options.UseFont = true;
            this.MaSanPham.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaSanPham.AppearanceHeader.Options.UseFont = true;
            this.MaSanPham.Caption = "Mã sản phẩm";
            this.MaSanPham.FieldName = "MaSanPham";
            this.MaSanPham.MaxWidth = 250;
            this.MaSanPham.MinWidth = 250;
            this.MaSanPham.Name = "MaSanPham";
            this.MaSanPham.OptionsColumn.AllowEdit = false;
            this.MaSanPham.Visible = true;
            this.MaSanPham.VisibleIndex = 1;
            this.MaSanPham.Width = 250;
            // 
            // SoLuongDat
            // 
            this.SoLuongDat.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoLuongDat.AppearanceCell.Options.UseFont = true;
            this.SoLuongDat.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoLuongDat.AppearanceHeader.Options.UseFont = true;
            this.SoLuongDat.Caption = "Số lượng đặt";
            this.SoLuongDat.ColumnEdit = this.repositoryItemSpinEditSoLuongDat;
            this.SoLuongDat.FieldName = "SoLuongDat";
            this.SoLuongDat.MaxWidth = 150;
            this.SoLuongDat.MinWidth = 150;
            this.SoLuongDat.Name = "SoLuongDat";
            this.SoLuongDat.OptionsColumn.AllowEdit = false;
            this.SoLuongDat.Visible = true;
            this.SoLuongDat.VisibleIndex = 3;
            this.SoLuongDat.Width = 150;
            // 
            // repositoryItemSpinEditSoLuongDat
            // 
            this.repositoryItemSpinEditSoLuongDat.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repositoryItemSpinEditSoLuongDat.Appearance.Options.UseFont = true;
            this.repositoryItemSpinEditSoLuongDat.AutoHeight = false;
            this.repositoryItemSpinEditSoLuongDat.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSpinEditSoLuongDat.IsFloatValue = false;
            this.repositoryItemSpinEditSoLuongDat.MaskSettings.Set("mask", "N00");
            this.repositoryItemSpinEditSoLuongDat.MaxValue = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.repositoryItemSpinEditSoLuongDat.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.repositoryItemSpinEditSoLuongDat.Name = "repositoryItemSpinEditSoLuongDat";
            this.repositoryItemSpinEditSoLuongDat.NullText = "Chưa nhập số lượng đặt";
            this.repositoryItemSpinEditSoLuongDat.NullValuePrompt = "Chưa nhập số lượng đặt";
            // 
            // SoLuongNhap
            // 
            this.SoLuongNhap.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoLuongNhap.AppearanceCell.Options.UseFont = true;
            this.SoLuongNhap.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoLuongNhap.AppearanceHeader.Options.UseFont = true;
            this.SoLuongNhap.Caption = "Số lượng nhập";
            this.SoLuongNhap.ColumnEdit = this.repositoryItemSpinEditSoLuongNhap;
            this.SoLuongNhap.FieldName = "SoLuongNhap";
            this.SoLuongNhap.MaxWidth = 150;
            this.SoLuongNhap.MinWidth = 150;
            this.SoLuongNhap.Name = "SoLuongNhap";
            this.SoLuongNhap.Visible = true;
            this.SoLuongNhap.VisibleIndex = 4;
            this.SoLuongNhap.Width = 150;
            // 
            // repositoryItemSpinEditSoLuongNhap
            // 
            this.repositoryItemSpinEditSoLuongNhap.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repositoryItemSpinEditSoLuongNhap.Appearance.Options.UseFont = true;
            this.repositoryItemSpinEditSoLuongNhap.AutoHeight = false;
            this.repositoryItemSpinEditSoLuongNhap.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSpinEditSoLuongNhap.IsFloatValue = false;
            this.repositoryItemSpinEditSoLuongNhap.MaskSettings.Set("mask", "N00");
            this.repositoryItemSpinEditSoLuongNhap.MaxValue = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.repositoryItemSpinEditSoLuongNhap.Name = "repositoryItemSpinEditSoLuongNhap";
            // 
            // GiaNhap
            // 
            this.GiaNhap.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GiaNhap.AppearanceCell.Options.UseFont = true;
            this.GiaNhap.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GiaNhap.AppearanceHeader.Options.UseFont = true;
            this.GiaNhap.Caption = "Đơn giá nhập";
            this.GiaNhap.ColumnEdit = this.repositoryItemSpinEditGiaNhap;
            this.GiaNhap.FieldName = "GiaNhap";
            this.GiaNhap.MinWidth = 300;
            this.GiaNhap.Name = "GiaNhap";
            this.GiaNhap.Visible = true;
            this.GiaNhap.VisibleIndex = 5;
            this.GiaNhap.Width = 300;
            // 
            // repositoryItemSpinEditGiaNhap
            // 
            this.repositoryItemSpinEditGiaNhap.AutoHeight = false;
            this.repositoryItemSpinEditGiaNhap.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSpinEditGiaNhap.IsFloatValue = false;
            this.repositoryItemSpinEditGiaNhap.MaskSettings.Set("mask", "c");
            this.repositoryItemSpinEditGiaNhap.Name = "repositoryItemSpinEditGiaNhap";
            // 
            // ThanhTien
            // 
            this.ThanhTien.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThanhTien.AppearanceCell.Options.UseFont = true;
            this.ThanhTien.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThanhTien.AppearanceHeader.Options.UseFont = true;
            this.ThanhTien.Caption = "Thành tiền";
            this.ThanhTien.FieldName = "ThanhTien";
            this.ThanhTien.MinWidth = 300;
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.OptionsColumn.AllowEdit = false;
            this.ThanhTien.Visible = true;
            this.ThanhTien.VisibleIndex = 6;
            this.ThanhTien.Width = 300;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel2.Controls.Add(this.btnSave, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnDone, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 613);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1272, 64);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // btnSave
            // 
            this.btnSave.Appearance.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSave.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Appearance.Options.UseBackColor = true;
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSave.Location = new System.Drawing.Point(877, 5);
            this.btnSave.Margin = new System.Windows.Forms.Padding(5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(190, 54);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Lưu";
            this.btnSave.ToolTip = "Lưu";
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnDone
            // 
            this.btnDone.Appearance.BackColor = System.Drawing.Color.ForestGreen;
            this.btnDone.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDone.Appearance.Options.UseBackColor = true;
            this.btnDone.Appearance.Options.UseFont = true;
            this.btnDone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDone.Location = new System.Drawing.Point(1077, 5);
            this.btnDone.Margin = new System.Windows.Forms.Padding(5);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(190, 54);
            this.btnDone.TabIndex = 3;
            this.btnDone.Text = "Hoàn thành";
            this.btnDone.ToolTip = "Lưu & Hoàn thành";
            this.btnDone.Click += new System.EventHandler(this.BtnDone_Click);
            // 
            // FormImportGoods
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 680);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormImportGoods";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập hàng";
            this.Load += new System.EventHandler(this.FormImportGoods_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEditSoLuongDat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEditSoLuongNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEditGiaNhap)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn TenSP;
        private DevExpress.XtraGrid.Columns.GridColumn MaPhieuDat;
        private DevExpress.XtraGrid.Columns.GridColumn STT;
        private DevExpress.XtraGrid.Columns.GridColumn MaSanPham;
        private DevExpress.XtraGrid.Columns.GridColumn SoLuongDat;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEditSoLuongDat;
        private DevExpress.XtraGrid.Columns.GridColumn SoLuongNhap;
        private DevExpress.XtraGrid.Columns.GridColumn GiaNhap;
        private DevExpress.XtraGrid.Columns.GridColumn ThanhTien;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEditGiaNhap;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnDone;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEditSoLuongNhap;
    }
}