using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

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
            return dataContext.tb_TaiKhoans.FirstOrDefault(acc => string.Compare(acc.Username, username, true) == 0 && acc.Password.Equals(password));
        }
    }
}
