using BLL;
using DTO;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormBrand : DevExpress.XtraEditors.XtraForm
    {
        private bool IsEdit = false;
        public tb_ThuongHieu Brand { get; set; }

        public FormBrand()
        {
            InitializeComponent();
        }

        public FormBrand(tb_ThuongHieu brand)
        {
            InitializeComponent();

            Brand = brand;
            IsEdit = true;

            lblFormTitle.Text = "Cập nhật thông tin thương hiệu";
            txtName.Text = brand.TenThuongHieu;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            // Insert
            if (!IsEdit)
            {
                try
                {
                    var brand = new tb_ThuongHieu();
                    brand.TenThuongHieu = txtName.Text;
                    brand.DaXoa = false;

                    if (ThuongHieuBLL.Insert(brand) > 0)
                    {
                        MessageBox.Show("Thêm thương hiệu thành công", "Thông báo", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Có lỗi xảy ra", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else // Update
            {
                try
                {
                    Brand.TenThuongHieu = txtName.Text;

                    if (ThuongHieuBLL.Update(Brand) > 0)
                    {
                        MessageBox.Show("Cập nhật thương hiệu thành công", "Thông báo", MessageBoxButtons.OK,
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
}