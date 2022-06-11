using DAL;
using DTO;
using System.Collections.Generic;

namespace BLL
{
    public class PhanQuyenBLL
    {
        /// <summary>
        /// Get permission list by username
        /// </summary>
        /// <param name="username">Username</param>
        /// <returns></returns>
        public static List<tb_PhanQuyen> GetPermission(string username)
        {
            return new PhanQuyenDAL().GetPermissions(username);
        }

        /// <summary>
        /// Get a permission
        /// </summary>
        /// <param name="username">Username</param>
        /// <param name="feature">Feature</param>
        /// <returns></returns>
        public static tb_PhanQuyen GetPermission(string username, string feature)
        {
            return new PhanQuyenDAL().GetPermission(username, feature);
        }

        /// <summary>
        /// Update permission in database
        /// </summary>
        /// <param name="permission"></param>
        /// <returns></returns>
        public static int Update(tb_PhanQuyen permission)
        {
            return new PhanQuyenDAL().Update(permission);
        }
    }
}