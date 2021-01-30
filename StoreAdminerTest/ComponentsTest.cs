using Microsoft.VisualStudio.TestTools.UnitTesting;
using StoreAdminer.Components;

namespace StoreAdminerTest {
    [TestClass]
    public class ComponentsTest {
        
        [TestMethod]
        public void Test_ScreenContainer() {
            var screenContainer = new ScreenContainer();
            PrivateObject accessor = new PrivateObject(screenContainer);

            screenContainer.NavigateTo(new MainScreen());
            var currentScreen = (Screen) accessor.GetField("_currentScreen");
            Assert.IsInstanceOfType(currentScreen, typeof(MainScreen));
            
            screenContainer.NavigateTo(new LoginScreen());
            currentScreen = (Screen) accessor.GetField("_currentScreen");
            Assert.IsInstanceOfType(currentScreen, typeof(LoginScreen));
        }
        
        [TestMethod]
        public void Test_Navigator() {
            var screenContainer = new ScreenContainer();
            PrivateObject containerAccessor = new PrivateObject(screenContainer);

            var screen = new MainScreen();
            PrivateObject screenAccessor = new PrivateObject(screen);
            screenContainer.NavigateTo(screen);
            var profilePage = (ProfilePage) screenAccessor.GetField("profilePage");
            profilePage.Screen.Navigator.NavigateTo(new LoginScreen());

            var currentScreen = containerAccessor.GetField("_currentScreen");
            Assert.IsInstanceOfType(currentScreen, typeof(LoginScreen));
        }
    }
}