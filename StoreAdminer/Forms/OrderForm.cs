using System;
using System.Windows.Forms;
using StoreAdminer.Data;
using StoreAdminer.Data.Models;
using StoreAdminer.Data.Services;

namespace StoreAdminer.Forms {
    public partial class OrderForm : Form {
        
        public Order Item { get; set; }
        
        private readonly OrderService _orderService = OrderService.GetInstance();
        
        public OrderForm() {
            InitializeComponent();
            
            gridView.Columns.Add("id", "ID");
            gridView.Columns.Add("name", "Название");
            gridView.Columns.Add("amount", "Количество");
            gridView.Columns.Add("price", "Общая цена");
        }
        
        private void AddItem(Good item) {
            gridView.Rows.Add(
                item.Id, 
                item.Name,
                item.Amount,
                item.Price * item.Amount
                );
        }

        private void OnLoad(object sender, EventArgs e) {
            idLabel.Text = Item.Id.ToString();
            userIdLabel.Text = Item.UserId.ToString();
            userLoginLabel.Text = Item.UserLogin;
            createdAtLabel.Text = Item.CreatedAt.ToLocalTime().ToString("dd.MM.yyyy HH:mm:ss");

            string[] availableStatuses = { Item.Status };
            if (Item.Status == Status.PROCESSING) {
                availableStatuses = new[] {
                    Status.PROCESSING,
                    Status.ACCEPTED,
                    Status.REJECTED
                };
            } else if (Item.Status == Status.ACCEPTED) {
                availableStatuses = new[] {
                    Status.ACCEPTED,
                    Status.IN_TRANSIT
                };
            } else if (Item.Status == Status.IN_TRANSIT) {
                availableStatuses = new[] {
                    Status.IN_TRANSIT,
                    Status.ARRIVED,
                    Status.GONE
                };
            }

            statusComboBox.DataSource = availableStatuses;

            foreach (Good good in Item.Goods) {
                AddItem(good);
            }
        }

        private void statusComboBox_ValueMemberChanged(object sender, EventArgs e) {
            saveButton.Enabled = Item.Status != ((string) ((ComboBox) sender).SelectedValue);
        }

        private async void OnSaveButtonClick(object sender, EventArgs e) {
            try {
                var status = (string) statusComboBox.SelectedValue;
                if (status == Status.ACCEPTED) {
                    await _orderService.AcceptOrder(Item);
                } else if (status == Status.REJECTED) {
                    await _orderService.RejectOrder(Item);
                } else if (status == Status.IN_TRANSIT) {
                    await _orderService.SendOrder(Item);
                } else if (status == Status.ARRIVED) {
                    await _orderService.OrderArrived(Item);
                } else if (status == Status.GONE) {
                    await _orderService.OrderGone(Item);
                } else {
                    MessageBox.Show("Что-то не так", "Ошибка");
                    return;
                }

                Item.Status = status;
                saveButton.Enabled = false;
                DialogResult = DialogResult.OK;
            } catch (HttpError err) { 
                MessageBox.Show(err.Message, "Ошибка");
            }
        }
    }
}