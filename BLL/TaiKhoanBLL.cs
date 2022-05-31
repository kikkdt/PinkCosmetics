using DAL;
using DTO;
using System;

namespace BLL
{
    public class TaiKhoanBLL
    {
        /// <summary>
        /// Get an account
        /// </summary>
        /// <param name="username">Username</param>
        /// <param name="password">Password</param>
        /// <returns></returns>
        public static tb_TaiKhoan GetAccount(string username, string password)
        {
            return new TaiKhoanDAL().GetAccount(username, password);
        }

        public static bool IsValidLogin(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username))
            {
                throw new Exception("Tên đăng nhập không được trống.");
            }
            else if (string.IsNullOrWhiteSpace(password))
            {
                throw new Exception("Mật khẩu không được trống.");
            }
            else { return true; }
        }
    }
}