using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormOrder : DevExpress.XtraEditors.XtraForm
    {
        public FormOrder()
        {
            InitializeComponent();

            LoadDgvInventory();
        }

        #region Prepare data

        /// <summary>
        /// Load list of products
        /// </summary>
        private void LoadDgvInventory()
        {
            List<tb_SanPham> products = SanPhamBLL.GetProducts();
            List<tb_NhomSanPham> productGroups = NhomSanPhamBLL.GetProductGroups();

            dgvInventory.DataSource = (products.Join(productGroups, product => product.MaNSP, productGroup => productGroup.MaNSP, (product, productGroup) => new  // Result selector
            {
                product.MaSanPham,
                product.TenSP,
                product.MaThuongHieu,
                product.TonKho,
                productGroup.TenNSP
            }));
        }

        /// <summary>
        /// Customize columns to display ordinal number columns
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GridView1_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "STT")
                e.DisplayText = (e.ListSourceRowIndex + 1).ToString();
        }

        #endregion Prepare data

        #region Handle event

        private void BtnAddToOrder_Click(object sender, EventArgs e)
        {
            string orderID = PhieuDatHangBLL.CreateOrderID();
            // Initialize order
            tb_PhieuDatHang order = new tb_PhieuDatHang
            {
                MaPhieuDat = orderID,
                MaNV = FormMain.Employee.MaNV,
                NgayLap = DateTime.Now,
                TrangThai = false
            };

            // Get a list of selected order details
            List<tb_ChiTietPhieuDat> orderDetails = new List<tb_ChiTietPhieuDat>();
            foreach (int rowHandle in gridView1.GetSelectedRows())
            {
                tb_ChiTietPhieuDat orderDetail = new tb_ChiTietPhieuDat
                {
                    MaPhieuDat = order.MaPhieuDat,
                    MaSanPham = gridView1.GetRowCellValue(rowHandle, "MaSanPham").ToString(),
                    SoLuong = 1
                };
                orderDetails.Add(orderDetail);
            }

            FormOrderDetail formOrderDetail = new FormOrderDetail(order, orderDetails);
            formOrderDetail.FormClosed += (o, evt) =>
            {
                if (formOrderDetail.IsSuccess)
                {
                    MessageBox.Show("Tạo đơn đặt hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            };
            formOrderDetail.ShowDialog();
        }

        #endregion Handle event
    }
}