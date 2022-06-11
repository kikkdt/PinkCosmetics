using DTO;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public class PhanQuyenDAL
    {
        private readonly PinkCosmetics _dataContext = new PinkCosmetics();

        /// <summary>
        /// Get permission list by username
        /// </summary>
        /// <param name="username">Username</param>
        /// <returns></returns>
        public List<tb_PhanQuyen> GetPermissions(string username)
        {
            return _dataContext.tb_PhanQuyen.Where(x => x.Username == username).ToList();
        }

        /// <summary>
        /// Get a permission
        /// </summary>
        /// <param name="username">Username</param>
        /// <param name="feature">Feature</param>
        /// <returns></returns>
        public tb_PhanQuyen GetPermission(string username, string feature)
        {
            return _dataContext.tb_PhanQuyen.FirstOrDefault(x => x.Username == username && x.MaChucNang == feature);
        }

        /// <summary>
        /// Update permission in database
        /// </summary>
        /// <param name="permission"></param>
        /// <returns></returns>
        public int Update(tb_PhanQuyen permission)
        {
            try
            {
                tb_PhanQuyen permissionUpdate = GetPermission(permission.Username, permission.MaChucNang);
                permissionUpdate.CoQuyen = permission.CoQuyen;

                return _dataContext.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
    }
}