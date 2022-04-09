using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class SanPham_BLL
    {
        public static List<SanPham_DTO> GetAllSanPham()
        {
            return SanPham_DAL.GetAllSanPham();
        }
    }
}
