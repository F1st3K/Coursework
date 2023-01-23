using System.ComponentModel;

namespace AISShopComputerParts
{
    partial class UserEditor
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
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.add = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.status = new System.Windows.Forms.ComboBox();
            this.staff = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 13);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 23);
            this.label3.TabIndex = 17;
            this.label3.Text = "Логин:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 23);
            this.label1.TabIndex = 18;
            this.label1.Text = "Пароль:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(337, 13);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 23);
            this.label2.TabIndex = 19;
            this.label2.Text = "Доступ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(308, 57);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 20;
            this.label4.Text = "Сотрудник:\r\n";
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(106, 10);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(173, 30);
            this.login.TabIndex = 21;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(106, 54);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(173, 30);
            this.password.TabIndex = 22;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(10, 96);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(563, 202);
            this.dataGridView.TabIndex = 25;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(10, 304);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(124, 41);
            this.add.TabIndex = 26;
            this.add.Text = "Добавить";
            this.add.UseVisualStyleBackColor = false;
            // 
            // edit
            // 
            this.edit.Location = new System.Drawing.Point(140, 304);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(173, 41);
            this.edit.TabIndex = 27;
            this.edit.Text = "Редактировать";
            this.edit.UseVisualStyleBackColor = false;
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(319, 304);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(124, 41);
            this.delete.TabIndex = 28;
            this.delete.Text = "Удалить";
            this.delete.UseVisualStyleBackColor = false;
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(460, 304);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(113, 41);
            this.back.TabIndex = 29;
            this.back.Text = "В меню";
            this.back.UseVisualStyleBackColor = false;
            // 
            // status
            // 
            this.status.FormattingEnabled = true;
            this.status.Location = new System.Drawing.Point(417, 13);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(155, 30);
            this.status.TabIndex = 30;
            // 
            // staff
            // 
            this.staff.FormattingEnabled = true;
            this.staff.Location = new System.Drawing.Point(417, 54);
            this.staff.Name = "staff";
            this.staff.Size = new System.Drawing.Size(155, 30);
            this.staff.TabIndex = 31;
            // 
            // UserEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.ControlBox = false;
            this.Controls.Add(this.staff);
            this.Controls.Add(this.status);
            this.Controls.Add(this.back);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.add);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.password);
            this.Controls.Add(this.login);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserEditor";
            this.Text = "UserEditor";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button back;

        private System.Windows.Forms.Button add;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.DataGridView dataGridView;

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;

        #endregion

        private System.Windows.Forms.ComboBox status;
        private System.Windows.Forms.ComboBox staff;
    }
}