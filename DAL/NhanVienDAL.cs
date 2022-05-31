using DTO;
using System.Linq;

namespace DAL
{
    public class NhanVienDAL
    {
        private PinkCosmeticsDataContext dataContext = new PinkCosmeticsDataContext();

        /// <summary>
        /// Get a employee by ID
        /// </summary>
        /// <param name="id">Employee ID</param>
        /// <returns>Employee</returns>
        public tb_NhanVien GetEmployee(string id)
        {
            return dataContext.tb_NhanViens.FirstOrDefault(e => e.MaNV.Equals(id));
        }

        /// <summary>
        /// Get a employee by account
        /// </summary>
        /// <param name="username">Username</param>
        /// <returns></returns>
        public tb_NhanVien GetEmployeeByAccount(string username)
        {
            return dataContext.tb_NhanViens.FirstOrDefault(e => e.Username.Equals(username));
        }
    }
}