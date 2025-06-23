namespace ПР3РКИС
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.keyTextBox = new System.Windows.Forms.TextBox();
            this.valueTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.generateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.dictionaryListBox = new System.Windows.Forms.ListBox();
            this.duplicatesListBox = new System.Windows.Forms.ListBox();
            this.findDuplicatesButton = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.keysTextBox = new System.Windows.Forms.TextBox();
            this.valuesTextBox = new System.Windows.Forms.TextBox();
            this.createDictButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // keyTextBox
            // 
            this.keyTextBox.Location = new System.Drawing.Point(12, 53);
            this.keyTextBox.Name = "keyTextBox";
            this.keyTextBox.Size = new System.Drawing.Size(150, 20);
            this.keyTextBox.TabIndex = 0;
            this.keyTextBox.TextChanged += new System.EventHandler(this.keyTextBox_TextChanged);
            // 
            // valueTextBox
            // 
            this.valueTextBox.Location = new System.Drawing.Point(168, 53);
            this.valueTextBox.Name = "valueTextBox";
            this.valueTextBox.Size = new System.Drawing.Size(150, 20);
            this.valueTextBox.TabIndex = 1;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(324, 50);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(100, 23);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Добавить пару";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(430, 51);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(100, 23);
            this.generateButton.TabIndex = 3;
            this.generateButton.Text = "Сгенерировать";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(536, 50);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(100, 23);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "Очистить";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // dictionaryListBox
            // 
            this.dictionaryListBox.FormattingEnabled = true;
            this.dictionaryListBox.Location = new System.Drawing.Point(12, 100);
            this.dictionaryListBox.Name = "dictionaryListBox";
            this.dictionaryListBox.Size = new System.Drawing.Size(300, 290);
            this.dictionaryListBox.TabIndex = 5;
            // 
            // duplicatesListBox
            // 
            this.duplicatesListBox.FormattingEnabled = true;
            this.duplicatesListBox.Location = new System.Drawing.Point(336, 100);
            this.duplicatesListBox.Name = "duplicatesListBox";
            this.duplicatesListBox.Size = new System.Drawing.Size(300, 290);
            this.duplicatesListBox.TabIndex = 6;
            // 
            // findDuplicatesButton
            // 
            this.findDuplicatesButton.Location = new System.Drawing.Point(642, 51);
            this.findDuplicatesButton.Name = "findDuplicatesButton";
            this.findDuplicatesButton.Size = new System.Drawing.Size(100, 23);
            this.findDuplicatesButton.TabIndex = 7;
            this.findDuplicatesButton.Text = "Найти дубликаты";
            this.findDuplicatesButton.UseVisualStyleBackColor = true;
            this.findDuplicatesButton.Click += new System.EventHandler(this.findDuplicatesButton_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(12, 400);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(36, 13);
            this.statusLabel.TabIndex = 8;
            this.statusLabel.Text = "Готов";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // keysTextBox
            // 
            this.keysTextBox.Location = new System.Drawing.Point(12, 12);
            this.keysTextBox.Name = "keysTextBox";
            this.keysTextBox.Size = new System.Drawing.Size(300, 20);
            this.keysTextBox.TabIndex = 9;
            // 
            // valuesTextBox
            // 
            this.valuesTextBox.Location = new System.Drawing.Point(336, 12);
            this.valuesTextBox.Name = "valuesTextBox";
            this.valuesTextBox.Size = new System.Drawing.Size(300, 20);
            this.valuesTextBox.TabIndex = 10;
            // 
            // createDictButton
            // 
            this.createDictButton.Location = new System.Drawing.Point(642, 10);
            this.createDictButton.Name = "createDictButton";
            this.createDictButton.Size = new System.Drawing.Size(100, 23);
            this.createDictButton.TabIndex = 11;
            this.createDictButton.Text = "Создать словарь";
            this.createDictButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Ключ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Значение";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 422);
            this.Controls.Add(this.createDictButton);
            this.Controls.Add(this.valuesTextBox);
            this.Controls.Add(this.keysTextBox);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.findDuplicatesButton);
            this.Controls.Add(this.duplicatesListBox);
            this.Controls.Add(this.dictionaryListBox);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.valueTextBox);
            this.Controls.Add(this.keyTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Работа со словарями";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox keyTextBox;
        private System.Windows.Forms.TextBox valueTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.ListBox dictionaryListBox;
        private System.Windows.Forms.ListBox duplicatesListBox;
        private System.Windows.Forms.Button findDuplicatesButton;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.TextBox keysTextBox;
        private System.Windows.Forms.TextBox valuesTextBox;
        private System.Windows.Forms.Button createDictButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}