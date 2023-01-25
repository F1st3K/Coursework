
namespace AISShopComputerParts
{
    partial class OrderList
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
            this.viewOrder = new System.Windows.Forms.Button();
            this.exportExcel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.staff = new System.Windows.Forms.ComboBox();
            this.statusNegative = new System.Windows.Forms.RadioButton();
            this.statusPositive = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.dateFinish = new System.Windows.Forms.DateTimePicker();
            this.dateStart = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupSort = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.clear = new System.Windows.Forms.Button();
            this.byDate = new System.Windows.Forms.Button();
            this.groupSearch = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.countStrings = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupSort.SuspendLayout();
            this.groupSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // viewOrder
            // 
            this.viewOrder.Location = new System.Drawing.Point(15, 663);
            this.viewOrder.Name = "viewOrder";
            this.viewOrder.Size = new System.Drawing.Size(251, 41);
            this.viewOrder.TabIndex = 124;
            this.viewOrder.Text = "Просмотреть заказ";
            this.viewOrder.UseVisualStyleBackColor = false;
            this.viewOrder.Click += new System.EventHandler(this.viewOrder_Click);
            // 
            // exportExcel
            // 
            this.exportExcel.Location = new System.Drawing.Point(710, 663);
            this.exportExcel.Name = "exportExcel";
            this.exportExcel.Size = new System.Drawing.Size(129, 41);
            this.exportExcel.TabIndex = 123;
            this.exportExcel.Text = "Отчет Excel";
            this.exportExcel.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.staff);
            this.groupBox1.Controls.Add(this.statusNegative);
            this.groupBox1.Controls.Add(this.statusPositive);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.dateFinish);
            this.groupBox1.Controls.Add(this.dateStart);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(15, 391);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(536, 237);
            this.groupBox1.TabIndex = 122;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Фильтрация";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 157);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 23);
            this.label9.TabIndex = 108;
            this.label9.Text = "Сотрудник:";
            // 
            // staff
            // 
            this.staff.FormattingEnabled = true;
            this.staff.Location = new System.Drawing.Point(12, 192);
            this.staff.Name = "staff";
            this.staff.Size = new System.Drawing.Size(518, 31);
            this.staff.TabIndex = 2;
            // 
            // statusNegative
            // 
            this.statusNegative.AutoSize = true;
            this.statusNegative.Location = new System.Drawing.Point(319, 91);
            this.statusNegative.Name = "statusNegative";
            this.statusNegative.Size = new System.Drawing.Size(99, 27);
            this.statusNegative.TabIndex = 107;
            this.statusNegative.TabStop = true;
            this.statusNegative.Text = "Отменен";
            this.statusNegative.UseVisualStyleBackColor = true;
            // 
            // statusPositive
            // 
            this.statusPositive.AutoSize = true;
            this.statusPositive.Location = new System.Drawing.Point(319, 42);
            this.statusPositive.Name = "statusPositive";
            this.statusPositive.Size = new System.Drawing.Size(110, 27);
            this.statusPositive.TabIndex = 106;
            this.statusPositive.TabStop = true;
            this.statusPositive.Text = "Выполнен";
            this.statusPositive.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(285, 15);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 23);
            this.label7.TabIndex = 103;
            this.label7.Text = "Статус:";
            // 
            // dateFinish
            // 
            this.dateFinish.Location = new System.Drawing.Point(51, 91);
            this.dateFinish.Name = "dateFinish";
            this.dateFinish.Size = new System.Drawing.Size(200, 31);
            this.dateFinish.TabIndex = 102;
            // 
            // dateStart
            // 
            this.dateStart.Location = new System.Drawing.Point(51, 36);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(200, 31);
            this.dateStart.TabIndex = 101;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 97);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 23);
            this.label6.TabIndex = 100;
            this.label6.Text = "До:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 42);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 23);
            this.label4.TabIndex = 99;
            this.label4.Text = "От:";
            // 
            // groupSort
            // 
            this.groupSort.Controls.Add(this.label5);
            this.groupSort.Controls.Add(this.clear);
            this.groupSort.Controls.Add(this.byDate);
            this.groupSort.Location = new System.Drawing.Point(557, 474);
            this.groupSort.Name = "groupSort";
            this.groupSort.Size = new System.Drawing.Size(417, 154);
            this.groupSort.TabIndex = 121;
            this.groupSort.TabStop = false;
            this.groupSort.Text = "Сортировка";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(348, 45);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 23);
            this.label5.TabIndex = 101;
            this.label5.Text = "\t↓";
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(7, 107);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(297, 32);
            this.clear.TabIndex = 2;
            this.clear.Text = "Сброс";
            this.clear.UseVisualStyleBackColor = true;
            // 
            // byDate
            // 
            this.byDate.Location = new System.Drawing.Point(7, 40);
            this.byDate.Name = "byDate";
            this.byDate.Size = new System.Drawing.Size(297, 32);
            this.byDate.TabIndex = 1;
            this.byDate.Text = "Дата заказа";
            this.byDate.UseVisualStyleBackColor = true;
            // 
            // groupSearch
            // 
            this.groupSearch.Controls.Add(this.label2);
            this.groupSearch.Controls.Add(this.textSearch);
            this.groupSearch.Location = new System.Drawing.Point(555, 391);
            this.groupSearch.Name = "groupSearch";
            this.groupSearch.Size = new System.Drawing.Size(417, 65);
            this.groupSearch.TabIndex = 120;
            this.groupSearch.TabStop = false;
            this.groupSearch.Text = "Поиск";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 23);
            this.label2.TabIndex = 109;
            this.label2.Text = "Код заказа";
            // 
            // textSearch
            // 
            this.textSearch.Location = new System.Drawing.Point(112, 25);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(299, 31);
            this.textSearch.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(330, 355);
            this.label13.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(20, 23);
            this.label13.TabIndex = 116;
            this.label13.Text = "2";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(360, 355);
            this.label12.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(20, 23);
            this.label12.TabIndex = 115;
            this.label12.Text = "3";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(390, 355);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(20, 23);
            this.label11.TabIndex = 114;
            this.label11.Text = "4";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(300, 355);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 23);
            this.label10.TabIndex = 113;
            this.label10.Text = "1";
            // 
            // countStrings
            // 
            this.countStrings.AutoSize = true;
            this.countStrings.Location = new System.Drawing.Point(195, 353);
            this.countStrings.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.countStrings.Name = "countStrings";
            this.countStrings.Size = new System.Drawing.Size(20, 23);
            this.countStrings.TabIndex = 112;
            this.countStrings.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(0, 353);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(185, 23);
            this.label8.TabIndex = 111;
            this.label8.Text = "Колличество записей:";
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(845, 663);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(129, 41);
            this.back.TabIndex = 110;
            this.back.Text = "В меню";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(4, 6);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(980, 346);
            this.dataGridView.TabIndex = 109;
            // 
            // OrderList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 711);
            this.ControlBox = false;
            this.Controls.Add(this.viewOrder);
            this.Controls.Add(this.exportExcel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupSort);
            this.Controls.Add(this.groupSearch);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.countStrings);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.back);
            this.Controls.Add(this.dataGridView);
            this.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OrderList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderList";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupSort.ResumeLayout(false);
            this.groupSort.PerformLayout();
            this.groupSearch.ResumeLayout(false);
            this.groupSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button viewOrder;
        private System.Windows.Forms.Button exportExcel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox staff;
        private System.Windows.Forms.RadioButton statusNegative;
        private System.Windows.Forms.RadioButton statusPositive;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateFinish;
        private System.Windows.Forms.DateTimePicker dateStart;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupSort;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button byDate;
        private System.Windows.Forms.GroupBox groupSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label countStrings;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}