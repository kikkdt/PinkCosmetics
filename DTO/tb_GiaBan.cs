namespace DTO
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class tb_GiaBan
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaBangGia { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(7)]
        public string MaSanPham { get; set; }

        [Column(TypeName = "money")]
        public decimal GiaBan { get; set; }

        public virtual tb_BangGia tb_BangGia { get; set; }

        public virtual tb_SanPham tb_SanPham { get; set; }
    }
}