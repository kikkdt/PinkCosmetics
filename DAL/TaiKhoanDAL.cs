using DTO;
using System.Linq;

namespace DAL
{
    public class TaiKhoanDAL
    {
        private PinkCosmeticsDataContext dataContext = new PinkCosmeticsDataContext();

        /// <summary>
        /// Get an account
        /// </summary>
        /// <param name="username">Username</param>
        /// <param name="password">Password</param>
        /// <returns></returns>
        public tb_TaiKhoan GetAccount(string username, string password)
        {
            return dataContext.tb_TaiKhoans.FirstOrDefault(acc => acc.Username.Equals(username) && acc.Password.Equals(password) && acc.DaXoa == false);
        }
    }
}