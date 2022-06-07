namespace DTO
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("ViewChiTietPhieuDatHang")]
    public partial class ViewChiTietPhieuDatHang
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(7)]
        public string MaPhieuDat { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(7)]
        public string MaSanPham { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SoLuong { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(120)]
        public string TenSP { get; set; }
    }
}