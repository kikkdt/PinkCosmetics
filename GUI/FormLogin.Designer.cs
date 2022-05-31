namespace GUI
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.btnLogin = new DevExpress.XtraEditors.SimpleButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtUsername = new DevExpress.XtraEditors.TextEdit();
            this.txtPassword = new DevExpress.XtraEditors.TextEdit();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsername.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Appearance.BackColor = System.Drawing.Color.White;
            this.btnLogin.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.btnLogin.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnLogin.Appearance.Options.UseBackColor = true;
            this.btnLogin.Appearance.Options.UseBorderColor = true;
            this.btnLogin.Appearance.Options.UseFont = true;
            this.btnLogin.Appearance.Options.UseForeColor = true;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLogin.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.btnLogin.Location = new System.Drawing.Point(3, 160);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnLogin.Size = new System.Drawing.Size(494, 67);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "ĐĂNG NHẬP";
            this.btnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            this.btnLogin.MouseLeave += new System.EventHandler(this.BtnLogin_MouseLeave);
            this.btnLogin.MouseHover += new System.EventHandler(this.BtnLogin_MouseHover);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.txtUsername, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnLogin, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtPassword, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(100, 35);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(500, 230);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // txtUsername
            // 
            this.txtUsername.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUsername.Location = new System.Drawing.Point(3, 3);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Properties.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.txtUsername.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Properties.Appearance.Options.UseFont = true;
            this.txtUsername.Properties.ContextImageOptions.AllowChangeAnimation = DevExpress.Utils.DefaultBoolean.True;
            this.txtUsername.Properties.ContextImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.txtUsername.Properties.ContextImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("txtUsername.Properties.ContextImageOptions.SvgImage")));
            this.txtUsername.Properties.Padding = new System.Windows.Forms.Padding(10);
            this.txtUsername.Size = new System.Drawing.Size(494, 64);
            this.txtUsername.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPassword.Location = new System.Drawing.Point(3, 68);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Properties.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.txtPassword.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Properties.Appearance.Options.UseFont = true;
            this.txtPassword.Properties.ContextImageOptions.AllowChangeAnimation = DevExpress.Utils.DefaultBoolean.True;
            this.txtPassword.Properties.ContextImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.txtPassword.Properties.ContextImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("txtPassword.Properties.ContextImageOptions.SvgImage")));
            this.txtPassword.Properties.Padding = new System.Windows.Forms.Padding(10);
            this.txtPassword.Properties.UseSystemPasswordChar = true;
            this.txtPassword.Size = new System.Drawing.Size(494, 64);
            this.txtPassword.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(197)))));
            this.btnClose.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnClose.Appearance.Options.UseBackColor = true;
            this.btnClose.Appearance.Options.UseForeColor = true;
            this.btnClose.Appearance.Options.UseImage = true;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.btnClose.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnClose.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnClose.ImageOptions.SvgImage")));
            this.btnClose.ImageOptions.SvgImageSize = new System.Drawing.Size(50, 50);
            this.btnClose.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnClose.Location = new System.Drawing.Point(638, 12);
            this.btnClose.MaximumSize = new System.Drawing.Size(50, 50);
            this.btnClose.MinimumSize = new System.Drawing.Size(50, 50);
            this.btnClose.Name = "btnClose";
            this.btnClose.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnClose.Size = new System.Drawing.Size(50, 50);
            this.btnClose.TabIndex = 4;
            this.btnClose.ToolTip = "Thoát";
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // FormLogin
            // 
            this.AcceptButton = this.btnLogin;
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(197)))));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(700, 300);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtUsername.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnLogin;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.TextEdit txtUsername;
        private DevExpress.XtraEditors.TextEdit txtPassword;
        private DevExpress.XtraEditors.SimpleButton btnClose;
    }
}