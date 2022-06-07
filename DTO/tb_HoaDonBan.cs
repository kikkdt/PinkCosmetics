namespace DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class tb_HoaDonBan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_HoaDonBan()
        {
            tb_ChiTietHDBan = new HashSet<tb_ChiTietHDBan>();
        }

        [Key]
        [StringLength(7)]
        public string MaHDBan { get; set; }

        [Required]
        [StringLength(7)]
        public string MaNV { get; set; }

        [StringLength(7)]
        public string MaKH { get; set; }

        public DateTime NgayLap { get; set; }

        [Column(TypeName = "money")]
        public decimal? TongTien { get; set; }

        [Column(TypeName = "money")]
        public decimal? GiamGia { get; set; }

        [Column(TypeName = "money")]
        public decimal? ThanhTien { get; set; }

        public bool? TrangThai { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_ChiTietHDBan> tb_ChiTietHDBan { get; set; }

        public virtual tb_KhachHang tb_KhachHang { get; set; }

        public virtual tb_NhanVien tb_NhanVien { get; set; }
    }
}