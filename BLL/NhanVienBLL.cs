using DAL;
using DTO;
using System.Collections.Generic;

namespace BLL
{
    public class NhanVienBLL
    {
        /// <summary>
        /// Get a list of employees
        /// </summary>
        /// <returns></returns>
        public static List<tb_NhanVien> GetEmployees()
        {
            return new NhanVienDAL().GetEmployees();
        }

        /// <summary>
        /// Get a employee by ID
        /// </summary>
        /// <param name="id">Employee ID</param>
        /// <returns>Employee</returns>
        public static tb_NhanVien GetEmployee(string id)
        {
            return new NhanVienDAL().GetEmployee(id);
        }

        /// <summary>
        /// Get a employee by account
        /// </summary>
        /// <param name="username">Username</param>
        /// <returns></returns>
        public static tb_NhanVien GetEmployeeByAccount(string username)
        {
            return new NhanVienDAL().GetEmployeeByAccount(username);
        }
    }
}