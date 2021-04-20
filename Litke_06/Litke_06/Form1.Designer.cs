namespace Litke_06
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
            this.customGraphics1 = new CustomGraphics.CustomGraphics();
            this.SuspendLayout();
            // 
            // customGraphics1
            // 
            this.customGraphics1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customGraphics1.Location = new System.Drawing.Point(0, 0);
            this.customGraphics1.Name = "customGraphics1";
            this.customGraphics1.Size = new System.Drawing.Size(400, 264);
            this.customGraphics1.TabIndex = 0;
            this.customGraphics1.Text = "customGraphics1";
            this.customGraphics1.Click += new System.EventHandler(this.customGraphics1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 264);
            this.Controls.Add(this.customGraphics1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private CustomGraphics.CustomGraphics customGraphics1;
    }
}

