using DTO;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public class ThuongHieuDAL
    {
        private readonly PinkCosmetics _dataContext = new PinkCosmetics();

        /// <summary>
        /// Get all brands
        /// </summary>
        /// <returns>List of brands</returns>
        public List<tb_ThuongHieu> GetBrands()
        {
            return _dataContext.tb_ThuongHieu.Where(x => x.DaXoa == false).ToList();
        }

        /// <summary>
        /// Get brand by ID
        /// </summary>
        /// <param name="id">Brand ID</param>
        /// <returns>Brand</returns>
        public tb_ThuongHieu GetBrand(int id)
        {
            return _dataContext.tb_ThuongHieu.FirstOrDefault(x => x.MaThuongHieu == id);
        }
    }
}