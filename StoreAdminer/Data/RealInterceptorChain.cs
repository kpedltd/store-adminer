using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace StoreAdminer.Data {
    public class RealInterceptorChain : Chain {
        
        public Request Request { get; set; }

        private readonly int _index;
        private readonly List<Interceptor> _interceptors;
        private int _calls = 0;

        public RealInterceptorChain(
            Request request, 
            int index,
            List<Interceptor> interceptors
            ) {
            
            Request = request;
            _index = index;
            _interceptors = interceptors;
        }

        private RealInterceptorChain Copy(
            Request request,
            int index
            ) {
            return new RealInterceptorChain(request, index, _interceptors);
        }
        
        public async Task<HttpResponseMessage> Proceed(Request request) {
            if (_index > _interceptors.Count) {
                throw new IndexOutOfRangeException($"There is no interceptor under index {_index}");
            }

            _calls++;

            if (_calls > 1) {
                throw new Exception($"Interceptor {_interceptors[_index - 1]} must call Proceed() exactly once");
            }

            if (_index == _interceptors.Count) {
                return await request.Invoke();
            }

            var next = Copy(request, _index + 1);
            var interceptor = _interceptors[_index];

            var response = await interceptor.Invoke(next);
            if (response == null) {
                throw new Exception($"Interceptor {interceptor} returned null");
            }

            return response;
        }
        
    }
}