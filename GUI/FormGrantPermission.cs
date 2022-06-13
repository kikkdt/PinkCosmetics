using BLL;
using DevExpress.XtraEditors.Controls;
using DTO;
using System;
using System.Linq;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormGrantPermission : DevExpress.XtraEditors.XtraForm
    {
        public FormGrantPermission()
        {
            InitializeComponent();
        }

        private void FormGrantPermission_Load(object sender, EventArgs e)
        {
            LoadDgvUser();
        }

        private void LoadDgvUser()
        {
            var employees = NhanVienBLL.GetEmployees();
            gridControlUser.DataSource = TaiKhoanBLL.GetAccounts().Where(x => x.IsAdmin == false).Join(employees,
                acc => acc.Username, emp => emp.Username, (acc, emp) => new
                {
                    emp.HoTen,
                    acc.Username,
                    acc.Password
                }).ToList();
        }

        private void LoadDgvPermission(string username)
        {
            gridControlPermission.DataSource = PhanQuyenBLL.GetPermission(username);
        }

        /// <summary>
        /// Customize columns to display ordinal number columns
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GridView_CustomColumnDisplayText(object sender,
            DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName.Equals("STT") || e.Column.FieldName.Equals("STT2"))
                e.DisplayText = (e.ListSourceRowIndex + 1).ToString();
        }

        private void GridViewUser_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            int rowSelected = gridViewUser.GetSelectedRows()[0];
            string username = gridViewUser.GetRowCellValue(rowSelected, "Username").ToString();
            LoadDgvPermission(username);
        }

        /// <summary>
        /// Perform save to database when value is edited by user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GridViewPermission_CellValueChanged(object sender,
            DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column != CoQuyen)
                return;

            int indexRow = e.RowHandle;
            string username = gridViewPermission.GetRowCellValue(indexRow, "Username").ToString();
            string feature = gridViewPermission.GetRowCellValue(indexRow, "MaChucNang").ToString();

            try
            {
                tb_PhanQuyen permission = new tb_PhanQuyen()
                {
                    Username = username,
                    MaChucNang = feature,
                    CoQuyen = Convert.ToBoolean(gridViewPermission.GetRowCellValue(indexRow, "CoQuyen"))
                };
                if (PhanQuyenBLL.Update(permission) <= 0)
                {
                    MessageBox.Show("Lưu thất bại", "Có lỗi xảy ra", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Có lỗi xảy ra", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RepositoryItemButtonAction_ButtonClick(object sender,
            DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            EditorButton button = e.Button;
            int indexRowSelected = gridViewUser.GetSelectedRows()[0];
            string username = gridViewUser.GetRowCellValue(indexRowSelected, "Username").ToString();
            switch (button.Caption)
            {
                case "Reset":
                    if (MessageBox.Show("Bạn có chắc muốn reset mật khẩu về mặc định?", "Xác nhận reset",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            if (TaiKhoanBLL.ResetPassword(username) > 0)
                            {
                                MessageBox.Show($"Reset mật khẩu tài khoản {username} về mặc định thành công", "Thông báo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadDgvUser();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Có lỗi xảy ra",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    break;

                case "Xoá":
                    if (MessageBox.Show("Bạn có chắc muốn xoá tài khoản này?", "Xác nhận xoá",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            if (TaiKhoanBLL.Delete(username) > 0)
                            {
                                MessageBox.Show($"Xoá tài khoản {username} thành công", "Thông báo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadDgvUser();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Có lỗi xảy ra",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    break;
            }
        }
    }
}