using System.Net.Http;
using System.Threading.Tasks;

namespace StoreAdminer.Data { 
    
    public delegate Task<HttpResponseMessage> Interceptor(Chain chain);
    
}