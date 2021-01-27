using StoreAdminer.Components;
using StoreAdminer.Data;
using StoreAdminer.Data.Services;
using System;
using System.Windows.Forms;

namespace StoreAdminer.Forms {
    public partial class ContainerForm : Form {

        private readonly UserService userService = UserService.GetInstance();

        public ContainerForm() {
            InitializeComponent();

        }

        private async void ContainerForm_Load(object sender, System.EventArgs e) {

            try {
                var isAuthorized = await userService.IsLoggedIn();

                Components.Screen screen;
                if (isAuthorized) {
                    screen = new MainScreen();
                } else {
                    screen = new LoginScreen();
                }

                Container.NavigateTo(screen);
            } catch (Exception err) {
                MessageBox.Show(err.Message, "Ошибка");
                Close();
            }
        }
    }
}
