namespace GUI
{
    partial class FormListOfInvoices
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormListOfInvoices));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.STT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaHDBan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HoTenKhachHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HoTenNhanVien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ThanhTien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayLap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TrangThai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.Action = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl
            // 
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(1);
            this.gridControl.Location = new System.Drawing.Point(0, 0);
            this.gridControl.MainView = this.gridView1;
            this.gridControl.Name = "gridControl";
            this.gridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEdit1,
            this.repositoryItemTextEdit1});
            this.gridControl.Size = new System.Drawing.Size(1278, 680);
            this.gridControl.TabIndex = 1;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.STT,
            this.MaHDBan,
            this.HoTenKhachHang,
            this.HoTenNhanVien,
            this.ThanhTien,
            this.NgayLap,
            this.TrangThai,
            this.Action});
            this.gridView1.GridControl = this.gridControl;
            this.gridView1.GroupPanelText = " ";
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.FindNullPrompt = "Nhập để tìm kiếm hoá đơn";
            this.gridView1.OptionsFind.FindPanelLocation = DevExpress.XtraGrid.Views.Grid.GridFindPanelLocation.GroupPanel;
            this.gridView1.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.RowHeight = 50;
            this.gridView1.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.GridView_CustomColumnDisplayText);
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
            // MaHDBan
            // 
            this.MaHDBan.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaHDBan.AppearanceCell.Options.UseFont = true;
            this.MaHDBan.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaHDBan.AppearanceHeader.Options.UseFont = true;
            this.MaHDBan.Caption = "Mã hoá đơn";
            this.MaHDBan.FieldName = "MaHDBan";
            this.MaHDBan.MaxWidth = 300;
            this.MaHDBan.MinWidth = 300;
            this.MaHDBan.Name = "MaHDBan";
            this.MaHDBan.OptionsColumn.AllowEdit = false;
            this.MaHDBan.Visible = true;
            this.MaHDBan.VisibleIndex = 1;
            this.MaHDBan.Width = 300;
            // 
            // HoTenKhachHang
            // 
            this.HoTenKhachHang.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoTenKhachHang.AppearanceCell.Options.UseFont = true;
            this.HoTenKhachHang.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoTenKhachHang.AppearanceHeader.Options.UseFont = true;
            this.HoTenKhachHang.Caption = "Khách hàng";
            this.HoTenKhachHang.FieldName = "HoTenKhachHang";
            this.HoTenKhachHang.MinWidth = 300;
            this.HoTenKhachHang.Name = "HoTenKhachHang";
            this.HoTenKhachHang.OptionsColumn.AllowEdit = false;
            this.HoTenKhachHang.Visible = true;
            this.HoTenKhachHang.VisibleIndex = 2;
            this.HoTenKhachHang.Width = 300;
            // 
            // HoTenNhanVien
            // 
            this.HoTenNhanVien.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoTenNhanVien.AppearanceCell.Options.UseFont = true;
            this.HoTenNhanVien.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoTenNhanVien.AppearanceHeader.Options.UseFont = true;
            this.HoTenNhanVien.Caption = "Nhân viên";
            this.HoTenNhanVien.FieldName = "HoTenNhanVien";
            this.HoTenNhanVien.MinWidth = 300;
            this.HoTenNhanVien.Name = "HoTenNhanVien";
            this.HoTenNhanVien.OptionsColumn.AllowEdit = false;
            this.HoTenNhanVien.Visible = true;
            this.HoTenNhanVien.VisibleIndex = 3;
            this.HoTenNhanVien.Width = 302;
            // 
            // ThanhTien
            // 
            this.ThanhTien.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F);
            this.ThanhTien.AppearanceCell.Options.UseFont = true;
            this.ThanhTien.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThanhTien.AppearanceHeader.Options.UseFont = true;
            this.ThanhTien.Caption = "Thành tiền";
            this.ThanhTien.FieldName = "ThanhTien";
            this.ThanhTien.MinWidth = 200;
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.OptionsColumn.AllowEdit = false;
            this.ThanhTien.Visible = true;
            this.ThanhTien.VisibleIndex = 4;
            this.ThanhTien.Width = 200;
            // 
            // NgayLap
            // 
            this.NgayLap.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NgayLap.AppearanceCell.Options.UseFont = true;
            this.NgayLap.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NgayLap.AppearanceHeader.Options.UseFont = true;
            this.NgayLap.Caption = "Ngày tạo";
            this.NgayLap.FieldName = "NgayLap";
            this.NgayLap.MinWidth = 300;
            this.NgayLap.Name = "NgayLap";
            this.NgayLap.OptionsColumn.AllowEdit = false;
            this.NgayLap.Visible = true;
            this.NgayLap.VisibleIndex = 5;
            this.NgayLap.Width = 302;
            // 
            // TrangThai
            // 
            this.TrangThai.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F);
            this.TrangThai.AppearanceCell.Options.UseFont = true;
            this.TrangThai.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrangThai.AppearanceHeader.Options.UseFont = true;
            this.TrangThai.Caption = "Trạng thái";
            this.TrangThai.ColumnEdit = this.repositoryItemTextEdit1;
            this.TrangThai.FieldName = "TrangThai";
            this.TrangThai.MinWidth = 200;
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.OptionsColumn.AllowEdit = false;
            this.TrangThai.UnboundDataType = typeof(string);
            this.TrangThai.Visible = true;
            this.TrangThai.VisibleIndex = 6;
            this.TrangThai.Width = 200;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // Action
            // 
            this.Action.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Action.AppearanceCell.Options.UseFont = true;
            this.Action.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Action.AppearanceHeader.Options.UseFont = true;
            this.Action.Caption = "Action";
            this.Action.ColumnEdit = this.repositoryItemButtonEdit1;
            this.Action.FieldName = "Action";
            this.Action.MaxWidth = 200;
            this.Action.MinWidth = 200;
            this.Action.Name = "Action";
            this.Action.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.Action.Visible = true;
            this.Action.VisibleIndex = 7;
            this.Action.Width = 200;
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            editorButtonImageOptions1.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("editorButtonImageOptions1.SvgImage")));
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Print", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "In lại", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            this.repositoryItemButtonEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemButtonEdit1.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.RepositoryItemButtonEdit1_ButtonClick);
            // 
            // FormListOfInvoices
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 680);
            this.Controls.Add(this.gridControl);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FormListOfInvoices";
            this.Text = "Lịch sử hoá đơn";
            this.Load += new System.EventHandler(this.FormListOfInvoices_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn STT;
        private DevExpress.XtraGrid.Columns.GridColumn MaHDBan;
        private DevExpress.XtraGrid.Columns.GridColumn HoTenKhachHang;
        private DevExpress.XtraGrid.Columns.GridColumn HoTenNhanVien;
        private DevExpress.XtraGrid.Columns.GridColumn ThanhTien;
        private DevExpress.XtraGrid.Columns.GridColumn NgayLap;
        private DevExpress.XtraGrid.Columns.GridColumn TrangThai;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn Action;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
    }
}