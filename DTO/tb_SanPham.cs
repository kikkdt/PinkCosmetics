namespace DTO
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class tb_SanPham
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_SanPham()
        {
            tb_ChiTietHDBan = new HashSet<tb_ChiTietHDBan>();
            tb_ChiTietHDNhap = new HashSet<tb_ChiTietHDNhap>();
            tb_ChiTietPhieuDat = new HashSet<tb_ChiTietPhieuDat>();
            tb_GiaBan = new HashSet<tb_GiaBan>();
        }

        [Key]
        [StringLength(7)]
        public string MaSanPham { get; set; }

        [StringLength(20)]
        public string MaVach { get; set; }

        [Required]
        [StringLength(120)]
        public string TenSP { get; set; }

        public int MaNSP { get; set; }

        public int? MaThuongHieu { get; set; }

        [Column(TypeName = "money")]
        public decimal? GiaVon { get; set; }

        public int? TonKho { get; set; }

        public int? DaMua { get; set; }

        [StringLength(1000)]
        public string UrlHinh { get; set; }

        public string MoTa { get; set; }

        public bool? DaXoa { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_ChiTietHDBan> tb_ChiTietHDBan { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_ChiTietHDNhap> tb_ChiTietHDNhap { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_ChiTietPhieuDat> tb_ChiTietPhieuDat { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_GiaBan> tb_GiaBan { get; set; }

        public virtual tb_NhomSanPham tb_NhomSanPham { get; set; }

        public virtual tb_ThuongHieu tb_ThuongHieu { get; set; }
    }
}