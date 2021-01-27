using System.Windows.Forms;

namespace StoreAdminer.Components
{
    public interface Screen
    {
        DockStyle Dock
        {
            get;
            set;
        }

        Control Parent
        {
            get;
            set;
        }

        Navigator Navigator
        {
            get;
            set;
        }

        void Dispose();
    }
}