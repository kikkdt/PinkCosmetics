namespace GUI.UserComponents
{
    partial class ProductItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.panelPrice = new DevExpress.XtraEditors.PanelControl();
            this.lblPrice = new System.Windows.Forms.Label();
            this.panelProductName = new DevExpress.XtraEditors.PanelControl();
            this.lblName = new System.Windows.Forms.Label();
            this.panelImageControl = new DevExpress.XtraEditors.PanelControl();
            this.pictureProduct = new System.Windows.Forms.PictureBox();
            this.toolTipController1 = new DevExpress.Utils.ToolTipController(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelPrice)).BeginInit();
            this.panelPrice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelProductName)).BeginInit();
            this.panelProductName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelImageControl)).BeginInit();
            this.panelImageControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 40F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 60F)});
            this.tablePanel1.Controls.Add(this.panelPrice);
            this.tablePanel1.Controls.Add(this.panelProductName);
            this.tablePanel1.Controls.Add(this.panelImageControl);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(10, 10);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 70F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 30F)});
            this.tablePanel1.Size = new System.Drawing.Size(330, 130);
            this.tablePanel1.TabIndex = 0;
            this.tablePanel1.Click += new System.EventHandler(this.ItemProductControl_Click);
            this.tablePanel1.MouseLeave += new System.EventHandler(this.ItemProductControl_MouseLeave);
            this.tablePanel1.MouseHover += new System.EventHandler(this.ItemProductControl_MouseHover);
            // 
            // panelPrice
            // 
            this.panelPrice.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.tablePanel1.SetColumn(this.panelPrice, 1);
            this.panelPrice.Controls.Add(this.lblPrice);
            this.panelPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrice.Location = new System.Drawing.Point(135, 94);
            this.panelPrice.Name = "panelPrice";
            this.tablePanel1.SetRow(this.panelPrice, 1);
            this.panelPrice.Size = new System.Drawing.Size(192, 33);
            this.panelPrice.TabIndex = 2;
            this.panelPrice.Click += new System.EventHandler(this.ItemProductControl_Click);
            this.panelPrice.MouseLeave += new System.EventHandler(this.ItemProductControl_MouseLeave);
            this.panelPrice.MouseHover += new System.EventHandler(this.ItemProductControl_MouseHover);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoEllipsis = true;
            this.lblPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPrice.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(0, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(192, 33);
            this.lblPrice.TabIndex = 0;
            this.lblPrice.Text = "Giá";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPrice.Click += new System.EventHandler(this.ItemProductControl_Click);
            this.lblPrice.MouseLeave += new System.EventHandler(this.ItemProductControl_MouseLeave);
            this.lblPrice.MouseHover += new System.EventHandler(this.ItemProductControl_MouseHover);
            // 
            // panelProductName
            // 
            this.panelProductName.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.tablePanel1.SetColumn(this.panelProductName, 1);
            this.panelProductName.Controls.Add(this.lblName);
            this.panelProductName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelProductName.Location = new System.Drawing.Point(135, 3);
            this.panelProductName.Name = "panelProductName";
            this.tablePanel1.SetRow(this.panelProductName, 0);
            this.panelProductName.Size = new System.Drawing.Size(192, 85);
            this.panelProductName.TabIndex = 1;
            this.panelProductName.Click += new System.EventHandler(this.ItemProductControl_Click);
            this.panelProductName.MouseLeave += new System.EventHandler(this.ItemProductControl_MouseLeave);
            this.panelProductName.MouseHover += new System.EventHandler(this.ItemProductControl_MouseHover);
            // 
            // lblName
            // 
            this.lblName.AutoEllipsis = true;
            this.lblName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(0, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(192, 85);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Tên sản phẩm";
            this.lblName.Click += new System.EventHandler(this.ItemProductControl_Click);
            this.lblName.MouseLeave += new System.EventHandler(this.ItemProductControl_MouseLeave);
            this.lblName.MouseHover += new System.EventHandler(this.ItemProductControl_MouseHover);
            // 
            // panelImageControl
            // 
            this.panelImageControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.tablePanel1.SetColumn(this.panelImageControl, 0);
            this.panelImageControl.Controls.Add(this.pictureProduct);
            this.panelImageControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelImageControl.Location = new System.Drawing.Point(3, 3);
            this.panelImageControl.Name = "panelImageControl";
            this.tablePanel1.SetRow(this.panelImageControl, 0);
            this.tablePanel1.SetRowSpan(this.panelImageControl, 2);
            this.panelImageControl.Size = new System.Drawing.Size(126, 124);
            this.panelImageControl.TabIndex = 0;
            this.panelImageControl.Click += new System.EventHandler(this.ItemProductControl_Click);
            this.panelImageControl.MouseLeave += new System.EventHandler(this.ItemProductControl_MouseLeave);
            this.panelImageControl.MouseHover += new System.EventHandler(this.ItemProductControl_MouseHover);
            // 
            // pictureProduct
            // 
            this.pictureProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureProduct.ErrorImage = global::GUI.Properties.Resources.icons8_nothing_found_48;
            this.pictureProduct.Location = new System.Drawing.Point(0, 0);
            this.pictureProduct.Name = "pictureProduct";
            this.pictureProduct.Size = new System.Drawing.Size(126, 124);
            this.pictureProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureProduct.TabIndex = 0;
            this.pictureProduct.TabStop = false;
            this.pictureProduct.Click += new System.EventHandler(this.ItemProductControl_Click);
            this.pictureProduct.MouseLeave += new System.EventHandler(this.ItemProductControl_MouseLeave);
            this.pictureProduct.MouseHover += new System.EventHandler(this.ItemProductControl_MouseHover);
            // 
            // ItemProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tablePanel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "ItemProduct";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(350, 150);
            this.Click += new System.EventHandler(this.ItemProductControl_Click);
            this.MouseLeave += new System.EventHandler(this.ItemProductControl_MouseLeave);
            this.MouseHover += new System.EventHandler(this.ItemProductControl_MouseHover);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelPrice)).EndInit();
            this.panelPrice.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelProductName)).EndInit();
            this.panelProductName.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelImageControl)).EndInit();
            this.panelImageControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.XtraEditors.PanelControl panelPrice;
        private DevExpress.XtraEditors.PanelControl panelProductName;
        private DevExpress.XtraEditors.PanelControl panelImageControl;
        private System.Windows.Forms.PictureBox pictureProduct;
        private DevExpress.Utils.ToolTipController toolTipController1;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblName;
    }
}
