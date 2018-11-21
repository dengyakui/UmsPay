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
        public string RequestTimestamp { get; set; }

        /// <summary>
        /// 账单号
        /// </summary>
        public string BillNo { get; set; }

        /// <summary>
        /// 账单日期，格式yyyy-MM-dd
        /// </summary>
        public string BillDate { get; set; }

        /// <summary>
        /// 账单描述
        /// </summary>
        public string BillDesc { get; set; }

        /// <summary>
        /// 支付总金额
        /// </summary>
        public string TotalAmount { get; set; }

        /// <summary>
        /// 支付结果通知地址
        /// </summary>
        public string NotifyUrl { get; set; }

        /// <summary>
        /// 网页跳转地址
        /// </summary>
        public string ReturnUrl { get; set; }

        public string MsgType => "bills.getQRCode";

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new UmsPayDictionary
            {
                {"requestTimestamp",RequestTimestamp },
                {"billNo",BillNo },
                {"billDate",BillDate },
                {"billDesc",BillDesc },
                {"totalAmount",TotalAmount },
                {"notifyUrl",NotifyUrl},
                {"returnUrl",ReturnUrl },
                {"msgType", MsgType},

            };
            return parameters;
        }
    }


    /// <summary>
    /// 获取二维码请求
    /// </summary>
    public class BillQueryRequest : IUmsPayRequest<BillQueryResponse>
    {
        /// <summary>
        /// 消息ID
        /// </summary>
        public string MsgId { get; set; }

        /// <summary>
        /// 报文请求时间，格式yyyy-MM-dd HH:mm:ss
        /// </summary>
        public string RequestTimestamp { get; set; }

        /// <summary>
        /// 账单号
        /// </summary>
        public string BillNo { get; set; }

        /// <summary>
        /// 账单日期，格式yyyy-MM-dd
        /// </summary>
        public string BillDate { get; set; }


        public string MsgType => "bills.query";

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new UmsPayDictionary
            {
                {"msgType", MsgType},
                {"requestTimestamp",RequestTimestamp },
                {"billNo",BillNo },
                {"billDate",BillDate },
            };
            return parameters;
        }
    }
}