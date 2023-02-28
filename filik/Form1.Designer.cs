namespace filik
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.NametextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TypecomboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.allFilesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.сортировкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поИмениToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.возрастаниеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.убываниеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поТипуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.возрастаниеToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.убываниеToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.поДатеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.возрастаниеToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.убываниеToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allFilesBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(15, 36);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(597, 222);
            this.dataGridView.TabIndex = 0;
            // 
            // NametextBox
            // 
            this.NametextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.NametextBox.Location = new System.Drawing.Point(12, 280);
            this.NametextBox.Name = "NametextBox";
            this.NametextBox.Size = new System.Drawing.Size(134, 20);
            this.NametextBox.TabIndex = 1;
            this.NametextBox.TextChanged += new System.EventHandler(this.NametextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "По названию";
            // 
            // TypecomboBox
            // 
            this.TypecomboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TypecomboBox.FormattingEnabled = true;
            this.TypecomboBox.Location = new System.Drawing.Point(192, 280);
            this.TypecomboBox.Name = "TypecomboBox";
            this.TypecomboBox.Size = new System.Drawing.Size(121, 21);
            this.TypecomboBox.TabIndex = 3;
            this.TypecomboBox.SelectedIndexChanged += new System.EventHandler(this.TypecomboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "По типу";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(15, 319);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 69);
            this.button1.TabIndex = 5;
            this.button1.Text = "сброс";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dateTimePicker.Location = new System.Drawing.Point(354, 281);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 6;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(351, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "По дате";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сортировкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(624, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "SortmenuStrip";
            // 
            // сортировкаToolStripMenuItem
            // 
            this.сортировкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поИмениToolStripMenuItem,
            this.поТипуToolStripMenuItem,
            this.поДатеToolStripMenuItem});
            this.сортировкаToolStripMenuItem.Name = "сортировкаToolStripMenuItem";
            this.сортировкаToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.сортировкаToolStripMenuItem.Text = "Сортировка";
            // 
            // поИмениToolStripMenuItem
            // 
            this.поИмениToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.возрастаниеToolStripMenuItem,
            this.убываниеToolStripMenuItem});
            this.поИмениToolStripMenuItem.Name = "поИмениToolStripMenuItem";
            this.поИмениToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.поИмениToolStripMenuItem.Text = "По имени";
            // 
            // возрастаниеToolStripMenuItem
            // 
            this.возрастаниеToolStripMenuItem.Name = "возрастаниеToolStripMenuItem";
            this.возрастаниеToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.возрастаниеToolStripMenuItem.Text = "Возрастание";
            this.возрастаниеToolStripMenuItem.Click += new System.EventHandler(this.возрастаниеToolStripMenuItem_Click);
            // 
            // убываниеToolStripMenuItem
            // 
            this.убываниеToolStripMenuItem.Name = "убываниеToolStripMenuItem";
            this.убываниеToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.убываниеToolStripMenuItem.Text = "Убывание";
            this.убываниеToolStripMenuItem.Click += new System.EventHandler(this.убываниеToolStripMenuItem_Click);
            // 
            // поТипуToolStripMenuItem
            // 
            this.поТипуToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.возрастаниеToolStripMenuItem1,
            this.убываниеToolStripMenuItem1});
            this.поТипуToolStripMenuItem.Name = "поТипуToolStripMenuItem";
            this.поТипуToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.поТипуToolStripMenuItem.Text = "По типу";
            // 
            // возрастаниеToolStripMenuItem1
            // 
            this.возрастаниеToolStripMenuItem1.Name = "возрастаниеToolStripMenuItem1";
            this.возрастаниеToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.возрастаниеToolStripMenuItem1.Text = "Возрастание";
            this.возрастаниеToolStripMenuItem1.Click += new System.EventHandler(this.возрастаниеToolStripMenuItem1_Click);
            // 
            // убываниеToolStripMenuItem1
            // 
            this.убываниеToolStripMenuItem1.Name = "убываниеToolStripMenuItem1";
            this.убываниеToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.убываниеToolStripMenuItem1.Text = "Убывание";
            this.убываниеToolStripMenuItem1.Click += new System.EventHandler(this.убываниеToolStripMenuItem1_Click);
            // 
            // поДатеToolStripMenuItem
            // 
            this.поДатеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.возрастаниеToolStripMenuItem2,
            this.убываниеToolStripMenuItem2});
            this.поДатеToolStripMenuItem.Name = "поДатеToolStripMenuItem";
            this.поДатеToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.поДатеToolStripMenuItem.Text = "По дате";
            // 
            // возрастаниеToolStripMenuItem2
            // 
            this.возрастаниеToolStripMenuItem2.Name = "возрастаниеToolStripMenuItem2";
            this.возрастаниеToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.возрастаниеToolStripMenuItem2.Text = "Возрастание";
            this.возрастаниеToolStripMenuItem2.Click += new System.EventHandler(this.возрастаниеToolStripMenuItem2_Click);
            // 
            // убываниеToolStripMenuItem2
            // 
            this.убываниеToolStripMenuItem2.Name = "убываниеToolStripMenuItem2";
            this.убываниеToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.убываниеToolStripMenuItem2.Text = "Убывание";
            this.убываниеToolStripMenuItem2.Click += new System.EventHandler(this.убываниеToolStripMenuItem2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 400);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TypecomboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NametextBox);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(640, 420);
            this.Name = "Form1";
            this.Text = "Файлер";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allFilesBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.BindingSource allFilesBindingSource;
        private System.Windows.Forms.TextBox NametextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox TypecomboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem сортировкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поИмениToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem возрастаниеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem убываниеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поТипуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem возрастаниеToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem убываниеToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem поДатеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem возрастаниеToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem убываниеToolStripMenuItem2;
    }
}

