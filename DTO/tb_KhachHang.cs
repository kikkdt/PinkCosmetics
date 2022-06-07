namespace DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class tb_KhachHang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_KhachHang()
        {
            tb_HoaDonBan = new HashSet<tb_HoaDonBan>();
        }

        [Key]
        [StringLength(7)]
        public string MaKH { get; set; }

        [Required]
        [StringLength(60)]
        public string HoTen { get; set; }

        [Required]
        [StringLength(3)]
        public string GioiTinh { get; set; }

        [Required]
        [StringLength(10)]
        public string DienThoai { get; set; }

        public DateTime? NgaySinh { get; set; }

        [StringLength(120)]
        public string DiaChi { get; set; }

        public int? DiemTichLuy { get; set; }

        public bool? DaXoa { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_HoaDonBan> tb_HoaDonBan { get; set; }
    }
}