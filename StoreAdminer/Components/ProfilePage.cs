using StoreAdminer.Data;
using StoreAdminer.Data.Models;
using StoreAdminer.Data.Services;
using System;
using System.Windows.Forms;

namespace StoreAdminer.Components {
    public partial class ProfilePage : UserControl, Page {

        public Screen Screen { get; set; }
        private readonly UserService userService = UserService.GetInstance();

        public ProfilePage() {
            InitializeComponent();
        }

        private async void OnLoad(object sender, EventArgs e) {
            try {
                var profile = await userService.GetProfile();
                UpdateView(profile);

            } catch (HttpError err) {
                var caption = $" {err.StatusCode} - {(int)err.StatusCode}";
                MessageBox.Show(err.Message, caption);

            } catch (Exception err) {
                MessageBox.Show(err.StackTrace, "Error");
            }
        }

        private void UpdateView(User profile) {
            LoginLabel.Text = profile.Login;
            LastNameLabel.Text = profile.Lastname;
            FirstNameLabel.Text = profile.Firstname;
            CreatedAtLabel.Text = profile.CreatedAt.ToLocalTime().ToString();
            LastLoginLabel.Text = profile.LastLoginAt?.ToLocalTime().ToString();
            LastLoginIpLabel.Text = profile.LastLoginIp;
        }

        private async void LogoutButton_Click(object sender, EventArgs e) {
            try {
                await userService.Logout();

                Screen.Navigator.NavigateTo(new LoginScreen());

            } catch(HttpError err) {
                var caption = $" {err.StatusCode} - {(int) err.StatusCode}";
                MessageBox.Show(err.Message, caption);

            } catch(RefreshTokenExpiredException ex) {
                MessageBox.Show("Refresh token is expired", "Error");
                Screen.Navigator.NavigateTo(new LoginScreen());


            } catch (Exception err) {
                Console.WriteLine(err.StackTrace);
                MessageBox.Show(err.Message, "Error");

            }
        }
    }
}
