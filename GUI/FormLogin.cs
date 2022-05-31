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
    public partial class FormLogin : Form
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
    }
}
