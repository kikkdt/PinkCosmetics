namespace DTO
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class tb_ChiTietHDBan
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(7)]
        public string MaHDBan { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(7)]
        public string MaSanPham { get; set; }

        public int MaBangGia { get; set; }

        public int SoLuong { get; set; }

        [Column(TypeName = "money")]
        public decimal? DonGia { get; set; }

        [Column(TypeName = "money")]
        public decimal? ThanhTien { get; set; }

        public virtual tb_BangGia tb_BangGia { get; set; }

        public virtual tb_SanPham tb_SanPham { get; set; }

        public virtual tb_HoaDonBan tb_HoaDonBan { get; set; }
    }
}