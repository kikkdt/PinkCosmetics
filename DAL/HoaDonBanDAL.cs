using DTO;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public class HoaDonBanDAL
    {
        private readonly PinkCosmetics _dataContext = new PinkCosmetics();

        /// <summary>
        /// Get all sales invoice
        /// </summary>
        /// <returns>List of sales invoices</returns>
        public List<tb_HoaDonBan> GetSalesInvoices()
        {
            return _dataContext.tb_HoaDonBan.ToList();
        }

        /// <summary>
        /// Insert sales invoice to database
        /// </summary>
        /// <param name="salesInvoice">Sales invoice</param>
        /// <param name="salesInvoiceDetails">List of sales invoice detail</param>
        /// <returns></returns>
        public bool Insert(tb_HoaDonBan salesInvoice, List<tb_ChiTietHDBan> salesInvoiceDetails)
        {
            try
            {
                _dataContext.tb_ChiTietHDBan.AddRange(salesInvoiceDetails);
                _dataContext.tb_HoaDonBan.Add(salesInvoice);
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