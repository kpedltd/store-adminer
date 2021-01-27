
namespace StoreAdminer.Components {
    partial class PriceHistoryPage {
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
            this.RootTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.gridView = new System.Windows.Forms.DataGridView();
            this.bottomFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.goodIdNumeric = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.RootTableLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.bottomFlowLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.goodIdNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // RootTableLayout
            // 
            this.RootTableLayout.ColumnCount = 1;
            this.RootTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.RootTableLayout.Controls.Add(this.gridView, 0, 0);
            this.RootTableLayout.Controls.Add(this.bottomFlowLayout, 0, 1);
            this.RootTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RootTableLayout.Location = new System.Drawing.Point(0, 0);
            this.RootTableLayout.Name = "RootTableLayout";
            this.RootTableLayout.RowCount = 2;
            this.RootTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.RootTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.RootTableLayout.Size = new System.Drawing.Size(900, 600);
            this.RootTableLayout.TabIndex = 1;
            // 
            // gridView
            // 
            this.gridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.gridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridView.Location = new System.Drawing.Point(3, 3);
            this.gridView.Name = "gridView";
            this.gridView.RowHeadersVisible = false;
            this.gridView.RowHeadersWidth = 62;
            this.gridView.RowTemplate.Height = 28;
            this.gridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridView.Size = new System.Drawing.Size(894, 529);
            this.gridView.TabIndex = 0;
            // 
            // bottomFlowLayout
            // 
            this.bottomFlowLayout.Controls.Add(this.goodIdNumeric);
            this.bottomFlowLayout.Controls.Add(this.label1);
            this.bottomFlowLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bottomFlowLayout.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.bottomFlowLayout.Location = new System.Drawing.Point(3, 538);
            this.bottomFlowLayout.Name = "bottomFlowLayout";
            this.bottomFlowLayout.Size = new System.Drawing.Size(894, 59);
            this.bottomFlowLayout.TabIndex = 1;
            // 
            // goodIdNumeric
            // 
            this.goodIdNumeric.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.goodIdNumeric.Location = new System.Drawing.Point(771, 14);
            this.goodIdNumeric.Margin = new System.Windows.Forms.Padding(3, 14, 3, 14);
            this.goodIdNumeric.Name = "goodIdNumeric";
            this.goodIdNumeric.Size = new System.Drawing.Size(120, 30);
            this.goodIdNumeric.TabIndex = 1;
            this.goodIdNumeric.ValueChanged += new System.EventHandler(this.IdValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(675, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 15, 3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID товара:";
            // 
            // PriceHistoryPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RootTableLayout);
            this.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PriceHistoryPage";
            this.Size = new System.Drawing.Size(900, 600);
            this.Load += new System.EventHandler(this.OnLoad);
            this.RootTableLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.bottomFlowLayout.ResumeLayout(false);
            this.bottomFlowLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.goodIdNumeric)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel RootTableLayout;
        private System.Windows.Forms.DataGridView gridView;
        private System.Windows.Forms.FlowLayoutPanel bottomFlowLayout;
        private System.Windows.Forms.NumericUpDown goodIdNumeric;
        private System.Windows.Forms.Label label1;
    }
}
