namespace DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class tb_HoaDonNhap
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_HoaDonNhap()
        {
            tb_ChiTietHDNhap = new HashSet<tb_ChiTietHDNhap>();
        }

        [Key]
        [StringLength(7)]
        public string MaHDNhap { get; set; }

        [StringLength(7)]
        public string MaPhieuDat { get; set; }

        [StringLength(7)]
        public string MaNV { get; set; }

        public DateTime NgayLap { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_ChiTietHDNhap> tb_ChiTietHDNhap { get; set; }

        public virtual tb_PhieuDatHang tb_PhieuDatHang { get; set; }

        public virtual tb_NhanVien tb_NhanVien { get; set; }
    }
}