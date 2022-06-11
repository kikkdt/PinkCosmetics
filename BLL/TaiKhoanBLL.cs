using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace BLL
{
    public class TaiKhoanBLL
    {
        /// <summary>
        /// Get a list of accounts
        /// </summary>
        /// <returns></returns>
        public static List<tb_TaiKhoan> GetAccounts()
        {
            return new TaiKhoanDAL().GetAccounts();
        }

        /// <summary>
        /// Get an account
        /// </summary>
        /// <param name="username">Username</param>
        /// <param name="password">Password</param>
        /// <returns></returns>
        public static tb_TaiKhoan GetAccount(string username, string password)
        {
            return new TaiKhoanDAL().GetAccount(username, HashSHA256(password + username));
        }

        /// <summary>
        /// Get an account
        /// </summary>
        /// <param name="username">Username</param>
        /// <returns></returns>
        public static tb_TaiKhoan GetAccount(string username)
        {
            return new TaiKhoanDAL().GetAccount(username);
        }

        public static bool IsValidLogin(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username))
            {
                throw new Exception("Tên đăng nhập không được trống.");
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                throw new Exception("Mật khẩu không được trống.");
            }
            return true;
        }

        public static string HashSHA256(string message)
        {
            // Create a SHA256   
            using (SHA256 sha256 = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                byte[] hashMessages = sha256.ComputeHash(Encoding.UTF8.GetBytes(message));

                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();
                foreach (var b in hashMessages)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }

        public static int ResetPassword(string username)
        {
            var account = GetAccount(username);
            // Hashing before update to database
            string passwordDefault = "123";
            account.Password = HashSHA256(passwordDefault + account.Username);
            return new TaiKhoanDAL().Update(account);
        }

        public static int ChangePassword(string username, string currentPassword, string newPassword, string confirmPassword)
        {
            // Validate the requested form
            if (string.IsNullOrWhiteSpace(currentPassword))
            {
                throw new Exception("Nhập mật khẩu hiện tại");
            }
            if (string.IsNullOrWhiteSpace(newPassword))
            {
                throw new Exception("Nhập mật khẩu mới cần thay đổi");
            }
            if (string.IsNullOrWhiteSpace(confirmPassword))
            {
                throw new Exception("Nhập lại mật khẩu mới cần thay đổi");
            }

            // Validate user
            var account = GetAccount(username, currentPassword);
            if (account == null)
            {
                throw new Exception("Tên đăng nhập hoặc mật khẩu hiện tại không đúng");
            }

            if (newPassword.CompareTo(confirmPassword) != 0)
            {
                throw new Exception("Mật khẩu không trùng khớp");
            }

            // Hashing before update new password
            account.Password = HashSHA256(newPassword + username);
            return new TaiKhoanDAL().Update(account);
        }

        public static int Delete(string username)
        {
            var account = GetAccount(username);
            account.DaXoa = true;
            return new TaiKhoanDAL().Update(account);
        }
    }
}