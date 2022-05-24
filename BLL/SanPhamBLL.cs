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
        /// <param name="id">Product ID</param>
        /// <returns></returns>
        public static tb_SanPham GetProduct(string id)
        {
            return new SanPhamDAL().GetProduct(id);
        }

        /// <summary>
        /// Validate the quantity want to get
        /// </summary>
        /// <param name="id">Product ID</param>
        /// <param name="quantity">Quantity want to get</param>
        /// <returns></returns>
        public static bool IsValidQuantityToGet(string id, int quantity)
        {
            return quantity >= 0 && quantity <= GetProduct(id).TonKho;
        }
    }
}