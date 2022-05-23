using DAL;
using DTO;
using System.Collections.Generic;

namespace BLL
{
    public class SanPhamBLL
    {
        /// <summary>
        /// Get all list of products
        /// </summary>
        /// <returns>List of products</returns>
        public static List<tb_SanPham> GetProducts()
        {
            return new SanPhamDAL().GetProducts();
        }

        /// <summary>
        /// Get a product by ID
        /// </summary>
        /// <param name="maSanPham">Product ID</param>
        /// <returns></returns>
        public static tb_SanPham GetProduct(string maSanPham)
        {
            return new SanPhamDAL().GetProduct(maSanPham);
        }
    }
}