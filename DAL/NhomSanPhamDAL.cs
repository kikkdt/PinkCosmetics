using DTO;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public class NhomSanPhamDAL
    {
        private readonly PinkCosmetics _dataContext = new PinkCosmetics();

        /// <summary>
        /// Get all product groups
        /// </summary>
        /// <returns>List of product groups</returns>
        public List<tb_NhomSanPham> GetProductGroups()
        {
            return _dataContext.tb_NhomSanPham.Where(x => x.DaXoa == false).ToList();
        }

        /// <summary>
        /// Get product groups by ID
        /// </summary>
        /// <param name="id">Product groups ID</param>
        /// <returns>Product groups</returns>
        public tb_NhomSanPham GetProductGroups(int id)
        {
            return _dataContext.tb_NhomSanPham.FirstOrDefault(x => x.MaNSP == id);
        }

        /// <summary>
        /// Insert into database
        /// </summary>
        /// <param name="productGroup"></param>
        /// <returns></returns>
        public int Insert(tb_NhomSanPham productGroup)
        {
            _dataContext.tb_NhomSanPham.Add(productGroup);
            return _dataContext.SaveChanges();
        }

        /// <summary>
        /// Update in database
        /// </summary>
        /// <param name="productGroup"></param>
        /// <returns></returns>
        public int Update(tb_NhomSanPham productGroup)
        {
            var productGroupUpdate = GetProductGroups(productGroup.MaNSP);
            productGroupUpdate.TenNSP = productGroup.TenNSP;
            productGroupUpdate.NSPCha = productGroup.NSPCha;
            productGroupUpdate.DaXoa = productGroup.DaXoa;
            return _dataContext.SaveChanges();
        }
    }
}