using DAL;
using DTO;
using System.Collections.Generic;

namespace BLL
{
    public class HoaDonBanHangBLL
    {
        /// <summary>
        /// Create sales invoice ID by concatenating the prefix "HD" with the value selected in the Identity table as the suffix
        /// </summary>
        /// <returns></returns>
        public static string CreateSalesInvoiceID()
        {
            return $"HD{(IdentityBLL.GetIdentity("HoaDonBan") + 1).ToString().PadLeft(5, '0')}";
        }

        /// <summary>
        /// Get all sales invoice
        /// </summary>
        /// <returns>List of sales invoices</returns>
        public static List<tb_HoaDonBan> GetSalesInvoices()
        {
            return new HoaDonBanDAL().GetSalesInvoices();
        }

        /// <summary>
        /// Insert sales invoice to database
        /// </summary>
        /// <param name="salesInvoice">Sales invoice</param>
        /// <param name="salesInvoiceDetails">List of sales invoice detail</param>
        /// <returns></returns>
        public static bool Insert(tb_HoaDonBan salesInvoice, List<tb_ChiTietHDBan> salesInvoiceDetails)
        {
            salesInvoice.TrangThai = true;
            return new HoaDonBanDAL().Insert(salesInvoice, salesInvoiceDetails);
        }
    }
}