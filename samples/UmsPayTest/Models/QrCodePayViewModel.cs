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
        /// 账单号,银商的推荐退则为:{来源编号(4位)}{时间(yyyyMMddmmHHssSSS)(17位)}{7位随机数}
        /// </summary>
        [MinLength(6)]
        [MaxLength(31)]
        public string billNo { get; set; }

        /// <summary>
        /// 账单日期，格式yyyy-MM-dd
        /// </summary>
        public string billDate { get; set; }

        /// <summary>
        /// 账单描述
        /// </summary>
        [MaxLength(128)]
        public string billDesc { get; set; }

        /// <summary>
        /// 支付总金额
        /// </summary>
        [Required]
        [Range(1, 100000000)]
        public string totalAmount { get; set; }

        /// <summary>
        /// 支付结果通知地址
        /// </summary>
        [Required]
        public string notifyUrl { get; set; }

        /// <summary>
        /// 网页跳转地址(用户扫码支付完成后,在结果页中会有一个[返回商户]的按钮,点击后跳转到指定的地址)
        /// </summary>
        public string returnUrl { get; set; }
    }
}
