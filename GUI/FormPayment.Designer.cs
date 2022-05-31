namespace GUI
{
    partial class FormPayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPayment));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnPayout = new DevExpress.XtraEditors.SimpleButton();
            this.linkLoyalty = new System.Windows.Forms.LinkLabel();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblNeedToPay = new System.Windows.Forms.Label();
            this.lblExcessCash = new System.Windows.Forms.Label();
            this.spinMoneyGiven = new DevExpress.XtraEditors.SpinEdit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinMoneyGiven.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnPayout, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.linkLoyalty, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblCustomerName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblTotalAmount, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblDiscount, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblNeedToPay, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblExcessCash, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.spinMoneyGiven, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(598, 510);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnPayout
            // 
            this.btnPayout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPayout.Appearance.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnPayout.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayout.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnPayout.Appearance.Options.UseBackColor = true;
            this.btnPayout.Appearance.Options.UseFont = true;
            this.btnPayout.Appearance.Options.UseForeColor = true;
            this.tableLayoutPanel1.SetColumnSpan(this.btnPayout, 2);
            this.btnPayout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPayout.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.btnPayout.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnPayout.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPayout.ImageOptions.SvgImage")));
            this.btnPayout.Location = new System.Drawing.Point(13, 437);
            this.btnPayout.Name = "btnPayout";
            this.btnPayout.Size = new System.Drawing.Size(572, 60);
            this.btnPayout.TabIndex = 15;
            this.btnPayout.Text = "THANH TOÁN";
            this.btnPayout.Click += new System.EventHandler(this.BtnPayout_Click);
            // 
            // linkLoyalty
            // 
            this.linkLoyalty.AutoSize = true;
            this.linkLoyalty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.linkLoyalty.LinkColor = System.Drawing.Color.DodgerBlue;
            this.linkLoyalty.Location = new System.Drawing.Point(302, 10);
            this.linkLoyalty.Name = "linkLoyalty";
            this.linkLoyalty.Size = new System.Drawing.Size(283, 60);
            this.linkLoyalty.TabIndex = 7;
            this.linkLoyalty.TabStop = true;
            this.linkLoyalty.Text = "Điểm tích luỹ";
            this.linkLoyalty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLoyalty.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLoyalty_LinkClicked);
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCustomerName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.Location = new System.Drawing.Point(13, 10);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(283, 60);
            this.lblCustomerName.TabIndex = 0;
            this.lblCustomerName.Text = "Tên khách hàng";
            this.lblCustomerName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tổng tiền hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Giảm giá";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Khách cần trả";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "Khách thanh toán";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 310);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(185, 24);
            this.label6.TabIndex = 6;
            this.label6.Text = "Tiền thừa trả khách";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Location = new System.Drawing.Point(302, 70);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(64, 24);
            this.lblTotalAmount.TabIndex = 8;
            this.lblTotalAmount.Text = "label1";
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Location = new System.Drawing.Point(302, 130);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(64, 24);
            this.lblDiscount.TabIndex = 9;
            this.lblDiscount.Text = "label7";
            // 
            // lblNeedToPay
            // 
            this.lblNeedToPay.AutoSize = true;
            this.lblNeedToPay.Location = new System.Drawing.Point(302, 190);
            this.lblNeedToPay.Name = "lblNeedToPay";
            this.lblNeedToPay.Size = new System.Drawing.Size(64, 24);
            this.lblNeedToPay.TabIndex = 10;
            this.lblNeedToPay.Text = "label8";
            // 
            // lblExcessCash
            // 
            this.lblExcessCash.AutoSize = true;
            this.lblExcessCash.Location = new System.Drawing.Point(302, 310);
            this.lblExcessCash.Name = "lblExcessCash";
            this.lblExcessCash.Size = new System.Drawing.Size(64, 24);
            this.lblExcessCash.TabIndex = 11;
            this.lblExcessCash.Text = "label9";
            // 
            // spinMoneyGiven
            // 
            this.spinMoneyGiven.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spinMoneyGiven.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinMoneyGiven.Location = new System.Drawing.Point(302, 253);
            this.spinMoneyGiven.Name = "spinMoneyGiven";
            this.spinMoneyGiven.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spinMoneyGiven.Properties.Appearance.Options.UseFont = true;
            this.spinMoneyGiven.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinMoneyGiven.Properties.IsFloatValue = false;
            this.spinMoneyGiven.Properties.MaskSettings.Set("mask", "n");
            this.spinMoneyGiven.Properties.MaskSettings.Set("autoHideDecimalSeparator", null);
            this.spinMoneyGiven.Properties.MaskSettings.Set("hideInsignificantZeros", null);
            this.spinMoneyGiven.Properties.NullText = "0";
            this.spinMoneyGiven.Size = new System.Drawing.Size(283, 30);
            this.spinMoneyGiven.TabIndex = 14;
            this.spinMoneyGiven.TextChanged += new System.EventHandler(this.SpinMoneyGiven_TextChanged);
            this.spinMoneyGiven.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SpinMoneyGiven_KeyPress);
            // 
            // FormPayment
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 510);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thanh toán";
            this.Load += new System.EventHandler(this.FormPayment_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinMoneyGiven.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.LinkLabel linkLoyalty;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblNeedToPay;
        private System.Windows.Forms.Label lblExcessCash;
        private DevExpress.XtraEditors.SpinEdit spinMoneyGiven;
        private DevExpress.XtraEditors.SimpleButton btnPayout;
    }
}