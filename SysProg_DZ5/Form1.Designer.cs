namespace SysProg_DZ5
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(13, 144);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(775, 294);
            this.textBox1.TabIndex = 0;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(13, 13);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(173, 17);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Считать кол-во предложений";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(13, 37);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(155, 17);
            this.checkBox2.TabIndex = 2;
            this.checkBox2.Text = "Считать кол-во символов";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(13, 61);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(129, 17);
            this.checkBox3.TabIndex = 3;
            this.checkBox3.Text = "Считать кол-во слов";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(13, 85);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(191, 17);
            this.checkBox4.TabIndex = 4;
            this.checkBox4.Text = "Считать кол-во восклицат. пред.";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(13, 109);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(215, 17);
            this.checkBox5.TabIndex = 5;
            this.checkBox5.Text = "Считать кол-во вопрос. предложений";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(406, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(382, 71);
            this.button1.TabIndex = 6;
            this.button1.Text = "СЧИТАТЬ!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(406, 13);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(120, 17);
            this.checkBox6.TabIndex = 7;
            this.checkBox6.Text = "Сохранить в  файл";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBox6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox6;
    }
}

