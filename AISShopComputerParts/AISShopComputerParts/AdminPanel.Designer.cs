using System.ComponentModel;

namespace AISShopComputerParts
{
    partial class AdminPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.exit = new System.Windows.Forms.Button();
            this.nameStaff = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.picture = new System.Windows.Forms.PictureBox();
            this.users = new System.Windows.Forms.Button();
            this.staffs = new System.Windows.Forms.Button();
            this.categories = new System.Windows.Forms.Button();
            this.salesAccounting = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize) (this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(20, 463);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(919, 34);
            this.exit.TabIndex = 18;
            this.exit.Text = "Выйти из учетной записи\r\n";
            this.exit.UseVisualStyleBackColor = true;
            // 
            // nameStaff
            // 
            this.nameStaff.AutoSize = true;
            this.nameStaff.Location = new System.Drawing.Point(151, 8);
            this.nameStaff.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.nameStaff.Name = "nameStaff";
            this.nameStaff.Size = new System.Drawing.Size(20, 29);
            this.nameStaff.TabIndex = 17;
            this.nameStaff.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 8);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 29);
            this.label3.TabIndex = 16;
            this.label3.Text = "Сотрудник:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(341, 58);
            this.label2.TabIndex = 15;
            this.label2.Text = "Права доступа: Администратор.\r\n\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(454, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(486, 29);
            this.label1.TabIndex = 14;
            this.label1.Text = "Учет продажи компьютерных комплектующих";
            // 
            // picture
            // 
            this.picture.Image = global::AISShopComputerParts.Properties.Resources.logo;
            this.picture.ImageLocation = "";
            this.picture.Location = new System.Drawing.Point(431, 49);
            this.picture.Margin = new System.Windows.Forms.Padding(5);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(509, 406);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture.TabIndex = 13;
            this.picture.TabStop = false;
            // 
            // users
            // 
            this.users.Location = new System.Drawing.Point(14, 91);
            this.users.Name = "users";
            this.users.Size = new System.Drawing.Size(340, 50);
            this.users.TabIndex = 19;
            this.users.Text = "Пользователи";
            this.users.UseVisualStyleBackColor = true;
            // 
            // staffs
            // 
            this.staffs.Location = new System.Drawing.Point(14, 147);
            this.staffs.Name = "staffs";
            this.staffs.Size = new System.Drawing.Size(340, 50);
            this.staffs.TabIndex = 20;
            this.staffs.Text = "Сотрудники";
            this.staffs.UseVisualStyleBackColor = true;
            // 
            // categories
            // 
            this.categories.Location = new System.Drawing.Point(14, 203);
            this.categories.Name = "categories";
            this.categories.Size = new System.Drawing.Size(340, 50);
            this.categories.TabIndex = 21;
            this.categories.Text = "Категории товаров";
            this.categories.UseVisualStyleBackColor = true;
            // 
            // salesAccounting
            // 
            this.salesAccounting.Location = new System.Drawing.Point(14, 259);
            this.salesAccounting.Name = "salesAccounting";
            this.salesAccounting.Size = new System.Drawing.Size(340, 50);
            this.salesAccounting.TabIndex = 22;
            this.salesAccounting.Text = "Учет продаж";
            this.salesAccounting.UseVisualStyleBackColor = true;
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 505);
            this.ControlBox = false;
            this.Controls.Add(this.salesAccounting);
            this.Controls.Add(this.categories);
            this.Controls.Add(this.staffs);
            this.Controls.Add(this.users);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.nameStaff);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picture);
            this.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdminPanel";
            this.Text = "AdminPanel";
            ((System.ComponentModel.ISupportInitialize) (this.picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button users;
        private System.Windows.Forms.Button staffs;
        private System.Windows.Forms.Button categories;
        private System.Windows.Forms.Button salesAccounting;


        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label nameStaff;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picture;

        #endregion
    }
}