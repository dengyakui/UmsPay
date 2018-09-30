using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace UmsPay.Utility
{
    public class UmsSignature
    {
        
        public static void Sign(IDictionary<string, string> reqData, string secretKey)
        {
            if (reqData == null || reqData.Count <= 0)
            {
                throw new ArgumentException("请求报文不能为空");
            }

            var list = new List<string>(reqData.Keys);
            list.Sort(StringComparer.Ordinal);

            var sb = new StringBuilder();
            foreach (var key in list)
            {
                sb.Append($"{key}={reqData[key]}&");
            }

            var content = sb.Remove(sb.Length - 1, 1) + secretKey;

            var bytes = MD5.Create().ComputeHash(Encoding.UTF8.GetBytes(content));

            var sb2 = new StringBuilder();

            foreach (var b in bytes)
            {
                sb2.Append(b.ToString("X2"));
            }

            var sign = sb2.ToString();

            reqData["sign"] = sign;

        }



        public static bool Validate(Dictionary<string, string> resData)
        {
            return false;
        }


    }
}