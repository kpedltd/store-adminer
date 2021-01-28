using StoreAdminer.Data;
using StoreAdminer.Data.Models;
using StoreAdminer.Data.Services;
using System;
using System.Windows.Forms;

namespace StoreAdminer.Forms {
    public partial class AddUpdateCategoryForm : Form {

        private readonly GoodService goodService = GoodService.GetInstance();

        public Category Item { get; set; }

        public AddUpdateCategoryForm() {
            InitializeComponent();
        }

        private async void SaveButton_Click(object sender, EventArgs e) {

            var category = new Category {
                Name = NameTextBox.Text.GetOrNull(),
            };

            if (!category.IsValid()) {
                MessageBox.Show("Все необходимые поля должны быть заполнены", "Ошибка");
            }

            var categories = await goodService.GetCategories();
            foreach (Category item in categories) {
                if (item.Name == category.Name) {
                    MessageBox.Show("Категория с таким именем уже существует", "Ошибка");
                    return;
                }
            }

            try {
                if (Item == null) {
                    Item = await goodService.AddCategory(category);
                } else {
                    category.Id = Item.Id;
                    await goodService.UpdateCategory(category);
                    Item = category;
                }
                DialogResult = DialogResult.OK;
                Close();
            } catch (HttpError err) {
                MessageBox.Show(err.Message, "Ошибка");
            }
        }

        private void OnLoad(object sender, EventArgs e) {

            if (Item != null) {
                NameTextBox.Text = Item.Name;
                SaveButton.Text = "Изменить";
                Text = "Изменить";
            }

        }
    }
}
