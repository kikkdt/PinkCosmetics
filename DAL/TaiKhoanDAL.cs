using DTO;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public class TaiKhoanDAL
    {
        private readonly PinkCosmetics _dataContext = new PinkCosmetics();

        /// <summary>
        /// Get a list of accounts
        /// </summary>
        /// <returns></returns>
        public List<tb_TaiKhoan> GetAccounts()
        {
            return _dataContext.tb_TaiKhoan.Where(account => account.DaXoa == false).ToList();
        }

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

        /// <summary>
        /// Get an account
        /// </summary>
        /// <param name="username">Username</param>
        /// <returns></returns>
        public tb_TaiKhoan GetAccount(string username)
        {
            return _dataContext.tb_TaiKhoan.FirstOrDefault(acc => acc.Username == username && acc.DaXoa == false);
        }

        /// <summary>
        /// Update account
        /// </summary>
        /// <param name="account">Account</param>
        /// <returns></returns>
        public int Update(tb_TaiKhoan account)
        {
            tb_TaiKhoan accountUpdate = GetAccount(account.Username);
            accountUpdate.Password = account.Password;
            accountUpdate.DaXoa = account.DaXoa;

            return _dataContext.SaveChanges();
        }
    }
}