using Newtonsoft.Json.Linq;
using System.IO;
using System.Net;
using System.Text;

namespace BLL
{
    public class MoMoRequest
    {
        private static readonly string endpoint = "https://test-payment.momo.vn/v2/gateway/api/create";

        // MoMo's partner code for testing
        private static readonly string partnerCode = "MOMO5RGX20191128";

        // Access key's MoMo for testing
        private static readonly string accessKey = "M8brj9K6E22vXoDB";

        // Secret key's MoMo for testing
        private static readonly string serectkey = "nqQiVSgDMy809JoPF6OzP5OdBUB550Y4";

        private static readonly string redirectUrl = "https://127.0.0.1:7238/api/Invoice";
        private static readonly string ipnUrl = "https://127.0.0.1:7238/api/Invoice";
        private static readonly string requestType = "captureWallet";

        public MoMoRequest()
        {
        }

        public static JObject CreatePostJsonString(string orderInfo, string amount, string orderId, string requestId, string extraData)
        {
            // Before sign HMAC SHA256 signature
            string rawHash = "accessKey=" + accessKey +
                             "&amount=" + amount +
                             "&extraData=" + extraData +
                             "&ipnUrl=" + ipnUrl +
                             "&orderId=" + orderId +
                             "&orderInfo=" + orderInfo +
                             "&partnerCode=" + partnerCode +
                             "&redirectUrl=" + redirectUrl +
                             "&requestId=" + requestId +
                             "&requestType=" + requestType
                ;

            // Sign signature SHA256
            MoMoSecurity crypto = new MoMoSecurity();
            string signature = crypto.SignSHA256(rawHash, serectkey);

            //build body json request
            JObject message = new JObject
            {
                { "partnerCode", partnerCode },
                { "partnerName", "Test" },
                { "storeId", "MomoTestStore" },
                { "requestId", requestId },
                { "amount", amount },
                { "orderId", orderId },
                { "orderInfo", orderInfo },
                { "redirectUrl", redirectUrl },
                { "ipnUrl", ipnUrl },
                { "lang", "en" },
                { "extraData", extraData },
                { "requestType", requestType },
                { "signature", signature }
            };

            return message;
        }

        public static string SendPaymentRequest(string postJsonString)
        {
            try
            {
                HttpWebRequest httpWReq = (HttpWebRequest)WebRequest.Create(endpoint);

                var postData = postJsonString;

                var data = Encoding.UTF8.GetBytes(postData);

                httpWReq.ProtocolVersion = HttpVersion.Version11;
                httpWReq.Method = "POST";
                httpWReq.ContentType = "application/json";

                httpWReq.ContentLength = data.Length;
                httpWReq.ReadWriteTimeout = 30000;
                httpWReq.Timeout = 15000;
                Stream stream = httpWReq.GetRequestStream();
                stream.Write(data, 0, data.Length);
                stream.Close();

                HttpWebResponse response = (HttpWebResponse)httpWReq.GetResponse();

                string jsonRespone = "";

                using (var reader = new StreamReader(response.GetResponseStream()))
                {
                    string temp = null;
                    while ((temp = reader.ReadLine()) != null)
                    {
                        jsonRespone += temp;
                    }
                }

                return jsonRespone;
            }
            catch (WebException e)
            {
                return e.Message;
            }
        }
    }
}