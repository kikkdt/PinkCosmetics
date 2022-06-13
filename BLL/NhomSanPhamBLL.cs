using DAL;
using DTO;
using System;
using System.Collections.Generic;

namespace BLL
{
    public class NhomSanPhamBLL
    {
        /// <summary>
        /// Get all product groups
        /// </summary>
        /// <returns>List of product groups</returns>
        public static List<tb_NhomSanPham> GetProductGroups()
        {
            return new NhomSanPhamDAL().GetProductGroups();
        }

        /// <summary>
        /// Get product groups by ID
        /// </summary>
        /// <param name="id">Product groups ID</param>
        /// <returns>Product groups</returns>
        public static tb_NhomSanPham GetProductGroups(int id)
        {
            return new NhomSanPhamDAL().GetProductGroups(id);
        }

        /// <summary>
        /// Insert into database
        /// </summary>
        /// <param name="productGroup"></param>
        /// <returns></returns>
        public static int Insert(tb_NhomSanPham productGroup)
        {
            if (string.IsNullOrEmpty(productGroup.TenNSP))
            {
                throw new Exception("Nhập tên nhóm hàng");
            }

            if (productGroup.NSPCha != null && GetProductGroups((int)productGroup.NSPCha) == null)
            {
                throw new Exception("Nhóm hàng cha không hợp lệ");
            }

            return new NhomSanPhamDAL().Insert(productGroup);
        }

        /// <summary>
        /// Update in database
        /// </summary>
        /// <param name="productGroup"></param>
        /// <returns></returns>
        public static int Update(tb_NhomSanPham productGroup)
        {
            if (string.IsNullOrEmpty(productGroup.TenNSP))
            {
                throw new Exception("Nhập tên nhóm hàng");
            }

            if (productGroup.NSPCha != null && GetProductGroups((int)productGroup.NSPCha) == null)
            {
                throw new Exception("Nhóm hàng cha không hợp lệ");
            }

            return new NhomSanPhamDAL().Update(productGroup);
        }

        /// <summary>
        /// Update in database
        /// </summary>
        /// <param name="productGroup"></param>
        /// <returns></returns>
        public static int Delete(int productGroupId)
        {
            var productGroup = GetProductGroups(productGroupId);
            productGroup.DaXoa = true;
            return new NhomSanPhamDAL().Update(productGroup);
        }
    }
}