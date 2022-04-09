namespace DTO
{
    public class SanPham_DTO
    {
        private string _maSanPham, _maVach, _tenSanPham;
        private int _maNSP;
        private int? _maThuongHieu;
        private double _giaVon;
        private int _tonKho;
        private int _daMua;
        private string _urlHinh, _moTa;
        private bool _daXoa;

        public SanPham_DTO(string maSanPham, string maVach, string tenSanPham, int maNSP, int? maThuongHieu, double giaVon, int tonKho, int daMua, string urlHinh, string moTa, bool daXoa)
        {
            _maSanPham = maSanPham;
            _maVach = maVach;
            _tenSanPham = tenSanPham;
            _maNSP = maNSP;
            _maThuongHieu = maThuongHieu;
            _giaVon = giaVon;
            _tonKho = tonKho;
            _daMua = daMua;
            _urlHinh = urlHinh;
            _moTa = moTa;
            _daXoa = daXoa;
        }

        public string MaSanPham { get => _maSanPham; set => _maSanPham = value; }
        public string MaVach { get => _maVach; set => _maVach = value; }
        public string TenSanPham { get => _tenSanPham; set => _tenSanPham = value; }
        public int MaNSP { get => _maNSP; set => _maNSP = value; }
        public int? MaThuongHieu { get => _maThuongHieu; set => _maThuongHieu = value; }
        public double GiaVon { get => _giaVon; set => _giaVon = value; }
        public int TonKho { get => _tonKho; set => _tonKho = value; }
        public int DaMua { get => _daMua; set => _daMua = value; }
        public string UrlHinh { get => _urlHinh; set => _urlHinh = value; }
        public string MoTa { get => _moTa; set => _moTa = value; }
        public bool DaXoa { get => _daXoa; set => _daXoa = value; }
    }
}