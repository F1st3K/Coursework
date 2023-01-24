
namespace AISShopComputerParts.Forms.User
{
    partial class OrderCreater
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.groupProducts = new System.Windows.Forms.GroupBox();
            this.groupCart = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonFilter = new System.Windows.Forms.Button();
            this.categoryFilter = new System.Windows.Forms.ComboBox();
            this.stringSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.charactirystics = new System.Windows.Forms.TextBox();
            this.picture = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.countOnAdd = new System.Windows.Forms.NumericUpDown();
            this.addToCart = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.countOnCart = new System.Windows.Forms.NumericUpDown();
            this.delete = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.viewOrder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.groupProducts.SuspendLayout();
            this.groupCart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countOnAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countOnCart)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(6, 30);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(465, 354);
            this.dataGridView.TabIndex = 0;
            // 
            // groupProducts
            // 
            this.groupProducts.Controls.Add(this.addToCart);
            this.groupProducts.Controls.Add(this.label5);
            this.groupProducts.Controls.Add(this.countOnAdd);
            this.groupProducts.Controls.Add(this.picture);
            this.groupProducts.Controls.Add(this.label7);
            this.groupProducts.Controls.Add(this.charactirystics);
            this.groupProducts.Controls.Add(this.label2);
            this.groupProducts.Controls.Add(this.categoryFilter);
            this.groupProducts.Controls.Add(this.buttonFilter);
            this.groupProducts.Controls.Add(this.label1);
            this.groupProducts.Controls.Add(this.dataGridView);
            this.groupProducts.Controls.Add(this.stringSearch);
            this.groupProducts.Location = new System.Drawing.Point(12, 12);
            this.groupProducts.Name = "groupProducts";
            this.groupProducts.Size = new System.Drawing.Size(472, 687);
            this.groupProducts.TabIndex = 2;
            this.groupProducts.TabStop = false;
            this.groupProducts.Text = "Ассортимент";
            // 
            // groupCart
            // 
            this.groupCart.Controls.Add(this.clear);
            this.groupCart.Controls.Add(this.delete);
            this.groupCart.Controls.Add(this.label3);
            this.groupCart.Controls.Add(this.dataGridView1);
            this.groupCart.Controls.Add(this.countOnCart);
            this.groupCart.Location = new System.Drawing.Point(490, 12);
            this.groupCart.Name = "groupCart";
            this.groupCart.Size = new System.Drawing.Size(482, 489);
            this.groupCart.TabIndex = 3;
            this.groupCart.TabStop = false;
            this.groupCart.Text = "Корзина";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(465, 354);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonFilter
            // 
            this.buttonFilter.Location = new System.Drawing.Point(6, 428);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(140, 31);
            this.buttonFilter.TabIndex = 88;
            this.buttonFilter.Text = "Отфильтровать";
            this.buttonFilter.UseVisualStyleBackColor = true;
            // 
            // categoryFilter
            // 
            this.categoryFilter.FormattingEnabled = true;
            this.categoryFilter.Location = new System.Drawing.Point(152, 428);
            this.categoryFilter.Name = "categoryFilter";
            this.categoryFilter.Size = new System.Drawing.Size(314, 31);
            this.categoryFilter.TabIndex = 87;
            // 
            // stringSearch
            // 
            this.stringSearch.Location = new System.Drawing.Point(152, 391);
            this.stringSearch.Name = "stringSearch";
            this.stringSearch.Size = new System.Drawing.Size(314, 31);
            this.stringSearch.TabIndex = 85;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 394);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 23);
            this.label1.TabIndex = 86;
            this.label1.Text = "Код товара:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 466);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 23);
            this.label2.TabIndex = 89;
            this.label2.Text = "Характеристики:";
            // 
            // charactirystics
            // 
            this.charactirystics.Enabled = false;
            this.charactirystics.Location = new System.Drawing.Point(6, 492);
            this.charactirystics.Multiline = true;
            this.charactirystics.Name = "charactirystics";
            this.charactirystics.Size = new System.Drawing.Size(274, 144);
            this.charactirystics.TabIndex = 90;
            // 
            // picture
            // 
            this.picture.Location = new System.Drawing.Point(286, 492);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(180, 144);
            this.picture.TabIndex = 92;
            this.picture.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(287, 466);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 23);
            this.label7.TabIndex = 91;
            this.label7.Text = "Фото:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 650);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 23);
            this.label5.TabIndex = 94;
            this.label5.Text = "Колличество:";
            // 
            // countOnAdd
            // 
            this.countOnAdd.Enabled = false;
            this.countOnAdd.Location = new System.Drawing.Point(127, 648);
            this.countOnAdd.Name = "countOnAdd";
            this.countOnAdd.Size = new System.Drawing.Size(153, 31);
            this.countOnAdd.TabIndex = 93;
            // 
            // addToCart
            // 
            this.addToCart.Location = new System.Drawing.Point(286, 642);
            this.addToCart.Name = "addToCart";
            this.addToCart.Size = new System.Drawing.Size(180, 39);
            this.addToCart.TabIndex = 95;
            this.addToCart.Text = "Добавить в корзину";
            this.addToCart.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 398);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 23);
            this.label3.TabIndex = 97;
            this.label3.Text = "Колличество:";
            // 
            // countOnCart
            // 
            this.countOnCart.Enabled = false;
            this.countOnCart.Location = new System.Drawing.Point(127, 396);
            this.countOnCart.Name = "countOnCart";
            this.countOnCart.Size = new System.Drawing.Size(153, 31);
            this.countOnCart.TabIndex = 96;
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(296, 390);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(180, 39);
            this.delete.TabIndex = 96;
            this.delete.Text = "Удалить";
            this.delete.UseVisualStyleBackColor = true;
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(6, 444);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(274, 39);
            this.clear.TabIndex = 98;
            this.clear.Text = "Очистить корзину";
            this.clear.UseVisualStyleBackColor = true;
            // 
            // viewOrder
            // 
            this.viewOrder.Location = new System.Drawing.Point(687, 609);
            this.viewOrder.Name = "viewOrder";
            this.viewOrder.Size = new System.Drawing.Size(274, 82);
            this.viewOrder.TabIndex = 99;
            this.viewOrder.Text = "Просмотреть заказ";
            this.viewOrder.UseVisualStyleBackColor = true;
            // 
            // OrderCreater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 711);
            this.ControlBox = false;
            this.Controls.Add(this.viewOrder);
            this.Controls.Add(this.groupCart);
            this.Controls.Add(this.groupProducts);
            this.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OrderCreater";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderCreater";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.groupProducts.ResumeLayout(false);
            this.groupProducts.PerformLayout();
            this.groupCart.ResumeLayout(false);
            this.groupCart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countOnAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countOnCart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.GroupBox groupProducts;
        private System.Windows.Forms.GroupBox groupCart;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox categoryFilter;
        private System.Windows.Forms.Button buttonFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox stringSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox charactirystics;
        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button addToCart;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown countOnAdd;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown countOnCart;
        private System.Windows.Forms.Button viewOrder;
    }
}