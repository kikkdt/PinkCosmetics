using DTO;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace APIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvoiceController : ControllerBase
    {
        private readonly PinkCosmetics db = new PinkCosmetics();

        [HttpGet]
        public HttpResponseMessage GetResult()
        {
            try
            {
                string orderId = Request.Query["orderId"].ToString();
                string resultCode = Request.Query["resultCode"].ToString();
                string signature = Request.Query["signature"].ToString();

                tb_ResultMoMo resultMoMo = db.tb_ResultMoMo.FirstOrDefault(x => x.OrderID == orderId);

                if (resultMoMo == null)
                {
                    return new HttpResponseMessage(HttpStatusCode.BadRequest);
                }

                resultMoMo.ResultCode = Convert.ToInt32(resultCode);
                db.SaveChanges();

                return new HttpResponseMessage(HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                return new HttpResponseMessage()
                {
                    Content = new StringContent($"Failed. Code: {Request.Query["resultCode"]}\nMessage: {ex.Message}")
                };
            }
        }
    }
}