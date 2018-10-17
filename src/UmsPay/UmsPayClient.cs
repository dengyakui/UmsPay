using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using UmsPay.Abstract;
using UmsPay.Common;
using UmsPay.Utility;

namespace UmsPay
{
    public class UmsPayClient : IUmsPayClient
    {
        private readonly UmsPayOptions _options;
        private readonly IHttpClientFactory _httpClientFactory;

        public UmsPayClient(IOptions<UmsPayOptions> options, IHttpClientFactory factory)
        {
            _options = options.Value;
            _httpClientFactory = factory;
        }

        public async Task<T> ExecuteAsync<T>(IUmsPayRequest<T> request) where T : UmsPayResponseBase
        {
            var txtParams = new UmsPayDictionary(request.GetParameters())
            {
                { "mid", _options.mid},
                { "instMid", _options.instMid},
                { "msgSrc", _options.msgSrc},
                { "tid", _options.tid }
            };
            UmsSignature.Sign(txtParams, _options.secretKey);
            using (var client = _httpClientFactory.CreateClient(UmsPayOptions.DefaultClientName))
            {
                var content = JsonConvert.SerializeObject(txtParams);
                var body = await HttpClientUtility.DoPostAsync(client, _options.GetQrCodeUrl, content);
                if (string.IsNullOrEmpty(body)) throw new ArgumentNullException(nameof(body));

                //var dict = JsonConvert.DeserializeObject<Dictionary<string, object>>(body);
                
                T resp = default(T);
                try
                {
                    resp = JsonConvert.DeserializeObject<T>(body);
                }
                catch
                {
                    throw new FormatException($"二维码返回信息解析失败: {body}");
                }

                resp.Body = body;
                return resp;
            }

        }
    }
}
