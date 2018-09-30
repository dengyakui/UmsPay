using System.Collections.Generic;
using UmsPay.Abstract;
using UmsPay.Common;
using UmsPay.Response;

namespace UmsPay.Request
{
    /// <summary>
    /// 获取二维码请求
    /// </summary>
    public class GetQrCodeRequest : IUmsPayRequest<GetQrCodeResponse>
    {

        /// <summary>
        /// 报文请求时间，格式yyyy-MM-dd HH:mm:ss
        /// </summary>
        public string requestTimestamp { get; set; }

        /// <summary>
        /// 账单号
        /// </summary>
        public string billNo { get; set; }

        /// <summary>
        /// 账单日期，格式yyyy-MM-dd
        /// </summary>
        public string billDate { get; set; }

        /// <summary>
        /// 账单描述
        /// </summary>
        public string billDesc { get; set; }

        /// <summary>
        /// 支付总金额
        /// </summary>
        public string totalAmount { get; set; }

        /// <summary>
        /// 支付结果通知地址
        /// </summary>
        public string notifyUrl { get; set; }

        /// <summary>
        /// 网页跳转地址
        /// </summary>
        public string returnUrl { get; set; }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new UmsPayDictionary
            {
                {"requestTimestamp",requestTimestamp },
                {"billNo",billNo },
                {"billDate",billDate },
                {"billDesc",billDesc },
                {"totalAmount",totalAmount },
                {"notifyUrl",notifyUrl},
                {"returnUrl",returnUrl },

            };
            return parameters;
        }
    }
}