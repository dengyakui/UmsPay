using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using UmsPay;
using UmsPay.Request;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly UmsPayClient _client;
        private readonly UmsPayOptions _options;
        public HomeController(UmsPayClient client,IOptions<UmsPayOptions> options)
        {
            _client = client;
            _options = options.Value;
        }

        /// <summary>
        /// 接收回调测试
        /// </summary>
        /// <returns></returns>

        [HttpPost]
        public async Task<IActionResult> PayNotify()
        {
            using (StreamReader reader=  new StreamReader(Request.Body,Encoding.UTF8))
            {
                var res = await reader.ReadToEndAsync();
            }
            return Ok();
        }

        [HttpGet]

        public async Task<IActionResult> Index()
        {
            var req = new GetQrCodeRequest()
            {
                totalAmount = "1",
                billDate = DateTime.Now.ToString("yyyy-MM-dd"),
                billNo = _options.msgSrcId + DateTime.Now.ToString("yyyyMMddHHmmssfff") + "1234567",
                billDesc = "测试",
                requestTimestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                notifyUrl = "http://808b70a6.ngrok.io"
            };

            var res =  await _client.ExecuteAsync(req);
            return Ok(res);
        }
    }
}