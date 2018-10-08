using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UmsPayTest.Models
{
    public class QrCodePayViewModel
    {

        /// <summary>
        /// 报文请求时间，格式yyyy-MM-dd HH:mm:ss
        /// </summary>
        [Required]
        public string requestTimestamp { get; set; }

        /// <summary>
        /// 账单号
        /// </summary>
        [Required]
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
        [Required]
        public string totalAmount { get; set; }

        /// <summary>
        /// 支付结果通知地址
        /// </summary>
        [Required]
        public string notifyUrl { get; set; }

        /// <summary>
        /// 网页跳转地址
        /// </summary>
        public string returnUrl { get; set; }
    }
}
