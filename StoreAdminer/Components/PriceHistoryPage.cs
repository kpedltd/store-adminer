using StoreAdminer.Data;
using StoreAdminer.Data.Models;
using StoreAdminer.Data.Services;
using System;
using System.Windows.Forms;

namespace StoreAdminer.Components
{
    public partial class PriceHistoryPage : UserControl, Page
    {
        public Screen Screen { get; set; }

        private readonly GoodService goodService = GoodService.GetInstance();

        public PriceHistoryPage()
        {
            InitializeComponent();
        }

        private async void IdValueChanged(object sender, EventArgs e)
        {
            try
            {
                var prices = await goodService.GetPriceHistory((int)goodIdNumeric.Value);
                gridView.Rows.Clear();
                foreach (Price price in prices)
                {
                    AddItem(price);
                }
            }
            catch (HttpError err)
            {
                MessageBox.Show(err.Message, "Ошибка");
            }
        }

        private void AddItem(Price item)
        {
            gridView.Rows.Add(
                item.Id,
                item.Amount,
                item.CreatedAt.ToLocalTime().ToString("dd.MM.yyyy HH:mm:ss")
                );
        }

        private void OnLoad(object sender, EventArgs e)
        {
            gridView.Columns.Add("id", "ID");
            gridView.Columns.Add("price", "Цена");
            gridView.Columns.Add("createdAt", "Дата обновления");
        }
    }
}