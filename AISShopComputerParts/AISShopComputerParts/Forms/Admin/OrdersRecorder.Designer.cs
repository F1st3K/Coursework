namespace AISShopComputerParts
{
    partial class OrdersRecorder
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
            this.pageNumber = new System.Windows.Forms.Label();
            this.countStrings = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.allPrice = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupSearch = new System.Windows.Forms.GroupBox();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.groupSort = new System.Windows.Forms.GroupBox();
            this.symbolSort = new System.Windows.Forms.Label();
            this.clear = new System.Windows.Forms.Button();
            this.byDate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.statusNegative = new System.Windows.Forms.CheckBox();
            this.statusPositive = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.staff = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dateFinish = new System.Windows.Forms.DateTimePicker();
            this.dateStart = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.exportExcel = new System.Windows.Forms.Button();
            this.viewOrder = new System.Windows.Forms.Button();
            this.backPage = new System.Windows.Forms.Button();
            this.nextPage = new System.Windows.Forms.Button();
            this.finishPage = new System.Windows.Forms.Button();
            this.startPage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView)).BeginInit();
            this.groupSearch.SuspendLayout();
            this.groupSort.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pageNumber
            // 
            this.pageNumber.AutoSize = true;
            this.pageNumber.Location = new System.Drawing.Point(328, 355);
            this.pageNumber.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.pageNumber.Name = "pageNumber";
            this.pageNumber.Size = new System.Drawing.Size(25, 29);
            this.pageNumber.TabIndex = 97;
            this.pageNumber.Text = "1";
            // 
            // countStrings
            // 
            this.countStrings.AutoSize = true;
            this.countStrings.Location = new System.Drawing.Point(193, 348);
            this.countStrings.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.countStrings.Name = "countStrings";
            this.countStrings.Size = new System.Drawing.Size(25, 29);
            this.countStrings.TabIndex = 96;
            this.countStrings.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(-2, 348);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(237, 29);
            this.label8.TabIndex = 95;
            this.label8.Text = "Колличество записей:";
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(843, 658);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(129, 41);
            this.back.TabIndex = 94;
            this.back.Text = "В меню";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(2, 1);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(980, 346);
            this.dataGridView.TabIndex = 93;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewCellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(551, 350);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 29);
            this.label1.TabIndex = 101;
            this.label1.Text = "Сумма оплаченных заказов: ";
            // 
            // allPrice
            // 
            this.allPrice.AutoSize = true;
            this.allPrice.Location = new System.Drawing.Point(802, 350);
            this.allPrice.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.allPrice.Name = "allPrice";
            this.allPrice.Size = new System.Drawing.Size(25, 29);
            this.allPrice.TabIndex = 102;
            this.allPrice.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(926, 350);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 29);
            this.label3.TabIndex = 103;
            this.label3.Text = "руб.";
            // 
            // groupSearch
            // 
            this.groupSearch.Controls.Add(this.textSearch);
            this.groupSearch.Location = new System.Drawing.Point(553, 386);
            this.groupSearch.Name = "groupSearch";
            this.groupSearch.Size = new System.Drawing.Size(417, 65);
            this.groupSearch.TabIndex = 104;
            this.groupSearch.TabStop = false;
            this.groupSearch.Text = "Поиск";
            // 
            // textSearch
            // 
            this.textSearch.Location = new System.Drawing.Point(9, 25);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(402, 36);
            this.textSearch.TabIndex = 1;
            this.textSearch.TextChanged += new System.EventHandler(this.OnSearch);
            // 
            // groupSort
            // 
            this.groupSort.Controls.Add(this.symbolSort);
            this.groupSort.Controls.Add(this.clear);
            this.groupSort.Controls.Add(this.byDate);
            this.groupSort.Location = new System.Drawing.Point(555, 469);
            this.groupSort.Name = "groupSort";
            this.groupSort.Size = new System.Drawing.Size(417, 154);
            this.groupSort.TabIndex = 105;
            this.groupSort.TabStop = false;
            this.groupSort.Text = "Сортировка";
            // 
            // symbolSort
            // 
            this.symbolSort.AutoSize = true;
            this.symbolSort.Location = new System.Drawing.Point(348, 45);
            this.symbolSort.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.symbolSort.Name = "symbolSort";
            this.symbolSort.Size = new System.Drawing.Size(35, 29);
            this.symbolSort.TabIndex = 101;
            this.symbolSort.Text = "\t↓";
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(7, 107);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(297, 32);
            this.clear.TabIndex = 2;
            this.clear.Text = "Сброс";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.OnLoad);
            // 
            // byDate
            // 
            this.byDate.Location = new System.Drawing.Point(7, 40);
            this.byDate.Name = "byDate";
            this.byDate.Size = new System.Drawing.Size(297, 32);
            this.byDate.TabIndex = 1;
            this.byDate.Text = "Дата заказа";
            this.byDate.UseVisualStyleBackColor = true;
            this.byDate.Click += new System.EventHandler(this.OnSort);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.statusNegative);
            this.groupBox1.Controls.Add(this.statusPositive);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.staff);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.dateFinish);
            this.groupBox1.Controls.Add(this.dateStart);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(13, 386);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(536, 237);
            this.groupBox1.TabIndex = 106;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Фильтрация";
            this.groupBox1.TextChanged += new System.EventHandler(this.OnFilter);
            // 
            // statusNegative
            // 
            this.statusNegative.Checked = true;
            this.statusNegative.CheckState = System.Windows.Forms.CheckState.Checked;
            this.statusNegative.Location = new System.Drawing.Point(319, 93);
            this.statusNegative.Name = "statusNegative";
            this.statusNegative.Size = new System.Drawing.Size(173, 39);
            this.statusNegative.TabIndex = 110;
            this.statusNegative.Text = "Отменен";
            this.statusNegative.UseVisualStyleBackColor = true;
            this.statusNegative.Click += new System.EventHandler(this.OnFilter);
            // 
            // statusPositive
            // 
            this.statusPositive.Checked = true;
            this.statusPositive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.statusPositive.Location = new System.Drawing.Point(319, 42);
            this.statusPositive.Name = "statusPositive";
            this.statusPositive.Size = new System.Drawing.Size(182, 30);
            this.statusPositive.TabIndex = 109;
            this.statusPositive.Text = "Выполнен";
            this.statusPositive.UseVisualStyleBackColor = true;
            this.statusPositive.Click += new System.EventHandler(this.OnFilter);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 157);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 29);
            this.label9.TabIndex = 108;
            this.label9.Text = "Сотрудник:";
            // 
            // staff
            // 
            this.staff.FormattingEnabled = true;
            this.staff.Location = new System.Drawing.Point(12, 192);
            this.staff.Name = "staff";
            this.staff.Size = new System.Drawing.Size(518, 37);
            this.staff.TabIndex = 2;
            this.staff.SelectedValueChanged += new System.EventHandler(this.OnFilter);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(285, 15);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 29);
            this.label7.TabIndex = 103;
            this.label7.Text = "Статус:";
            // 
            // dateFinish
            // 
            this.dateFinish.CustomFormat = "d.MM.yyyy HH:m";
            this.dateFinish.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateFinish.Location = new System.Drawing.Point(51, 91);
            this.dateFinish.Name = "dateFinish";
            this.dateFinish.ShowUpDown = true;
            this.dateFinish.Size = new System.Drawing.Size(226, 36);
            this.dateFinish.TabIndex = 102;
            // 
            // dateStart
            // 
            this.dateStart.CustomFormat = "d.MM.yyyy HH:m";
            this.dateStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateStart.Location = new System.Drawing.Point(51, 36);
            this.dateStart.Name = "dateStart";
            this.dateStart.ShowUpDown = true;
            this.dateStart.Size = new System.Drawing.Size(226, 36);
            this.dateStart.TabIndex = 101;
            this.dateStart.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateStart.ValueChanged += new System.EventHandler(this.OnFilter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 97);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 29);
            this.label6.TabIndex = 100;
            this.label6.Text = "До:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 42);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 29);
            this.label4.TabIndex = 99;
            this.label4.Text = "От:";
            // 
            // exportExcel
            // 
            this.exportExcel.Location = new System.Drawing.Point(708, 658);
            this.exportExcel.Name = "exportExcel";
            this.exportExcel.Size = new System.Drawing.Size(129, 41);
            this.exportExcel.TabIndex = 107;
            this.exportExcel.Text = "Отчет Excel";
            this.exportExcel.UseVisualStyleBackColor = false;
            // 
            // viewOrder
            // 
            this.viewOrder.Location = new System.Drawing.Point(13, 658);
            this.viewOrder.Name = "viewOrder";
            this.viewOrder.Size = new System.Drawing.Size(251, 41);
            this.viewOrder.TabIndex = 108;
            this.viewOrder.Text = "Просмотреть заказ";
            this.viewOrder.UseVisualStyleBackColor = false;
            this.viewOrder.Click += new System.EventHandler(this.viewOrder_Click);
            // 
            // backPage
            // 
            this.backPage.Location = new System.Drawing.Point(302, 353);
            this.backPage.Name = "backPage";
            this.backPage.Size = new System.Drawing.Size(26, 27);
            this.backPage.TabIndex = 109;
            this.backPage.Text = "<";
            this.backPage.UseVisualStyleBackColor = true;
            this.backPage.Click += new System.EventHandler(this.backPage_Click);
            // 
            // nextPage
            // 
            this.nextPage.Location = new System.Drawing.Point(346, 353);
            this.nextPage.Name = "nextPage";
            this.nextPage.Size = new System.Drawing.Size(26, 27);
            this.nextPage.TabIndex = 110;
            this.nextPage.Text = ">";
            this.nextPage.UseVisualStyleBackColor = true;
            this.nextPage.Click += new System.EventHandler(this.nextPage_Click);
            // 
            // finishPage
            // 
            this.finishPage.Location = new System.Drawing.Point(378, 353);
            this.finishPage.Name = "finishPage";
            this.finishPage.Size = new System.Drawing.Size(73, 27);
            this.finishPage.TabIndex = 111;
            this.finishPage.Text = " ";
            this.finishPage.UseVisualStyleBackColor = true;
            // 
            // startPage
            // 
            this.startPage.Location = new System.Drawing.Point(223, 353);
            this.startPage.Name = "startPage";
            this.startPage.Size = new System.Drawing.Size(73, 27);
            this.startPage.TabIndex = 112;
            this.startPage.Text = " ";
            this.startPage.UseVisualStyleBackColor = true;
            // 
            // OrdersRecorder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 711);
            this.ControlBox = false;
            this.Controls.Add(this.startPage);
            this.Controls.Add(this.finishPage);
            this.Controls.Add(this.nextPage);
            this.Controls.Add(this.backPage);
            this.Controls.Add(this.viewOrder);
            this.Controls.Add(this.exportExcel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupSort);
            this.Controls.Add(this.groupSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.allPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pageNumber);
            this.Controls.Add(this.countStrings);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.back);
            this.Controls.Add(this.dataGridView);
            this.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OrdersRecorder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Учет продаж";
            this.Load += new System.EventHandler(this.OnLoad);
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView)).EndInit();
            this.groupSearch.ResumeLayout(false);
            this.groupSearch.PerformLayout();
            this.groupSort.ResumeLayout(false);
            this.groupSort.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label symbolSort;

        private System.Windows.Forms.CheckBox statusPositive;

        private System.Windows.Forms.CheckBox checkBox1statusNegative;

        #endregion
        private System.Windows.Forms.Label pageNumber;
        private System.Windows.Forms.Label countStrings;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label allPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupSearch;
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.GroupBox groupSort;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button byDate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox staff;
        private System.Windows.Forms.CheckBox statusNegative;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateFinish;
        private System.Windows.Forms.DateTimePicker dateStart;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button exportExcel;
        private System.Windows.Forms.Button viewOrder;
        private System.Windows.Forms.Button backPage;
        private System.Windows.Forms.Button nextPage;
        private System.Windows.Forms.Button finishPage;
        private System.Windows.Forms.Button startPage;
    }
}