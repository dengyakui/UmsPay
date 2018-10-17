using System;
using UmsPay.Abstract;

namespace UmsPay.Response
{
    /// <summary>
    /// 账单查询接口返回信息
    /// </summary>
    public class BillQueryResponse : UmsPayResponseBase
    {
        /// <summary>
        /// 平台错误码
        /// </summary>
        public string errCode { get; set; }

        /// <summary>
        /// 平台错误信息
        /// </summary>
        public string errMsg { get; set; }

        /// <summary>
        /// 消息ID，原样返回
        /// </summary>
        public string msgId { get; set; }

        /// <summary>
        /// 消息类型，原样返回
        /// </summary>
        public string msgType { get; set; }

        /// <summary>
        /// 消息类型，原样返回
        /// </summary>
        public string msgSrc { get; set; }

        /// <summary>
        /// 报文应答时间，格式yyyy-MM-dd HH:mm:ss
        /// </summary>
        public string responseTimeStamp { get; set; }

        /// <summary>
        /// 请求系统预留字段
        /// </summary>
        public string srcReserve { get; set; }

        /// <summary>
        /// 商户号，原样返回
        /// </summary>
        public string mid { get; set; }

        /// <summary>
        /// 终端号，原样返回
        /// </summary>
        public string tid { get; set; }

        /// <summary>
        /// 业务类型：QRPAYDEFAULT
        /// </summary>
        public string instMid { get; set; }

        /// <summary>
        /// 账单号，原样返回
        /// </summary>
        public string billNo { get; set; }

        /// <summary>
        /// 账单日期，原样返回
        /// </summary>
        public string billDate { get; set; }

        /// <summary>
        /// 账单创建时间，格式yyyy-MM-dd HH:mm:ss
        /// </summary>
        public string createTime { get; set; }

        // 账单状态
        public string billStatus { get; set; }

        /// <summary>
        /// 账单描述
        /// </summary>
        public string billDesc { get; set; }


        /// <summary>
        /// 账单总金额, 若涉及营销联盟优惠，则此为优惠前总金额
        /// </summary>
        public int totalAmount { get; set; }

        /// <summary>
        /// 账单二维码
        /// </summary>
        public string billQRCode { get; set; }

        /// <summary>
        /// 会员id
        /// </summary>
        public string memberId { get; set; }

        /// <summary>
        /// 桌号、柜台号、房间号
        /// </summary>
        public string counterNo { get; set; }

        /// <summary>
        /// 商户名称
        /// </summary>
        public string merName { get; set; }

        /// <summary>
        /// 付款附言
        /// </summary>
        public string memo { get; set; }

        /// <summary>
        /// 担保状态
        /// </summary>
        public string secureStatus { get; set; }

        /// <summary>
        /// 担保完成金额（分）
        /// </summary>
        public int completeAmount { get; set; }

        /// <summary>
        /// 账单详情(JSON string)
        /// </summary>
        public BillPayment billPayment { get; set; }

        ///// <summary>
        ///// 账单详情,反序列化之后的信息
        ///// </summary>
        //public BillPayment billPaymentObj { get; set; }

        /// <summary>
        /// 系统ID，原样返回
        /// </summary>
        public string systemId { get; set; }



        /// <summary>
        /// 签名
        /// </summary>
        public string sign { get; set; }

        public string refundBillPayment { get; set; }
        public RefundBillPayment RefundBillPaymentObj { get; set; }

    }
}