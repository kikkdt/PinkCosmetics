using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SanPham_DAL
    {
        public static List<SanPham_DTO> GetAllSanPham()
        {
            using (var dataContext = new DataClassesDataContext())
            {
                return (from product in dataContext.tb_SanPhams select new SanPham_DTO(product.MaSanPham, product.MaVach, product.TenSP, product.MaNSP, (int)product.MaThuongHieu, (double)product.GiaVon, (int)product.TonKho, (int)product.DaMua, product.UrlHinh, product.MoTa, (bool)product.DaXoa)).ToList();
            }
        }
    }
}
