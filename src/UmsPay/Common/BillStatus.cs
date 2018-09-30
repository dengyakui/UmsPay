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
        public const string PAID = "PAID";

        /// <summary>
        /// 未支付
        /// </summary>
        public const string UNPAID = "UNPAID";

        /// <summary>
        /// 已退款
        /// </summary>
        public const string REFUND = "REFUND";

        /// <summary>
        /// 已关闭
        /// </summary>
        public const string CLOSED = "CLOSED";

        /// <summary>
        /// 未知
        /// </summary>
        public const string UNKNOWN = "UNKNOWN";

    }
}