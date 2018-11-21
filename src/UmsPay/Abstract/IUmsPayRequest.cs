using System.Collections.Generic;
using UmsPay.Common;

namespace UmsPay.Abstract
{
    public interface IUmsPayRequest<T> where T : UmsPayResponseBase
    {
        /// <summary>
        /// 获取所有的Key-Value形式的文本请求参数字典
        /// </summary>
        IDictionary<string, string> GetParameters();

        string MsgType { get; }
    }
}