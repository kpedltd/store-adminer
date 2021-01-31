
namespace StoreAdminer.Components {
    partial class LoginScreen {
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
            this.RootLayout = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.RootLayout.SuspendLayout();
            this.flowLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // RootLayout
            // 
            this.RootLayout.ColumnCount = 3;
            this.RootLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.RootLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 273F));
            this.RootLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.RootLayout.Controls.Add(this.flowLayout, 1, 1);
            this.RootLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RootLayout.Location = new System.Drawing.Point(0, 0);
            this.RootLayout.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.RootLayout.Name = "RootLayout";
            this.RootLayout.RowCount = 3;
            this.RootLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.RootLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 230F));
            this.RootLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.RootLayout.Size = new System.Drawing.Size(900, 600);
            this.RootLayout.TabIndex = 1;
            // 
            // flowLayout
            // 
            this.flowLayout.Controls.Add(this.LoginLabel);
            this.flowLayout.Controls.Add(this.LoginTextBox);
            this.flowLayout.Controls.Add(this.PasswordLabel);
            this.flowLayout.Controls.Add(this.PasswordTextBox);
            this.flowLayout.Controls.Add(this.LoginButton);
            this.flowLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayout.Location = new System.Drawing.Point(317, 188);
            this.flowLayout.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.flowLayout.Name = "flowLayout";
            this.flowLayout.Size = new System.Drawing.Size(265, 224);
            this.flowLayout.TabIndex = 1;
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.LoginLabel.Location = new System.Drawing.Point(0, 0);
            this.LoginLabel.Margin = new System.Windows.Forms.Padding(0);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(54, 24);
            this.LoginLabel.TabIndex = 0;
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LoginTextBox.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.LoginTextBox.Location = new System.Drawing.Point(0, 28);
            this.LoginTextBox.Margin = new System.Windows.Forms.Padding(0, 4, 0, 16);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(264, 30);
            this.LoginTextBox.TabIndex = 1;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.PasswordLabel.Location = new System.Drawing.Point(0, 74);
            this.PasswordLabel.Margin = new System.Windows.Forms.Padding(0);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(68, 24);
            this.PasswordLabel.TabIndex = 2;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PasswordTextBox.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.PasswordTextBox.Location = new System.Drawing.Point(0, 102);
            this.PasswordTextBox.Margin = new System.Windows.Forms.Padding(0, 4, 0, 16);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(264, 30);
            this.PasswordTextBox.TabIndex = 3;
            // 
            // LoginButton
            // 
            this.LoginButton.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.LoginButton.Location = new System.Drawing.Point(4, 151);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(257, 51);
            this.LoginButton.TabIndex = 4;
            this.LoginButton.Text = "Войти";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RootLayout);
            this.Name = "LoginScreen";
            this.Size = new System.Drawing.Size(900, 600);
            this.RootLayout.ResumeLayout(false);
            this.flowLayout.ResumeLayout(false);
            this.flowLayout.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.FlowLayoutPanel flowLayout;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TableLayoutPanel RootLayout;

        #endregion
    }
}
