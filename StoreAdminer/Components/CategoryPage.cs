using StoreAdminer.Data;
using StoreAdminer.Data.Models;
using StoreAdminer.Data.Services;
using StoreAdminer.Forms;
using System.Collections.Generic;
using System.Windows.Forms;

namespace StoreAdminer.Components
{
    public partial class CategoryPage : UserControl, Page
    {
        public Screen Screen { get; set; }

        private readonly GoodService goodService = GoodService.GetInstance();

        public CategoryPage()
        {
            InitializeComponent();

            gridView.Columns.Add("id", "ID");
            gridView.Columns.Add("name", "Название");
        }

        private async void OnLoad(object sender, System.EventArgs e)
        {
            var categories = await goodService.GetCategories(true);

            foreach (Category category in categories)
            {
                AddItem(category);
            }
        }

        private void AddItem(Category category)
        {
            gridView.Rows.Add(category.Id, category.Name);
        }

        private void UpdateItem(int index, Category category)
        {
            var row = gridView.Rows[index];
            row.Cells[0].Value = category.Id;
            row.Cells[1].Value = category.Name;
        }

        private void AddButton_Click(object sender, System.EventArgs e)
        {
            using (var form = new AddUpdateCategoryForm())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    var newItem = form.Item;
                    AddItem(newItem);
                }
            }
        }

        private async void ModifyButton_Click(object sender, System.EventArgs e)
        {
            var categories = await goodService.GetCategories();
            List<Category> categoriesToModify = new List<Category>();
            DataGridViewRow itemToModify = null;

            foreach (DataGridViewRow item in gridView.SelectedRows)
            {
                if (item.Cells[0].Value == null)
                {
                    continue;
                }
                int id = (int)item.Cells[0].Value;
                categoriesToModify.Add(categories.Find(category => category.Id == id));
                itemToModify = item;
            }

            if (categoriesToModify.Count == 0)
            {
                MessageBox.Show("Выберите товар для изменения", "Ошибка");
                return;
            }
            if (categoriesToModify.Count > 1)
            {
                MessageBox.Show("Выберите один товар для изменения", "Ошибка");
                return;
            }

            using (var form = new AddUpdateCategoryForm())
            {
                form.Item = categoriesToModify[0];
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    var updatedItem = form.Item;
                    UpdateItem(itemToModify.Index, updatedItem);
                }
            }
        }

        private async void RemoveButton_Click(object sender, System.EventArgs e)
        {
            var categories = await goodService.GetCategories();
            List<Category> categoriesToRemove = new List<Category>();
            List<DataGridViewRow> itemsToRemove = new List<DataGridViewRow>();

            foreach (DataGridViewRow item in gridView.SelectedRows)
            {
                if (item.Cells[0].Value == null)
                {
                    continue;
                }
                int id = (int)item.Cells[0].Value;
                categoriesToRemove.Add(categories.Find(category => category.Id == id));
                itemsToRemove.Add(item);
            }

            if (categoriesToRemove.Count == 0)
            {
                MessageBox.Show("Выберите товар для удаления", "Ошибка");
                return;
            }

            try
            {
                await goodService.RemoveCategories(categoriesToRemove);
            }
            catch (HttpError err)
            {
                MessageBox.Show(err.Message, "Ошибка");
                return;
            }

            foreach (DataGridViewRow item in itemsToRemove)
            {
                gridView.Rows.Remove(item);
            }
            gridView.ClearSelection();
        }
    }
}