using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormImportGoods : DevExpress.XtraEditors.XtraForm
    {
        public tb_PhieuDatHang Order { get; set; }
        private tb_HoaDonNhap ImportInvoice;
        private List<tb_ChiTietHDNhap> ImportInvoiceDetails = new List<tb_ChiTietHDNhap>();
        private bool IsInsert = false;
        public bool IsDone { get; set; }

        public FormImportGoods(tb_PhieuDatHang order)
        {
            InitializeComponent();
            Order = order;

            tb_HoaDonNhap importInvoice = HoaDonNhapBLL.GetImportInvoiceByOrder(Order.MaPhieuDat);
            if (importInvoice != null)
            {
                ImportInvoice = importInvoice;
                ImportInvoiceDetails = importInvoice.tb_ChiTietHDNhaps.ToList();
            }
            else
            {
                IsInsert = true;
                ImportInvoice = new tb_HoaDonNhap
                {
                    MaHDNhap = HoaDonNhapBLL.CreateID(),
                    MaPhieuDat = Order.MaPhieuDat,
                    MaNV = FormMain.Employee.MaNV,
                    NgayLap = DateTime.Now
                };

                foreach (var orderDetail in Order.tb_ChiTietPhieuDats)
                {
                    tb_ChiTietHDNhap importInvoiceDetail = new tb_ChiTietHDNhap
                    {
                        MaHDNhap = ImportInvoice.MaHDNhap,
                        MaSanPham = orderDetail.MaSanPham
                    };
                    ImportInvoiceDetails.Add(importInvoiceDetail);
                }
            }
        }

        #region Prepare data

        private void FormImportGoods_Load(object sender, EventArgs e)
        {
            LoadDgv();
        }

        private void LoadDgv()
        {
            List<tb_SanPham> products = SanPhamBLL.GetProducts();
            var orderDetailAndProducts
                = Order.tb_ChiTietPhieuDats.Join(products, orderDetail => orderDetail.MaSanPham, product => product.MaSanPham, (orderDetail, product) => new { orderDetail, product }).Join(new List<tb_HoaDonNhap> { ImportInvoice }, orderDetailAndProduct => orderDetailAndProduct.orderDetail.MaPhieuDat, importInvoice => importInvoice.MaPhieuDat, (orderDetailAndProduct, importInvoice) => new { orderDetailAndProduct, importInvoice });

            var importInvoiceDetailAndProducts = ImportInvoiceDetails.Join(products,
                importInvoiceDetail => importInvoiceDetail.MaSanPham, product => product.MaSanPham,
                (importInvoiceDetail, product) => new { importInvoiceDetail, product }).Join(new List<tb_HoaDonNhap> { ImportInvoice }, importInvoiceDetailAndProduct => importInvoiceDetailAndProduct.importInvoiceDetail.MaHDNhap, importInvoice => importInvoice.MaHDNhap, (importInvoiceDetailAndProduct, importInvoice) => new { importInvoiceDetailAndProduct, importInvoice });

            gridControl.DataSource = orderDetailAndProducts.Join(importInvoiceDetailAndProducts,
                orderDetailAndProduct => orderDetailAndProduct.orderDetailAndProduct.orderDetail.MaSanPham,
                importInvoiceDetailAndProduct => importInvoiceDetailAndProduct.importInvoiceDetailAndProduct.importInvoiceDetail.MaSanPham,
                (orderDetailAndProduct, importInvoiceDetailAndProduct) => new ViewChiTietNhapHang()
                {
                    MaSanPham = importInvoiceDetailAndProduct.importInvoiceDetailAndProduct.importInvoiceDetail.MaSanPham,
                    TenSP = importInvoiceDetailAndProduct.importInvoiceDetailAndProduct.product.TenSP,
                    SoLuongDat = orderDetailAndProduct.orderDetailAndProduct.orderDetail.SoLuong,
                    SoLuongNhap = importInvoiceDetailAndProduct.importInvoiceDetailAndProduct.importInvoiceDetail.SoLuong,
                    GiaNhap = importInvoiceDetailAndProduct.importInvoiceDetailAndProduct.importInvoiceDetail.GiaNhap,
                    ThanhTien = importInvoiceDetailAndProduct.importInvoiceDetailAndProduct.importInvoiceDetail.ThanhTien,
                }).ToList();
        }

        #endregion Prepare data

        #region Handle event

        /// <summary>
        /// Customize columns to display ordinal number columns
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName.Equals("STT"))
                e.DisplayText = (e.ListSourceRowIndex + 1).ToString();
            else if (e.Column.FieldName.Equals("GiaNhap") || e.Column.FieldName.Equals("ThanhTien"))
            {
                e.DisplayText = Utilities.FormatWithThousandSeparator(Convert.ToDouble(e.Value));
            }
        }

        /// <summary>
        /// Update the quantity and subtotal after cell value changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            var rowIndex = e.RowHandle;
            string productID = gridView.GetRowCellValue(rowIndex, "MaSanPham").ToString();
            if (e.Column == SoLuongNhap || e.Column == GiaNhap)
            {
                int quantity = gridView.GetRowCellValue(rowIndex, "SoLuongNhap") == null ? 0 : Convert.ToInt32(gridView.GetRowCellValue(rowIndex, "SoLuongNhap"));
                double price = gridView.GetRowCellValue(rowIndex, "GiaNhap") == null ? 0 : Convert.ToDouble(gridView.GetRowCellValue(rowIndex, "GiaNhap"));
                double subtotal = quantity * price;

                // Update import invoice detail
                foreach (var item in ImportInvoiceDetails)
                {
                    if (item.MaSanPham.Equals(productID))
                    {
                        item.SoLuong = quantity;
                        item.GiaNhap = (decimal)price;
                        item.ThanhTien = (decimal)subtotal;
                        break;
                    }
                }

                // Update ThanhTien column in UI
                gridView.SetRowCellValue(rowIndex, "ThanhTien", subtotal);
            }
        }

        /// <summary>
        /// Validate form
        /// </summary>
        /// <returns></returns>
        private bool IsValidForm()
        {
            foreach (var importInvoiceDetail in ImportInvoiceDetails)
            {
                int orderQuantity = Order.tb_ChiTietPhieuDats
                    .FirstOrDefault(x => x.MaSanPham.Equals(importInvoiceDetail.MaSanPham)).SoLuong;
                if (importInvoiceDetail.SoLuong > orderQuantity)
                {
                    MessageBox.Show($"Số lượng nhập sản phẩm {importInvoiceDetail.MaSanPham} không hợp lệ.");
                    return false;
                }
            }
            return true;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (IsValidForm())
            {
                // Not exist, insert
                if (IsInsert)
                {
                    try
                    {
                        if (HoaDonNhapBLL.Insert(ImportInvoice, ImportInvoiceDetails))
                        {
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
                        if (HoaDonNhapBLL.Update(ImportInvoice, ImportInvoiceDetails))
                        {
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

        private void BtnDone_Click(object sender, EventArgs e)
        {
            btnSave.PerformClick();
            try
            {
                Order.TrangThai = true;
                if (PhieuDatHangBLL.Update(Order))
                {
                    IsDone = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Có lỗi xảy ra", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion Handle event
    }
}