namespace DTO
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class tb_TaiKhoan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_TaiKhoan()
        {
            tb_NhanVien = new HashSet<tb_NhanVien>();
        }

        [Key]
        [StringLength(30)]
        public string Username { get; set; }

        [Required]
        [StringLength(1000)]
        public string Password { get; set; }

        public bool? IsAdmin { get; set; }

        public bool? DaXoa { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_NhanVien> tb_NhanVien { get; set; }
    }
}