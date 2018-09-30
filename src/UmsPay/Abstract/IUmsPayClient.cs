using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UmsPay.Common;

namespace UmsPay.Abstract
{
    public interface IUmsPayClient
    {
        Task<T> ExecuteAsync<T>(IUmsPayRequest<T> request) where T : UmsPayResponseBase;

    }
}
