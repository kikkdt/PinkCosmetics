using DTO;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public class PhieuDatHangDAL
    {
        private PinkCosmeticsDataContext dataContext = new PinkCosmeticsDataContext();

        /// <summary>
        /// Get all of orders
        /// </summary>
        /// <returns></returns>
        public List<tb_PhieuDatHang> GetOrders()
        {
            return dataContext.tb_PhieuDatHangs.ToList();
        }

        /// <summary>
        /// Get an order
        /// </summary>
        /// <param name="id">Order ID</param>
        /// <returns></returns>
        public tb_PhieuDatHang GetOrder(string id)
        {
            return dataContext.tb_PhieuDatHangs.FirstOrDefault(x => x.MaPhieuDat.Equals(id));
        }

        /// <summary>
        /// Insert order  to database
        /// </summary>
        /// <param name="order">Order</param>
        /// <param name="orderDetails">List of order details</param>
        /// <returns>True if perform successful, false otherwise</returns>
        public bool Insert(tb_PhieuDatHang order, List<tb_ChiTietPhieuDat> orderDetails)
        {
            try
            {
                order.tb_ChiTietPhieuDats.AddRange(orderDetails);
                dataContext.tb_PhieuDatHangs.InsertOnSubmit(order);
                dataContext.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Update order to database
        /// </summary>
        /// <param name="order">Order</param>
        /// <param name="orderDetails">List of order details</param>
        /// <returns>True if perform successful, false otherwise</returns>
        public bool Update(tb_PhieuDatHang order)
        {
            try
            {
                tb_PhieuDatHang orderUpdate = GetOrder(order.MaPhieuDat);
                orderUpdate.TrangThai = order.TrangThai;
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