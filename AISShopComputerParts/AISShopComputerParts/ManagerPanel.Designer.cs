﻿using System.ComponentModel;

namespace AISShopComputerParts
{
    partial class ManagerPanel
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
            this.picture = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nameStaff = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.computerParts = new System.Windows.Forms.Button();
            this.sales = new System.Windows.Forms.Button();
            this.createSale = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize) (this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // picture
            // 
            this.picture.Image = global::AISShopComputerParts.Properties.Resources.logo;
            this.picture.ImageLocation = "";
            this.picture.Location = new System.Drawing.Point(431, 50);
            this.picture.Margin = new System.Windows.Forms.Padding(5);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(509, 406);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture.TabIndex = 7;
            this.picture.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(454, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(486, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Учет продажи компьютерных комплектующих";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(322, 29);
            this.label2.TabIndex = 9;
            this.label2.Text = "Права доступа: Пользователь.\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 29);
            this.label3.TabIndex = 10;
            this.label3.Text = "Сотрудник:";
            // 
            // nameStaff
            // 
            this.nameStaff.AutoSize = true;
            this.nameStaff.Location = new System.Drawing.Point(151, 9);
            this.nameStaff.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.nameStaff.Name = "nameStaff";
            this.nameStaff.Size = new System.Drawing.Size(20, 29);
            this.nameStaff.TabIndex = 11;
            this.nameStaff.Text = "-";
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(20, 464);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(919, 34);
            this.exit.TabIndex = 12;
            this.exit.Text = "Выйти из учетной записи\r\n";
            this.exit.UseVisualStyleBackColor = true;
            // 
            // computerParts
            // 
            this.computerParts.Location = new System.Drawing.Point(14, 102);
            this.computerParts.Name = "computerParts";
            this.computerParts.Size = new System.Drawing.Size(322, 54);
            this.computerParts.TabIndex = 13;
            this.computerParts.Text = "Просмотр запчастей";
            this.computerParts.UseVisualStyleBackColor = true;
            // 
            // sales
            // 
            this.sales.Location = new System.Drawing.Point(14, 186);
            this.sales.Name = "sales";
            this.sales.Size = new System.Drawing.Size(322, 54);
            this.sales.TabIndex = 14;
            this.sales.Text = "Просмотр продаж";
            this.sales.UseVisualStyleBackColor = true;
            // 
            // createSale
            // 
            this.createSale.Location = new System.Drawing.Point(14, 275);
            this.createSale.Name = "createSale";
            this.createSale.Size = new System.Drawing.Size(322, 54);
            this.createSale.TabIndex = 15;
            this.createSale.Text = "Новая продажа";
            this.createSale.UseVisualStyleBackColor = true;
            // 
            // ManagerPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 505);
            this.ControlBox = false;
            this.Controls.Add(this.createSale);
            this.Controls.Add(this.sales);
            this.Controls.Add(this.computerParts);
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
            this.Name = "ManagerPanel";
            this.Text = "ManagerPanel";
            ((System.ComponentModel.ISupportInitialize) (this.picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button createSale;

        private System.Windows.Forms.Button computerParts;
        private System.Windows.Forms.Button sales;

        private System.Windows.Forms.Button exit;

        private System.Windows.Forms.Label nameStaff;

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.PictureBox picture;

        #endregion
    }
}