using DTO;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public class NhomSanPhamDAL
    {
        private PinkCosmeticsDataContext dataContext = new PinkCosmeticsDataContext();

        /// <summary>
        /// Get all product groups
        /// </summary>
        /// <returns>List of product groups</returns>
        public List<tb_NhomSanPham> GetProductGroups()
        {
            return dataContext.tb_NhomSanPhams.Where(x => x.DaXoa == false).ToList();
        }

        /// <summary>
        /// Get product groups by ID
        /// </summary>
        /// <param name="id">Product groups ID</param>
        /// <returns>Product groups</returns>
        public tb_NhomSanPham GetProductGroups(int id)
        {
            return dataContext.tb_NhomSanPhams.FirstOrDefault(x => x.MaNSP == id);
        }
    }
}