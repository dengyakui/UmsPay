# UmsPay 
[![Build Status](https://dengyakui.visualstudio.com/UmsPay/_apis/build/status/UmsPay-ASP.NET%20Core-CI)](https://dengyakui.visualstudio.com/UmsPay/_build/latest?definitionId=5)
Supports China Ums qrcode pay

## How to setup the component?
1. Open then samples web project, and add the appsettings.json file based on your payment paramers from your client or ums provider
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
3. More useage details was in Home Controler, you can set up a breakpoint, and open the debugger.
