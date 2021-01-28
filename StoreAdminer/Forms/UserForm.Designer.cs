
namespace StoreAdminer.Forms {
    partial class UserForm {
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ButtonsFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.revokeButton = new System.Windows.Forms.Button();
            this.restrictButton = new System.Windows.Forms.Button();
            this.ProfileFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.createdAtLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.lastLoginAtLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.lastLoginIpLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel7 = new System.Windows.Forms.FlowLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.isBlockedLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.gridView = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            this.ButtonsFlowLayout.SuspendLayout();
            this.ProfileFlowLayout.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.flowLayoutPanel6.SuspendLayout();
            this.flowLayoutPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.gridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.ButtonsFlowLayout, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ProfileFlowLayout, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(591, 576);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // ButtonsFlowLayout
            // 
            this.ButtonsFlowLayout.Controls.Add(this.revokeButton);
            this.ButtonsFlowLayout.Controls.Add(this.restrictButton);
            this.ButtonsFlowLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonsFlowLayout.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.ButtonsFlowLayout.Location = new System.Drawing.Point(3, 514);
            this.ButtonsFlowLayout.Name = "ButtonsFlowLayout";
            this.ButtonsFlowLayout.Size = new System.Drawing.Size(585, 59);
            this.ButtonsFlowLayout.TabIndex = 4;
            // 
            // revokeButton
            // 
            this.revokeButton.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.revokeButton.Location = new System.Drawing.Point(401, 3);
            this.revokeButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.revokeButton.Name = "revokeButton";
            this.revokeButton.Size = new System.Drawing.Size(180, 51);
            this.revokeButton.TabIndex = 5;
            this.revokeButton.Text = "Отозвать";
            this.revokeButton.UseVisualStyleBackColor = true;
            this.revokeButton.Click += new System.EventHandler(this.revokeButton_Click);
            // 
            // restrictButton
            // 
            this.restrictButton.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.restrictButton.Location = new System.Drawing.Point(213, 3);
            this.restrictButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.restrictButton.Name = "restrictButton";
            this.restrictButton.Size = new System.Drawing.Size(180, 51);
            this.restrictButton.TabIndex = 6;
            this.restrictButton.Text = "Заблокировать";
            this.restrictButton.UseVisualStyleBackColor = true;
            this.restrictButton.Click += new System.EventHandler(this.restrictButton_Click);
            // 
            // ProfileFlowLayout
            // 
            this.ProfileFlowLayout.Controls.Add(this.flowLayoutPanel3);
            this.ProfileFlowLayout.Controls.Add(this.flowLayoutPanel1);
            this.ProfileFlowLayout.Controls.Add(this.flowLayoutPanel2);
            this.ProfileFlowLayout.Controls.Add(this.flowLayoutPanel4);
            this.ProfileFlowLayout.Controls.Add(this.flowLayoutPanel5);
            this.ProfileFlowLayout.Controls.Add(this.flowLayoutPanel6);
            this.ProfileFlowLayout.Controls.Add(this.flowLayoutPanel7);
            this.ProfileFlowLayout.Controls.Add(this.label7);
            this.ProfileFlowLayout.Controls.Add(this.gridView);
            this.ProfileFlowLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProfileFlowLayout.Location = new System.Drawing.Point(3, 4);
            this.ProfileFlowLayout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ProfileFlowLayout.Name = "ProfileFlowLayout";
            this.ProfileFlowLayout.Size = new System.Drawing.Size(585, 503);
            this.ProfileFlowLayout.TabIndex = 3;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.label3);
            this.flowLayoutPanel3.Controls.Add(this.loginLabel);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 4);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 10);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(579, 29);
            this.flowLayoutPanel3.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Логин:";
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.loginLabel.Location = new System.Drawing.Point(68, 0);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(66, 24);
            this.loginLabel.TabIndex = 1;
            this.loginLabel.Text = "<none>";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.firstNameLabel);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 47);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 10);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(579, 29);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя:";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.firstNameLabel.Location = new System.Drawing.Point(56, 0);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(66, 24);
            this.firstNameLabel.TabIndex = 1;
            this.firstNameLabel.Text = "<none>";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label2);
            this.flowLayoutPanel2.Controls.Add(this.lastNameLabel);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 90);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 10);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(579, 29);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Фамилия:";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.lastNameLabel.Location = new System.Drawing.Point(93, 0);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(66, 24);
            this.lastNameLabel.TabIndex = 1;
            this.lastNameLabel.Text = "<none>";
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.label4);
            this.flowLayoutPanel4.Controls.Add(this.createdAtLabel);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(3, 133);
            this.flowLayoutPanel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 10);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(579, 29);
            this.flowLayoutPanel4.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Зарегистрирован:";
            // 
            // createdAtLabel
            // 
            this.createdAtLabel.AutoSize = true;
            this.createdAtLabel.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.createdAtLabel.Location = new System.Drawing.Point(155, 0);
            this.createdAtLabel.Name = "createdAtLabel";
            this.createdAtLabel.Size = new System.Drawing.Size(66, 24);
            this.createdAtLabel.TabIndex = 1;
            this.createdAtLabel.Text = "<none>";
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.Controls.Add(this.label5);
            this.flowLayoutPanel5.Controls.Add(this.lastLoginAtLabel);
            this.flowLayoutPanel5.Location = new System.Drawing.Point(3, 176);
            this.flowLayoutPanel5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 10);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(579, 29);
            this.flowLayoutPanel5.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "Последний вход:";
            // 
            // lastLoginAtLabel
            // 
            this.lastLoginAtLabel.AutoSize = true;
            this.lastLoginAtLabel.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.lastLoginAtLabel.Location = new System.Drawing.Point(150, 0);
            this.lastLoginAtLabel.Name = "lastLoginAtLabel";
            this.lastLoginAtLabel.Size = new System.Drawing.Size(66, 24);
            this.lastLoginAtLabel.TabIndex = 1;
            this.lastLoginAtLabel.Text = "<none>";
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.Controls.Add(this.label6);
            this.flowLayoutPanel6.Controls.Add(this.lastLoginIpLabel);
            this.flowLayoutPanel6.Location = new System.Drawing.Point(3, 219);
            this.flowLayoutPanel6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 10);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Size = new System.Drawing.Size(579, 29);
            this.flowLayoutPanel6.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "IP:";
            // 
            // lastLoginIpLabel
            // 
            this.lastLoginIpLabel.AutoSize = true;
            this.lastLoginIpLabel.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.lastLoginIpLabel.Location = new System.Drawing.Point(40, 0);
            this.lastLoginIpLabel.Name = "lastLoginIpLabel";
            this.lastLoginIpLabel.Size = new System.Drawing.Size(66, 24);
            this.lastLoginIpLabel.TabIndex = 1;
            this.lastLoginIpLabel.Text = "<none>";
            // 
            // flowLayoutPanel7
            // 
            this.flowLayoutPanel7.Controls.Add(this.label8);
            this.flowLayoutPanel7.Controls.Add(this.isBlockedLabel);
            this.flowLayoutPanel7.Location = new System.Drawing.Point(3, 262);
            this.flowLayoutPanel7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 10);
            this.flowLayoutPanel7.Name = "flowLayoutPanel7";
            this.flowLayoutPanel7.Size = new System.Drawing.Size(579, 29);
            this.flowLayoutPanel7.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label8.Location = new System.Drawing.Point(3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 24);
            this.label8.TabIndex = 0;
            this.label8.Text = "Заблокирован:";
            // 
            // isBlockedLabel
            // 
            this.isBlockedLabel.AutoSize = true;
            this.isBlockedLabel.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.isBlockedLabel.Location = new System.Drawing.Point(132, 0);
            this.isBlockedLabel.Name = "isBlockedLabel";
            this.isBlockedLabel.Size = new System.Drawing.Size(66, 24);
            this.isBlockedLabel.TabIndex = 1;
            this.isBlockedLabel.Text = "<none>";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label7.Location = new System.Drawing.Point(3, 301);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 24);
            this.label7.TabIndex = 7;
            this.label7.Text = "Токены:";
            // 
            // gridView
            // 
            this.gridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.gridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridView.Location = new System.Drawing.Point(3, 328);
            this.gridView.Name = "gridView";
            this.gridView.RowHeadersVisible = false;
            this.gridView.RowHeadersWidth = 62;
            this.gridView.RowTemplate.Height = 28;
            this.gridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridView.Size = new System.Drawing.Size(580, 171);
            this.gridView.TabIndex = 6;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 576);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(613, 632);
            this.MinimumSize = new System.Drawing.Size(613, 632);
            this.Name = "UserForm";
            this.ShowIcon = false;
            this.Text = "UserForm";
            this.Load += new System.EventHandler(this.OnLoad);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ButtonsFlowLayout.ResumeLayout(false);
            this.ProfileFlowLayout.ResumeLayout(false);
            this.ProfileFlowLayout.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel5.PerformLayout();
            this.flowLayoutPanel6.ResumeLayout(false);
            this.flowLayoutPanel6.PerformLayout();
            this.flowLayoutPanel7.ResumeLayout(false);
            this.flowLayoutPanel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.gridView)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.FlowLayoutPanel ButtonsFlowLayout;
        private System.Windows.Forms.Label createdAtLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel6;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel7;
        private System.Windows.Forms.DataGridView gridView;
        private System.Windows.Forms.Label isBlockedLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lastLoginAtLabel;
        private System.Windows.Forms.Label lastLoginIpLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.FlowLayoutPanel ProfileFlowLayout;
        private System.Windows.Forms.Button restrictButton;
        private System.Windows.Forms.Button revokeButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

        #endregion
    }
}