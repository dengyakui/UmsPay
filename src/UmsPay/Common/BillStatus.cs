namespace UmsPay.Common
{
    /// <summary>
    /// 账单状态
    /// </summary>
    public class BillStatus
    {
        /// <summary>
        /// 已支付
        /// </summary>
        public const string Paid = "PAID";

        /// <summary>
        /// 未支付
        /// </summary>
        public const string Unpaid = "UNPAID";

        /// <summary>
        /// 已退款
        /// </summary>
        public const string Refund = "REFUND";

        /// <summary>
        /// 已关闭
        /// </summary>
        public const string Closed = "CLOSED";

        /// <summary>
        /// 未知
        /// </summary>
        public const string Unknown = "UNKNOWN";

    }
}