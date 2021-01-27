
namespace StoreAdminer.Forms {
    partial class AddUpdateCategoryForm {
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
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.ButtonsFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.SaveButton = new System.Windows.Forms.Button();
            this.RootTableLayout.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.ButtonsFlowLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // RootTableLayout
            // 
            this.RootTableLayout.ColumnCount = 1;
            this.RootTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.RootTableLayout.Controls.Add(this.flowLayoutPanel5, 0, 0);
            this.RootTableLayout.Controls.Add(this.ButtonsFlowLayout, 0, 1);
            this.RootTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RootTableLayout.Location = new System.Drawing.Point(0, 0);
            this.RootTableLayout.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.RootTableLayout.Name = "RootTableLayout";
            this.RootTableLayout.RowCount = 2;
            this.RootTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.RootTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 79F));
            this.RootTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.RootTableLayout.Size = new System.Drawing.Size(450, 133);
            this.RootTableLayout.TabIndex = 1;
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.Controls.Add(this.label3);
            this.flowLayoutPanel5.Controls.Add(this.NameTextBox);
            this.flowLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(444, 48);
            this.flowLayoutPanel5.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(4, 6);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Название:";
            // 
            // NameTextBox
            // 
            this.NameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameTextBox.Location = new System.Drawing.Point(101, 5);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 3);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(337, 26);
            this.NameTextBox.TabIndex = 2;
            // 
            // ButtonsFlowLayout
            // 
            this.ButtonsFlowLayout.Controls.Add(this.SaveButton);
            this.ButtonsFlowLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonsFlowLayout.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.ButtonsFlowLayout.Location = new System.Drawing.Point(4, 57);
            this.ButtonsFlowLayout.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ButtonsFlowLayout.Name = "ButtonsFlowLayout";
            this.ButtonsFlowLayout.Size = new System.Drawing.Size(442, 73);
            this.ButtonsFlowLayout.TabIndex = 3;
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveButton.Location = new System.Drawing.Point(152, 3);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(285, 61);
            this.SaveButton.TabIndex = 5;
            this.SaveButton.Text = "Добавить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // AddUpdateCategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 133);
            this.Controls.Add(this.RootTableLayout);
            this.Name = "AddUpdateCategoryForm";
            this.ShowIcon = false;
            this.Text = "Добавить";
            this.Load += new System.EventHandler(this.OnLoad);
            this.RootTableLayout.ResumeLayout(false);
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel5.PerformLayout();
            this.ButtonsFlowLayout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel RootTableLayout;
        private System.Windows.Forms.FlowLayoutPanel ButtonsFlowLayout;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NameTextBox;
    }
}