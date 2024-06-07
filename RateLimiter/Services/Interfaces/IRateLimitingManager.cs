using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RateLimiter.Services.Interfaces
{
    public interface IRateLimitingManager
    {
        Task<(int? StatusCode, string Message)> IsRequestAllowedAsync(string resource, string accessToken);
    }
}
