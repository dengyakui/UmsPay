using System;
using System.Collections.Generic;
using System.Text;

namespace UmsPay
{
    public class UmsPayOptions
    {
        public const string DefaultClientName = "Payment.Ums.Client";
        /// <summary>
        /// 消息来源
        /// </summary>
        public string msgSrc { get; set; }

        /// <summary>
        /// 来源编号
        /// </summary>
        public string msgSrcId { get; set; }

        /// <summary>
        /// 消息类型
        /// </summary>
        public string msgType { get; set; }

        /// <summary>
        /// 商户号
        /// </summary>
        public string mid { get; set; }

        /// <summary>
        /// 终端号
        /// </summary>
        public string tid { get; set; }

        /// <summary>
        /// 业务类型
        /// </summary>
        public string instMid { get; set; }

        public string secretKey { get; set; }

        public string GetQrCodeUrl { get; set; }

        /// <summary>
        /// 支付结果通知url
        /// </summary>
        public string NotifyUrl { get; set; }
    }
}
