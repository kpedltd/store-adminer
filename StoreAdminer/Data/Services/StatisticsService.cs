using StoreAdminer.Data.Models;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;

namespace StoreAdminer.Data.Services {
    public class StatisticsService {

        private static StatisticsService  _instance;

        private readonly CallFactoryProvider callFactory = CallFactoryProvider.GetInstance();
        
        public static StatisticsService  GetInstance() {
            return _instance ?? (_instance = new StatisticsService ());
        }

        private StatisticsService () { }

        public async Task<List<Good>> GetGoodStatistics() {
            return await callFactory.GetRequestAsync<List<Good>>(Endpoints.GOOD_STATISTICS);
        }
        
        public async Task<List<Category>> GetCategoryStatistics() {
            return await callFactory.GetRequestAsync<List<Category>>(Endpoints.CATEGORY_STATISTICS);
        }
        
    }
}
