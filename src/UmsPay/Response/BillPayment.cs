namespace UmsPay.Response
{
    /// <summary>
    /// 账单详情
    /// </summary>
    public class BillPayment
    {
        /// <summary>
        /// 支付时间，格式yyyy-MM-dd HH:mm:ss
        /// </summary>
        public string payTime { get; set; }

        /// <summary>
        /// 交易参考号
        /// </summary>
        public string paySeqId { get; set; }

        /// <summary>
        /// 开票金额
        /// </summary>
        public int invoiceAmount { get; set; }

        /// <summary>
        /// 结算时间，格式yyyy-MM-dd
        /// </summary>
        public string settleDate { get; set; }

        /// <summary>
        /// 买家ID
        /// </summary>
        public string buyerId { get; set; }

        /// <summary>
        /// 账单流水总金额
        /// </summary>
        public int totalAmount { get; set; }

        /// <summary>
        /// 钱包折扣金额
        /// </summary>
        public int couponAmount { get; set; }

        /// <summary>
        /// 账单业务类型
        /// </summary>
        public string billBizType { get; set; }


        /// <summary>
        /// 实付金额
        /// </summary>
        public int buyerPayAmount { get; set; }

        /// <summary>
        /// 目标平台单号
        /// </summary>
        public string targetOrderId { get; set; }

        /// <summary>
        /// 支付详情
        /// </summary>
        public string payDetail { get; set; }

        /// <summary>
        /// 商户订单号
        /// </summary>
        public string merOrderId { get; set; }


        /// <summary>
        /// 交易状态
        /// </summary>
        public string status { get; set; }

        /// <summary>
        /// 目标系统
        /// </summary>
        public string targetSys { get; set; }
    }
}