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

        /// <summary>
        /// Update product
        /// </summary>
        /// <param name="product">Product</param>
        /// <returns>True if perform successful, false otherwise</returns>
        public bool Update(tb_SanPham product)
        {
            try
            {
                tb_SanPham productUpdate = GetProduct(product.MaSanPham);
                productUpdate.MaVach = product.MaVach;
                productUpdate.TenSP = product.TenSP;
                productUpdate.MaNSP = product.MaNSP;
                productUpdate.MaThuongHieu = product.MaThuongHieu;
                productUpdate.GiaVon = product.GiaVon;
                productUpdate.TonKho = product.TonKho;
                productUpdate.DaMua = product.DaMua;
                productUpdate.UrlHinh = product.UrlHinh;
                productUpdate.MoTa = product.MoTa;
                productUpdate.DaXoa = product.DaXoa;
                dataContext.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}