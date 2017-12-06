namespace WindowsFormsApplication3
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
      this.textBox2 = new System.Windows.Forms.TextBox();
      this.textBox4 = new System.Windows.Forms.TextBox();
      this.button1 = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(202, 78);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(247, 20);
      this.textBox1.TabIndex = 0;
      this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
      // 
      // textBox2
      // 
      this.textBox2.Location = new System.Drawing.Point(202, 166);
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new System.Drawing.Size(247, 20);
      this.textBox2.TabIndex = 1;
      // 
      // textBox4
      // 
      this.textBox4.Location = new System.Drawing.Point(202, 237);
      this.textBox4.Name = "textBox4";
      this.textBox4.Size = new System.Drawing.Size(247, 20);
      this.textBox4.TabIndex = 3;
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(271, 208);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(75, 23);
      this.button1.TabIndex = 4;
      this.button1.Text = "button1";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(718, 478);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.textBox4);
      this.Controls.Add(this.textBox2);
      this.Controls.Add(this.textBox1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.TextBox textBox4;
    private System.Windows.Forms.Button button1;
  }
}

