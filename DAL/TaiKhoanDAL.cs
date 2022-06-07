using DTO;
using System.Linq;

namespace DAL
{
    public class TaiKhoanDAL
    {
        private readonly PinkCosmetics _dataContext = new PinkCosmetics();

        /// <summary>
        /// Get an account
        /// </summary>
        /// <param name="username">Username</param>
        /// <param name="password">Password</param>
        /// <returns></returns>
        public tb_TaiKhoan GetAccount(string username, string password)
        {
            return _dataContext.tb_TaiKhoan.FirstOrDefault(acc => acc.Username == username && acc.Password == password && acc.DaXoa == false);
        }
    }
}