using DAL;
using DTO;

namespace BLL
{
    public class GiaBanBLL
    {
        /// <summary>
        /// Get price of product
        /// </summary>
        /// <param name="priceTypeID">Price type ID</param>
        /// <param name="productID">Product ID</param>
        /// <returns>The price of product</returns>
        public static tb_GiaBan GetPrice(int priceTypeID, string productID)
        {
            return new GiaBanDAL().GetPrice(priceTypeID, productID);
        }
    }
}