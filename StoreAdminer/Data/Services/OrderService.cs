using StoreAdminer.Data.Models;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;

namespace StoreAdminer.Data.Services {
    public class OrderService {

        private static OrderService _instance;

        private readonly CallFactoryProvider callFactory = CallFactoryProvider.GetInstance();
        
        private List<Order> _cachedOrders;

        public static OrderService GetInstance() {
            return _instance ?? (_instance = new OrderService());
        }

        private OrderService() { }

        public async Task<List<Order>> GetOrders(bool isDirty = false) {
            if (_cachedOrders == null || isDirty) {
                _cachedOrders = await callFactory.GetRequestAsync<List<Order>>(Endpoints.ORDERS);
            }
            return _cachedOrders;
        }
        
        public async Task AcceptOrder(Order order) {
            var query = new NameValueCollection() {
                { "orderId", order.Id.ToString() }
            };
            await callFactory.PostRequestAsync(Endpoints.ACCEPT_ORDER, query);
        }
        
        public async Task RejectOrder(Order order) {
            var query = new NameValueCollection() {
                { "orderId", order.Id.ToString() }
            };
            await callFactory.PostRequestAsync(Endpoints.REJECT_ORDER, query);
        }
        
        public async Task SendOrder(Order order) {
            var query = new NameValueCollection() {
                { "orderId", order.Id.ToString() }
            };
            await callFactory.PostRequestAsync(Endpoints.SEND_ORDER, query);
        }
        
        public async Task OrderArrived(Order order) {
            var query = new NameValueCollection() {
                { "orderId", order.Id.ToString() }
            };
            await callFactory.PostRequestAsync(Endpoints.ORDER_ARRIVED, query);
        }
        
        public async Task OrderGone(Order order) {
            var query = new NameValueCollection() {
                { "orderId", order.Id.ToString() }
            };
            await callFactory.PostRequestAsync(Endpoints.ORDER_GONE, query);
        }
        
    }
}
