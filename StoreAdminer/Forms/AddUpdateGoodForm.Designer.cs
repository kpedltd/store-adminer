
namespace StoreAdminer.Forms {
    partial class AddUpdateGoodForm {
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.RootTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.PartNumberTextBox = new System.Windows.Forms.TextBox();
            this.ManufacturedAtDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.AmountNumeric = new System.Windows.Forms.NumericUpDown();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.ButtonsFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.SaveButton = new System.Windows.Forms.Button();
            this.RootTableLayout.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.AmountNumeric)).BeginInit();
            this.ButtonsFlowLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // RootTableLayout
            // 
            this.RootTableLayout.ColumnCount = 1;
            this.RootTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.RootTableLayout.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.RootTableLayout.Controls.Add(this.ButtonsFlowLayout, 0, 1);
            this.RootTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RootTableLayout.Location = new System.Drawing.Point(0, 0);
            this.RootTableLayout.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.RootTableLayout.Name = "RootTableLayout";
            this.RootTableLayout.RowCount = 2;
            this.RootTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.RootTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 79F));
            this.RootTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.RootTableLayout.Size = new System.Drawing.Size(631, 529);
            this.RootTableLayout.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel5, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel4, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(625, 444);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.Controls.Add(this.label3);
            this.flowLayoutPanel5.Controls.Add(this.label1);
            this.flowLayoutPanel5.Controls.Add(this.label2);
            this.flowLayoutPanel5.Controls.Add(this.label4);
            this.flowLayoutPanel5.Controls.Add(this.label7);
            this.flowLayoutPanel5.Controls.Add(this.label6);
            this.flowLayoutPanel5.Controls.Add(this.label5);
            this.flowLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel5.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(194, 438);
            this.flowLayoutPanel5.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label3.Location = new System.Drawing.Point(4, 6);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Название:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label1.Location = new System.Drawing.Point(4, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Артикул:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label2.Location = new System.Drawing.Point(4, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Дата изготовления:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label4.Location = new System.Drawing.Point(4, 114);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "Категория:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label7.Location = new System.Drawing.Point(4, 150);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 24);
            this.label7.TabIndex = 4;
            this.label7.Text = "Количество:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label6.Location = new System.Drawing.Point(4, 186);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 24);
            this.label6.TabIndex = 3;
            this.label6.Text = "Цена:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label5.Location = new System.Drawing.Point(4, 222);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 24);
            this.label5.TabIndex = 2;
            this.label5.Text = "Описание:";
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.NameTextBox);
            this.flowLayoutPanel4.Controls.Add(this.PartNumberTextBox);
            this.flowLayoutPanel4.Controls.Add(this.ManufacturedAtDateTimePicker);
            this.flowLayoutPanel4.Controls.Add(this.CategoryComboBox);
            this.flowLayoutPanel4.Controls.Add(this.AmountNumeric);
            this.flowLayoutPanel4.Controls.Add(this.PriceTextBox);
            this.flowLayoutPanel4.Controls.Add(this.DescriptionTextBox);
            this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel4.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(203, 3);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(419, 438);
            this.flowLayoutPanel4.TabIndex = 0;
            // 
            // NameTextBox
            // 
            this.NameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameTextBox.Location = new System.Drawing.Point(1, 3);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(414, 30);
            this.NameTextBox.TabIndex = 1;
            // 
            // PartNumberTextBox
            // 
            this.PartNumberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PartNumberTextBox.Location = new System.Drawing.Point(1, 39);
            this.PartNumberTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PartNumberTextBox.Name = "PartNumberTextBox";
            this.PartNumberTextBox.Size = new System.Drawing.Size(414, 30);
            this.PartNumberTextBox.TabIndex = 1;
            // 
            // ManufacturedAtDateTimePicker
            // 
            this.ManufacturedAtDateTimePicker.Location = new System.Drawing.Point(1, 75);
            this.ManufacturedAtDateTimePicker.Name = "ManufacturedAtDateTimePicker";
            this.ManufacturedAtDateTimePicker.Size = new System.Drawing.Size(415, 30);
            this.ManufacturedAtDateTimePicker.TabIndex = 2;
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.DisplayMember = "Name";
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Location = new System.Drawing.Point(1, 111);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(415, 32);
            this.CategoryComboBox.TabIndex = 4;
            this.CategoryComboBox.ValueMember = "Id";
            // 
            // AmountNumeric
            // 
            this.AmountNumeric.Location = new System.Drawing.Point(1, 149);
            this.AmountNumeric.Name = "AmountNumeric";
            this.AmountNumeric.Size = new System.Drawing.Size(415, 30);
            this.AmountNumeric.TabIndex = 6;
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PriceTextBox.Location = new System.Drawing.Point(1, 185);
            this.PriceTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(414, 30);
            this.PriceTextBox.TabIndex = 5;
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DescriptionTextBox.Location = new System.Drawing.Point(1, 221);
            this.DescriptionTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DescriptionTextBox.Multiline = true;
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(414, 214);
            this.DescriptionTextBox.TabIndex = 3;
            // 
            // ButtonsFlowLayout
            // 
            this.ButtonsFlowLayout.Controls.Add(this.SaveButton);
            this.ButtonsFlowLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonsFlowLayout.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.ButtonsFlowLayout.Location = new System.Drawing.Point(4, 453);
            this.ButtonsFlowLayout.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ButtonsFlowLayout.Name = "ButtonsFlowLayout";
            this.ButtonsFlowLayout.Size = new System.Drawing.Size(623, 73);
            this.ButtonsFlowLayout.TabIndex = 3;
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.SaveButton.Location = new System.Drawing.Point(333, 3);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(285, 61);
            this.SaveButton.TabIndex = 5;
            this.SaveButton.Text = "Добавить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // AddUpdateGoodForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 529);
            this.Controls.Add(this.RootTableLayout);
            this.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximumSize = new System.Drawing.Size(653, 585);
            this.MinimumSize = new System.Drawing.Size(653, 585);
            this.Name = "AddUpdateGoodForm";
            this.ShowIcon = false;
            this.Text = "Добавить";
            this.Load += new System.EventHandler(this.OnLoad);
            this.RootTableLayout.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel5.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.AmountNumeric)).EndInit();
            this.ButtonsFlowLayout.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.NumericUpDown AmountNumeric;
        private System.Windows.Forms.FlowLayoutPanel ButtonsFlowLayout;
        private System.Windows.Forms.ComboBox CategoryComboBox;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker ManufacturedAtDateTimePicker;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox PartNumberTextBox;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.TableLayoutPanel RootTableLayout;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

        #endregion
    }
}