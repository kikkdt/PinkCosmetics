namespace DTO
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class tb_PhanQuyen
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(30)]
        public string Username { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(60)]
        public string MaChucNang { get; set; }

        public bool? CoQuyen { get; set; }

        public virtual tb_ChucNang tb_ChucNang { get; set; }

        public virtual tb_TaiKhoan tb_TaiKhoan { get; set; }
    }
}