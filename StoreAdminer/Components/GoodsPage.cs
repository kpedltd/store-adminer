using StoreAdminer.Data;
using StoreAdminer.Data.Models;
using StoreAdminer.Data.Services;
using StoreAdminer.Forms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace StoreAdminer.Components
{
    public partial class GoodsPage : UserControl, Page
    {
        public Screen Screen { get; set; }

        private readonly GoodService goodService = GoodService.GetInstance();

        public GoodsPage()
        {
            InitializeComponent();

            gridView.Columns.Add("id", "ID");
            gridView.Columns.Add("name", "Название");
            gridView.Columns.Add("manufacturedAt", "Дата изготовления");
            gridView.Columns.Add("partNumber", "Артикул");
            gridView.Columns.Add("category", "Категория");
            gridView.Columns.Add("price", "Цена");
        }

        private async void OnLoad(object sender, EventArgs e)
        {
            var categories = await goodService.GetCategories(true);
            var goods = await goodService.GetGoods(true);

            foreach (Good good in goods)
            {
                AddItem(good, categories);
            }
        }

        private void AddItem(Good good, List<Category> categories)
        {
            var categoryName = categories.Find((category) => category.Id == good.CategoryId).Name;
            gridView.Rows.Add(
                good.Id,
                good.Name,
                good.ManufacturedAt.ToString("dd.MM.yyyy"),
                good.PartNumber,
                categoryName,
                good.Price.ToString() + " руб."
                );
        }

        private void UpdateItem(int index, Good good, List<Category> categories)
        {
            var categoryName = categories.Find((category) => category.Id == good.CategoryId).Name;
            var row = gridView.Rows[index];
            row.Cells[0].Value = good.Id;
            row.Cells[1].Value = good.Name;
            row.Cells[2].Value = good.ManufacturedAt.ToString("dd.MM.yyyy");
            row.Cells[3].Value = good.PartNumber;
            row.Cells[4].Value = categoryName;
            row.Cells[5].Value = good.Price.ToString() + " руб.";
        }

        private async void DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = gridView.Rows[e.RowIndex];
            if (row.Cells[0].Value == null)
            {
                return;
            }
            int id = (int)row.Cells[0].Value;
            var goods = await goodService.GetGoods();
            var itemToShow = goods.Find(good => good.Id == id);
            new GoodForm(itemToShow).ShowDialog();
        }

        private async void AddButton_Click(object sender, EventArgs e)
        {
            using (var form = new AddUpdateGoodForm())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    var newItem = form.Item;
                    var categories = await goodService.GetCategories();
                    AddItem(newItem, categories);
                }
            }
        }

        private async void RemoveButton_Click(object sender, EventArgs e)
        {
            var goods = await goodService.GetGoods();
            List<Good> goodsToRemove = new List<Good>();
            List<DataGridViewRow> itemsToRemove = new List<DataGridViewRow>();

            foreach (DataGridViewRow item in gridView.SelectedRows)
            {
                if (item.Cells[0].Value == null)
                {
                    continue;
                }
                int id = (int)item.Cells[0].Value;
                goodsToRemove.Add(goods.Find(good => good.Id == id));
                itemsToRemove.Add(item);
            }

            if (goodsToRemove.Count == 0)
            {
                MessageBox.Show("Выберите товар для удаления", "Ошибка");
                return;
            }

            try
            {
                await goodService.RemoveGoods(goodsToRemove);
            }
            catch (HttpError err)
            {
                MessageBox.Show(err.Message, "Ошибка");
            }

            foreach (DataGridViewRow item in itemsToRemove)
            {
                gridView.Rows.Remove(item);
            }
            gridView.ClearSelection();
        }

        private async void ModifyButton_Click(object sender, EventArgs e)
        {
            var goods = await goodService.GetGoods();
            List<Good> goodsToModify = new List<Good>();
            DataGridViewRow itemToModify = null;

            foreach (DataGridViewRow item in gridView.SelectedRows)
            {
                if (item.Cells[0].Value == null)
                {
                    continue;
                }
                int id = (int)item.Cells[0].Value;
                goodsToModify.Add(goods.Find(good => good.Id == id));
                itemToModify = item;
            }

            if (goodsToModify.Count == 0)
            {
                MessageBox.Show("Выберите товар для изменения", "Ошибка");
                return;
            }
            if (goodsToModify.Count > 1)
            {
                MessageBox.Show("Выберите один товар для изменения", "Ошибка");
                return;
            }

            using (var form = new AddUpdateGoodForm())
            {
                form.Item = goodsToModify[0];
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    var updatedItem = form.Item;
                    var categories = await goodService.GetCategories();
                    UpdateItem(itemToModify.Index, updatedItem, categories);
                }
            }
        }
    }
}