namespace GUI
{
    partial class FormGrantPermission
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGrantPermission));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gridControlUser = new DevExpress.XtraGrid.GridControl();
            this.gridViewUser = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.STT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HoTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Username = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Password = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Action = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonAction = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gridControlPermission = new DevExpress.XtraGrid.GridControl();
            this.gridViewPermission = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.STT2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UsernamePermission = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaChucNang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CoQuyen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonAction)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPermission)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPermission)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1278, 680);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gridControlUser);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(633, 674);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Người dùng";
            // 
            // gridControlUser
            // 
            this.gridControlUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlUser.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(1);
            this.gridControlUser.Location = new System.Drawing.Point(3, 28);
            this.gridControlUser.MainView = this.gridViewUser;
            this.gridControlUser.Name = "gridControlUser";
            this.gridControlUser.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonAction});
            this.gridControlUser.Size = new System.Drawing.Size(627, 643);
            this.gridControlUser.TabIndex = 0;
            this.gridControlUser.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewUser});
            // 
            // gridViewUser
            // 
            this.gridViewUser.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.STT,
            this.HoTen,
            this.Username,
            this.Password,
            this.Action});
            this.gridViewUser.GridControl = this.gridControlUser;
            this.gridViewUser.GroupPanelText = " ";
            this.gridViewUser.Name = "gridViewUser";
            this.gridViewUser.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.gridViewUser.RowHeight = 35;
            this.gridViewUser.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.GridViewUser_SelectionChanged);
            this.gridViewUser.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.GridView_CustomColumnDisplayText);
            // 
            // STT
            // 
            this.STT.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F);
            this.STT.AppearanceCell.Options.UseFont = true;
            this.STT.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STT.AppearanceHeader.Options.UseFont = true;
            this.STT.Caption = "STT";
            this.STT.FieldName = "STT";
            this.STT.MaxWidth = 150;
            this.STT.MinWidth = 150;
            this.STT.Name = "STT";
            this.STT.OptionsColumn.AllowEdit = false;
            this.STT.Visible = true;
            this.STT.VisibleIndex = 0;
            this.STT.Width = 150;
            // 
            // HoTen
            // 
            this.HoTen.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F);
            this.HoTen.AppearanceCell.Options.UseFont = true;
            this.HoTen.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoTen.AppearanceHeader.Options.UseFont = true;
            this.HoTen.Caption = "Họ tên nhân viên";
            this.HoTen.FieldName = "HoTen";
            this.HoTen.MinWidth = 200;
            this.HoTen.Name = "HoTen";
            this.HoTen.OptionsColumn.AllowEdit = false;
            this.HoTen.Visible = true;
            this.HoTen.VisibleIndex = 1;
            this.HoTen.Width = 200;
            // 
            // Username
            // 
            this.Username.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F);
            this.Username.AppearanceCell.Options.UseFont = true;
            this.Username.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.AppearanceHeader.Options.UseFont = true;
            this.Username.Caption = "Username";
            this.Username.FieldName = "Username";
            this.Username.MinWidth = 150;
            this.Username.Name = "Username";
            this.Username.OptionsColumn.AllowEdit = false;
            this.Username.Visible = true;
            this.Username.VisibleIndex = 2;
            this.Username.Width = 200;
            // 
            // Password
            // 
            this.Password.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F);
            this.Password.AppearanceCell.Options.UseFont = true;
            this.Password.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.AppearanceHeader.Options.UseFont = true;
            this.Password.Caption = "Mật khẩu";
            this.Password.FieldName = "Password";
            this.Password.MaxWidth = 300;
            this.Password.MinWidth = 200;
            this.Password.Name = "Password";
            this.Password.OptionsColumn.AllowEdit = false;
            this.Password.Visible = true;
            this.Password.VisibleIndex = 3;
            this.Password.Width = 200;
            // 
            // Action
            // 
            this.Action.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F);
            this.Action.AppearanceCell.Options.UseFont = true;
            this.Action.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Action.AppearanceHeader.Options.UseFont = true;
            this.Action.Caption = "Action";
            this.Action.ColumnEdit = this.repositoryItemButtonAction;
            this.Action.MaxWidth = 200;
            this.Action.MinWidth = 200;
            this.Action.Name = "Action";
            this.Action.Visible = true;
            this.Action.VisibleIndex = 4;
            this.Action.Width = 200;
            // 
            // repositoryItemButtonAction
            // 
            this.repositoryItemButtonAction.AutoHeight = false;
            editorButtonImageOptions1.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("editorButtonImageOptions1.SvgImage")));
            editorButtonImageOptions2.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("editorButtonImageOptions2.SvgImage")));
            this.repositoryItemButtonAction.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Reset", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "Reset về mật khẩu mặc định \'123\'", null, null, DevExpress.Utils.ToolTipAnchor.Default),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Xoá", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "Xoá", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repositoryItemButtonAction.Name = "repositoryItemButtonAction";
            this.repositoryItemButtonAction.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemButtonAction.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.RepositoryItemButtonAction_ButtonClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gridControlPermission);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(642, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(633, 674);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Phân quyền";
            // 
            // gridControlPermission
            // 
            this.gridControlPermission.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlPermission.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(1);
            this.gridControlPermission.Location = new System.Drawing.Point(3, 28);
            this.gridControlPermission.MainView = this.gridViewPermission;
            this.gridControlPermission.Name = "gridControlPermission";
            this.gridControlPermission.Size = new System.Drawing.Size(627, 643);
            this.gridControlPermission.TabIndex = 0;
            this.gridControlPermission.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPermission});
            // 
            // gridViewPermission
            // 
            this.gridViewPermission.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.STT2,
            this.UsernamePermission,
            this.MaChucNang,
            this.CoQuyen});
            this.gridViewPermission.GridControl = this.gridControlPermission;
            this.gridViewPermission.GroupPanelText = " ";
            this.gridViewPermission.Name = "gridViewPermission";
            this.gridViewPermission.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.gridViewPermission.RowHeight = 35;
            this.gridViewPermission.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.GridViewPermission_CellValueChanged);
            this.gridViewPermission.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.GridView_CustomColumnDisplayText);
            // 
            // STT2
            // 
            this.STT2.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F);
            this.STT2.AppearanceCell.Options.UseFont = true;
            this.STT2.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STT2.AppearanceHeader.Options.UseFont = true;
            this.STT2.Caption = "STT";
            this.STT2.FieldName = "STT";
            this.STT2.MaxWidth = 75;
            this.STT2.MinWidth = 75;
            this.STT2.Name = "STT2";
            this.STT2.Visible = true;
            this.STT2.VisibleIndex = 0;
            // 
            // UsernamePermission
            // 
            this.UsernamePermission.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F);
            this.UsernamePermission.AppearanceCell.Options.UseFont = true;
            this.UsernamePermission.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernamePermission.AppearanceHeader.Options.UseFont = true;
            this.UsernamePermission.Caption = "Username";
            this.UsernamePermission.FieldName = "Username";
            this.UsernamePermission.MinWidth = 25;
            this.UsernamePermission.Name = "UsernamePermission";
            this.UsernamePermission.OptionsColumn.AllowEdit = false;
            this.UsernamePermission.Visible = true;
            this.UsernamePermission.VisibleIndex = 1;
            this.UsernamePermission.Width = 94;
            // 
            // MaChucNang
            // 
            this.MaChucNang.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F);
            this.MaChucNang.AppearanceCell.Options.UseFont = true;
            this.MaChucNang.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaChucNang.AppearanceHeader.Options.UseFont = true;
            this.MaChucNang.Caption = "Chức năng";
            this.MaChucNang.FieldName = "MaChucNang";
            this.MaChucNang.MinWidth = 25;
            this.MaChucNang.Name = "MaChucNang";
            this.MaChucNang.OptionsColumn.AllowEdit = false;
            this.MaChucNang.Visible = true;
            this.MaChucNang.VisibleIndex = 3;
            this.MaChucNang.Width = 94;
            // 
            // CoQuyen
            // 
            this.CoQuyen.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F);
            this.CoQuyen.AppearanceCell.Options.UseFont = true;
            this.CoQuyen.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CoQuyen.AppearanceHeader.Options.UseFont = true;
            this.CoQuyen.Caption = "Cấp quyền";
            this.CoQuyen.FieldName = "CoQuyen";
            this.CoQuyen.MinWidth = 25;
            this.CoQuyen.Name = "CoQuyen";
            this.CoQuyen.Visible = true;
            this.CoQuyen.VisibleIndex = 2;
            this.CoQuyen.Width = 94;
            // 
            // FormGrantPermission
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 680);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FormGrantPermission";
            this.Text = "Phân quyền";
            this.Load += new System.EventHandler(this.FormGrantPermission_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonAction)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPermission)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPermission)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraGrid.GridControl gridControlUser;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewUser;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraGrid.Columns.GridColumn HoTen;
        private DevExpress.XtraGrid.Columns.GridColumn Username;
        private DevExpress.XtraGrid.Columns.GridColumn Password;
        private DevExpress.XtraGrid.GridControl gridControlPermission;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewPermission;
        private DevExpress.XtraGrid.Columns.GridColumn UsernamePermission;
        private DevExpress.XtraGrid.Columns.GridColumn MaChucNang;
        private DevExpress.XtraGrid.Columns.GridColumn CoQuyen;
        private DevExpress.XtraGrid.Columns.GridColumn STT;
        private DevExpress.XtraGrid.Columns.GridColumn STT2;
        private DevExpress.XtraGrid.Columns.GridColumn Action;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonAction;
    }
}