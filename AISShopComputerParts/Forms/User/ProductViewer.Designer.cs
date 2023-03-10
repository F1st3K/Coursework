namespace AISShopComputerParts
{
    partial class ProductViewer
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
            this.label7 = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.NumericUpDown();
            this.count = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.NumericUpDown();
            this.category = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.charactirystics = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.stringSearch = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.categoryFilter = new System.Windows.Forms.ComboBox();
            this.buttonFilter = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.countStrings = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.price)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.count)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.id)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(763, 15);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 23);
            this.label7.TabIndex = 79;
            this.label7.Text = "Фото:";
            // 
            // price
            // 
            this.price.Enabled = false;
            this.price.Location = new System.Drawing.Point(386, 237);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(120, 31);
            this.price.TabIndex = 70;
            // 
            // count
            // 
            this.count.Enabled = false;
            this.count.Location = new System.Drawing.Point(154, 237);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(120, 31);
            this.count.TabIndex = 69;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(101, 15);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 23);
            this.label4.TabIndex = 77;
            this.label4.Text = "Код:";
            // 
            // id
            // 
            this.id.Enabled = false;
            this.id.Location = new System.Drawing.Point(154, 13);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(120, 31);
            this.id.TabIndex = 65;
            // 
            // category
            // 
            this.category.Enabled = false;
            this.category.FormattingEnabled = true;
            this.category.Location = new System.Drawing.Point(386, 12);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(369, 31);
            this.category.TabIndex = 67;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(282, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 23);
            this.label2.TabIndex = 74;
            this.label2.Text = "Категория:";
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(859, 663);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(113, 41);
            this.back.TabIndex = 78;
            this.back.Text = "В меню";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(8, 311);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(964, 346);
            this.dataGridView.TabIndex = 73;
            // 
            // charactirystics
            // 
            this.charactirystics.Enabled = false;
            this.charactirystics.Location = new System.Drawing.Point(154, 87);
            this.charactirystics.Multiline = true;
            this.charactirystics.Name = "charactirystics";
            this.charactirystics.Size = new System.Drawing.Size(601, 144);
            this.charactirystics.TabIndex = 68;
            // 
            // name
            // 
            this.name.Enabled = false;
            this.name.Location = new System.Drawing.Point(154, 50);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(601, 31);
            this.name.TabIndex = 66;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 90);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 23);
            this.label1.TabIndex = 64;
            this.label1.Text = "Характеристики:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 53);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 23);
            this.label3.TabIndex = 63;
            this.label3.Text = "Наименование:";
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(761, 50);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(211, 181);
            this.pictureBox.TabIndex = 80;
            this.pictureBox.TabStop = false;
            // 
            // stringSearch
            // 
            this.stringSearch.Location = new System.Drawing.Point(154, 274);
            this.stringSearch.Name = "stringSearch";
            this.stringSearch.Size = new System.Drawing.Size(352, 31);
            this.stringSearch.TabIndex = 81;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(8, 273);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(138, 31);
            this.buttonSearch.TabIndex = 82;
            this.buttonSearch.Text = "Поиск";
            this.buttonSearch.UseVisualStyleBackColor = true;
            // 
            // categoryFilter
            // 
            this.categoryFilter.FormattingEnabled = true;
            this.categoryFilter.Location = new System.Drawing.Point(670, 273);
            this.categoryFilter.Name = "categoryFilter";
            this.categoryFilter.Size = new System.Drawing.Size(302, 31);
            this.categoryFilter.TabIndex = 83;
            // 
            // buttonFilter
            // 
            this.buttonFilter.Location = new System.Drawing.Point(524, 274);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(139, 31);
            this.buttonFilter.TabIndex = 84;
            this.buttonFilter.Text = "Отфильтровать";
            this.buttonFilter.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(323, 239);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 23);
            this.label6.TabIndex = 86;
            this.label6.Text = "Цена:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 239);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 23);
            this.label5.TabIndex = 85;
            this.label5.Text = "Колличество:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 658);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(185, 23);
            this.label8.TabIndex = 87;
            this.label8.Text = "Колличество записей:";
            // 
            // countStrings
            // 
            this.countStrings.AutoSize = true;
            this.countStrings.Location = new System.Drawing.Point(199, 658);
            this.countStrings.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.countStrings.Name = "countStrings";
            this.countStrings.Size = new System.Drawing.Size(20, 23);
            this.countStrings.TabIndex = 88;
            this.countStrings.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 681);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 23);
            this.label10.TabIndex = 89;
            this.label10.Text = "1";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(94, 681);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(20, 23);
            this.label11.TabIndex = 90;
            this.label11.Text = "4";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(64, 681);
            this.label12.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(20, 23);
            this.label12.TabIndex = 91;
            this.label12.Text = "3";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(34, 681);
            this.label13.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(20, 23);
            this.label13.TabIndex = 92;
            this.label13.Text = "2";
            // 
            // ProductViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 711);
            this.ControlBox = false;
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.countStrings);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonFilter);
            this.Controls.Add(this.categoryFilter);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.stringSearch);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.price);
            this.Controls.Add(this.count);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.id);
            this.Controls.Add(this.category);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.back);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.charactirystics);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProductViewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Просмотр комплектующих";
            ((System.ComponentModel.ISupportInitialize)(this.price)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.count)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.id)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown price;
        private System.Windows.Forms.NumericUpDown count;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown id;
        private System.Windows.Forms.ComboBox category;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox charactirystics;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox stringSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.ComboBox categoryFilter;
        private System.Windows.Forms.Button buttonFilter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label countStrings;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}