using System.Collections.Generic;

namespace UmsPay.Common
{
    /// <summary>
    /// 用于生成request参数
    /// </summary>
    public class UmsPayDictionary : Dictionary<string, string>
    {
        public UmsPayDictionary()
        {

        }

        public UmsPayDictionary(IDictionary<string, string> dictionary) : base(dictionary)
        {

        }

        /// <summary>
        /// 值为null的参数不参与签名,所以对null的key进行了过滤
        /// </summary>
        public new void Add(string key, string value)
        {
            if (!string.IsNullOrEmpty(key) && !string.IsNullOrEmpty(value))
            {
                base.Add(key, value);
            }
        }

        public string GetValue(string key)
        {
            return TryGetValue(key, out var o) ? o : null;
        }
    }
}