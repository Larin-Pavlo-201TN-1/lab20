namespace lab20
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numerator_txt = new System.Windows.Forms.TextBox();
            this.denominator_txt = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.Label();
            this.btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Чисельник";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Знаменник";
            // 
            // numerator_txt
            // 
            this.numerator_txt.Location = new System.Drawing.Point(44, 55);
            this.numerator_txt.Name = "numerator_txt";
            this.numerator_txt.Size = new System.Drawing.Size(100, 22);
            this.numerator_txt.TabIndex = 2;
            // 
            // denominator_txt
            // 
            this.denominator_txt.Location = new System.Drawing.Point(44, 111);
            this.denominator_txt.Name = "denominator_txt";
            this.denominator_txt.Size = new System.Drawing.Size(100, 22);
            this.denominator_txt.TabIndex = 3;
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(41, 144);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(0, 16);
            this.result.TabIndex = 4;
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(44, 161);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(87, 26);
            this.btn.TabIndex = 5;
            this.btn.Text = "Виконати";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.result);
            this.Controls.Add(this.denominator_txt);
            this.Controls.Add(this.numerator_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox numerator_txt;
        private System.Windows.Forms.TextBox denominator_txt;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Button btn;
    }
}

