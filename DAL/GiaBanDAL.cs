using DTO;
using System.Linq;

namespace DAL
{
    public class GiaBanDAL
    {
        private PinkCosmeticsDataContext dataContext = new PinkCosmeticsDataContext();

        /// <summary>
        /// Get price of product
        /// </summary>
        /// <param name="priceTypeID">Price type ID</param>
        /// <param name="productID">Product ID</param>
        /// <returns>The price of product</returns>
        public tb_GiaBan GetPrice(int priceTypeID, string productID)
        {
            return dataContext.tb_GiaBans.FirstOrDefault(p => p.MaBangGia.Equals(priceTypeID) && p.MaSanPham.Equals(productID));
        }
    }
}