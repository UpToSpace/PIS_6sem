namespace client
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
            this.a = new System.Windows.Forms.TextBox();
            this.b = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.TextBox();
            this.plus = new System.Windows.Forms.Label();
            this.result_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // a
            // 
            this.a.Location = new System.Drawing.Point(27, 34);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(100, 22);
            this.a.TabIndex = 0;
            // 
            // b
            // 
            this.b.Location = new System.Drawing.Point(187, 34);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(100, 22);
            this.b.TabIndex = 1;
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(106, 139);
            this.result.Name = "result";
            this.result.ReadOnly = true;
            this.result.Size = new System.Drawing.Size(100, 22);
            this.result.TabIndex = 2;
            // 
            // plus
            // 
            this.plus.AutoSize = true;
            this.plus.Location = new System.Drawing.Point(149, 40);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(14, 16);
            this.plus.TabIndex = 3;
            this.plus.Text = "+";
            // 
            // result_button
            // 
            this.result_button.Location = new System.Drawing.Point(96, 83);
            this.result_button.Name = "result_button";
            this.result_button.Size = new System.Drawing.Size(110, 38);
            this.result_button.TabIndex = 5;
            this.result_button.Text = "get result";
            this.result_button.UseVisualStyleBackColor = true;
            this.result_button.Click += new System.EventHandler(this.result_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 450);
            this.Controls.Add(this.result_button);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.result);
            this.Controls.Add(this.b);
            this.Controls.Add(this.a);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox a;
        private System.Windows.Forms.TextBox b;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Label plus;
        private System.Windows.Forms.Button result_button;
    }
}

