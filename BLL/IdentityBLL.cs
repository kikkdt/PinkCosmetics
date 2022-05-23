using DAL;

namespace BLL
{
    public class IdentityBLL
    {
        /// <summary>
        /// Get identity from database
        /// </summary>
        /// <param name="parameter">one of {"NhanVien", "SanPham", "HoaDonBan", "HoaDonNhap", "PhieuDatHang"}</param>
        /// <returns></returns>
        /// <exception cref="Invalid parameter"></exception>
        public static int GetIdentity(string parameter)
        {
            return new IdentityDAL().GetIdentity(parameter);
        }
    }
}