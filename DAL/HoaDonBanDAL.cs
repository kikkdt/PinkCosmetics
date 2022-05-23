using DTO;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public class HoaDonBanDAL
    {
        private PinkCosmeticsDataContext dataContext = new PinkCosmeticsDataContext();

        /// <summary>
        /// Get all sales invoice
        /// </summary>
        /// <returns>List of sales invoices</returns>
        public List<tb_HoaDonBan> GetSalesInvoices()
        {
            return dataContext.tb_HoaDonBans.ToList();
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
                salesInvoice.tb_ChiTietHDBans.AddRange(salesInvoiceDetails);
                dataContext.tb_HoaDonBans.InsertOnSubmit(salesInvoice);
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