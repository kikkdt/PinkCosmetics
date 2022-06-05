using DAL;
using DTO;
using System.Collections.Generic;

namespace BLL
{
    public class NhomSanPhamBLL
    {
        /// <summary>
        /// Get all product groups
        /// </summary>
        /// <returns>List of product groups</returns>
        public static List<tb_NhomSanPham> GetProductGroups()
        {
            return new NhomSanPhamDAL().GetProductGroups();
        }

        /// <summary>
        /// Get product groups by ID
        /// </summary>
        /// <param name="id">Product groups ID</param>
        /// <returns>Product groups</returns>
        public static tb_NhomSanPham GetProductGroups(int id)
        {
            return new NhomSanPhamDAL().GetProductGroups(id);
        }
    }
}