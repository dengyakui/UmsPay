using UmsPay.Abstract;

namespace UmsPay.Response
{
    /// <summary>
    /// 二维码接口返回信息
    /// </summary>
    public class GetQrCodeResponse : UmsPayResponseBase
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
        /// 业务类型，原样返回
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
        /// 账单二维码url
        /// </summary>
        public string BillQrCode { get; set; }

        /// <summary>
        /// 系统ID，原样返回
        /// </summary>
        public string SystemId { get; set; }

        /// <summary>
        /// 签名算法, 值为：MD5或 SHA25, 若不上送默认为MD5
        /// </summary>
        public string SignType { get; set; }

        /// <summary>
        /// 签名
        /// </summary>
        public string Sign { get; set; }

    }
}