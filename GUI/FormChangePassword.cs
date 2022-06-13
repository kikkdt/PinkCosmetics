using BLL;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormChangePassword : DevExpress.XtraEditors.XtraForm
    {
        public FormChangePassword()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void BtnChangePassword_MouseHover(object sender, EventArgs e)
        {
            btnChangePassword.Appearance.BackColor = Color.FromArgb(255, 189, 197);
            btnChangePassword.Appearance.ForeColor = Color.White;
        }

        private void BtnChangePassword_MouseLeave(object sender, EventArgs e)
        {
            btnChangePassword.Appearance.BackColor = Color.White;
            btnChangePassword.Appearance.ForeColor = Color.Black;
        }

        /// <summary>
        /// Perform password change
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnChangePassword_Click(object sender, EventArgs e)
        {
            try
            {
                string username = FormMain.Account.Username;
                string currentPassword = txtCurrentPassword.Text;
                string newPassword = txtNewPassword.Text;
                string confirmPassword = txtConfirmPassword.Text;

                if (TaiKhoanBLL.ChangePassword(username, currentPassword, newPassword, confirmPassword) > 0)
                {
                    MessageBox.Show("Thay đổi mật khẩu thành công", "Thông báo", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Có lỗi xảy ra", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}