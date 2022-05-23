using DAL;
using DTO;

namespace BLL
{
    public class NhanVienBLL
    {
        /// <summary>
        /// Get a employee by ID
        /// </summary>
        /// <param name="id">Employee ID</param>
        /// <returns>Employee</returns>
        public static tb_NhanVien GetEmployee(string id)
        {
            return new NhanVienDAL().GetEmployee(id);
        }
    }
}