using DTO;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public class SanPham_DAL
    {
        public static List<tb_SanPham> GetAllSanPham()
        {
            using (var dataContext = new PinkCosmeticsDataContext())
            {
                return dataContext.tb_SanPhams.Select(sp => sp).ToList();
            }
        }
    }
}