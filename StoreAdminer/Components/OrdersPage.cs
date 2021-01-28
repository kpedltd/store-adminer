using System;
using System.Windows.Forms;
using StoreAdminer.Data.Models;
using StoreAdminer.Data.Services;
using StoreAdminer.Forms;

namespace StoreAdminer.Components {
    public partial class OrdersPage : UserControl, Page {

        public Screen Screen { get; set; }
        
        private readonly OrderService _orderService = OrderService.GetInstance();
        
        public OrdersPage() {
            InitializeComponent();
            
            gridView.Columns.Add("id", "ID");
            gridView.Columns.Add("userId", "ID пользователя");
            gridView.Columns.Add("login", "Логин пользователя");
            gridView.Columns.Add("status", "Статус");
            gridView.Columns.Add("createdAt", "Дата создания");
        }

        private async void OnLoad(object sender, EventArgs e) {
            var orders = await _orderService.GetOrders(true);

            foreach (Order order in orders) {
                AddItem(order);
            }
        }
        
        private void AddItem(Order item) {
            gridView.Rows.Add(
                item.Id, 
                item.UserId,
                item.UserLogin,
                item.Status,
                item.CreatedAt.ToLocalTime().ToString("dd.MM.yyyy HH:mm:ss")
                );
        }
        
        private void UpdateItem(int index, Order item) {
            var row = gridView.Rows[index];
            row.Cells[0].Value = item.Id;
            row.Cells[1].Value = item.UserId;
            row.Cells[2].Value = item.UserLogin;
            row.Cells[3].Value = item.Status;
            row.Cells[4].Value = item.CreatedAt.ToLocalTime().ToString("dd.MM.yyyy HH:mm:ss");
        }

        private async void OnCellContentDoubleClick(object sender, DataGridViewCellEventArgs e) {
            var row = gridView.Rows[e.RowIndex];
            if (row.Cells[0].Value == null) {
                return;
            }
            int id = (int) row.Cells[0].Value;
            var orders = await _orderService.GetOrders();
            var itemToShow = orders.Find(order => order.Id == id);
            using (var form = new OrderForm()) {
                form.Item = itemToShow;
                var result = form.ShowDialog();
                if (result == DialogResult.OK) {
                    var newItem = form.Item;
                    UpdateItem(e.RowIndex, newItem);
                }
            }
        }
    }
}
