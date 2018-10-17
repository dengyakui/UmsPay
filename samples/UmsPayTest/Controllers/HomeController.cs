using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.Primitives;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UmsPay;
using UmsPay.Common;
using UmsPay.Notify;
using UmsPay.Request;
using UmsPay.Response;
using UmsPayTest.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly UmsPayClient _client;
        private readonly UmsPayOptions _options;
        public HomeController(UmsPayClient client, IOptions<UmsPayOptions> options)
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
            if (!Request.HasFormContentType)
            {
                return BadRequest("参数错误");
            }

            var formCollection = await Request.ReadFormAsync();
            if (formCollection == null || formCollection.Count <= 0)
            {
                throw new Exception("未解析到callback信息");
            }
            var sign = formCollection["sign"].ToString();

            var dict = new UmsPayDictionary();
            foreach (var key in formCollection.Keys)
            {
                if (key != "sign")
                {
                    dict.Add(key, formCollection[key]);
                }
            }

            // sign validation
            if (!UmsPay.Utility.UmsSignature.Validate(dict, sign, _options.secretKey))
            {
                throw new Exception("签名校验失败");
            }

            // TODO: check if it is an repeat request and if is repeat we should return SUCCESS OR FAILED to terminate.
            var billPayment = dict["billPayment"];
            var str = JsonConvert.SerializeObject(dict);
            var payResult = JsonConvert.DeserializeObject<PayResultNotify>(str);
            payResult.Body = str;
            payResult.billPaymentObj = JsonConvert.DeserializeObject<BillPayment>(billPayment);

            if (payResult.billStatus != BillStatus.PAID)
            {
                return Content("FAILED");
            }

            var billQuery = new BillQueryRequest
            {
                billDate = payResult.billDate,
                billNo = payResult.billNo,
                requestTimestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
            };

            var res = await _client.ExecuteAsync(billQuery);
            if (res.billStatus != BillStatus.PAID)
            {
                return Content("FAILED");
            }

            return Content("SUCCESS");

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
                notifyUrl = _options.NotifyUrl
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
            if (string.IsNullOrWhiteSpace(res.errCode) && string.IsNullOrWhiteSpace(res.errMsg))
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


        [HttpGet]
        public IActionResult About()
        {
            var model = new BillQueryViewModel
            {
                billDate = DateTime.Now.ToString("yyyy-MM-dd"),
                billNo = string.Empty,
                requestTimestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> About(BillQueryViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var req = new BillQueryRequest()
            {
                billDate = model.billDate,
                billNo = model.billNo,
                requestTimestamp = model.requestTimestamp
            };
            var res = await _client.ExecuteAsync(req);

            return Ok(res);
        }
    }
}