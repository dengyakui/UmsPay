using UmsPay.Common;
using UmsPay.Response;

namespace UmsPay.Notify
{
    /// <summary>
    /// 支付结果通知信息
    /// </summary>
    public class PayResultNotify
    {
        /// <summary>
        /// 原始表单数据
        /// </summary>
        public string Body { get; set; }
        /// <summary>
        /// 商户号
        /// </summary>
        public string Mid { get; set; }

        /// <summary>
        /// 终端 id
        /// </summary>
        public string Tid { get; set; }

        /// <summary>
        /// 业务类型, value: QRPAYDEFAULT
        /// </summary>
        public string InstMid { get; set; }

        /// <summary>
        /// 账单号
        /// </summary>
        public string BillNo { get; set; }


        /// <summary>
        /// 账单日期，格式yyyy-MM-dd
        /// </summary>
        public string BillDate { get; set; }
       

        /// <summary>
        /// 签名
        /// </summary>
        public string Sign { get; set; }


        /// <summary>
        /// 账单创建时间，格式yyyy-MM-dd HH:mm:ss
        /// </summary>
        public string CreateTime { get; set; }

        /// <summary>
        /// 账单状态, PAID,UNPAID,REFUND,CLOSED,UNKNOWN
        /// </summary>
        public string BillStatus { get; set; }

        /// <summary>
        /// 账单描述 (由request透传过来的)
        /// </summary>
        public string BillDesc { get; set; }

        /// <summary>
        /// 账单总金额, 若涉及营销联盟优惠，则此为优惠前总金额
        /// </summary>
        public string TotalAmount { get; set; }

        /// <summary>
        /// 会员id
        /// </summary>
        public string MemberId { get; set; }

        /// <summary>
        /// 桌号、柜台号、房间号
        /// </summary>
        public string CounterNo { get; set; }

        /// <summary>
        /// 商户名称
        /// </summary>
        public string MerName { get; set; }

        /// <summary>
        /// 付款附言
        /// </summary>
        public string Memo { get; set; }

        /// <summary>
        /// sample value: 051321a0-7487-49fb-ab98-cb142a6cb80f
        /// </summary>
        public string NotifyId { get; set; }

        /// <summary>
        /// 担保状态
        /// </summary>
        public string SecureStatus { get; set; }

        /// <summary>
        /// 担保完成金额（分）
        /// </summary>
        public int CompleteAmount { get; set; }

        /// <summary>
        /// 账单详情(JSON string)
        /// </summary>
        public string BillPayment { get; set; }

        /// <summary>
        /// 账单详情,反序列化之后的信息
        /// </summary>
        public BillPayment BillPaymentObj { get; set; }
        
        /// <summary>
        /// value: BILLPAY
        /// </summary>
        public string QrCodeType { get; set; }

        /// <summary>
        /// value: 2c9017965f51bc9d015f5c4259aa23f9
        /// </summary>
        public string MchntUuid { get; set; }


        /// <summary>
        /// 账单二维码url, sample: https://qr.chinaums.com/bills/qrCode.do?id=33791809296305631191110401
        /// </summary>
        public string BillQrCode { get; set; }


        /// <summary>
        /// value: 100000
        /// </summary>
        public string SubInst { get; set; }

    }
}