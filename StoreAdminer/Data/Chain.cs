using System.Net.Http;
using System.Threading.Tasks;

namespace StoreAdminer.Data {
    public interface Chain {
        
        Request Request { get; set; }

        Task<HttpResponseMessage> Proceed(Request request);
    }
}