using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Services
{
    public interface IApiClient
    {
        Task<HttpResponseMessage> PostAsync<T>(string endpoint, T content);
    }
}
