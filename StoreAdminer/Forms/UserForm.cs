using StoreAdminer.Data;
using StoreAdminer.Data.Models;
using StoreAdminer.Data.Services;
using System.Collections.Generic;
using System.Windows.Forms;

namespace StoreAdminer.Forms {
    public partial class UserForm : Form {

        private User user;
        private readonly UserService userService = UserService.GetInstance();

        public UserForm(User user) {
            InitializeComponent();

            gridView.Columns.Add("token", "Токен");
            gridView.Columns.Add("expiresAt", "Истекает");
            gridView.Columns.Add("createdByIp", "IP");

            this.user = user;
        }

        private void AddItem(RefreshToken item) {
            gridView.Rows.Add(
                item.Token, 
                item.ExpiresAt.ToLocalTime().ToString("dd.MM.yyyy HH:mm:ss"),
                item.CreatedByIp 
                );
        }

        private async void OnLoad(object sender, System.EventArgs e) {
            loginLabel.Text = user.Login;
            lastNameLabel.Text = user.Lastname;
            firstNameLabel.Text = user.Firstname;
            createdAtLabel.Text = user.CreatedAt.ToLocalTime().ToString();
            lastLoginAtLabel.Text = user.LastLoginAt?.ToLocalTime().ToString();
            lastLoginIpLabel.Text = user.LastLoginIp;
            isBlockedLabel.Text = user.IsBlocked ? "Да" : "Нет";
            restrictButton.Text = user.IsBlocked ? "Разблокировать" : "Заблокировать";

            try {
                var tokens = await userService.GetTokens(user.Id, true);
                foreach (RefreshToken token in tokens) {
                    AddItem(token);
                }
            } catch (HttpError err) {
                MessageBox.Show(err.Message, "Ошибка");
            }
        }

        private async void revokeButton_Click(object sender, System.EventArgs e) {
            var tokens = await userService.GetTokens(user.Id);
            List<RefreshToken> tokensToRevoke = new List<RefreshToken>();
            List<DataGridViewRow> itemsToRemove = new List<DataGridViewRow>();

            foreach (DataGridViewRow item in gridView.SelectedRows) {
                if (item.Cells[0].Value == null) {
                    continue;
                }
                string token = (string) item.Cells[0].Value;
                tokensToRevoke.Add(tokens.Find(refreshToken => refreshToken.Token == token));
                itemsToRemove.Add(item);
            }

            if (tokensToRevoke.Count == 0) {
                MessageBox.Show("Выберете токен для отзыва", "Ошибка");
                return;
            }

            try {
                foreach (RefreshToken token in tokens) {
                    await userService.RevokeRefreshToken(token);
                }
            } catch (HttpError err) {
                MessageBox.Show(err.Message, "Ошибка");
            }

            foreach (DataGridViewRow item in itemsToRemove) {
                gridView.Rows.Remove(item);
            }
            gridView.ClearSelection();
        }

        private async void restrictButton_Click(object sender, System.EventArgs e) {
            var task = user.IsBlocked ? userService.UnblockUser(user.Id) : userService.BlockUser(user.Id);
            await task;
            user.IsBlocked = !user.IsBlocked;
            
            isBlockedLabel.Text = user.IsBlocked ? "Да" : "Нет";
            restrictButton.Text = user.IsBlocked ? "Разблокировать" : "Заблокировать";
        }
    }
}
