using DTO;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public class PhieuDatHangDAL
    {
        private readonly PinkCosmetics _dataContext = new PinkCosmetics();

        /// <summary>
        /// Get all of orders
        /// </summary>
        /// <returns></returns>
        public List<tb_PhieuDatHang> GetOrders()
        {
            return _dataContext.tb_PhieuDatHang.ToList();
        }

        /// <summary>
        /// Get an order
        /// </summary>
        /// <param name="id">Order ID</param>
        /// <returns></returns>
        public tb_PhieuDatHang GetOrder(string id)
        {
            return _dataContext.tb_PhieuDatHang.FirstOrDefault(x => x.MaPhieuDat == id);
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
                _dataContext.tb_ChiTietPhieuDat.AddRange(orderDetails);
                _dataContext.tb_PhieuDatHang.Add(order);
                _dataContext.SaveChanges();
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