using System.Data.Entity;
using SqlProviderServices = System.Data.Entity.SqlServer.SqlProviderServices;
namespace DTO
{
    public partial class PinkCosmetics : DbContext
    {
        public PinkCosmetics()
            : base("data source = kikkdt-g14; initial catalog = dbPinkCosmetics; user id = sa; password=123;MultipleActiveResultSets=True;App=EntityFramework")
        {
        }

        public virtual DbSet<tb_BangGia> tb_BangGia { get; set; }
        public virtual DbSet<tb_ChiTietHDBan> tb_ChiTietHDBan { get; set; }
        public virtual DbSet<tb_ChiTietHDNhap> tb_ChiTietHDNhap { get; set; }
        public virtual DbSet<tb_ChiTietPhieuDat> tb_ChiTietPhieuDat { get; set; }
        public virtual DbSet<tb_GiaBan> tb_GiaBan { get; set; }
        public virtual DbSet<tb_HoaDonBan> tb_HoaDonBan { get; set; }
        public virtual DbSet<tb_HoaDonNhap> tb_HoaDonNhap { get; set; }
        public virtual DbSet<tb_KhachHang> tb_KhachHang { get; set; }
        public virtual DbSet<tb_NhanVien> tb_NhanVien { get; set; }
        public virtual DbSet<tb_NhomSanPham> tb_NhomSanPham { get; set; }
        public virtual DbSet<tb_PhieuDatHang> tb_PhieuDatHang { get; set; }
        public virtual DbSet<tb_ResultMoMo> tb_ResultMoMo { get; set; }
        public virtual DbSet<tb_SanPham> tb_SanPham { get; set; }
        public virtual DbSet<tb_TaiKhoan> tb_TaiKhoan { get; set; }
        public virtual DbSet<tb_ThuongHieu> tb_ThuongHieu { get; set; }
        public virtual DbSet<tb_Identity> tb_Identity { get; set; }
        public virtual DbSet<ViewChiTietNhapHang> ViewChiTietNhapHang { get; set; }
        public virtual DbSet<ViewChiTietPhieuDatHang> ViewChiTietPhieuDatHang { get; set; }
        public virtual DbSet<ViewPhieuDatHang> ViewPhieuDatHang { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tb_BangGia>()
                .HasMany(e => e.tb_ChiTietHDBan)
                .WithRequired(e => e.tb_BangGia)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tb_BangGia>()
                .HasMany(e => e.tb_GiaBan)
                .WithRequired(e => e.tb_BangGia)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tb_ChiTietHDBan>()
                .Property(e => e.MaHDBan)
                .IsUnicode(false);

            modelBuilder.Entity<tb_ChiTietHDBan>()
                .Property(e => e.MaSanPham)
                .IsUnicode(false);

            modelBuilder.Entity<tb_ChiTietHDBan>()
                .Property(e => e.DonGia)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tb_ChiTietHDBan>()
                .Property(e => e.ThanhTien)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tb_ChiTietHDNhap>()
                .Property(e => e.MaHDNhap)
                .IsUnicode(false);

            modelBuilder.Entity<tb_ChiTietHDNhap>()
                .Property(e => e.MaSanPham)
                .IsUnicode(false);

            modelBuilder.Entity<tb_ChiTietHDNhap>()
                .Property(e => e.GiaNhap)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tb_ChiTietHDNhap>()
                .Property(e => e.ThanhTien)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tb_ChiTietPhieuDat>()
                .Property(e => e.MaPhieuDat)
                .IsUnicode(false);

            modelBuilder.Entity<tb_ChiTietPhieuDat>()
                .Property(e => e.MaSanPham)
                .IsUnicode(false);

            modelBuilder.Entity<tb_GiaBan>()
                .Property(e => e.MaSanPham)
                .IsUnicode(false);

            modelBuilder.Entity<tb_GiaBan>()
                .Property(e => e.GiaBan)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tb_HoaDonBan>()
                .Property(e => e.MaHDBan)
                .IsUnicode(false);

            modelBuilder.Entity<tb_HoaDonBan>()
                .Property(e => e.MaNV)
                .IsUnicode(false);

            modelBuilder.Entity<tb_HoaDonBan>()
                .Property(e => e.MaKH)
                .IsUnicode(false);

            modelBuilder.Entity<tb_HoaDonBan>()
                .Property(e => e.TongTien)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tb_HoaDonBan>()
                .Property(e => e.GiamGia)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tb_HoaDonBan>()
                .Property(e => e.ThanhTien)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tb_HoaDonBan>()
                .HasMany(e => e.tb_ChiTietHDBan)
                .WithRequired(e => e.tb_HoaDonBan)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tb_HoaDonNhap>()
                .Property(e => e.MaHDNhap)
                .IsUnicode(false);

            modelBuilder.Entity<tb_HoaDonNhap>()
                .Property(e => e.MaPhieuDat)
                .IsUnicode(false);

            modelBuilder.Entity<tb_HoaDonNhap>()
                .Property(e => e.MaNV)
                .IsUnicode(false);

            modelBuilder.Entity<tb_HoaDonNhap>()
                .HasMany(e => e.tb_ChiTietHDNhap)
                .WithRequired(e => e.tb_HoaDonNhap)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tb_KhachHang>()
                .Property(e => e.MaKH)
                .IsUnicode(false);

            modelBuilder.Entity<tb_KhachHang>()
                .Property(e => e.DienThoai)
                .IsUnicode(false);

            modelBuilder.Entity<tb_NhanVien>()
                .Property(e => e.MaNV)
                .IsUnicode(false);

            modelBuilder.Entity<tb_NhanVien>()
                .Property(e => e.DienThoai)
                .IsUnicode(false);

            modelBuilder.Entity<tb_NhanVien>()
                .Property(e => e.Username)
                .IsUnicode(false);

            modelBuilder.Entity<tb_NhanVien>()
                .HasMany(e => e.tb_HoaDonBan)
                .WithRequired(e => e.tb_NhanVien)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tb_NhanVien>()
                .HasMany(e => e.tb_PhieuDatHang)
                .WithRequired(e => e.tb_NhanVien)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tb_NhomSanPham>()
                .HasMany(e => e.tb_NhomSanPham1)
                .WithOptional(e => e.tb_NhomSanPham2)
                .HasForeignKey(e => e.NSPCha);

            modelBuilder.Entity<tb_NhomSanPham>()
                .HasMany(e => e.tb_SanPham)
                .WithRequired(e => e.tb_NhomSanPham)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tb_PhieuDatHang>()
                .Property(e => e.MaPhieuDat)
                .IsUnicode(false);

            modelBuilder.Entity<tb_PhieuDatHang>()
                .Property(e => e.MaNV)
                .IsUnicode(false);

            modelBuilder.Entity<tb_PhieuDatHang>()
                .HasMany(e => e.tb_ChiTietPhieuDat)
                .WithRequired(e => e.tb_PhieuDatHang)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tb_ResultMoMo>()
                .Property(e => e.OrderID)
                .IsUnicode(false);

            modelBuilder.Entity<tb_SanPham>()
                .Property(e => e.MaSanPham)
                .IsUnicode(false);

            modelBuilder.Entity<tb_SanPham>()
                .Property(e => e.MaVach)
                .IsUnicode(false);

            modelBuilder.Entity<tb_SanPham>()
                .Property(e => e.GiaVon)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tb_SanPham>()
                .Property(e => e.UrlHinh)
                .IsUnicode(false);

            modelBuilder.Entity<tb_SanPham>()
                .HasMany(e => e.tb_ChiTietHDBan)
                .WithRequired(e => e.tb_SanPham)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tb_SanPham>()
                .HasMany(e => e.tb_ChiTietHDNhap)
                .WithRequired(e => e.tb_SanPham)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tb_SanPham>()
                .HasMany(e => e.tb_ChiTietPhieuDat)
                .WithRequired(e => e.tb_SanPham)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tb_SanPham>()
                .HasMany(e => e.tb_GiaBan)
                .WithRequired(e => e.tb_SanPham)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tb_TaiKhoan>()
                .Property(e => e.Username)
                .IsUnicode(false);

            modelBuilder.Entity<tb_TaiKhoan>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<tb_TaiKhoan>()
                .HasMany(e => e.tb_NhanVien)
                .WithRequired(e => e.tb_TaiKhoan)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ViewChiTietNhapHang>()
                .Property(e => e.MaSanPham)
                .IsUnicode(false);

            modelBuilder.Entity<ViewChiTietNhapHang>()
                .Property(e => e.GiaNhap)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ViewChiTietNhapHang>()
                .Property(e => e.ThanhTien)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ViewChiTietPhieuDatHang>()
                .Property(e => e.MaPhieuDat)
                .IsUnicode(false);

            modelBuilder.Entity<ViewChiTietPhieuDatHang>()
                .Property(e => e.MaSanPham)
                .IsUnicode(false);

            modelBuilder.Entity<ViewPhieuDatHang>()
                .Property(e => e.MaPhieuDat)
                .IsUnicode(false);

            modelBuilder.Entity<ViewPhieuDatHang>()
                .Property(e => e.MaNV)
                .IsUnicode(false);
        }
    }
}