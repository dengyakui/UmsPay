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
using UmsPayTest.Models;

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
            if (Request.HasFormContentType)
            {
                var formCollection = await Request.ReadFormAsync();
            }
            using (StreamReader reader=  new StreamReader(Request.Body,Encoding.UTF8))
            {
                var res = await reader.ReadToEndAsync();
                if (string.IsNullOrEmpty(res))
                {
                    throw new Exception("response was empty");
                }

            }
            return Ok();
        }

        [HttpGet]

        public IActionResult Index()
        {
            var req = new QrCodePayViewModel()
            {
                totalAmount = "1",
                billDate = DateTime.Now.ToString("yyyy-MM-dd"),
                billNo = _options.msgSrcId + DateTime.Now.ToString("yyyyMMddHHmmssfff") + "1234567890",
                billDesc = "测试",
                requestTimestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                returnUrl = Url.Action(nameof(PayResult)),
                notifyUrl = ""
            };
            return View(req);
        }

        [HttpPost]
        public async Task<IActionResult> Index(QrCodePayViewModel model)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError(nameof(model), "invalid form data");
                return View(model);
            }
            var req = new GetQrCodeRequest
            {
                totalAmount = model.totalAmount,
                billDate = model.billDate,
                billDesc = model.billDesc,
                billNo = model.billNo,
                requestTimestamp = model.requestTimestamp,
                notifyUrl = model.notifyUrl,
                returnUrl = model.returnUrl
            };
            var res = await _client.ExecuteAsync(req);
            if(string.IsNullOrWhiteSpace(res.errCode) && string.IsNullOrWhiteSpace(res.errMsg))
            {
                throw new Exception("请求失败:" + res.Body);
            }
            return RedirectToAction(nameof(QrCode), new { code = res.billQRCode });
        }

        [HttpGet]
        public IActionResult QrCode(string code)
        {
            ViewBag.Code = code;
            return View();
        }



        public IActionResult PayResult()
        {
            return View();
        }
    }
}