using BLL;
using DTO;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormProductGroups : DevExpress.XtraEditors.XtraForm
    {
        private bool IsEdit = false;
        public tb_NhomSanPham ProductGroup { get; set; }

        public FormProductGroups()
        {
            InitializeComponent();
        }

        public FormProductGroups(tb_NhomSanPham productGroup)
        {
            InitializeComponent();
            LoadCboxParentProductGroup();

            ProductGroup = productGroup;
            IsEdit = true;

            lblFormTitle.Text = "Cập nhật thông tin nhóm hàng";
            txtName.Text = productGroup.TenNSP;
            int index = cboxParent.Items.IndexOf(NhomSanPhamBLL.GetProductGroups(productGroup.MaNSP));
            if (productGroup.NSPCha == null)
                cboxParent.SelectedIndex = 0;
            else
                cboxParent.SelectedItem = productGroup;
        }

        private void LoadCboxParentProductGroup()
        {
            cboxParent.Items.Add("");
            cboxParent.Items.AddRange(NhomSanPhamBLL.GetProductGroups().ToArray());
            cboxParent.DisplayMember = "TenNSP";
            cboxParent.ValueMember = "MaNSP";
            cboxParent.SelectedIndex = 0;
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
                    var productGroup = new tb_NhomSanPham();
                    productGroup.TenNSP = txtName.Text;
                    if (cboxParent.SelectedItem == "")
                        productGroup.NSPCha = null;
                    else
                        productGroup.NSPCha = Convert.ToInt32((cboxParent.SelectedItem as tb_NhomSanPham).MaNSP);
                    productGroup.DaXoa = false;

                    if (NhomSanPhamBLL.Insert(productGroup) > 0)
                    {
                        MessageBox.Show("Thêm nhóm hàng thành công", "Thông báo", MessageBoxButtons.OK,
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
                    ProductGroup.TenNSP = txtName.Text;
                    if (cboxParent.SelectedItem == "")
                        ProductGroup.NSPCha = null;
                    else
                        ProductGroup.NSPCha = Convert.ToInt32((cboxParent.SelectedItem as tb_NhomSanPham).MaNSP);

                    if (NhomSanPhamBLL.Update(ProductGroup) > 0)
                    {
                        MessageBox.Show("Cập nhật nhóm hàng thành công", "Thông báo", MessageBoxButtons.OK,
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