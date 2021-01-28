using StoreAdminer.Data.Models;
using StoreAdminer.Data.Services;
using System.Windows.Forms;

namespace StoreAdminer.Forms {
    public partial class GoodForm : Form {

        private readonly GoodService goodService = GoodService.GetInstance();

        private Good item;

        public GoodForm(Good item) {
            InitializeComponent();

            this.item = item;
        }

        private async void OnLoad(object sender, System.EventArgs e) {
            var categories = await goodService.GetCategories();

            NameLabel.Text = item.Name;
            PartNumberLabel.Text = item.PartNumber.ToString();
            ManufacturedAtLabel.Text = item.ManufacturedAt.ToString("dd.MM.yyyy");
            CategoryLabel.Text = categories.Find(category => category.Id == item.CategoryId).Name;
            PriceLabel.Text = item.Price.ToString() + " руб.";
            DescriptionTextBox.Text = item.Description;
            DescriptionTextBox.Select(0, 0);
        }
    }
}
