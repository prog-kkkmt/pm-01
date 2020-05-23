namespace DBComplexProgramm
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
            this.btnSave = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.выбратьТаблицуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.доходыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.расходыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выполнитьЗапросToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnInsert = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.saveWord = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewДоходы = new System.Windows.Forms.DataGridView();
            this.dataGridViewРасходы = new System.Windows.Forms.DataGridView();
            this.saveExcel = new System.Windows.Forms.Button();
            this.labelWord = new System.Windows.Forms.Label();
            this.labelExcel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewДоходы)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewРасходы)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(353, 279);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(142, 33);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "btnSave";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 15);
            this.dataGridView1.MaximumSize = new System.Drawing.Size(452, 203);
            this.dataGridView1.MinimumSize = new System.Drawing.Size(452, 203);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(452, 203);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridView1_RowsRemoved);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выбратьТаблицуToolStripMenuItem,
            this.выполнитьЗапросToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // выбратьТаблицуToolStripMenuItem
            // 
            this.выбратьТаблицуToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.выбратьТаблицуToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.доходыToolStripMenuItem,
            this.расходыToolStripMenuItem});
            this.выбратьТаблицуToolStripMenuItem.Name = "выбратьТаблицуToolStripMenuItem";
            this.выбратьТаблицуToolStripMenuItem.Size = new System.Drawing.Size(114, 20);
            this.выбратьТаблицуToolStripMenuItem.Text = "Выбрать таблицу";
            // 
            // доходыToolStripMenuItem
            // 
            this.доходыToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.доходыToolStripMenuItem.Name = "доходыToolStripMenuItem";
            this.доходыToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.доходыToolStripMenuItem.Text = "Доходы";
            this.доходыToolStripMenuItem.Click += new System.EventHandler(this.доходыToolStripMenuItem_Click);
            // 
            // расходыToolStripMenuItem
            // 
            this.расходыToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.расходыToolStripMenuItem.Name = "расходыToolStripMenuItem";
            this.расходыToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.расходыToolStripMenuItem.Text = "Расходы";
            this.расходыToolStripMenuItem.Click += new System.EventHandler(this.расходыToolStripMenuItem_Click);
            // 
            // выполнитьЗапросToolStripMenuItem
            // 
            this.выполнитьЗапросToolStripMenuItem.Name = "выполнитьЗапросToolStripMenuItem";
            this.выполнитьЗапросToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.выполнитьЗапросToolStripMenuItem.Text = "Выполнить запрос";
            this.выполнитьЗапросToolStripMenuItem.Click += new System.EventHandler(this.выполнитьЗапросToolStripMenuItem_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnInsert.Location = new System.Drawing.Point(12, 279);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(142, 33);
            this.btnInsert.TabIndex = 4;
            this.btnInsert.Text = "btnInsert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(16, 15);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(240, 203);
            this.dataGridView2.TabIndex = 5;
            // 
            // saveWord
            // 
            this.saveWord.Location = new System.Drawing.Point(683, 268);
            this.saveWord.Name = "saveWord";
            this.saveWord.Size = new System.Drawing.Size(89, 25);
            this.saveWord.TabIndex = 6;
            this.saveWord.Text = "Итог";
            this.saveWord.UseVisualStyleBackColor = true;
            this.saveWord.Click += new System.EventHandler(this.saveWord_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(12, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(483, 235);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel2.Controls.Add(this.dataGridView2);
            this.panel2.Location = new System.Drawing.Point(501, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(273, 235);
            this.panel2.TabIndex = 8;
            // 
            // dataGridViewДоходы
            // 
            this.dataGridViewДоходы.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewДоходы.Location = new System.Drawing.Point(82, 353);
            this.dataGridViewДоходы.Name = "dataGridViewДоходы";
            this.dataGridViewДоходы.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewДоходы.TabIndex = 9;
            this.dataGridViewДоходы.Visible = false;
            // 
            // dataGridViewРасходы
            // 
            this.dataGridViewРасходы.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewРасходы.Location = new System.Drawing.Point(462, 353);
            this.dataGridViewРасходы.Name = "dataGridViewРасходы";
            this.dataGridViewРасходы.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewРасходы.TabIndex = 10;
            this.dataGridViewРасходы.Visible = false;
            // 
            // saveExcel
            // 
            this.saveExcel.Location = new System.Drawing.Point(683, 299);
            this.saveExcel.Name = "saveExcel";
            this.saveExcel.Size = new System.Drawing.Size(89, 25);
            this.saveExcel.TabIndex = 11;
            this.saveExcel.Text = "button1";
            this.saveExcel.UseVisualStyleBackColor = true;
            this.saveExcel.Click += new System.EventHandler(this.saveExcel_Click);
            // 
            // labelWord
            // 
            this.labelWord.AutoSize = true;
            this.labelWord.Location = new System.Drawing.Point(626, 274);
            this.labelWord.Name = "labelWord";
            this.labelWord.Size = new System.Drawing.Size(35, 13);
            this.labelWord.TabIndex = 12;
            this.labelWord.Text = "label1";
            // 
            // labelExcel
            // 
            this.labelExcel.AutoSize = true;
            this.labelExcel.Location = new System.Drawing.Point(626, 305);
            this.labelExcel.Name = "labelExcel";
            this.labelExcel.Size = new System.Drawing.Size(35, 13);
            this.labelExcel.TabIndex = 13;
            this.labelExcel.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(784, 332);
            this.Controls.Add(this.labelExcel);
            this.Controls.Add(this.labelWord);
            this.Controls.Add(this.saveExcel);
            this.Controls.Add(this.dataGridViewРасходы);
            this.Controls.Add(this.dataGridViewДоходы);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.saveWord);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(800, 370);
            this.MinimumSize = new System.Drawing.Size(800, 370);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewДоходы)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewРасходы)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem выбратьТаблицуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem доходыToolStripMenuItem;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.ToolStripMenuItem расходыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выполнитьЗапросToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button saveWord;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridViewДоходы;
        private System.Windows.Forms.DataGridView dataGridViewРасходы;
        private System.Windows.Forms.Button saveExcel;
        private System.Windows.Forms.Label labelWord;
        private System.Windows.Forms.Label labelExcel;
    }
}

