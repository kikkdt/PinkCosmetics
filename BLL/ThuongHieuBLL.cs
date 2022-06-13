using System;
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

        /// <summary>
        /// Insert into database
        /// </summary>
        /// <param name="brand"></param>
        /// <returns></returns>
        public static int Insert(tb_ThuongHieu brand)
        {
            if (string.IsNullOrEmpty(brand.TenThuongHieu))
            {
                throw new Exception("Nhập tên thương hiệu");
            }

            return new ThuongHieuDAL().Insert(brand);
        }

        /// <summary>
        /// Update in database
        /// </summary>
        /// <param name="brand"></param>
        /// <returns></returns>
        public static int Update(tb_ThuongHieu brand)
        {
            if (string.IsNullOrEmpty(brand.TenThuongHieu))
            {
                throw new Exception("Nhập tên thương hiệu");
            }

            return new ThuongHieuDAL().Update(brand);
        }

        /// <summary>
        /// Delete in database
        /// </summary>
        /// <param name="brand"></param>
        /// <returns></returns>
        public static int Delete(int id)
        {
            var brand = GetBrand(id);
            brand.DaXoa = true;
            return new ThuongHieuDAL().Update(brand);
        }
    }
}