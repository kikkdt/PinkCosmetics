namespace DTO
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class tb_ChiTietHDNhap
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(7)]
        public string MaHDNhap { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(7)]
        public string MaSanPham { get; set; }

        public int SoLuong { get; set; }

        [Column(TypeName = "money")]
        public decimal? GiaNhap { get; set; }

        [Column(TypeName = "money")]
        public decimal? ThanhTien { get; set; }

        public virtual tb_HoaDonNhap tb_HoaDonNhap { get; set; }

        public virtual tb_SanPham tb_SanPham { get; set; }
    }
}