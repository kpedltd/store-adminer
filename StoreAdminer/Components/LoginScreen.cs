using StoreAdminer.Data;
using StoreAdminer.Data.Services;
using System;
using System.Windows.Forms;

namespace StoreAdminer.Components {
    public partial class LoginScreen : UserControl, Screen {

        private readonly UserService userService = UserService.GetInstance();
        public Navigator Navigator { get; set; }

        public LoginScreen() {
            InitializeComponent();
        }

        private async void LoginButton_Click(object sender, EventArgs e) {
            LoginButton.Enabled = false;

            var login = LoginTextBox.Text;
            var password = PasswordTextBox.Text;

            try {
                await userService.Login(login, password);

                Navigator.NavigateTo(new MainScreen());

            } catch(HttpError err) {
                var caption = $" {err.StatusCode} - {(int) err.StatusCode}";
                MessageBox.Show(err.Message, caption);

            } catch (Exception err) {
                MessageBox.Show(err.StackTrace, "Ошибка");

            } finally {
                LoginButton.Enabled = true;

            }
        }
    }
}
