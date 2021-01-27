using System.Windows.Forms;

namespace StoreAdminer.Components
{
    public partial class MainScreen : UserControl, Screen
    {
        public Navigator Navigator { get; set; }

        public MainScreen()
        {
            InitializeComponent();

            //foreach (TabPage tab in Tabs.Controls) {
            //    var tabControls = tab.Controls.GetEnumerator();
            //    if (tabControls.MoveNext()) {
            //        var page = (tabControls.Current as UserControl);
            //        if (page is Page) {
            //            (page as Page).Screen = this;
            //        }
            //    }
            //}
        }
    }
}