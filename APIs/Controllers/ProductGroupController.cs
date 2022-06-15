using APIs.Model;
using DTO;
using Microsoft.AspNetCore.Mvc;

namespace APIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductGroupController : ControllerBase
    {
        private readonly PinkCosmetics db = new PinkCosmetics();

        [HttpGet]
        public IEnumerable<ProductGroup> Get()
        {
            List<ProductGroup> productGroups = new List<ProductGroup>();
            foreach (var item in db.tb_NhomSanPham.Where(x => x.DaXoa == false).ToList())
            {
                productGroups.Add(new ProductGroup(item.MaNSP, item.TenNSP, item.NSPCha));
            }
            return productGroups;
        }
    }
}