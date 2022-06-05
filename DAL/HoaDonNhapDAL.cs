using DTO;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public class HoaDonNhapDAL
    {
        private PinkCosmeticsDataContext dataContext = new PinkCosmeticsDataContext();

        /// <summary>
        /// Get all of import invoices
        /// </summary>
        /// <returns></returns>
        public List<tb_HoaDonNhap> GetImportInvoices()
        {
            return dataContext.tb_HoaDonNhaps.ToList();
        }

        /// <summary>
        /// Get an import invoice by ID
        /// </summary>
        /// <param name="id">Import invoice ID</param>
        /// <returns></returns>
        public tb_HoaDonNhap GetImportInvoice(string id)
        {
            return dataContext.tb_HoaDonNhaps.FirstOrDefault(x => x.MaHDNhap.Equals(id));
        }

        /// <summary>
        /// Insert import invoice to database
        /// </summary>
        /// <param name="importInvoice">Import invoice</param>
        /// <param name="importInvoiceDetails">List of import invoice details</param>
        /// <returns></returns>
        public bool Insert(tb_HoaDonNhap importInvoice, List<tb_ChiTietHDNhap> importInvoiceDetails)
        {
            try
            {
                importInvoice.tb_ChiTietHDNhaps.AddRange(importInvoiceDetails);
                dataContext.tb_HoaDonNhaps.InsertOnSubmit(importInvoice);
                dataContext.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Update import invoice to database
        /// </summary>
        /// <param name="importInvoice">Import invoice</param>
        /// <param name="importInvoiceDetails">List of import invoice details</param>
        /// <returns></returns>
        public bool Update(tb_HoaDonNhap importInvoice, List<tb_ChiTietHDNhap> importInvoiceDetails)
        {
            try
            {
                tb_HoaDonNhap importInvoiceUpdate = GetImportInvoice(importInvoice.MaHDNhap);
                foreach (var importInvoiceDetail
                         in importInvoiceUpdate.tb_ChiTietHDNhaps)
                {
                    var tmp = importInvoiceDetails.Find(x => x.MaSanPham.Equals(importInvoiceDetail.MaSanPham));
                    importInvoiceDetail.SoLuong = tmp.SoLuong;
                    importInvoiceDetail.GiaNhap = tmp.GiaNhap;
                    importInvoiceDetail.ThanhTien = tmp.ThanhTien;
                }

                dataContext.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}