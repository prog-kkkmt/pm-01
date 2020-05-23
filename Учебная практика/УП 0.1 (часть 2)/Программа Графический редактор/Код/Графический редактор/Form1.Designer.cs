namespace Графический_редактор
{
    partial class MainForm
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
            this.OpenButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.Canvas = new System.Windows.Forms.PictureBox();
            this.PenButton = new System.Windows.Forms.Button();
            this.BrushButton = new System.Windows.Forms.Button();
            this.FillButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.ColorBox = new System.Windows.Forms.ComboBox();
            this.SizeBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).BeginInit();
            this.SuspendLayout();
            // 
            // OpenButton
            // 
            this.OpenButton.Location = new System.Drawing.Point(47, 392);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(75, 23);
            this.OpenButton.TabIndex = 1;
            this.OpenButton.Text = "Open";
            this.OpenButton.UseVisualStyleBackColor = true;
            this.OpenButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(461, 392);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 2;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Canvas
            // 
            this.Canvas.Location = new System.Drawing.Point(47, 61);
            this.Canvas.Name = "Canvas";
            this.Canvas.Size = new System.Drawing.Size(489, 325);
            this.Canvas.TabIndex = 3;
            this.Canvas.TabStop = false;
            this.Canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.Canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.Canvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // PenButton
            // 
            this.PenButton.Location = new System.Drawing.Point(47, 22);
            this.PenButton.Name = "PenButton";
            this.PenButton.Size = new System.Drawing.Size(41, 23);
            this.PenButton.TabIndex = 4;
            this.PenButton.Text = "Pen";
            this.PenButton.UseVisualStyleBackColor = true;
            this.PenButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // BrushButton
            // 
            this.BrushButton.Location = new System.Drawing.Point(108, 20);
            this.BrushButton.Name = "BrushButton";
            this.BrushButton.Size = new System.Drawing.Size(43, 23);
            this.BrushButton.TabIndex = 5;
            this.BrushButton.Text = "Brush";
            this.BrushButton.UseVisualStyleBackColor = true;
            this.BrushButton.Click += new System.EventHandler(this.button5_Click);
            // 
            // FillButton
            // 
            this.FillButton.Location = new System.Drawing.Point(173, 20);
            this.FillButton.Name = "FillButton";
            this.FillButton.Size = new System.Drawing.Size(28, 23);
            this.FillButton.TabIndex = 6;
            this.FillButton.Text = "Fill";
            this.FillButton.UseVisualStyleBackColor = true;
            this.FillButton.Click += new System.EventHandler(this.button6_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(229, 21);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(61, 23);
            this.ClearButton.TabIndex = 7;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.button7_Click);
            // 
            // ColorBox
            // 
            this.ColorBox.FormattingEnabled = true;
            this.ColorBox.Location = new System.Drawing.Point(316, 23);
            this.ColorBox.Name = "ColorBox";
            this.ColorBox.Size = new System.Drawing.Size(85, 21);
            this.ColorBox.TabIndex = 9;
            // 
            // SizeBox
            // 
            this.SizeBox.Location = new System.Drawing.Point(436, 24);
            this.SizeBox.Name = "SizeBox";
            this.SizeBox.Size = new System.Drawing.Size(100, 20);
            this.SizeBox.TabIndex = 10;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 443);
            this.Controls.Add(this.SizeBox);
            this.Controls.Add(this.ColorBox);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.FillButton);
            this.Controls.Add(this.BrushButton);
            this.Controls.Add(this.PenButton);
            this.Controls.Add(this.Canvas);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.OpenButton);
            this.Name = "MainForm";
            this.Text = "Графический редактор";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button OpenButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PictureBox Canvas;
        private System.Windows.Forms.Button PenButton;
        private System.Windows.Forms.Button BrushButton;
        private System.Windows.Forms.Button FillButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.ComboBox ColorBox;
        private System.Windows.Forms.TextBox SizeBox;
    }
}

