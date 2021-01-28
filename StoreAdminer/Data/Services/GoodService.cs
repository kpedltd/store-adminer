using StoreAdminer.Data.Models;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;

namespace StoreAdminer.Data.Services {
    public class GoodService {

        private static GoodService _instance;

        private readonly CallFactoryProvider callFactory = CallFactoryProvider.GetInstance();

        private List<Good> _cachedGoods;
        private List<Category> _cachedCategories;

        public static GoodService GetInstance() {
            if (_instance == null) {
                _instance = new GoodService();
            }
            return _instance;
        }

        private GoodService() {}

        public async Task<List<Good>> GetGoods(bool isDirty = false) {
            if (_cachedGoods == null || isDirty) {
                _cachedGoods = await callFactory.GetRequestAsync<List<Good>>(Endpoints.GOOD);
            }
            return _cachedGoods;
        }

        public async Task<Good> AddGood(Good goodToAdd) {
            var addedGood = await callFactory.PostRequestAsync<Good>(
                Endpoints.GOOD,
                content: goodToAdd.ToJsonContent()
                );
            _cachedGoods.Add(addedGood);
            return addedGood;
        }

        public async Task UpdateGood(Good goodToUpdate) {
            await callFactory.PostRequestAsync(Endpoints.UPDATE_GOOD, content: goodToUpdate.ToJsonContent());
            var index = _cachedGoods.FindIndex(good => good.Id == goodToUpdate.Id);
            _cachedGoods[index] = goodToUpdate;
        }

        public async Task RemoveGoods(List<Good> goodsToRemove) {
            await callFactory.PostRequestAsync(Endpoints.REMOVE_GOODS, content: goodsToRemove.ToJsonContent());
            foreach (Good item in goodsToRemove) {
                _cachedGoods.Remove(item);
            }
        }

        public async Task<List<Category>> GetCategories(bool isDirty = false) {
            if (_cachedCategories == null || isDirty) {
                _cachedCategories = await callFactory.GetRequestAsync<List<Category>>(Endpoints.CATEGORY);
            }
            return _cachedCategories;
        }

        public async Task<Category> AddCategory(Category categoryToAdd) {
            var addedCategory = await callFactory.PostRequestAsync<Category>(
                Endpoints.CATEGORY,
                content: categoryToAdd.ToJsonContent()
                );
            _cachedCategories.Add(addedCategory);
            return addedCategory;
        }

        public async Task UpdateCategory(Category categoryToUpdate) {
            await callFactory.PostRequestAsync(Endpoints.UPDATE_CATEGORY, content: categoryToUpdate.ToJsonContent());
            var index = _cachedCategories.FindIndex(category => category.Id == categoryToUpdate.Id);
            _cachedCategories[index] = categoryToUpdate;
        }

        public async Task RemoveCategories(List<Category> categoriesToRemove) {
            await callFactory.PostRequestAsync(Endpoints.REMOVE_CATEGORIES, content: categoriesToRemove.ToJsonContent());
            foreach (Category item in categoriesToRemove) {
                _cachedCategories.Remove(item);
            }
        }

        public async Task<List<Price>> GetPriceHistory(int goodId) {
            var query = new NameValueCollection() {
                { "goodId", goodId.ToString() }
            };
            return await callFactory.PostRequestAsync<List<Price>>(Endpoints.PRICE_HISTORY, query);
        }

    }
}
