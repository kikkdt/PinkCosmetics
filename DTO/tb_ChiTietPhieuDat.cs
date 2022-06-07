namespace DTO
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class tb_ChiTietPhieuDat
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(7)]
        public string MaPhieuDat { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(7)]
        public string MaSanPham { get; set; }

        public int SoLuong { get; set; }

        public virtual tb_PhieuDatHang tb_PhieuDatHang { get; set; }

        public virtual tb_SanPham tb_SanPham { get; set; }
    }
}