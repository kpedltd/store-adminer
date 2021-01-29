using System;
using System.Collections.Generic;
using System.Windows.Forms;
using StoreAdminer.Data.Models;
using StoreAdminer.Data.Services;

namespace StoreAdminer.Components {
    public partial class StatisticsPage : UserControl, Page {
        
        public Screen Screen { get; set; }
        
        private readonly StatisticsService _statisticsService = StatisticsService.GetInstance();
        
        public StatisticsPage() {
            InitializeComponent();
            
            gridView.Columns.Add("id", "ID");
            gridView.Columns.Add("name", "Название");
            gridView.Columns.Add("amount", "Всего продано");
            gridView.Columns.Add("price", "Выручка");
        }
        
        private void AddItem(Good good) {
            gridView.Rows.Add(
                good.Id, 
                good.Name,
                good.Amount,
                good.Price.ToString() + " руб."
                );
        }

        private async void OnLoad(object sender, EventArgs e) {
            var goods = await _statisticsService.GetGoodStatistics();

            foreach (Good good in goods) {
                AddItem(good);
            }

            var categories = await _statisticsService.GetCategoryStatistics();
        }
    }
}