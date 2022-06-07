namespace DTO
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class tb_BangGia
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_BangGia()
        {
            tb_ChiTietHDBan = new HashSet<tb_ChiTietHDBan>();
            tb_GiaBan = new HashSet<tb_GiaBan>();
        }

        [Key]
        public int MaBangGia { get; set; }

        [Required]
        [StringLength(60)]
        public string TenBangGia { get; set; }

        public bool? DaXoa { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_ChiTietHDBan> tb_ChiTietHDBan { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_GiaBan> tb_GiaBan { get; set; }
    }
}