using DAL;
using DTO;
using System.Collections.Generic;
using System.Linq;

namespace BLL
{
    public class HoaDonNhapBLL
    {
        /// <summary>
        /// Create import invoice ID by concatenating the prefix "NH" with the value selected in the Identity table as the suffix
        /// </summary>
        /// <returns></returns>
        public static string CreateID()
        {
            return $"HD{(IdentityBLL.GetIdentity("HoaDonNhap") + 1).ToString().PadLeft(5, '0')}";
        }

        /// <summary>
        /// Get all of import invoices
        /// </summary>
        /// <returns></returns>
        public static List<tb_HoaDonNhap> GetImportInvoices()
        {
            return new HoaDonNhapDAL().GetImportInvoices();
        }

        /// <summary>
        /// Get an import invoice by ID
        /// </summary>
        /// <param name="id">Import invoice ID</param>
        /// <returns></returns>
        public static tb_HoaDonNhap GetImportInvoice(string id)
        {
            return new HoaDonNhapDAL().GetImportInvoice(id);
        }

        /// <summary>
        /// Get an import invoice by order
        /// </summary>
        /// <param name="id">Order ID</param>
        /// <returns></returns>
        public static tb_HoaDonNhap GetImportInvoiceByOrder(string id)
        {
            return GetImportInvoices().FirstOrDefault(x => x.MaPhieuDat.Equals(id));
        }

        /// <summary>
        /// Insert import invoice to database
        /// </summary>
        /// <param name="importInvoice">Import invoice</param>
        /// <param name="importInvoiceDetails">List of import invoice details</param>
        /// <returns></returns>
        public static bool Insert(tb_HoaDonNhap importInvoice, List<tb_ChiTietHDNhap> importInvoiceDetails)
        {
            return new HoaDonNhapDAL().Insert(importInvoice, importInvoiceDetails);
        }

        /// <summary>
        /// Update import invoice to database
        /// </summary>
        /// <param name="importInvoice">Import invoice</param>
        /// <param name="importInvoiceDetails">List of import invoice details</param>
        /// <returns></returns>
        public static bool Update(tb_HoaDonNhap importInvoice, List<tb_ChiTietHDNhap> importInvoiceDetails)
        {
            return new HoaDonNhapDAL().Update(importInvoice, importInvoiceDetails);
        }
    }
}