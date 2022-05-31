using DAL;
using DTO;
using System.Collections.Generic;

namespace BLL
{
    public class KhachHangBLL
    {
        /// <summary>
        /// Get all customers
        /// </summary>
        /// <returns>List of customers</returns>
        public static List<tb_KhachHang> GetCustomers()
        {
            return new KhachHangDAL().GetCustomers();
        }

        /// <summary>
        /// Get a customer by ID
        /// </summary>
        /// <param name="maKH">Customer ID</param>
        /// <returns></returns>
        public static tb_KhachHang GetCustomer(string maKH)
        {
            return new KhachHangDAL().GetCustomer(maKH);
        }

        /// <summary>
        /// Verify the loyalty points want to use
        /// </summary>
        /// <param name="customer">Customer</param>
        /// <param name="loyaltyUse">Loyalty points want to use</param>
        /// <returns></returns>
        public static bool IsValidLoyaltyUse(tb_KhachHang customer, int loyaltyUse)
        {
            return loyaltyUse >= 0 && loyaltyUse <= customer.DiemTichLuy;
        }

        /// <summary>
        /// Update customer
        /// </summary>
        /// <param name="customer">Customer</param>
        /// <returns>True if perform successful, false otherwise</returns>
        public static bool Update(tb_KhachHang customer)
        {
            return new KhachHangDAL().Update(customer);
        }
    }
}