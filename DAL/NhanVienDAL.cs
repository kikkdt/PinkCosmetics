using DTO;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public class NhanVienDAL
    {
        private readonly PinkCosmetics _dataContext = new PinkCosmetics();

        /// <summary>
        /// Get a list of employees
        /// </summary>
        /// <returns></returns>
        public List<tb_NhanVien> GetEmployees()
        {
            return _dataContext.tb_NhanVien.Where(x => x.DaXoa == false).ToList();
        }

        /// <summary>
        /// Get a employee by ID
        /// </summary>
        /// <param name="id">Employee ID</param>
        /// <returns>Employee</returns>
        public tb_NhanVien GetEmployee(string id)
        {
            return _dataContext.tb_NhanVien.FirstOrDefault(e => e.MaNV == id);
        }

        /// <summary>
        /// Get a employee by account
        /// </summary>
        /// <param name="username">Username</param>
        /// <returns></returns>
        public tb_NhanVien GetEmployeeByAccount(string username)
        {
            return _dataContext.tb_NhanVien.FirstOrDefault(e => e.Username == username);
        }
    }
}