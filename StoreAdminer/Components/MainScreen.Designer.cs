
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
            this.tabs = new System.Windows.Forms.TabControl();
            this.profileTabPage = new System.Windows.Forms.TabPage();
            this.profilePage = new StoreAdminer.Components.ProfilePage();
            this.goodsTabPage = new System.Windows.Forms.TabPage();
            this.goodsPage = new StoreAdminer.Components.GoodsPage();
            this.categoryTabPage = new System.Windows.Forms.TabPage();
            this.categoryPage = new StoreAdminer.Components.CategoryPage();
            this.priceHistoryTabPage = new System.Windows.Forms.TabPage();
            this.priceHistoryPage = new StoreAdminer.Components.PriceHistoryPage();
            this.usersTabPage = new System.Windows.Forms.TabPage();
            this.usersPage = new StoreAdminer.Components.UsersPage();
            this.ordersTabPage = new System.Windows.Forms.TabPage();
            this.ordersPage = new StoreAdminer.Components.OrdersPage();
            this.statisticsTabPage = new System.Windows.Forms.TabPage();
            this.statisticsPage = new StoreAdminer.Components.StatisticsPage();
            this.tabs.SuspendLayout();
            this.profileTabPage.SuspendLayout();
            this.goodsTabPage.SuspendLayout();
            this.categoryTabPage.SuspendLayout();
            this.priceHistoryTabPage.SuspendLayout();
            this.usersTabPage.SuspendLayout();
            this.ordersTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.profileTabPage);
            this.tabs.Controls.Add(this.goodsTabPage);
            this.tabs.Controls.Add(this.categoryTabPage);
            this.tabs.Controls.Add(this.priceHistoryTabPage);
            this.tabs.Controls.Add(this.usersTabPage);
            this.tabs.Controls.Add(this.ordersTabPage);
            this.tabs.Controls.Add(this.statisticsTabPage);
            this.tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabs.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.tabs.Location = new System.Drawing.Point(0, 0);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(900, 600);
            this.tabs.TabIndex = 0;
            // 
            // profileTabPage
            // 
            this.profileTabPage.Controls.Add(this.profilePage);
            this.profileTabPage.Location = new System.Drawing.Point(4, 33);
            this.profileTabPage.Name = "profileTabPage";
            this.profileTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.profileTabPage.Size = new System.Drawing.Size(892, 563);
            this.profileTabPage.TabIndex = 0;
            this.profileTabPage.Text = "Профиль";
            this.profileTabPage.UseVisualStyleBackColor = true;
            // 
            // profilePage
            // 
            this.profilePage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.profilePage.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.profilePage.Location = new System.Drawing.Point(3, 3);
            this.profilePage.Margin = new System.Windows.Forms.Padding(0);
            this.profilePage.Name = "profilePage";
            this.profilePage.Screen = null;
            this.profilePage.Size = new System.Drawing.Size(886, 557);
            this.profilePage.TabIndex = 0;
            // 
            // goodsTabPage
            // 
            this.goodsTabPage.Controls.Add(this.goodsPage);
            this.goodsTabPage.Location = new System.Drawing.Point(4, 33);
            this.goodsTabPage.Name = "goodsTabPage";
            this.goodsTabPage.Size = new System.Drawing.Size(892, 563);
            this.goodsTabPage.TabIndex = 1;
            this.goodsTabPage.Text = "Товары";
            this.goodsTabPage.UseVisualStyleBackColor = true;
            // 
            // goodsPage
            // 
            this.goodsPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.goodsPage.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.goodsPage.Location = new System.Drawing.Point(0, 0);
            this.goodsPage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.goodsPage.Name = "goodsPage";
            this.goodsPage.Screen = null;
            this.goodsPage.Size = new System.Drawing.Size(892, 563);
            this.goodsPage.TabIndex = 0;
            // 
            // categoryTabPage
            // 
            this.categoryTabPage.Controls.Add(this.categoryPage);
            this.categoryTabPage.Location = new System.Drawing.Point(4, 33);
            this.categoryTabPage.Name = "categoryTabPage";
            this.categoryTabPage.Size = new System.Drawing.Size(892, 563);
            this.categoryTabPage.TabIndex = 2;
            this.categoryTabPage.Text = "Категории";
            this.categoryTabPage.UseVisualStyleBackColor = true;
            // 
            // categoryPage
            // 
            this.categoryPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categoryPage.Location = new System.Drawing.Point(0, 0);
            this.categoryPage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.categoryPage.Name = "categoryPage";
            this.categoryPage.Screen = null;
            this.categoryPage.Size = new System.Drawing.Size(892, 563);
            this.categoryPage.TabIndex = 0;
            // 
            // priceHistoryTabPage
            // 
            this.priceHistoryTabPage.Controls.Add(this.priceHistoryPage);
            this.priceHistoryTabPage.Location = new System.Drawing.Point(4, 33);
            this.priceHistoryTabPage.Name = "priceHistoryTabPage";
            this.priceHistoryTabPage.Size = new System.Drawing.Size(892, 563);
            this.priceHistoryTabPage.TabIndex = 3;
            this.priceHistoryTabPage.Text = "История цен";
            this.priceHistoryTabPage.UseVisualStyleBackColor = true;
            // 
            // priceHistoryPage
            // 
            this.priceHistoryPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.priceHistoryPage.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.priceHistoryPage.Location = new System.Drawing.Point(0, 0);
            this.priceHistoryPage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.priceHistoryPage.Name = "priceHistoryPage";
            this.priceHistoryPage.Screen = null;
            this.priceHistoryPage.Size = new System.Drawing.Size(892, 563);
            this.priceHistoryPage.TabIndex = 0;
            // 
            // usersTabPage
            // 
            this.usersTabPage.Controls.Add(this.usersPage);
            this.usersTabPage.Location = new System.Drawing.Point(4, 33);
            this.usersTabPage.Name = "usersTabPage";
            this.usersTabPage.Size = new System.Drawing.Size(892, 563);
            this.usersTabPage.TabIndex = 4;
            this.usersTabPage.Text = "Пользователи";
            this.usersTabPage.UseVisualStyleBackColor = true;
            // 
            // usersPage
            // 
            this.usersPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usersPage.Location = new System.Drawing.Point(0, 0);
            this.usersPage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.usersPage.Name = "usersPage";
            this.usersPage.Screen = null;
            this.usersPage.Size = new System.Drawing.Size(892, 563);
            this.usersPage.TabIndex = 0;
            // 
            // ordersTabPage
            // 
            this.ordersTabPage.Controls.Add(this.ordersPage);
            this.ordersTabPage.Location = new System.Drawing.Point(4, 33);
            this.ordersTabPage.Name = "ordersTabPage";
            this.ordersTabPage.Size = new System.Drawing.Size(892, 563);
            this.ordersTabPage.TabIndex = 5;
            this.ordersTabPage.Text = "Заказы";
            this.ordersTabPage.UseVisualStyleBackColor = true;
            // 
            // ordersPage
            // 
            this.ordersPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ordersPage.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.ordersPage.Location = new System.Drawing.Point(0, 0);
            this.ordersPage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ordersPage.Name = "ordersPage";
            this.ordersPage.Screen = null;
            this.ordersPage.Size = new System.Drawing.Size(892, 563);
            this.ordersPage.TabIndex = 0;
            // 
            // statisticsTabPage
            // 
            this.statisticsTabPage.Controls.Add(this.statisticsPage);
            this.statisticsTabPage.Location = new System.Drawing.Point(4, 33);
            this.statisticsTabPage.Name = "statisticsTabPage";
            this.statisticsTabPage.Size = new System.Drawing.Size(892, 563);
            this.statisticsTabPage.TabIndex = 6;
            this.statisticsTabPage.Text = "Статистика продаж";
            this.statisticsTabPage.UseVisualStyleBackColor = true;
            // 
            // statisticsPage
            // 
            this.statisticsPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statisticsPage.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.statisticsPage.Location = new System.Drawing.Point(0, 0);
            this.statisticsPage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.statisticsPage.Name = "statisticsPage";
            this.statisticsPage.Screen = null;
            this.statisticsPage.Size = new System.Drawing.Size(892, 563);
            this.statisticsPage.TabIndex = 0;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabs);
            this.Name = "MainScreen";
            this.Size = new System.Drawing.Size(900, 600);
            this.tabs.ResumeLayout(false);
            this.profileTabPage.ResumeLayout(false);
            this.goodsTabPage.ResumeLayout(false);
            this.categoryTabPage.ResumeLayout(false);
            this.priceHistoryTabPage.ResumeLayout(false);
            this.usersTabPage.ResumeLayout(false);
            this.ordersTabPage.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private StoreAdminer.Components.CategoryPage categoryPage;
        private System.Windows.Forms.TabPage categoryTabPage;
        private StoreAdminer.Components.GoodsPage goodsPage;
        private System.Windows.Forms.TabPage goodsTabPage;
        private StoreAdminer.Components.OrdersPage ordersPage;
        private System.Windows.Forms.TabPage ordersTabPage;
        private StoreAdminer.Components.PriceHistoryPage priceHistoryPage;
        private System.Windows.Forms.TabPage priceHistoryTabPage;
        private StoreAdminer.Components.ProfilePage profilePage;
        private System.Windows.Forms.TabPage profileTabPage;
        private System.Windows.Forms.TabPage statisticsTabPage;
        private StoreAdminer.Components.StatisticsPage statisticsPage;
        private System.Windows.Forms.TabControl tabs;
        private StoreAdminer.Components.UsersPage usersPage;
        private System.Windows.Forms.TabPage usersTabPage;

        #endregion
    }
}
