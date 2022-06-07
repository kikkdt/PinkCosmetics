namespace DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class tb_PhieuDatHang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_PhieuDatHang()
        {
            tb_ChiTietPhieuDat = new HashSet<tb_ChiTietPhieuDat>();
            tb_HoaDonNhap = new HashSet<tb_HoaDonNhap>();
        }

        [Key]
        [StringLength(7)]
        public string MaPhieuDat { get; set; }

        [Required]
        [StringLength(7)]
        public string MaNV { get; set; }

        public DateTime NgayLap { get; set; }

        public bool? TrangThai { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_ChiTietPhieuDat> tb_ChiTietPhieuDat { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_HoaDonNhap> tb_HoaDonNhap { get; set; }

        public virtual tb_NhanVien tb_NhanVien { get; set; }
    }
}