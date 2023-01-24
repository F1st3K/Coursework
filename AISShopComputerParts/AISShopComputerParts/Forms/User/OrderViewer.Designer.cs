
namespace AISShopComputerParts
{
    partial class OrderViewer
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
            this.staff = new System.Windows.Forms.ComboBox();
            this.orders = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.idOrder = new System.Windows.Forms.NumericUpDown();
            this.dateTimeOrder = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cheque = new System.Windows.Forms.Button();
            this.groupCart = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.totalPrice = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.discount = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.priceCart = new System.Windows.Forms.NumericUpDown();
            this.status = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.idOrder)).BeginInit();
            this.groupCart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.totalPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.discount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceCart)).BeginInit();
            this.SuspendLayout();
            // 
            // staff
            // 
            this.staff.Enabled = false;
            this.staff.FormattingEnabled = true;
            this.staff.Location = new System.Drawing.Point(550, 13);
            this.staff.Name = "staff";
            this.staff.Size = new System.Drawing.Size(416, 31);
            this.staff.TabIndex = 128;
            // 
            // orders
            // 
            this.orders.Location = new System.Drawing.Point(724, 660);
            this.orders.Name = "orders";
            this.orders.Size = new System.Drawing.Size(242, 39);
            this.orders.TabIndex = 127;
            this.orders.Text = "Вернуться в заказы";
            this.orders.UseVisualStyleBackColor = true;
            this.orders.Click += new System.EventHandler(this.orders_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(441, 12);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 126;
            this.label6.Text = "Сотрудник:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 14);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 23);
            this.label5.TabIndex = 123;
            this.label5.Text = "Код заказа:";
            // 
            // idOrder
            // 
            this.idOrder.Enabled = false;
            this.idOrder.Location = new System.Drawing.Point(172, 12);
            this.idOrder.Name = "idOrder";
            this.idOrder.Size = new System.Drawing.Size(200, 31);
            this.idOrder.TabIndex = 122;
            // 
            // dateTimeOrder
            // 
            this.dateTimeOrder.Enabled = false;
            this.dateTimeOrder.Location = new System.Drawing.Point(172, 58);
            this.dateTimeOrder.Name = "dateTimeOrder";
            this.dateTimeOrder.Size = new System.Drawing.Size(200, 31);
            this.dateTimeOrder.TabIndex = 125;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 58);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 23);
            this.label4.TabIndex = 124;
            this.label4.Text = "Дата время заказа:";
            // 
            // cheque
            // 
            this.cheque.Location = new System.Drawing.Point(18, 660);
            this.cheque.Name = "cheque";
            this.cheque.Size = new System.Drawing.Size(180, 39);
            this.cheque.TabIndex = 120;
            this.cheque.Text = "Оформить чек";
            this.cheque.UseVisualStyleBackColor = true;
            // 
            // groupCart
            // 
            this.groupCart.Controls.Add(this.label2);
            this.groupCart.Controls.Add(this.totalPrice);
            this.groupCart.Controls.Add(this.label1);
            this.groupCart.Controls.Add(this.discount);
            this.groupCart.Controls.Add(this.label3);
            this.groupCart.Controls.Add(this.dataGridView);
            this.groupCart.Controls.Add(this.priceCart);
            this.groupCart.Location = new System.Drawing.Point(12, 95);
            this.groupCart.Name = "groupCart";
            this.groupCart.Size = new System.Drawing.Size(960, 559);
            this.groupCart.TabIndex = 119;
            this.groupCart.TabStop = false;
            this.groupCart.Text = "Корзина";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(732, 524);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 23);
            this.label2.TabIndex = 101;
            this.label2.Text = "Итого:";
            // 
            // totalPrice
            // 
            this.totalPrice.Enabled = false;
            this.totalPrice.Location = new System.Drawing.Point(801, 522);
            this.totalPrice.Name = "totalPrice";
            this.totalPrice.Size = new System.Drawing.Size(153, 31);
            this.totalPrice.TabIndex = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(321, 524);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 23);
            this.label1.TabIndex = 99;
            this.label1.Text = "Скидка в %:";
            // 
            // discount
            // 
            this.discount.Enabled = false;
            this.discount.Location = new System.Drawing.Point(433, 522);
            this.discount.Name = "discount";
            this.discount.Size = new System.Drawing.Size(153, 31);
            this.discount.TabIndex = 98;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 524);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 23);
            this.label3.TabIndex = 97;
            this.label3.Text = "Сумма заказа:";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(6, 30);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(948, 486);
            this.dataGridView.TabIndex = 0;
            // 
            // priceCart
            // 
            this.priceCart.Enabled = false;
            this.priceCart.Location = new System.Drawing.Point(160, 522);
            this.priceCart.Name = "priceCart";
            this.priceCart.Size = new System.Drawing.Size(153, 31);
            this.priceCart.TabIndex = 96;
            // 
            // status
            // 
            this.status.Enabled = false;
            this.status.FormattingEnabled = true;
            this.status.Location = new System.Drawing.Point(550, 58);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(416, 31);
            this.status.TabIndex = 132;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(476, 58);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 23);
            this.label7.TabIndex = 131;
            this.label7.Text = "Статус:";
            // 
            // OrderViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 711);
            this.ControlBox = false;
            this.Controls.Add(this.status);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.staff);
            this.Controls.Add(this.orders);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.idOrder);
            this.Controls.Add(this.dateTimeOrder);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cheque);
            this.Controls.Add(this.groupCart);
            this.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OrderViewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Просмотр продажи";
            ((System.ComponentModel.ISupportInitialize)(this.idOrder)).EndInit();
            this.groupCart.ResumeLayout(false);
            this.groupCart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.totalPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.discount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceCart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox staff;
        private System.Windows.Forms.Button orders;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown idOrder;
        private System.Windows.Forms.DateTimePicker dateTimeOrder;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cheque;
        private System.Windows.Forms.GroupBox groupCart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown totalPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown discount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.NumericUpDown priceCart;
        private System.Windows.Forms.ComboBox status;
        private System.Windows.Forms.Label label7;
    }
}