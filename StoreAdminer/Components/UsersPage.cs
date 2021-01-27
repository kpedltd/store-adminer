using StoreAdminer.Data;
using StoreAdminer.Data.Models;
using StoreAdminer.Data.Services;
using StoreAdminer.Forms;
using System;
using System.Windows.Forms;

namespace StoreAdminer.Components
{
    public partial class UsersPage : UserControl, Page
    {
        public Screen Screen { get; set; }

        private readonly UserService userService = UserService.GetInstance();

        public UsersPage()
        {
            InitializeComponent();

            gridView.Columns.Add("id", "ID");
            gridView.Columns.Add("login", "Логин");
            gridView.Columns.Add("role", "Роль");
            gridView.Columns.Add("createdAt", "Дата создания");
            gridView.Columns.Add("lastLogin", "Последний вход");
        }

        private async void OnLoad(object sender, EventArgs e)
        {
            try
            {
                var users = await userService.GetUsers();

                foreach (User user in users)
                {
                    AddItem(user);
                }
            }
            catch (HttpError err)
            {
                MessageBox.Show(err.Message, "Ошибка");
            }
        }

        private void AddItem(User item)
        {
            gridView.Rows.Add(
                item.Id,
                item.Login,
                item.Role,
                item.CreatedAt.ToLocalTime().ToString("dd.MM.yyyy HH:mm:ss"),
                item.LastLoginAt?.ToLocalTime().ToString("dd.MM.yyyy HH:mm:ss")
                );
        }

        private void OnCellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = gridView.Rows[e.RowIndex];
            if (row.Cells[0].Value == null)
            {
                return;
            }
            int id = (int)row.Cells[0].Value;
            var user = userService.GetUser(id);
            new UserForm(user).ShowDialog();
        }
    }
}