using BLL;
using DevExpress.XtraEditors.Controls;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormListOfBrands : DevExpress.XtraEditors.XtraForm
    {
        public FormListOfBrands()
        {
            InitializeComponent();
        }

        private void FormListOfBrands_Load(object sender, EventArgs e)
        {
            LoadDgv();
        }

        private void LoadDgv()
        {
            gridControl1.DataSource = ThuongHieuBLL.GetBrands();
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
                            if (ThuongHieuBLL.Delete(
                                    Convert.ToInt32(gridView1.GetRowCellValue(indexRowSelected, "MaThuongHieu"))) > 0)
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
                    tb_ThuongHieu brand = ThuongHieuBLL.GetBrand(
                         Convert.ToInt32(gridView1.GetRowCellValue(indexRowSelected, "MaThuongHieu")));
                    FormBrand formBrand = new FormBrand(brand);
                    formBrand.FormClosed += (o, evt) =>
                    {
                        LoadDgv();
                    };
                    formBrand.ShowDialog();
                    break;
            }
        }
    }
}