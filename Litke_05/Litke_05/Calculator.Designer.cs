namespace Litke_05
{
    partial class Calculator
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
            if (disposing && (components != null)) {
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
            this.textBox_A = new System.Windows.Forms.TextBox();
            this.textBox_B = new System.Windows.Forms.TextBox();
            this.textBox_C = new System.Windows.Forms.TextBox();
            this.textBox_D = new System.Windows.Forms.TextBox();
            this.textBox_X = new System.Windows.Forms.TextBox();
            this.textBox_Result = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_A
            // 
            this.textBox_A.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox_A.Location = new System.Drawing.Point(136, 38);
            this.textBox_A.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_A.Name = "textBox_A";
            this.textBox_A.Size = new System.Drawing.Size(212, 22);
            this.textBox_A.TabIndex = 0;
            this.textBox_A.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox_A.TextChanged += new System.EventHandler(this.textBox_A_TextChanged);
            // 
            // textBox_B
            // 
            this.textBox_B.Location = new System.Drawing.Point(136, 73);
            this.textBox_B.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_B.Name = "textBox_B";
            this.textBox_B.Size = new System.Drawing.Size(212, 22);
            this.textBox_B.TabIndex = 1;
            this.textBox_B.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox_B.TextChanged += new System.EventHandler(this.textBox_B_TextChanged);
            // 
            // textBox_C
            // 
            this.textBox_C.Location = new System.Drawing.Point(136, 109);
            this.textBox_C.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_C.Name = "textBox_C";
            this.textBox_C.Size = new System.Drawing.Size(212, 22);
            this.textBox_C.TabIndex = 2;
            this.textBox_C.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox_C.TextChanged += new System.EventHandler(this.textBox_C_TextChanged);
            // 
            // textBox_D
            // 
            this.textBox_D.Location = new System.Drawing.Point(136, 144);
            this.textBox_D.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_D.Name = "textBox_D";
            this.textBox_D.Size = new System.Drawing.Size(212, 22);
            this.textBox_D.TabIndex = 3;
            this.textBox_D.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox_D.TextChanged += new System.EventHandler(this.textBox_D_TextChanged);
            // 
            // textBox_X
            // 
            this.textBox_X.Location = new System.Drawing.Point(136, 184);
            this.textBox_X.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_X.Name = "textBox_X";
            this.textBox_X.Size = new System.Drawing.Size(212, 22);
            this.textBox_X.TabIndex = 4;
            this.textBox_X.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox_X.TextChanged += new System.EventHandler(this.textBox_X_TextChanged);
            // 
            // textBox_Result
            // 
            this.textBox_Result.Location = new System.Drawing.Point(13, 312);
            this.textBox_Result.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Result.Name = "textBox_Result";
            this.textBox_Result.ReadOnly = true;
            this.textBox_Result.Size = new System.Drawing.Size(309, 22);
            this.textBox_Result.TabIndex = 14;
            this.textBox_Result.TabStop = false;
            this.textBox_Result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(26, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "A\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(26, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "B";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(26, 109);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "C";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(26, 144);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "D";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(26, 184);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "X";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(13, 268);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(309, 50);
            this.label6.TabIndex = 10;
            this.label6.Text = "Результат вычисления выражения:";
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(370, 369);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Result);
            this.Controls.Add(this.textBox_X);
            this.Controls.Add(this.textBox_D);
            this.Controls.Add(this.textBox_C);
            this.Controls.Add(this.textBox_B);
            this.Controls.Add(this.textBox_A);
            this.Name = "Calculator";
            this.Text = "Калькулятор";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_A;
        private System.Windows.Forms.TextBox textBox_B;
        private System.Windows.Forms.TextBox textBox_C;
        private System.Windows.Forms.TextBox textBox_D;
        private System.Windows.Forms.TextBox textBox_X;
        private System.Windows.Forms.TextBox textBox_Result;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

