namespace UmsPay.Response
{
    /// <summary>
    /// 退款信息
    /// </summary>
    public class RefundBillPayment
    {
        /// <summary>
        /// 商户退款单号
        /// </summary>
        public string MerOrderId { get; set; }

        /// <summary>
        /// 账单业务类型
        /// </summary>
        public string BillBizType { get; set; }

        /// <summary>
        /// 交易参考号
        /// </summary>
        public string PaySeqId { get; set; }


        /// <summary>
        /// 账单流水总金额
        /// </summary>
        public string TotalAmount { get; set; }


        /// <summary>
        /// 实付金额
        /// </summary>
        public int BuyerPayAmount { get; set; }

        /// <summary>
        /// 开票金额
        /// </summary>
        public int InvoiceAmount { get; set; }

        /// <summary>
        /// 折扣金额
        /// </summary>
        public int DiscountAmount { get; set; }

        /// <summary>
        /// 买家id
        /// </summary>
        public string BuyerId { get; set; }

        /// <summary>
        /// 买家用户名
        /// </summary>
        public string BuyerUsername { get; set; }

        /// <summary>
        /// 支付时间，格式yyyy-MM-dd HH:mm:ss
        /// </summary>
        public string PayTime { get; set; }

        /// <summary>
        /// 结算时间，格式yyyy-MM-dd
        /// </summary>
        public string SettleDate { get; set; }

        /// <summary>
        /// 交易状态
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// 目标平台单号
        /// </summary>
        public string TargetOrderId { get; set; }

        /// <summary>
        /// 目标系统
        /// </summary>
        public string TargetSys { get; set; }

    }
}