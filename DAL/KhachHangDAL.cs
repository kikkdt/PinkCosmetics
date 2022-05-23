using DTO;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public class KhachHangDAL
    {
        private PinkCosmeticsDataContext dataContext = new PinkCosmeticsDataContext();

        /// <summary>
        /// Get all customers
        /// </summary>
        /// <returns>List of customers</returns>
        public List<tb_KhachHang> GetCustomers()
        {
            return dataContext.tb_KhachHangs.Where(kh => kh.DaXoa == false).ToList();
        }

        /// <summary>
        /// Get a customer by ID
        /// </summary>
        /// <param name="maKH">Customer ID</param>
        /// <returns></returns>
        public tb_KhachHang GetCustomer(string maKH)
        {
            return dataContext.tb_KhachHangs.FirstOrDefault(kh => kh.MaKH.Equals(maKH));
        }
    }
}