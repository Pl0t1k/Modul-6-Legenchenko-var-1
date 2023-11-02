namespace Modul_6_Legenchenko_var_1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.post = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_delete = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button_download = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.surname,
            this.post,
            this.salary});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(722, 354);
            this.dataGridView1.TabIndex = 0;
            // 
            // name
            // 
            this.name.HeaderText = "Имя";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.Width = 125;
            // 
            // surname
            // 
            this.surname.HeaderText = "Фамилия";
            this.surname.MinimumWidth = 6;
            this.surname.Name = "surname";
            this.surname.Width = 125;
            // 
            // post
            // 
            this.post.HeaderText = "Должность";
            this.post.MinimumWidth = 6;
            this.post.Name = "post";
            this.post.Width = 125;
            // 
            // salary
            // 
            this.salary.HeaderText = "Зарплата";
            this.salary.MinimumWidth = 6;
            this.salary.Name = "salary";
            this.salary.Width = 125;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_add);
            this.groupBox1.Controls.Add(this.button_delete);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button_download);
            this.groupBox1.Location = new System.Drawing.Point(740, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(220, 354);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Действия";
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(6, 257);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(208, 61);
            this.button_delete.TabIndex = 2;
            this.button_delete.Text = "Удалить";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 177);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(208, 59);
            this.button2.TabIndex = 1;
            this.button2.Text = "Изменить";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button_download
            // 
            this.button_download.Location = new System.Drawing.Point(6, 21);
            this.button_download.Name = "button_download";
            this.button_download.Size = new System.Drawing.Size(208, 57);
            this.button_download.TabIndex = 0;
            this.button_download.Text = "Загрузить";
            this.button_download.UseVisualStyleBackColor = true;
            this.button_download.Click += new System.EventHandler(this.button_download_Click);
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(6, 99);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(208, 60);
            this.button_add.TabIndex = 3;
            this.button_add.Text = "Добавить";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 439);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn post;
        private System.Windows.Forms.DataGridViewTextBoxColumn salary;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button_download;
        private System.Windows.Forms.Button button_add;
    }
}

