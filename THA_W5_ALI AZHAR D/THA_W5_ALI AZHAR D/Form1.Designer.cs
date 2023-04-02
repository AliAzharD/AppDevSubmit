namespace THA_W5_ALI_AZHAR_D
{
    partial class Form_AliAzharD
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
            this.button_EditProduct = new System.Windows.Forms.Button();
            this.button2_AddProduct = new System.Windows.Forms.Button();
            this.button_RemoveProduct = new System.Windows.Forms.Button();
            this.button_RemoveCategory = new System.Windows.Forms.Button();
            this.button_AddCategory = new System.Windows.Forms.Button();
            this.DGV_Product = new System.Windows.Forms.DataGridView();
            this.ID_Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nama_Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Harga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_Category = new System.Windows.Forms.DataGridView();
            this.ID_Category_Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nama_Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_Filter = new System.Windows.Forms.Button();
            this.button_All = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox_Category = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_NamaDetail = new System.Windows.Forms.Label();
            this.textBox_NamaDetail = new System.Windows.Forms.TextBox();
            this.textBox_Harga = new System.Windows.Forms.TextBox();
            this.textBox_Stock = new System.Windows.Forms.TextBox();
            this.label_CategoryDetail = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_Stock = new System.Windows.Forms.Label();
            this.textBox_NamaCategory = new System.Windows.Forms.TextBox();
            this.label_Category = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Category)).BeginInit();
            this.SuspendLayout();
            // 
            // button_EditProduct
            // 
            this.button_EditProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button_EditProduct.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_EditProduct.Location = new System.Drawing.Point(343, 470);
            this.button_EditProduct.Name = "button_EditProduct";
            this.button_EditProduct.Size = new System.Drawing.Size(75, 41);
            this.button_EditProduct.TabIndex = 0;
            this.button_EditProduct.Text = "Edit Product";
            this.button_EditProduct.UseVisualStyleBackColor = false;
            this.button_EditProduct.Click += new System.EventHandler(this.button_EditProduct_Click);
            // 
            // button2_AddProduct
            // 
            this.button2_AddProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button2_AddProduct.Location = new System.Drawing.Point(262, 470);
            this.button2_AddProduct.Name = "button2_AddProduct";
            this.button2_AddProduct.Size = new System.Drawing.Size(75, 41);
            this.button2_AddProduct.TabIndex = 1;
            this.button2_AddProduct.Text = "Add Product";
            this.button2_AddProduct.UseVisualStyleBackColor = false;
            this.button2_AddProduct.Click += new System.EventHandler(this.button2_AddProduct_Click);
            // 
            // button_RemoveProduct
            // 
            this.button_RemoveProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button_RemoveProduct.Location = new System.Drawing.Point(424, 470);
            this.button_RemoveProduct.Name = "button_RemoveProduct";
            this.button_RemoveProduct.Size = new System.Drawing.Size(75, 41);
            this.button_RemoveProduct.TabIndex = 2;
            this.button_RemoveProduct.Text = "Remove Product";
            this.button_RemoveProduct.UseVisualStyleBackColor = false;
            this.button_RemoveProduct.Click += new System.EventHandler(this.button_RemoveProduct_Click);
            // 
            // button_RemoveCategory
            // 
            this.button_RemoveCategory.Location = new System.Drawing.Point(769, 266);
            this.button_RemoveCategory.Name = "button_RemoveCategory";
            this.button_RemoveCategory.Size = new System.Drawing.Size(98, 40);
            this.button_RemoveCategory.TabIndex = 3;
            this.button_RemoveCategory.Text = "Remove Category";
            this.button_RemoveCategory.UseVisualStyleBackColor = true;
            this.button_RemoveCategory.Click += new System.EventHandler(this.button_RemoveCategory_Click);
            // 
            // button_AddCategory
            // 
            this.button_AddCategory.Location = new System.Drawing.Point(664, 266);
            this.button_AddCategory.Name = "button_AddCategory";
            this.button_AddCategory.Size = new System.Drawing.Size(99, 40);
            this.button_AddCategory.TabIndex = 4;
            this.button_AddCategory.Text = "Add Category";
            this.button_AddCategory.UseVisualStyleBackColor = true;
            this.button_AddCategory.Click += new System.EventHandler(this.button_AddCategory_Click);
            // 
            // DGV_Product
            // 
            this.DGV_Product.AllowUserToAddRows = false;
            this.DGV_Product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Product.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Product,
            this.Nama_Product,
            this.Harga,
            this.Stock,
            this.ID_Category});
            this.DGV_Product.Location = new System.Drawing.Point(23, 52);
            this.DGV_Product.Name = "DGV_Product";
            this.DGV_Product.RowHeadersVisible = false;
            this.DGV_Product.RowHeadersWidth = 51;
            this.DGV_Product.RowTemplate.Height = 24;
            this.DGV_Product.Size = new System.Drawing.Size(542, 201);
            this.DGV_Product.TabIndex = 5;
            this.DGV_Product.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ID_Product
            // 
            this.ID_Product.HeaderText = "ID Product";
            this.ID_Product.MinimumWidth = 6;
            this.ID_Product.Name = "ID_Product";
            this.ID_Product.Width = 125;
            // 
            // Nama_Product
            // 
            this.Nama_Product.HeaderText = "Nama Product";
            this.Nama_Product.MinimumWidth = 6;
            this.Nama_Product.Name = "Nama_Product";
            this.Nama_Product.Width = 125;
            // 
            // Harga
            // 
            this.Harga.HeaderText = "Harga";
            this.Harga.MinimumWidth = 6;
            this.Harga.Name = "Harga";
            this.Harga.Width = 125;
            // 
            // Stock
            // 
            this.Stock.HeaderText = "Stock";
            this.Stock.MinimumWidth = 6;
            this.Stock.Name = "Stock";
            this.Stock.Width = 125;
            // 
            // ID_Category
            // 
            this.ID_Category.HeaderText = "ID Category";
            this.ID_Category.MinimumWidth = 6;
            this.ID_Category.Name = "ID_Category";
            this.ID_Category.Width = 125;
            // 
            // DGV_Category
            // 
            this.DGV_Category.AllowUserToAddRows = false;
            this.DGV_Category.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Category.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Category_Category,
            this.Nama_Category});
            this.DGV_Category.Location = new System.Drawing.Point(604, 53);
            this.DGV_Category.Name = "DGV_Category";
            this.DGV_Category.RowHeadersVisible = false;
            this.DGV_Category.RowHeadersWidth = 51;
            this.DGV_Category.RowTemplate.Height = 24;
            this.DGV_Category.Size = new System.Drawing.Size(240, 150);
            this.DGV_Category.TabIndex = 6;
            this.DGV_Category.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Category_CellContentClick);
            // 
            // ID_Category_Category
            // 
            this.ID_Category_Category.HeaderText = "ID Category";
            this.ID_Category_Category.MinimumWidth = 6;
            this.ID_Category_Category.Name = "ID_Category_Category";
            this.ID_Category_Category.Width = 125;
            // 
            // Nama_Category
            // 
            this.Nama_Category.HeaderText = "Nama Category";
            this.Nama_Category.MinimumWidth = 6;
            this.Nama_Category.Name = "Nama_Category";
            this.Nama_Category.Width = 125;
            // 
            // button_Filter
            // 
            this.button_Filter.Location = new System.Drawing.Point(261, 23);
            this.button_Filter.Name = "button_Filter";
            this.button_Filter.Size = new System.Drawing.Size(75, 23);
            this.button_Filter.TabIndex = 7;
            this.button_Filter.Text = "Filter:";
            this.button_Filter.UseVisualStyleBackColor = true;
            this.button_Filter.Click += new System.EventHandler(this.button_Filter_Click);
            // 
            // button_All
            // 
            this.button_All.Location = new System.Drawing.Point(180, 23);
            this.button_All.Name = "button_All";
            this.button_All.Size = new System.Drawing.Size(75, 23);
            this.button_All.TabIndex = 8;
            this.button_All.Text = "All";
            this.button_All.UseVisualStyleBackColor = true;
            this.button_All.Click += new System.EventHandler(this.button_All_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(343, 23);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox_Category
            // 
            this.comboBox_Category.FormattingEnabled = true;
            this.comboBox_Category.Location = new System.Drawing.Point(104, 345);
            this.comboBox_Category.Name = "comboBox_Category";
            this.comboBox_Category.Size = new System.Drawing.Size(121, 24);
            this.comboBox_Category.TabIndex = 11;
            this.comboBox_Category.SelectedIndexChanged += new System.EventHandler(this.comboBox_Category_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(601, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "nama:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Broadway", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(100, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Detail";
            // 
            // button_NamaDetail
            // 
            this.button_NamaDetail.AutoSize = true;
            this.button_NamaDetail.ForeColor = System.Drawing.Color.White;
            this.button_NamaDetail.Location = new System.Drawing.Point(29, 307);
            this.button_NamaDetail.Name = "button_NamaDetail";
            this.button_NamaDetail.Size = new System.Drawing.Size(47, 16);
            this.button_NamaDetail.TabIndex = 14;
            this.button_NamaDetail.Text = "Nama:";
            // 
            // textBox_NamaDetail
            // 
            this.textBox_NamaDetail.Location = new System.Drawing.Point(104, 307);
            this.textBox_NamaDetail.Name = "textBox_NamaDetail";
            this.textBox_NamaDetail.Size = new System.Drawing.Size(251, 22);
            this.textBox_NamaDetail.TabIndex = 15;
            this.textBox_NamaDetail.TextChanged += new System.EventHandler(this.textBox_NamaDetail_TextChanged);
            // 
            // textBox_Harga
            // 
            this.textBox_Harga.Location = new System.Drawing.Point(104, 388);
            this.textBox_Harga.Name = "textBox_Harga";
            this.textBox_Harga.Size = new System.Drawing.Size(100, 22);
            this.textBox_Harga.TabIndex = 16;
            this.textBox_Harga.TextChanged += new System.EventHandler(this.textBox_Harga_TextChanged);
            // 
            // textBox_Stock
            // 
            this.textBox_Stock.Location = new System.Drawing.Point(104, 416);
            this.textBox_Stock.Name = "textBox_Stock";
            this.textBox_Stock.Size = new System.Drawing.Size(100, 22);
            this.textBox_Stock.TabIndex = 17;
            this.textBox_Stock.TextChanged += new System.EventHandler(this.textBox_Stock_TextChanged);
            // 
            // label_CategoryDetail
            // 
            this.label_CategoryDetail.AutoSize = true;
            this.label_CategoryDetail.ForeColor = System.Drawing.Color.White;
            this.label_CategoryDetail.Location = new System.Drawing.Point(29, 345);
            this.label_CategoryDetail.Name = "label_CategoryDetail";
            this.label_CategoryDetail.Size = new System.Drawing.Size(65, 16);
            this.label_CategoryDetail.TabIndex = 18;
            this.label_CategoryDetail.Text = "Category:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(29, 390);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Harga:";
            // 
            // label_Stock
            // 
            this.label_Stock.AutoSize = true;
            this.label_Stock.ForeColor = System.Drawing.Color.White;
            this.label_Stock.Location = new System.Drawing.Point(29, 422);
            this.label_Stock.Name = "label_Stock";
            this.label_Stock.Size = new System.Drawing.Size(44, 16);
            this.label_Stock.TabIndex = 20;
            this.label_Stock.Text = "Stock:";
            // 
            // textBox_NamaCategory
            // 
            this.textBox_NamaCategory.Location = new System.Drawing.Point(664, 225);
            this.textBox_NamaCategory.Name = "textBox_NamaCategory";
            this.textBox_NamaCategory.Size = new System.Drawing.Size(151, 22);
            this.textBox_NamaCategory.TabIndex = 21;
            // 
            // label_Category
            // 
            this.label_Category.AutoSize = true;
            this.label_Category.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Category.ForeColor = System.Drawing.Color.White;
            this.label_Category.Location = new System.Drawing.Point(600, 23);
            this.label_Category.Name = "label_Category";
            this.label_Category.Size = new System.Drawing.Size(82, 19);
            this.label_Category.TabIndex = 23;
            this.label_Category.Text = "Category";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(32, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 19);
            this.label3.TabIndex = 24;
            this.label3.Text = "Product";
            // 
            // Form_AliAzharD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(901, 523);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_Category);
            this.Controls.Add(this.textBox_NamaCategory);
            this.Controls.Add(this.label_Stock);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label_CategoryDetail);
            this.Controls.Add(this.textBox_Stock);
            this.Controls.Add(this.textBox_Harga);
            this.Controls.Add(this.textBox_NamaDetail);
            this.Controls.Add(this.button_NamaDetail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_Category);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button_All);
            this.Controls.Add(this.button_Filter);
            this.Controls.Add(this.DGV_Category);
            this.Controls.Add(this.DGV_Product);
            this.Controls.Add(this.button_AddCategory);
            this.Controls.Add(this.button_RemoveCategory);
            this.Controls.Add(this.button_RemoveProduct);
            this.Controls.Add(this.button2_AddProduct);
            this.Controls.Add(this.button_EditProduct);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form_AliAzharD";
            this.Text = "Aplikasi Blink Shop";
            this.Load += new System.EventHandler(this.Form_AliAzharD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Category)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_EditProduct;
        private System.Windows.Forms.Button button2_AddProduct;
        private System.Windows.Forms.Button button_RemoveProduct;
        private System.Windows.Forms.Button button_RemoveCategory;
        private System.Windows.Forms.Button button_AddCategory;
        private System.Windows.Forms.DataGridView DGV_Product;
        private System.Windows.Forms.DataGridView DGV_Category;
        private System.Windows.Forms.Button button_Filter;
        private System.Windows.Forms.Button button_All;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox_Category;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label button_NamaDetail;
        private System.Windows.Forms.TextBox textBox_NamaDetail;
        private System.Windows.Forms.TextBox textBox_Harga;
        private System.Windows.Forms.TextBox textBox_Stock;
        private System.Windows.Forms.Label label_CategoryDetail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_Stock;
        private System.Windows.Forms.TextBox textBox_NamaCategory;
        private System.Windows.Forms.Label label_Category;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nama_Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn Harga;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Category_Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nama_Category;
    }
}

