using DTO;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public class SanPhamDAL
    {
        private PinkCosmeticsDataContext dataContext = new PinkCosmeticsDataContext();

        /// <summary>
        /// Get all list of products
        /// </summary>
        /// <returns>List of products</returns>
        public List<tb_SanPham> GetProducts()
        {
            return dataContext.tb_SanPhams.Where(p => p.DaXoa.Equals(false)).ToList();
        }

        /// <summary>
        /// Get a product by ID
        /// </summary>
        /// <param name="id">Product ID</param>
        /// <returns></returns>
        public tb_SanPham GetProduct(string id)
        {
            return dataContext.tb_SanPhams.FirstOrDefault(p => p.MaSanPham.Equals(id));
        }
    }
}