using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using StoreAdminer.Data.Models;
using StoreAdminer.Data.Services;

namespace StoreAdminer.Components
{
    public partial class StatisticsPage : UserControl, Page
    {
        public Screen Screen { get; set; }

        private readonly StatisticsService _statisticsService = StatisticsService.GetInstance();

        public StatisticsPage()
        {
            InitializeComponent();

            gridView.Columns.Add("id", "ID");
            gridView.Columns.Add("name", "Название");
            gridView.Columns.Add("amount", "Всего продано");
            gridView.Columns.Add("price", "Выручка");
        }

        private void AddItem(Good good)
        {
            gridView.Rows.Add(
                good.Id,
                good.Name,
                good.Amount,
                good.Price.ToString() + " руб."
                );
        }

        private async void OnLoad(object sender, EventArgs e)
        {
            var goods = await _statisticsService.GetGoodStatistics();

            foreach (Good good in goods)
            {
                AddItem(good);
            }

            var categories = await _statisticsService.GetCategoryStatistics();
            FillChart(categories);
        }

        private static readonly string CategoryLegend = "Количество проданных товаров в категорях";

        private void FillChart(IList<Category> categories)
        {
            int accumulator = 0;

            categoryChart.Series[0].Points.Clear();

            for (int i = 0; i < categories.Count; i++)
            {
                categoryChart.Series[0].Points.AddY(categories[i].Amount);
                categoryChart.Series[0].Points[i].LegendText = $"{categories[i].Name} - {categories[i].Amount}";

                accumulator += categories[i].Amount;
            }

            categoryChart.Legends[0].Title = $"{CategoryLegend} - {accumulator}";
        }
    }
}