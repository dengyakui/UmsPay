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
        /// 业务类型，原样返回
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
        /// 账单二维码url
        /// </summary>
        public string billQRCode { get; set; }

        /// <summary>
        /// 系统ID，原样返回
        /// </summary>
        public string systemId { get; set; }

        /// <summary>
        /// 签名算法, 值为：MD5或 SHA25, 若不上送默认为MD5
        /// </summary>
        public string signType { get; set; }

        /// <summary>
        /// 签名
        /// </summary>
        public string sign { get; set; }

    }
}