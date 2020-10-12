namespace CurrencyConverter
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
            this.ButtonCalculate = new System.Windows.Forms.Button();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RadioButtonDollar = new System.Windows.Forms.RadioButton();
            this.RadioButtonEuro = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RadioButtonSale = new System.Windows.Forms.RadioButton();
            this.RadioButtonPurchase = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TextBoxSum = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonCalculate
            // 
            this.ButtonCalculate.Location = new System.Drawing.Point(5, 359);
            this.ButtonCalculate.Name = "ButtonCalculate";
            this.ButtonCalculate.Size = new System.Drawing.Size(105, 38);
            this.ButtonCalculate.TabIndex = 0;
            this.ButtonCalculate.Text = "Обчислити";
            this.ButtonCalculate.UseVisualStyleBackColor = true;
            this.ButtonCalculate.Click += new System.EventHandler(this.ButtonCalculate_Click);
            // 
            // ButtonSave
            // 
            this.ButtonSave.Location = new System.Drawing.Point(90, 403);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(99, 35);
            this.ButtonSave.TabIndex = 1;
            this.ButtonSave.Text = "Зберегти";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RadioButtonDollar);
            this.groupBox1.Controls.Add(this.RadioButtonEuro);
            this.groupBox1.Location = new System.Drawing.Point(5, 161);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 79);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Вибір валюти";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // RadioButtonDollar
            // 
            this.RadioButtonDollar.AutoSize = true;
            this.RadioButtonDollar.Location = new System.Drawing.Point(6, 48);
            this.RadioButtonDollar.Name = "RadioButtonDollar";
            this.RadioButtonDollar.Size = new System.Drawing.Size(69, 21);
            this.RadioButtonDollar.TabIndex = 1;
            this.RadioButtonDollar.TabStop = true;
            this.RadioButtonDollar.Text = "долар";
            this.RadioButtonDollar.UseVisualStyleBackColor = true;
            // 
            // RadioButtonEuro
            // 
            this.RadioButtonEuro.AutoSize = true;
            this.RadioButtonEuro.Location = new System.Drawing.Point(6, 21);
            this.RadioButtonEuro.Name = "RadioButtonEuro";
            this.RadioButtonEuro.Size = new System.Drawing.Size(59, 21);
            this.RadioButtonEuro.TabIndex = 0;
            this.RadioButtonEuro.TabStop = true;
            this.RadioButtonEuro.Text = "євро";
            this.RadioButtonEuro.UseVisualStyleBackColor = true;
            this.RadioButtonEuro.CheckedChanged += new System.EventHandler(this.RadioButtonEuro_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RadioButtonSale);
            this.groupBox2.Controls.Add(this.RadioButtonPurchase);
            this.groupBox2.Location = new System.Drawing.Point(5, 256);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 76);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Вибір операції";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // RadioButtonSale
            // 
            this.RadioButtonSale.AutoSize = true;
            this.RadioButtonSale.Location = new System.Drawing.Point(5, 48);
            this.RadioButtonSale.Name = "RadioButtonSale";
            this.RadioButtonSale.Size = new System.Drawing.Size(78, 21);
            this.RadioButtonSale.TabIndex = 1;
            this.RadioButtonSale.TabStop = true;
            this.RadioButtonSale.Text = "продаж";
            this.RadioButtonSale.UseVisualStyleBackColor = true;
            // 
            // RadioButtonPurchase
            // 
            this.RadioButtonPurchase.AutoSize = true;
            this.RadioButtonPurchase.Location = new System.Drawing.Point(6, 21);
            this.RadioButtonPurchase.Name = "RadioButtonPurchase";
            this.RadioButtonPurchase.Size = new System.Drawing.Size(77, 21);
            this.RadioButtonPurchase.TabIndex = 0;
            this.RadioButtonPurchase.TabStop = true;
            this.RadioButtonPurchase.Text = "купівля";
            this.RadioButtonPurchase.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 4;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TextBoxSum);
            this.groupBox3.Location = new System.Drawing.Point(138, 338);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(141, 59);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "сума до видачі";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // TextBoxSum
            // 
            this.TextBoxSum.Location = new System.Drawing.Point(7, 31);
            this.TextBoxSum.Name = "TextBoxSum";
            this.TextBoxSum.Size = new System.Drawing.Size(128, 22);
            this.TextBoxSum.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.ButtonCalculate);
            this.Name = "Form1";
            this.Text = "Обмін валют";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonCalculate;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RadioButtonDollar;
        private System.Windows.Forms.RadioButton RadioButtonEuro;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton RadioButtonSale;
        private System.Windows.Forms.RadioButton RadioButtonPurchase;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox TextBoxSum;
    }
}

