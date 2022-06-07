namespace DTO
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class tb_ThuongHieu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_ThuongHieu()
        {
            tb_SanPham = new HashSet<tb_SanPham>();
        }

        [Key]
        public int MaThuongHieu { get; set; }

        [Required]
        [StringLength(120)]
        public string TenThuongHieu { get; set; }

        public bool? DaXoa { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_SanPham> tb_SanPham { get; set; }
    }
}