namespace NN_1
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Grid_pictureBox = new System.Windows.Forms.PictureBox();
            this.ApplySettings_button = new System.Windows.Forms.Button();
            this.Teach_button = new System.Windows.Forms.Button();
            this.IsTrue_checkBox = new System.Windows.Forms.CheckBox();
            this.Recognize_button = new System.Windows.Forms.Button();
            this.Recognize_textBox = new System.Windows.Forms.TextBox();
            this.LearningSpeed_label = new System.Windows.Forms.Label();
            this.LearningSpeed_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Threshold_label = new System.Windows.Forms.Label();
            this.Threshold_numericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LearningSpeed_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Threshold_numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // Grid_pictureBox
            // 
            this.Grid_pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Grid_pictureBox.BackColor = System.Drawing.Color.White;
            this.Grid_pictureBox.Location = new System.Drawing.Point(29, 96);
            this.Grid_pictureBox.Name = "Grid_pictureBox";
            this.Grid_pictureBox.Size = new System.Drawing.Size(300, 300);
            this.Grid_pictureBox.TabIndex = 0;
            this.Grid_pictureBox.TabStop = false;
            this.Grid_pictureBox.Click += new System.EventHandler(this.Grid_pictureBox_Click);
            this.Grid_pictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.Grid_pictureBox_Paint);
            this.Grid_pictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Grid_pictureBox_MouseClick);
            // 
            // ApplySettings_button
            // 
            this.ApplySettings_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ApplySettings_button.Location = new System.Drawing.Point(29, 41);
            this.ApplySettings_button.Name = "ApplySettings_button";
            this.ApplySettings_button.Size = new System.Drawing.Size(160, 29);
            this.ApplySettings_button.TabIndex = 9;
            this.ApplySettings_button.Text = "Применить";
            this.ApplySettings_button.UseVisualStyleBackColor = true;
            this.ApplySettings_button.Click += new System.EventHandler(this.ApplySettings_button_Click);
            // 
            // Teach_button
            // 
            this.Teach_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Teach_button.Location = new System.Drawing.Point(191, 402);
            this.Teach_button.Name = "Teach_button";
            this.Teach_button.Size = new System.Drawing.Size(81, 29);
            this.Teach_button.TabIndex = 10;
            this.Teach_button.Text = "Обучить";
            this.Teach_button.UseVisualStyleBackColor = true;
            this.Teach_button.Click += new System.EventHandler(this.Teach_button_Click);
            // 
            // IsTrue_checkBox
            // 
            this.IsTrue_checkBox.AutoSize = true;
            this.IsTrue_checkBox.Checked = true;
            this.IsTrue_checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.IsTrue_checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IsTrue_checkBox.Location = new System.Drawing.Point(46, 407);
            this.IsTrue_checkBox.Name = "IsTrue_checkBox";
            this.IsTrue_checkBox.Size = new System.Drawing.Size(87, 24);
            this.IsTrue_checkBox.TabIndex = 13;
            this.IsTrue_checkBox.Text = "Правда";
            this.IsTrue_checkBox.UseVisualStyleBackColor = true;
            this.IsTrue_checkBox.CheckedChanged += new System.EventHandler(this.IsTrue_checkBox_CheckedChanged);
            // 
            // Recognize_button
            // 
            this.Recognize_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Recognize_button.Location = new System.Drawing.Point(358, 169);
            this.Recognize_button.Name = "Recognize_button";
            this.Recognize_button.Size = new System.Drawing.Size(124, 86);
            this.Recognize_button.TabIndex = 13;
            this.Recognize_button.Text = "Распознать";
            this.Recognize_button.UseVisualStyleBackColor = true;
            this.Recognize_button.Click += new System.EventHandler(this.Recognize_button_Click);
            // 
            // Recognize_textBox
            // 
            this.Recognize_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Recognize_textBox.Location = new System.Drawing.Point(358, 285);
            this.Recognize_textBox.Name = "Recognize_textBox";
            this.Recognize_textBox.Size = new System.Drawing.Size(115, 26);
            this.Recognize_textBox.TabIndex = 14;
            // 
            // LearningSpeed_label
            // 
            this.LearningSpeed_label.AutoSize = true;
            this.LearningSpeed_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LearningSpeed_label.Location = new System.Drawing.Point(206, 9);
            this.LearningSpeed_label.Name = "LearningSpeed_label";
            this.LearningSpeed_label.Size = new System.Drawing.Size(85, 20);
            this.LearningSpeed_label.TabIndex = 5;
            this.LearningSpeed_label.Text = "Скорость:";
            // 
            // LearningSpeed_numericUpDown
            // 
            this.LearningSpeed_numericUpDown.DecimalPlaces = 2;
            this.LearningSpeed_numericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LearningSpeed_numericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.LearningSpeed_numericUpDown.Location = new System.Drawing.Point(297, 7);
            this.LearningSpeed_numericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.LearningSpeed_numericUpDown.Name = "LearningSpeed_numericUpDown";
            this.LearningSpeed_numericUpDown.Size = new System.Drawing.Size(73, 26);
            this.LearningSpeed_numericUpDown.TabIndex = 6;
            this.LearningSpeed_numericUpDown.Value = new decimal(new int[] {
            3,
            0,
            0,
            65536});
            // 
            // Threshold_label
            // 
            this.Threshold_label.AutoSize = true;
            this.Threshold_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Threshold_label.Location = new System.Drawing.Point(33, 9);
            this.Threshold_label.Name = "Threshold_label";
            this.Threshold_label.Size = new System.Drawing.Size(59, 20);
            this.Threshold_label.TabIndex = 7;
            this.Threshold_label.Text = "Порог:";
            // 
            // Threshold_numericUpDown
            // 
            this.Threshold_numericUpDown.DecimalPlaces = 2;
            this.Threshold_numericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Threshold_numericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.Threshold_numericUpDown.Location = new System.Drawing.Point(116, 9);
            this.Threshold_numericUpDown.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Threshold_numericUpDown.Name = "Threshold_numericUpDown";
            this.Threshold_numericUpDown.Size = new System.Drawing.Size(73, 26);
            this.Threshold_numericUpDown.TabIndex = 8;
            this.Threshold_numericUpDown.Value = new decimal(new int[] {
            8,
            0,
            0,
            65536});
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 466);
            this.Controls.Add(this.Threshold_numericUpDown);
            this.Controls.Add(this.IsTrue_checkBox);
            this.Controls.Add(this.Threshold_label);
            this.Controls.Add(this.Recognize_textBox);
            this.Controls.Add(this.LearningSpeed_label);
            this.Controls.Add(this.LearningSpeed_numericUpDown);
            this.Controls.Add(this.Teach_button);
            this.Controls.Add(this.Recognize_button);
            this.Controls.Add(this.ApplySettings_button);
            this.Controls.Add(this.Grid_pictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainForm";
            this.Text = "Распознование изображений с помощью персиптрона";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LearningSpeed_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Threshold_numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Grid_pictureBox;
        private System.Windows.Forms.Button ApplySettings_button;
        private System.Windows.Forms.Button Teach_button;
        private System.Windows.Forms.CheckBox IsTrue_checkBox;
        private System.Windows.Forms.Button Recognize_button;
        private System.Windows.Forms.TextBox Recognize_textBox;
        private System.Windows.Forms.Label LearningSpeed_label;
        private System.Windows.Forms.NumericUpDown LearningSpeed_numericUpDown;
        private System.Windows.Forms.Label Threshold_label;
        private System.Windows.Forms.NumericUpDown Threshold_numericUpDown;
    }
}

