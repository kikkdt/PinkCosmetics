using DTO;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public class KhachHangDAL
    {
        private readonly PinkCosmetics _dataContext = new PinkCosmetics();

        /// <summary>
        /// Get all customers
        /// </summary>
        /// <returns>List of customers</returns>
        public List<tb_KhachHang> GetCustomers()
        {
            return _dataContext.tb_KhachHang.Where(customer => customer.DaXoa == false).ToList();
        }

        /// <summary>
        /// Get a customer by ID
        /// </summary>
        /// <param name="id">Customer ID</param>
        /// <returns></returns>
        public tb_KhachHang GetCustomer(string id)
        {
            return _dataContext.tb_KhachHang.FirstOrDefault(kh => kh.MaKH == id);
        }

        /// <summary>
        /// Update customer
        /// </summary>
        /// <param name="customer">Customer</param>
        /// <returns>True if perform successful, false otherwise</returns>
        public bool Update(tb_KhachHang customer)
        {
            try
            {
                tb_KhachHang customerUpdate = GetCustomer(customer.MaKH);
                customerUpdate.HoTen = customer.HoTen;
                customerUpdate.GioiTinh = customer.GioiTinh;
                customerUpdate.DienThoai = customer.DienThoai;
                customerUpdate.NgaySinh = customer.NgaySinh;
                customerUpdate.DiaChi = customer.DiaChi;
                customerUpdate.DiemTichLuy = customer.DiemTichLuy;
                customerUpdate.DaXoa = customer.DaXoa;
                _dataContext.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}