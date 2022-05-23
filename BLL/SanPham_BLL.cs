using DAL;
using DTO;
using System.Collections.Generic;

namespace BLL
{
    public class SanPham_BLL
    {
        public static List<tb_SanPham> GetAllSanPham()
        {
            return SanPham_DAL.GetAllSanPham();
        }
    }
}