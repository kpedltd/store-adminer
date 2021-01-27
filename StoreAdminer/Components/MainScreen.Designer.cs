
namespace StoreAdminer.Components {
    partial class MainScreen {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.Tabs = new System.Windows.Forms.TabControl();
            this.ProfilePage = new System.Windows.Forms.TabPage();
            this.profilePage1 = new StoreAdminer.Components.ProfilePage();
            this.GoodsPage = new System.Windows.Forms.TabPage();
            this.goodsPage1 = new StoreAdminer.Components.GoodsPage();
            this.CategoryPage = new System.Windows.Forms.TabPage();
            this.categoryPage1 = new StoreAdminer.Components.CategoryPage();
            this.PriceHistoryPage = new System.Windows.Forms.TabPage();
            this.priceHistoryPage1 = new StoreAdminer.Components.PriceHistoryPage();
            this.UsersPage = new System.Windows.Forms.TabPage();
            this.usersPage1 = new StoreAdminer.Components.UsersPage();
            this.Tabs.SuspendLayout();
            this.ProfilePage.SuspendLayout();
            this.GoodsPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tabs
            // 
            this.Tabs.Controls.Add(this.ProfilePage);
            this.Tabs.Controls.Add(this.GoodsPage);
            this.Tabs.Controls.Add(this.CategoryPage);
            this.Tabs.Controls.Add(this.PriceHistoryPage);
            this.Tabs.Controls.Add(this.UsersPage);
            this.Tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tabs.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Tabs.Location = new System.Drawing.Point(0, 0);
            this.Tabs.Name = "Tabs";
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(900, 600);
            this.Tabs.TabIndex = 0;
            // 
            // ProfilePage
            // 
            this.ProfilePage.Controls.Add(this.profilePage1);
            this.ProfilePage.Location = new System.Drawing.Point(4, 33);
            this.ProfilePage.Name = "ProfilePage";
            this.ProfilePage.Padding = new System.Windows.Forms.Padding(3);
            this.ProfilePage.Size = new System.Drawing.Size(892, 563);
            this.ProfilePage.TabIndex = 0;
            this.ProfilePage.Text = "Профиль";
            this.ProfilePage.UseVisualStyleBackColor = true;
            // 
            // profilePage1
            // 
            this.profilePage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.profilePage1.Location = new System.Drawing.Point(3, 3);
            this.profilePage1.Margin = new System.Windows.Forms.Padding(0);
            this.profilePage1.Name = "profilePage1";
            this.profilePage1.Size = new System.Drawing.Size(886, 557);
            this.profilePage1.TabIndex = 0;
            // 
            // GoodsPage
            // 
            this.GoodsPage.Controls.Add(this.goodsPage1);
            this.GoodsPage.Location = new System.Drawing.Point(4, 33);
            this.GoodsPage.Name = "GoodsPage";
            this.GoodsPage.Size = new System.Drawing.Size(892, 563);
            this.GoodsPage.TabIndex = 1;
            this.GoodsPage.Text = "Товары";
            this.GoodsPage.UseVisualStyleBackColor = true;
            // 
            // goodsPage1
            // 
            this.goodsPage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.goodsPage1.Location = new System.Drawing.Point(0, 0);
            this.goodsPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.goodsPage1.Name = "goodsPage1";
            this.goodsPage1.Size = new System.Drawing.Size(892, 563);
            this.goodsPage1.TabIndex = 0;
            // 
            // CategoryPage
            // 
            this.CategoryPage.Controls.Add(this.categoryPage1);
            this.CategoryPage.Location = new System.Drawing.Point(4, 33);
            this.CategoryPage.Name = "CategoryPage";
            this.CategoryPage.Size = new System.Drawing.Size(892, 563);
            this.CategoryPage.TabIndex = 2;
            this.CategoryPage.Text = "Категории";
            this.CategoryPage.UseVisualStyleBackColor = true;
            // 
            // categoryPage1
            // 
            this.categoryPage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categoryPage1.Location = new System.Drawing.Point(0, 0);
            this.categoryPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.categoryPage1.Name = "categoryPage1";
            this.categoryPage1.Size = new System.Drawing.Size(892, 563);
            this.categoryPage1.TabIndex = 0;
            // 
            // PriceHistoryPage
            // 
            this.PriceHistoryPage.Controls.Add(this.priceHistoryPage1);
            this.PriceHistoryPage.Location = new System.Drawing.Point(4, 33);
            this.PriceHistoryPage.Name = "PriceHistoryPage";
            this.PriceHistoryPage.Size = new System.Drawing.Size(892, 563);
            this.PriceHistoryPage.TabIndex = 3;
            this.PriceHistoryPage.Text = "История цен";
            this.PriceHistoryPage.UseVisualStyleBackColor = true;
            // 
            // priceHistoryPage1
            // 
            this.priceHistoryPage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.priceHistoryPage1.Location = new System.Drawing.Point(0, 0);
            this.priceHistoryPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.priceHistoryPage1.Name = "priceHistoryPage1";
            this.priceHistoryPage1.Size = new System.Drawing.Size(892, 563);
            this.priceHistoryPage1.TabIndex = 0;
            // 
            // UsersPage
            // 
            this.UsersPage.Controls.Add(this.usersPage1);
            this.UsersPage.Location = new System.Drawing.Point(4, 33);
            this.UsersPage.Name = "UsersPage";
            this.UsersPage.Size = new System.Drawing.Size(892, 563);
            this.UsersPage.TabIndex = 4;
            this.UsersPage.Text = "Пользователи";
            this.UsersPage.UseVisualStyleBackColor = true;
            // 
            // usersPage1
            // 
            this.usersPage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usersPage1.Location = new System.Drawing.Point(0, 0);
            this.usersPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.usersPage1.Name = "usersPage1";
            this.usersPage1.Size = new System.Drawing.Size(892, 563);
            this.usersPage1.TabIndex = 0;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Tabs);
            this.Name = "MainScreen";
            this.Size = new System.Drawing.Size(900, 600);
            this.Tabs.ResumeLayout(false);
            this.ProfilePage.ResumeLayout(false);
            this.GoodsPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Tabs;
        private System.Windows.Forms.TabPage ProfilePage;
        private ProfilePage profilePage1;
        private System.Windows.Forms.TabPage GoodsPage;
        private GoodsPage goodsPage1;
        private System.Windows.Forms.TabPage CategoryPage;
        private CategoryPage categoryPage1;
        private System.Windows.Forms.TabPage PriceHistoryPage;
        private PriceHistoryPage priceHistoryPage1;
        private System.Windows.Forms.TabPage UsersPage;
        private UsersPage usersPage1;
    }
}
