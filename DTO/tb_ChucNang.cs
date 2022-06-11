namespace DTO
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class tb_ChucNang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_ChucNang()
        {
            tb_ChucNang1 = new HashSet<tb_ChucNang>();
            tb_PhanQuyen = new HashSet<tb_PhanQuyen>();
        }

        [Key]
        [StringLength(60)]
        public string MaChucNang { get; set; }

        [StringLength(120)]
        public string TenChucNang { get; set; }

        [StringLength(60)]
        public string ChucNangCha { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_ChucNang> tb_ChucNang1 { get; set; }

        public virtual tb_ChucNang tb_ChucNang2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_PhanQuyen> tb_PhanQuyen { get; set; }
    }
}