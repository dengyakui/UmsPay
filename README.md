# UmsPay
support china ums qrcode pay

## How to enable the component?
1. open then samples web project, Config the appsettings.json file base on your payment paramers from your client or ums provider
2. In then starup class, config as follows:
```csharp
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<UmsPayOptions>(_configuration);
            services.AddUmsPay();
            services.AddUmsPayHttpClient();
            services.AddMvc();
        }
```
3. More use details was in Home Controler, you can set a breakpoint, and open the debugger.
