using StoreAdminer.Data;
using StoreAdminer.Data.Models;
using StoreAdminer.Data.Services;
using System;
using System.Windows.Forms;

namespace StoreAdminer.Forms {
    public partial class AddUpdateGoodForm : Form {

        private readonly GoodService goodService = GoodService.GetInstance();

        public Good Item { get; set; }

        public AddUpdateGoodForm() {
            InitializeComponent();
        }

        private async void SaveButton_Click(object sender, EventArgs e) {

            int partNumber;
            try {
                partNumber = int.Parse(PartNumberTextBox.Text);
            } catch (FormatException) {
                MessageBox.Show("Артикул должен содержать целочисленное значение", "Ошибка");
                return;
            } catch (OverflowException) {
                MessageBox.Show("Значение для артикула не должно быть большим", "Ошибка");
                return;
            }

            decimal price;
            try {
                price = decimal.Parse(PriceTextBox.Text);
            } catch (FormatException) {
                MessageBox.Show("Не похоже на цену", "Ошибка");
                return;
            } catch (OverflowException) {
                MessageBox.Show("Больно бохато", "Ошибка");
                return;
            }

            var good = new Good {
                Name = NameTextBox.Text.GetOrNull(),
                PartNumber = partNumber,
                ManufacturedAt = ManufacturedAtDateTimePicker.Value,
                CategoryId = (int)CategoryComboBox.SelectedValue,
                Amount = (int) AmountNumeric.Value,
                Price = price,
                Description = DescriptionTextBox.Text.GetOrNull()
            };

            if (!good.IsValid()) {
                MessageBox.Show("Все необходимые поля должны быть заполнены", "Ошибка");
                return;
            }

            if (Item == null) {
                var goods = await goodService.GetGoods();
                foreach (Good item in goods) {
                    if (item.PartNumber == good.PartNumber) {
                        MessageBox.Show("Товар с таким артикулом уже существует", "Ошибка");
                        return;
                    }
                }
            }

            try {
                if (Item == null) {
                    Item = await goodService.AddGood(good);
                } else {
                    good.Id = Item.Id;
                    await goodService.UpdateGood(good);
                    Item = good;
                }
                DialogResult = DialogResult.OK;
                Close();
            } catch (HttpError err) {
                MessageBox.Show(err.Message, "Ошибка");
            }

        }

        private async void OnLoad(object sender, EventArgs e) {

            var categories = await goodService.GetCategories();
            CategoryComboBox.DataSource = categories;

            if (Item != null) {
                NameTextBox.Text = Item.Name;
                PartNumberTextBox.Text = Item.PartNumber.ToString();
                ManufacturedAtDateTimePicker.Value = Item.ManufacturedAt;
                CategoryComboBox.SelectedValue = Item.CategoryId;
                AmountNumeric.Value = Item.Amount;
                PriceTextBox.Text = Item.Price.ToString();
                DescriptionTextBox.Text = Item.Description;

                SaveButton.Text = "Изменить";
                Text = "Изменить";
            }
                
        }
    }
}
