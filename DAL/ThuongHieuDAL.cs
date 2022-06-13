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

        /// <summary>
        /// Insert into database
        /// </summary>
        /// <param name="brand"></param>
        /// <returns></returns>
        public int Insert(tb_ThuongHieu brand)
        {
            _dataContext.tb_ThuongHieu.Add(brand);
            return _dataContext.SaveChanges();
        }

        /// <summary>
        /// Update in database
        /// </summary>
        /// <param name="brand"></param>
        /// <returns></returns>
        public int Update(tb_ThuongHieu brand)
        {
            var brandUpdate = GetBrand(brand.MaThuongHieu);
            brandUpdate.TenThuongHieu = brand.TenThuongHieu;
            brandUpdate.DaXoa = brand.DaXoa;
            return _dataContext.SaveChanges();
        }
    }
}