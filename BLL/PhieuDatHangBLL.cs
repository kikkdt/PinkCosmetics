using DAL;
using DTO;
using System.Collections.Generic;

namespace BLL
{
    public class PhieuDatHangBLL
    {
        /// <summary>
        /// Create order ID by concatenating the prefix "PD" with the value selected in the Identity table as the suffix
        /// </summary>
        /// <returns></returns>
        public static string CreateOrderID()
        {
            return $"PD{(IdentityBLL.GetIdentity("PhieuDatHang") + 1).ToString().PadLeft(5, '0')}";
        }

        /// <summary>
        /// Get all of orders
        /// </summary>
        /// <returns></returns>
        public static List<tb_PhieuDatHang> GetOrders()
        {
            return new PhieuDatHangDAL().GetOrders();
        }

        /// <summary>
        /// Get an order
        /// </summary>
        /// <param name="id">Order ID</param>
        /// <returns></returns>
        public static tb_PhieuDatHang GetOrder(string id)
        {
            return new PhieuDatHangDAL().GetOrder(id);
        }

        /// <summary>
        /// Insert order  to database
        /// </summary>
        /// <param name="order">Order</param>
        /// <param name="orderDetails">List of order details</param>
        /// <returns>True if perform successful, false otherwise</returns>
        public static bool Insert(tb_PhieuDatHang order, List<tb_ChiTietPhieuDat> orderDetails)
        {
            return new PhieuDatHangDAL().Insert(order, orderDetails);
        }

        /// <summary>
        /// Update order to database
        /// </summary>
        /// <param name="order">Order</param>
        /// <param name="orderDetails">List of order details</param>
        /// <returns>True if perform successful, false otherwise</returns>
        public static bool Update(tb_PhieuDatHang order)
        {
            return new PhieuDatHangDAL().Update(order);
        }
    }
}