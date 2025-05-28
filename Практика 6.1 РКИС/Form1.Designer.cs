namespace Практика_6._1_РКИС
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonAccept = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbGV = new System.Windows.Forms.ComboBox();
            this.cbRam = new System.Windows.Forms.ComboBox();
            this.cbCPU = new System.Windows.Forms.ComboBox();
            this.cbPB = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.output = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAccept
            // 
            this.buttonAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAccept.Location = new System.Drawing.Point(720, 581);
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.Size = new System.Drawing.Size(242, 93);
            this.buttonAccept.TabIndex = 0;
            this.buttonAccept.Text = "button1";
            this.buttonAccept.UseVisualStyleBackColor = true;
            this.buttonAccept.Click += new System.EventHandler(this.buttonAccept_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-60, -16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(774, 809);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // cbGV
            // 
            this.cbGV.FormattingEnabled = true;
            this.cbGV.Location = new System.Drawing.Point(0, 100);
            this.cbGV.Name = "cbGV";
            this.cbGV.Size = new System.Drawing.Size(253, 21);
            this.cbGV.TabIndex = 2;
            this.cbGV.Text = "Выберите видеокарту";
            // 
            // cbRam
            // 
            this.cbRam.FormattingEnabled = true;
            this.cbRam.Location = new System.Drawing.Point(0, 21);
            this.cbRam.Name = "cbRam";
            this.cbRam.Size = new System.Drawing.Size(253, 21);
            this.cbRam.TabIndex = 3;
            this.cbRam.Text = "Выберите оперативку";
            // 
            // cbCPU
            // 
            this.cbCPU.FormattingEnabled = true;
            this.cbCPU.Location = new System.Drawing.Point(0, 73);
            this.cbCPU.Name = "cbCPU";
            this.cbCPU.Size = new System.Drawing.Size(253, 21);
            this.cbCPU.TabIndex = 4;
            this.cbCPU.Text = "Выберите процессор";
            // 
            // cbPB
            // 
            this.cbPB.FormattingEnabled = true;
            this.cbPB.Location = new System.Drawing.Point(0, 46);
            this.cbPB.Name = "cbPB";
            this.cbPB.Size = new System.Drawing.Size(253, 21);
            this.cbPB.TabIndex = 5;
            this.cbPB.Text = "Выберите блок питания";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cbRam);
            this.groupBox1.Controls.Add(this.cbGV);
            this.groupBox1.Controls.Add(this.cbCPU);
            this.groupBox1.Controls.Add(this.cbPB);
            this.groupBox1.Location = new System.Drawing.Point(720, 406);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 131);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Характеристики";
            // 
            // output
            // 
            this.output.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.output.BackColor = System.Drawing.SystemColors.InfoText;
            this.output.ForeColor = System.Drawing.SystemColors.Menu;
            this.output.Location = new System.Drawing.Point(720, 12);
            this.output.Multiline = true;
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(253, 274);
            this.output.TabIndex = 7;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-60, -16);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1, 1);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 805);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.output);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonAccept);
            this.Controls.Add(this.pictureBox1);
            this.MinimumSize = new System.Drawing.Size(1001, 844);
            this.Name = "Form1";
            this.Text = "Мамка - Продакшн";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAccept;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbGV;
        private System.Windows.Forms.ComboBox cbRam;
        private System.Windows.Forms.ComboBox cbCPU;
        private System.Windows.Forms.ComboBox cbPB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox output;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

