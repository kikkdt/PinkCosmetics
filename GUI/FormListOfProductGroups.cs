using BLL;
using DevExpress.XtraEditors.Controls;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormListOfProductGroups : DevExpress.XtraEditors.XtraForm
    {
        public FormListOfProductGroups()
        {
            InitializeComponent();
        }

        private void FormProductGroups_Load(object sender, EventArgs e)
        {
            LoadDgv();
        }

        private List<tb_NhomSanPham> productGroups;

        private void LoadDgv()
        {
            productGroups = NhomSanPhamBLL.GetProductGroups();
            gridControl1.DataSource = productGroups;
        }

        /// <summary>
        /// Customize columns to display
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridView1_CustomColumnDisplayText(object sender,
            DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "STT")
                e.DisplayText = (e.ListSourceRowIndex + 1).ToString();
            else if (e.Column.FieldName == "NSPCha")
                e.DisplayText = e.Value == null
                    ? ""
                    : productGroups.FirstOrDefault(x => x.MaNSP == Convert.ToInt32(e.Value)).TenNSP;
        }

        private void RepositoryItemButtonEdit1_ButtonClick(object sender,
            DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            EditorButton button = e.Button;
            int indexRowSelected = gridView1.GetSelectedRows()[0];
            switch (button.Caption)
            {
                case "Xoá":
                    if (MessageBox.Show("Bạn có chắc muốn xoá?", "Xác nhận xoá", MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            if (NhomSanPhamBLL.Delete(
                                    Convert.ToInt32(gridView1.GetRowCellValue(indexRowSelected, "MaNSP"))) > 0)
                            {
                                MessageBox.Show("Xoá thành công", "Thông báo", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                                LoadDgv();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Có lỗi xảy ra", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    break;

                case "Sửa":
                    tb_NhomSanPham productGroup = NhomSanPhamBLL.GetProductGroups(
                         Convert.ToInt32(gridView1.GetRowCellValue(indexRowSelected, "MaNSP")));
                    FormProductGroups formProductGroups = new FormProductGroups(productGroup);
                    formProductGroups.FormClosed += (o, evt) =>
                    {
                        LoadDgv();
                    };
                    formProductGroups.ShowDialog();
                    break;
            }
        }
    }
}