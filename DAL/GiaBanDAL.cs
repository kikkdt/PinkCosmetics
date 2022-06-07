using DTO;
using System.Linq;

namespace DAL
{
    public class GiaBanDAL
    {
        private readonly PinkCosmetics _dataContext = new PinkCosmetics();

        /// <summary>
        /// Get price of product
        /// </summary>
        /// <param name="priceTypeID">Price type ID</param>
        /// <param name="productID">Product ID</param>
        /// <returns>The price of product</returns>
        public tb_GiaBan GetPrice(int priceTypeID, string productID)
        {
            return _dataContext.tb_GiaBan.FirstOrDefault(p => p.MaBangGia == priceTypeID && p.MaSanPham == productID);
        }
    }
}