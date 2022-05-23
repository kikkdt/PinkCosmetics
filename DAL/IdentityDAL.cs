using DTO;
using System;
using System.Linq;

namespace DAL
{
    public class IdentityDAL
    {
        private PinkCosmeticsDataContext dataContext = new PinkCosmeticsDataContext();

        /// <summary>
        /// Get identity from database
        /// </summary>
        /// <param name="parameter">one of {"NhanVien", "SanPham", "HoaDonBan", "HoaDonNhap", "PhieuDatHang"}</param>
        /// <returns></returns>
        /// <exception cref="Invalid parameter"></exception>
        public int GetIdentity(string parameter)
        {
            tb_Identity identify = dataContext.tb_Identities.Select(i => i).FirstOrDefault();
            switch (parameter)
            {
                case "NhanVien":
                    return (int)identify.NhanVien;

                case "SanPham":
                    return (int)identify.SanPham;

                case "HoaDonBan":
                    return (int)identify.HoaDonBan;

                case "HoaDonNhap":
                    return (int)identify.HoaDonNhap;

                case "PhieuDatHang":
                    return (int)identify.PhieuDatHang;

                default: throw new Exception("Invalid parameter.");
            }
        }
    }
}