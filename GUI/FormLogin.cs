using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormLogin : DevExpress.XtraEditors.XtraForm
    {
        public FormMain FormMain;
        public FormLogin()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (TaiKhoanBLL.IsValidLogin(txtUsername.Text, txtPassword.Text))
                {
                    tb_TaiKhoan account = TaiKhoanBLL.GetAccount(txtUsername.Text, txtPassword.Text);
                    if (account is null) // Login failure
                    {
                        MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng.", "Lỗi", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                    else // Login success
                    {
                        FormMain = new FormMain(account);
                        Hide();
                        FormMain.FormClosing += delegate { Close(); };
                        FormMain.ShowDialog();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void BtnLogin_MouseHover(object sender, EventArgs e)
        {
            btnLogin.Appearance.BackColor = Color.FromArgb(255, 189, 197);
            btnLogin.Appearance.ForeColor = Color.White;
        }

        private void BtnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnLogin.Appearance.BackColor = Color.White;
            btnLogin.Appearance.ForeColor = Color.Black;
        }
    }
}
