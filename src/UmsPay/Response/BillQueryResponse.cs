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
        public string ErrCode { get; set; }

        /// <summary>
        /// 平台错误信息
        /// </summary>
        public string ErrMsg { get; set; }

        /// <summary>
        /// 消息ID，原样返回
        /// </summary>
        public string MsgId { get; set; }

        /// <summary>
        /// 消息类型，原样返回
        /// </summary>
        public string MsgType { get; set; }

        /// <summary>
        /// 消息类型，原样返回
        /// </summary>
        public string MsgSrc { get; set; }

        /// <summary>
        /// 报文应答时间，格式yyyy-MM-dd HH:mm:ss
        /// </summary>
        public string ResponseTimeStamp { get; set; }

        /// <summary>
        /// 请求系统预留字段
        /// </summary>
        public string SrcReserve { get; set; }

        /// <summary>
        /// 商户号，原样返回
        /// </summary>
        public string Mid { get; set; }

        /// <summary>
        /// 终端号，原样返回
        /// </summary>
        public string Tid { get; set; }

        /// <summary>
        /// 业务类型：QRPAYDEFAULT
        /// </summary>
        public string InstMid { get; set; }

        /// <summary>
        /// 账单号，原样返回
        /// </summary>
        public string BillNo { get; set; }

        /// <summary>
        /// 账单日期，原样返回
        /// </summary>
        public string BillDate { get; set; }

        /// <summary>
        /// 账单创建时间，格式yyyy-MM-dd HH:mm:ss
        /// </summary>
        public string CreateTime { get; set; }

        // 账单状态
        public string BillStatus { get; set; }

        /// <summary>
        /// 账单描述
        /// </summary>
        public string BillDesc { get; set; }


        /// <summary>
        /// 账单总金额, 若涉及营销联盟优惠，则此为优惠前总金额
        /// </summary>
        public int TotalAmount { get; set; }

        /// <summary>
        /// 账单二维码
        /// </summary>
        public string BillQrCode { get; set; }

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
        public BillPayment BillPayment { get; set; }

        ///// <summary>
        ///// 账单详情,反序列化之后的信息
        ///// </summary>
        //public BillPayment billPaymentObj { get; set; }

        /// <summary>
        /// 系统ID，原样返回
        /// </summary>
        public string SystemId { get; set; }



        /// <summary>
        /// 签名
        /// </summary>
        public string Sign { get; set; }

        public string RefundBillPayment { get; set; }
        public RefundBillPayment RefundBillPaymentObj { get; set; }

    }
}