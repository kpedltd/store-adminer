using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StoreAdminer.Data.Services;
using System.Threading.Tasks;
using System.Diagnostics.CodeAnalysis;
using StoreAdminer.Data.Models;

namespace StoreAdminerTest {
    [TestClass]
    [SuppressMessage("ReSharper", "SuggestVarOrType_Elsewhere")]
    public class ServiceTest {
        
        readonly UserService _userService = UserService.GetInstance();
        readonly GoodService _goodService = GoodService.GetInstance();
        readonly OrderService _orderService = OrderService.GetInstance();
        readonly StatisticsService _statisticsService = StatisticsService.GetInstance();

        [TestInitialize]
        public async Task TestInitialize() {
            bool needToLogin = !await _userService.IsLoggedIn();
            if (needToLogin) {
                await _userService.Login("admin", "qwerty");
            }
        }
        
        [TestMethod]
        public async Task Test_RetrieveUsers() {
            List<User> users = await _userService.GetUsers();

            Assert.AreNotEqual(users.Count, 0);
        }
        
        [TestMethod]
        public async Task Test_RetrieveProfileInfo() {
            User profile = await _userService.GetProfile();

            Assert.AreEqual(profile.Login, "admin");
        }
        
        [TestMethod]
        public async Task Test_RetrieveUserTokens() {
            List<RefreshToken> tokens = await _userService.GetTokens(1);

            Assert.AreNotEqual(tokens.Count, 0);
        }
        
        [TestMethod]
        public async Task Test_RetrieveGoods() {
            List<Good> goods = await _goodService.GetGoods();

            Assert.AreNotEqual(goods.Count, 0);
        }
        
        [TestMethod]
        public async Task Test_RetrieveCategories() {
            List<Category> categories = await _goodService.GetCategories();

            Assert.AreNotEqual(categories.Count, 0);
        }

        [TestMethod]
        public async Task Test_RetrieveOrders() {
            List<Order> orders = await _orderService.GetOrders();

            Assert.AreNotEqual(orders.Count, 0);
        }

        [TestMethod]
        public async Task Test_RetrieveStatistics() {
            List<Good> goods = await _statisticsService.GetGoodStatistics();
            Assert.AreNotEqual(goods.Count, 0);

            List<Category> categories = await _statisticsService.GetCategoryStatistics();
            Assert.AreNotEqual(categories.Count, 0);
        }
    }
}