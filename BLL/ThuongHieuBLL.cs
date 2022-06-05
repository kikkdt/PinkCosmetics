using DAL;
using DTO;
using System.Collections.Generic;

namespace BLL
{
    public class ThuongHieuBLL
    {
        /// <summary>
        /// Get all brands
        /// </summary>
        /// <returns>List of brands</returns>
        public static List<tb_ThuongHieu> GetBrands()
        {
            return new ThuongHieuDAL().GetBrands();
        }

        /// <summary>
        /// Get brand by ID
        /// </summary>
        /// <param name="id">Brand ID</param>
        /// <returns>Brand</returns>
        public static tb_ThuongHieu GetBrand(int id)
        {
            return new ThuongHieuDAL().GetBrand(id);
        }
    }
}