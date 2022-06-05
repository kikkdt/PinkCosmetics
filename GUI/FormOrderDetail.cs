using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormOrderDetail : DevExpress.XtraEditors.XtraForm
    {
        public tb_PhieuDatHang Order { get; set; }
        public List<tb_ChiTietPhieuDat> OrderDetails { get; set; }
        public bool IsSuccess = false;

        public FormOrderDetail(tb_PhieuDatHang order, List<tb_ChiTietPhieuDat> orderDetails)
        {
            InitializeComponent();

            Order = order;
            OrderDetails = orderDetails;
        }

        #region Prepare data

        private void FormOrderDetail_Load(object sender, EventArgs e)
        {
            LoadDgvOrderDetail();
        }

        private void LoadDgvOrderDetail()
        {
            List<tb_SanPham> products = SanPhamBLL.GetProducts();
            gridControl1.DataSource = OrderDetails.Join(products, orderDetail => orderDetail.MaSanPham, product => product.MaSanPham, (orderDetail, product) => new ViewChiTietPhieuDatHang()
            {
                MaPhieuDat = orderDetail.MaPhieuDat,
                MaSanPham = orderDetail.MaSanPham,
                TenSP = product.TenSP,
                SoLuong = orderDetail.SoLuong,
            }).ToList();
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

        private void BtnOrder_Click(object sender, EventArgs e)
        {
            try
            {
                if (PhieuDatHangBLL.Insert(Order, OrderDetails))
                {
                    IsSuccess = true;
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Có lỗi xảy ra", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Update the quantity after cell value changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            var rowIndex = e.RowHandle;
            string productID = gridView1.GetRowCellValue(rowIndex, "MaSanPham").ToString();
            foreach (var item in OrderDetails)
            {
                if (item.MaSanPham.Equals(productID))
                {
                    item.SoLuong = int.Parse(e.Value.ToString());
                    break;
                }
            }
        }

        #endregion Handle event
    }
}