using System.Windows.Forms;

namespace StoreAdminer.Components
{
    public class ScreenContainer : Panel, Navigator
    {
        private Screen _currentScreen;

        public void NavigateTo(Screen screen)
        {
            screen.Parent = this;
            screen.Dock = DockStyle.Fill;
            screen.Navigator = this;

            _currentScreen?.Dispose();
            _currentScreen = screen;
        }
    }
}