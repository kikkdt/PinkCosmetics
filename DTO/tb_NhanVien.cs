namespace DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class tb_NhanVien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_NhanVien()
        {
            tb_HoaDonBan = new HashSet<tb_HoaDonBan>();
            tb_HoaDonNhap = new HashSet<tb_HoaDonNhap>();
            tb_PhieuDatHang = new HashSet<tb_PhieuDatHang>();
        }

        [Key]
        [StringLength(7)]
        public string MaNV { get; set; }

        [Required]
        [StringLength(60)]
        public string HoTen { get; set; }

        [Required]
        [StringLength(3)]
        public string GioiTinh { get; set; }

        [Required]
        [StringLength(10)]
        public string DienThoai { get; set; }

        public DateTime NgaySinh { get; set; }

        [Required]
        [StringLength(30)]
        public string Username { get; set; }

        [StringLength(120)]
        public string DiaChi { get; set; }

        public bool? DaXoa { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_HoaDonBan> tb_HoaDonBan { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_HoaDonNhap> tb_HoaDonNhap { get; set; }

        public virtual tb_TaiKhoan tb_TaiKhoan { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_PhieuDatHang> tb_PhieuDatHang { get; set; }
    }
}