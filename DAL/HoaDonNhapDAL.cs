using DTO;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public class HoaDonNhapDAL
    {
        private readonly PinkCosmetics _dataContext = new PinkCosmetics();

        /// <summary>
        /// Get all of import invoices
        /// </summary>
        /// <returns></returns>
        public List<tb_HoaDonNhap> GetImportInvoices()
        {
            return _dataContext.tb_HoaDonNhap.ToList();
        }

        /// <summary>
        /// Get an import invoice by ID
        /// </summary>
        /// <param name="id">Import invoice ID</param>
        /// <returns></returns>
        public tb_HoaDonNhap GetImportInvoice(string id)
        {
            return _dataContext.tb_HoaDonNhap.FirstOrDefault(x => x.MaHDNhap == id);
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
                _dataContext.tb_ChiTietHDNhap.AddRange(importInvoiceDetails);
                _dataContext.tb_HoaDonNhap.Add(importInvoice);
                _dataContext.SaveChanges();
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
                         in importInvoiceUpdate.tb_ChiTietHDNhap)
                {
                    var tmp = importInvoiceDetails.Find(x => x.MaSanPham == importInvoiceDetail.MaSanPham);
                    importInvoiceDetail.SoLuong = tmp.SoLuong;
                    importInvoiceDetail.GiaNhap = tmp.GiaNhap;
                    importInvoiceDetail.ThanhTien = tmp.ThanhTien;
                }

                _dataContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}