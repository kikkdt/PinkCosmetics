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
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.panelCart = new System.Windows.Forms.FlowLayoutPanel();
            this.panelRight = new DevExpress.XtraEditors.PanelControl();
            this.tablePanel2 = new DevExpress.Utils.Layout.TablePanel();
            this.panelProducts = new System.Windows.Forms.FlowLayoutPanel();
            this.panelSearchCustomer = new System.Windows.Forms.Panel();
            this.searchControl1 = new DevExpress.XtraEditors.SearchControl();
            this.panelBtnPayout = new DevExpress.XtraEditors.PanelControl();
            this.btnPayout = new DevExpress.XtraEditors.SimpleButton();
            this.toolTipController1 = new DevExpress.Utils.ToolTipController(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
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
            this.tablePanel1.Controls.Add(this.panelCart);
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
            // panelCart
            // 
            this.panelCart.AutoScroll = true;
            this.tablePanel1.SetColumn(this.panelCart, 0);
            this.panelCart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCart.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelCart.Location = new System.Drawing.Point(3, 63);
            this.panelCart.Name = "panelCart";
            this.tablePanel1.SetRow(this.panelCart, 1);
            this.panelCart.Size = new System.Drawing.Size(751, 607);
            this.panelCart.TabIndex = 1;
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
        private System.Windows.Forms.FlowLayoutPanel panelCart;
    }
}