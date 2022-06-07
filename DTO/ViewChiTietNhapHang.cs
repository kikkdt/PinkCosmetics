namespace DTO
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("ViewChiTietNhapHang")]
    public partial class ViewChiTietNhapHang
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(7)]
        public string MaSanPham { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(120)]
        public string TenSP { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SoLuongDat { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SoLuongNhap { get; set; }

        [Column(TypeName = "money")]
        public decimal? GiaNhap { get; set; }

        [Column(TypeName = "money")]
        public decimal? ThanhTien { get; set; }
    }
}