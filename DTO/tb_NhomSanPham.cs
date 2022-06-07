namespace DTO
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class tb_NhomSanPham
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_NhomSanPham()
        {
            tb_NhomSanPham1 = new HashSet<tb_NhomSanPham>();
            tb_SanPham = new HashSet<tb_SanPham>();
        }

        [Key]
        public int MaNSP { get; set; }

        [Required]
        [StringLength(60)]
        public string TenNSP { get; set; }

        public int? NSPCha { get; set; }

        public bool? DaXoa { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_NhomSanPham> tb_NhomSanPham1 { get; set; }

        public virtual tb_NhomSanPham tb_NhomSanPham2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_SanPham> tb_SanPham { get; set; }
    }
}