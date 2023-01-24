
namespace AISShopComputerParts.Forms.User
{
    partial class PreviewerOrder
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
            this.groupCart = new System.Windows.Forms.GroupBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.createOrder = new System.Windows.Forms.Button();
            this.cheque = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.priceCart = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.discount = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.totalPrice = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimeOrder = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.idOrder = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.staffFullName = new System.Windows.Forms.Label();
            this.groupCart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.discount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idOrder)).BeginInit();
            this.SuspendLayout();
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
            this.groupCart.Location = new System.Drawing.Point(12, 12);
            this.groupCart.Name = "groupCart";
            this.groupCart.Size = new System.Drawing.Size(960, 527);
            this.groupCart.TabIndex = 4;
            this.groupCart.TabStop = false;
            this.groupCart.Text = "Корзина";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(6, 30);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(948, 454);
            this.dataGridView.TabIndex = 0;
            // 
            // createOrder
            // 
            this.createOrder.Location = new System.Drawing.Point(692, 660);
            this.createOrder.Name = "createOrder";
            this.createOrder.Size = new System.Drawing.Size(274, 39);
            this.createOrder.TabIndex = 98;
            this.createOrder.Text = "Занести\r\n";
            this.createOrder.UseVisualStyleBackColor = true;
            // 
            // cheque
            // 
            this.cheque.Location = new System.Drawing.Point(467, 660);
            this.cheque.Name = "cheque";
            this.cheque.Size = new System.Drawing.Size(180, 39);
            this.cheque.TabIndex = 96;
            this.cheque.Text = "Оформить чек";
            this.cheque.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 492);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 23);
            this.label3.TabIndex = 97;
            this.label3.Text = "Сумма заказа:";
            // 
            // priceCart
            // 
            this.priceCart.Enabled = false;
            this.priceCart.Location = new System.Drawing.Point(160, 490);
            this.priceCart.Name = "priceCart";
            this.priceCart.Size = new System.Drawing.Size(153, 31);
            this.priceCart.TabIndex = 96;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(321, 492);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 23);
            this.label1.TabIndex = 99;
            this.label1.Text = "Скидка в %:";
            // 
            // discount
            // 
            this.discount.Location = new System.Drawing.Point(433, 490);
            this.discount.Name = "discount";
            this.discount.Size = new System.Drawing.Size(153, 31);
            this.discount.TabIndex = 98;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(732, 492);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 23);
            this.label2.TabIndex = 101;
            this.label2.Text = "Итого:";
            // 
            // totalPrice
            // 
            this.totalPrice.Enabled = false;
            this.totalPrice.Location = new System.Drawing.Point(801, 490);
            this.totalPrice.Name = "totalPrice";
            this.totalPrice.Size = new System.Drawing.Size(153, 31);
            this.totalPrice.TabIndex = 100;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 591);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 23);
            this.label4.TabIndex = 103;
            this.label4.Text = "Дата время заказа:";
            // 
            // dateTimeOrder
            // 
            this.dateTimeOrder.Location = new System.Drawing.Point(172, 591);
            this.dateTimeOrder.Name = "dateTimeOrder";
            this.dateTimeOrder.Size = new System.Drawing.Size(200, 31);
            this.dateTimeOrder.TabIndex = 104;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 547);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 23);
            this.label5.TabIndex = 103;
            this.label5.Text = "Код заказа:";
            // 
            // idOrder
            // 
            this.idOrder.Enabled = false;
            this.idOrder.Location = new System.Drawing.Point(172, 545);
            this.idOrder.Name = "idOrder";
            this.idOrder.Size = new System.Drawing.Size(200, 31);
            this.idOrder.TabIndex = 102;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(441, 545);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 105;
            this.label6.Text = "Сотрудник:";
            // 
            // staffFullName
            // 
            this.staffFullName.AutoSize = true;
            this.staffFullName.Location = new System.Drawing.Point(582, 547);
            this.staffFullName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.staffFullName.Name = "staffFullName";
            this.staffFullName.Size = new System.Drawing.Size(16, 23);
            this.staffFullName.TabIndex = 106;
            this.staffFullName.Text = "-";
            // 
            // PreviewerOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 711);
            this.ControlBox = false;
            this.Controls.Add(this.staffFullName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.idOrder);
            this.Controls.Add(this.dateTimeOrder);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cheque);
            this.Controls.Add(this.createOrder);
            this.Controls.Add(this.groupCart);
            this.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PreviewerOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PreviewerOrder";
            this.groupCart.ResumeLayout(false);
            this.groupCart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceCart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.discount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupCart;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown totalPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown discount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown priceCart;
        private System.Windows.Forms.Button createOrder;
        private System.Windows.Forms.Button cheque;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimeOrder;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown idOrder;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label staffFullName;
    }
}