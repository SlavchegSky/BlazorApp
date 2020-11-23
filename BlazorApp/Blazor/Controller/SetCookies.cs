using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor.Controller
{
    public class SetCookies
    {
        private readonly IHttpContextAccessor _accessor;
        public SetCookies(IHttpContextAccessor accessor)
        {
            _accessor = accessor;
        }

        public void CookiesResponse(string key, string value)
        {
            var context = _accessor.HttpContext;

            if (context != null)
            {
                context.Response.Cookies.Append(key, value);
            }
        }

        public async Task<string> CookiesRequest(string key)
        {
            var context = _accessor.HttpContext;
            string result = "нет";

            if (context != null)
            {
                 context.Request.Cookies.TryGetValue(key, out result);
            }
            
            return await Task.FromResult(result);
        }
    }
}
