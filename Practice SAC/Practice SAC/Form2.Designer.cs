namespace Practice_SAC
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Purchaser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seller = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Purchase_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sale_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Profit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.Category,
            this.Purchaser,
            this.Seller,
            this.Purchase_Price,
            this.Sale_Price,
            this.Profit});
            this.dataGridView1.Location = new System.Drawing.Point(12, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1080, 179);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Name
            // 
            this.Name.HeaderText = "Name";
            this.Name.MinimumWidth = 8;
            this.Name.Name = "Name";
            this.Name.Width = 150;
            // 
            // Category
            // 
            this.Category.HeaderText = "Category";
            this.Category.MinimumWidth = 8;
            this.Category.Name = "Category";
            this.Category.Width = 150;
            // 
            // Purchaser
            // 
            this.Purchaser.HeaderText = "Purchaser";
            this.Purchaser.MinimumWidth = 8;
            this.Purchaser.Name = "Purchaser";
            this.Purchaser.Width = 150;
            // 
            // Seller
            // 
            this.Seller.HeaderText = "Seller";
            this.Seller.MinimumWidth = 8;
            this.Seller.Name = "Seller";
            this.Seller.Width = 150;
            // 
            // Purchase_Price
            // 
            this.Purchase_Price.HeaderText = "Purchase_Price";
            this.Purchase_Price.MinimumWidth = 8;
            this.Purchase_Price.Name = "Purchase_Price";
            this.Purchase_Price.Width = 150;
            // 
            // Sale_Price
            // 
            this.Sale_Price.HeaderText = "Sale_Price";
            this.Sale_Price.MinimumWidth = 8;
            this.Sale_Price.Name = "Sale_Price";
            this.Sale_Price.Width = 150;
            // 
            // Profit
            // 
            this.Profit.HeaderText = "Profit";
            this.Profit.MinimumWidth = 8;
            this.Profit.Name = "Profit";
            this.Profit.Width = 150;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Purchaser;
        private System.Windows.Forms.DataGridViewTextBoxColumn Seller;
        private System.Windows.Forms.DataGridViewTextBoxColumn Purchase_Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sale_Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Profit;
    }
}