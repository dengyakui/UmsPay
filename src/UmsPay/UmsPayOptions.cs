﻿using System;
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
        public string MsgSrc { get; set; }

        /// <summary>
        /// 来源编号
        /// </summary>
        public string MsgSrcId { get; set; }

        /// <summary>
        /// 商户号
        /// </summary>
        public string Mid { get; set; }

        /// <summary>
        /// 终端号
        /// </summary>
        public string Tid { get; set; }

        /// <summary>
        /// 业务类型
        /// </summary>
        public string InstMid { get; set; }

        public string SecretKey { get; set; }

        public string GetQrCodeUrl { get; set; }

        /// <summary>
        /// 支付结果通知url
        /// </summary>
        public string NotifyUrl { get; set; }
    }
}
