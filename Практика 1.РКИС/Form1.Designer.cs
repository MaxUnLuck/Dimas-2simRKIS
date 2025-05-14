using System;

namespace Практика_1.РКИС
{

    partial class Form1
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
            this.vehicleComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.flyButton = new System.Windows.Forms.Button();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.fuelProgressBar = new System.Windows.Forms.ProgressBar();
            this.fuelLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            //
            // vehicleComboBox
            //
            this.vehicleComboBox.FormattingEnabled = true;
            this.vehicleComboBox.Location = new System.Drawing.Point(12, 36);
            this.vehicleComboBox.Name = "vehicleComboBox";
            this.vehicleComboBox.Size = new System.Drawing.Size(260, 24);
            this.vehicleComboBox.TabIndex = 0;
            //
            // label1
            //
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выберите транспорт:";
            //
            // flyButton
            //
            this.flyButton.Location = new System.Drawing.Point(12, 75);
            this.flyButton.Name = "flyButton";
            this.flyButton.Size = new System.Drawing.Size(260, 35);
            this.flyButton.TabIndex = 2;
            this.flyButton.Text = "В путь!";
            this.flyButton.UseVisualStyleBackColor = true;
            this.flyButton.Click += new System.EventHandler(this.flyButton_Click);
            //
            // resultTextBox
            //
            this.resultTextBox.Location = new System.Drawing.Point(12, 178);
            this.resultTextBox.Multiline = true;
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.ReadOnly = true;
            this.resultTextBox.Size = new System.Drawing.Size(260, 133);
            this.resultTextBox.TabIndex = 3;
            //
            // fuelProgressBar
            //
            this.fuelProgressBar.Location = new System.Drawing.Point(12, 120);
            this.fuelProgressBar.Name = "fuelProgressBar";
            this.fuelProgressBar.Size = new System.Drawing.Size(260, 23);
            this.fuelProgressBar.TabIndex = 4;
            //
            // fuelLabel
            //
            this.fuelLabel.AutoSize = true;
            this.fuelLabel.Location = new System.Drawing.Point(12, 152);
            this.fuelLabel.Name = "fuelLabel";
            this.fuelLabel.Size = new System.Drawing.Size(53, 17);
            this.fuelLabel.TabIndex = 5;
            this.fuelLabel.Text = "Топливо:";
            //
            // Form1
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 323);
            this.Controls.Add(this.fuelLabel);
            this.Controls.Add(this.fuelProgressBar);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.flyButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vehicleComboBox);
            this.Name = "Form1";
            this.Text = "Flying Vehicles";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox vehicleComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button flyButton;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.ProgressBar fuelProgressBar;
        private System.Windows.Forms.Label fuelLabel;
    }
}

