# UmsPay 
[![Build Status](https://dengyakui.visualstudio.com/UmsPay/_apis/build/status/dengyakui.UmsPay)](https://dengyakui.visualstudio.com/UmsPay/_build/latest?definitionId=4)
Supports China Ums qrcode pay

## How to setup the component?
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
