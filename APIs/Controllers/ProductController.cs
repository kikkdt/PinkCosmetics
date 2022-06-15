using System.Net;
using System.Net.Mime;
using APIs.Model;
using DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.ML;
using ModelsTrainer;

namespace APIs.Controllers
{

    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly PinkCosmetics db = new PinkCosmetics();
        private readonly string projectFolder = Directory.GetParent(Directory.GetCurrentDirectory()).FullName;

        [Route("api/[controller]")]
        public IEnumerable<Product> Get()
        {
            List<Product> result = new List<Product>();
            var products = db.tb_SanPham.Where(x => x.DaXoa == false).ToList();
            foreach (var item in products)
            {
                FileContentResult image = null;
                if (item.UrlHinh != null)
                {
                    var filePath = Path.Combine(projectFolder, @"GUI/assets/image/" + item.UrlHinh);

                    Byte[] b = System.IO.File.ReadAllBytes(filePath);   // You can use your own method over here.         
                    image = File(b, "image/jpeg");
                }

                result.Add(new Product(item.MaSanPham, item.TenSP, item.MaNSP, item.TonKho > 0 ? "Còn hàng" : "Hết hàng",
                    image, item.MoTa, (double)item.GiaVon, (double)item.GiaVon));
            }
            return result;
        }

        [Route("api/[controller]/ByGroup/{id?}")]
        public IEnumerable<Product> GetByGroup(int? id)
        {
            if (id == null) return null;

            List<Product> result = new List<Product>();
            var products = db.tb_SanPham.Where(x => x.DaXoa == false && x.MaNSP == id).ToList();
            foreach (var item in products)
            {
                FileContentResult image = null;
                if (item.UrlHinh != null)
                {
                    var filePath = Path.Combine(projectFolder, @"GUI/assets/image/" + item.UrlHinh);

                    Byte[] b = System.IO.File.ReadAllBytes(filePath);   // You can use your own method over here.         
                    image = File(b, "image/jpeg");
                }

                result.Add(new Product(item.MaSanPham, item.TenSP, item.MaNSP, item.TonKho > 0 ? "Còn hàng" : "Hết hàng",
                    image, item.MoTa, (double)item.GiaVon, (double)item.GiaVon));
            }
            return result;
        }

        [Route("api/[controller]/ByID/{id?}")]
        public Product GetByID(string? id)
        {
            if (id == null) return null;

            var item = db.tb_SanPham.FirstOrDefault(x => x.MaSanPham == id);

            FileContentResult image = null;
            if (item.UrlHinh != null)
            {
                var filePath = Path.Combine(projectFolder, @"GUI/assets/image/" + item.UrlHinh);

                Byte[] b = System.IO.File.ReadAllBytes(filePath);   // You can use your own method over here.         
                image = File(b, "image/jpeg");
            }

            return new Product(item.MaSanPham, item.TenSP, item.MaNSP, item.TonKho > 0 ? "Còn hàng" : "Hết hàng",
                image, item.MoTa, (double)item.GiaVon, (double)item.GiaVon);
        }

        [Route("api/[controller]/Recommend/{id?}")]
        public IEnumerable<Product> GetProductRecommend(string id)
        {
            List<Product> result = new List<Product>();

            var top5 = ProductRecommender.GetProductRecommend(id);
            foreach (var item in top5)
            {
                FileContentResult image = null;
                if (item.UrlHinh != null)
                {
                    var filePath = Path.Combine(projectFolder, @"GUI/assets/image/" + item.UrlHinh);

                    Byte[] b = System.IO.File.ReadAllBytes(filePath);   // You can use your own method over here.         
                    image = File(b, "image/jpeg");
                }

                result.Add(new Product(item.MaSanPham, item.TenSP, item.MaNSP, item.TonKho > 0 ? "Còn hàng" : "Hết hàng",
                    image, item.MoTa, (double)item.GiaVon, (double)item.GiaVon));
            }

            return result;
        }
    }
}
