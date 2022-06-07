namespace DTO
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("ViewPhieuDatHang")]
    public partial class ViewPhieuDatHang
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(7)]
        public string MaPhieuDat { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(7)]
        public string MaNV { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime NgayLap { get; set; }

        public bool? TrangThai { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(60)]
        public string HoTen { get; set; }
    }
}