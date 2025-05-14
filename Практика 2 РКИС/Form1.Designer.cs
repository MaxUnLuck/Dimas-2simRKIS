namespace Практика_2_РКИС
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
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.generateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.dividerTextBox = new System.Windows.Forms.TextBox();
            this.processButton = new System.Windows.Forms.Button();
            this.originalListBox = new System.Windows.Forms.ListBox();
            this.resultListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(9, 29);
            this.inputTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(114, 20);
            this.inputTextBox.TabIndex = 0;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(126, 29);
            this.addButton.Margin = new System.Windows.Forms.Padding(2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(90, 19);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Добавить число";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(220, 29);
            this.generateButton.Margin = new System.Windows.Forms.Padding(2);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(112, 19);
            this.generateButton.TabIndex = 2;
            this.generateButton.Text = "Сгенерировать список";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(338, 29);
            this.clearButton.Margin = new System.Windows.Forms.Padding(2);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 19);
            this.clearButton.TabIndex = 3;
            this.clearButton.Text = "Очистить";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // dividerTextBox
            // 
            this.dividerTextBox.Location = new System.Drawing.Point(9, 65);
            this.dividerTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.dividerTextBox.Name = "dividerTextBox";
            this.dividerTextBox.Size = new System.Drawing.Size(114, 20);
            this.dividerTextBox.TabIndex = 4;
            this.dividerTextBox.Text = "Введите делитель";
            this.dividerTextBox.Enter += new System.EventHandler(this.dividerTextBox_Enter);
            this.dividerTextBox.Leave += new System.EventHandler(this.dividerTextBox_Leave);
            // 
            // processButton
            // 
            this.processButton.Location = new System.Drawing.Point(126, 65);
            this.processButton.Margin = new System.Windows.Forms.Padding(2);
            this.processButton.Name = "processButton";
            this.processButton.Size = new System.Drawing.Size(90, 19);
            this.processButton.TabIndex = 5;
            this.processButton.Text = "Удалить элементы";
            this.processButton.UseVisualStyleBackColor = true;
            this.processButton.Click += new System.EventHandler(this.processButton_Click);
            // 
            // originalListBox
            // 
            this.originalListBox.FormattingEnabled = true;
            this.originalListBox.Location = new System.Drawing.Point(9, 114);
            this.originalListBox.Margin = new System.Windows.Forms.Padding(2);
            this.originalListBox.Name = "originalListBox";
            this.originalListBox.Size = new System.Drawing.Size(188, 147);
            this.originalListBox.TabIndex = 6;
            // 
            // resultListBox
            // 
            this.resultListBox.FormattingEnabled = true;
            this.resultListBox.Location = new System.Drawing.Point(225, 114);
            this.resultListBox.Margin = new System.Windows.Forms.Padding(2);
            this.resultListBox.Name = "resultListBox";
            this.resultListBox.Size = new System.Drawing.Size(188, 147);
            this.resultListBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 98);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Исходный список";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(223, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Результат";
            // 
            // statusLabel
            // 
            this.statusLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.statusLabel.Location = new System.Drawing.Point(9, 268);
            this.statusLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(404, 33);
            this.statusLabel.TabIndex = 10;
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 327);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resultListBox);
            this.Controls.Add(this.originalListBox);
            this.Controls.Add(this.processButton);
            this.Controls.Add(this.dividerTextBox);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.inputTextBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Обработчик списка чисел";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.TextBox dividerTextBox;
        private System.Windows.Forms.Button processButton;
        private System.Windows.Forms.ListBox originalListBox;
        private System.Windows.Forms.ListBox resultListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}

