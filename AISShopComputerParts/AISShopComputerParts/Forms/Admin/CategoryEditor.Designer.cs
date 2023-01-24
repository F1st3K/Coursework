
namespace AISShopComputerParts
{
    partial class CategoryEditor
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
            this.back = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.categoryName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(465, 307);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(113, 41);
            this.back.TabIndex = 53;
            this.back.Text = "В меню";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(324, 307);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(124, 41);
            this.delete.TabIndex = 52;
            this.delete.Text = "Удалить";
            this.delete.UseVisualStyleBackColor = false;
            // 
            // edit
            // 
            this.edit.Location = new System.Drawing.Point(145, 307);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(173, 41);
            this.edit.TabIndex = 51;
            this.edit.Text = "Редактировать";
            this.edit.UseVisualStyleBackColor = false;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(15, 307);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(124, 41);
            this.add.TabIndex = 50;
            this.add.Text = "Добавить";
            this.add.UseVisualStyleBackColor = false;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(15, 49);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(563, 252);
            this.dataGridView.TabIndex = 49;
            // 
            // categoryName
            // 
            this.categoryName.Location = new System.Drawing.Point(112, 12);
            this.categoryName.Name = "categoryName";
            this.categoryName.Size = new System.Drawing.Size(466, 31);
            this.categoryName.TabIndex = 47;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 23);
            this.label3.TabIndex = 44;
            this.label3.Text = "Категория:";
            // 
            // CategoryEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.ControlBox = false;
            this.Controls.Add(this.back);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.add);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.categoryName);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CategoryEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CategoryEditor";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox categoryName;
        private System.Windows.Forms.Label label3;
    }
}