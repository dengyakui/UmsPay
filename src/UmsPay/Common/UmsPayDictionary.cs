using System.Collections.Generic;

namespace UmsPay.Common
{
    public class UmsPayDictionary : Dictionary<string, string>
    {
        public UmsPayDictionary()
        {

        }

        public UmsPayDictionary(IDictionary<string, string> dictionary) : base(dictionary)
        {

        }

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