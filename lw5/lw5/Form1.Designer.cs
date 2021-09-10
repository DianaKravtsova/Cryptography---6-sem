namespace lw5
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.resultTimeCode1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.resultTimeDecode1 = new System.Windows.Forms.TextBox();
            this.resultCode1 = new System.Windows.Forms.TextBox();
            this.resultDecode1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.resultDecode2 = new System.Windows.Forms.TextBox();
            this.resultCode2 = new System.Windows.Forms.TextBox();
            this.resultTimeDecode2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.resultTimeCode2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.keyWord1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.keyWord2 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.countCode1 = new System.Windows.Forms.TextBox();
            this.countDecode1 = new System.Windows.Forms.TextBox();
            this.countCode2 = new System.Windows.Forms.TextBox();
            this.countDecode2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(191, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Маршрутная перестановка";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(218)))), ((int)(((byte)(158)))));
            this.button1.Location = new System.Drawing.Point(53, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(222, 70);
            this.button1.TabIndex = 1;
            this.button1.Text = "Зашифровать";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(218)))), ((int)(((byte)(158)))));
            this.button2.Location = new System.Drawing.Point(437, 43);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(222, 70);
            this.button2.TabIndex = 2;
            this.button2.Text = "Расшифровать";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(49, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "время выполнения:";
            // 
            // resultTimeCode1
            // 
            this.resultTimeCode1.Location = new System.Drawing.Point(53, 145);
            this.resultTimeCode1.Name = "resultTimeCode1";
            this.resultTimeCode1.Size = new System.Drawing.Size(215, 22);
            this.resultTimeCode1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(432, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "время выполнения:";
            // 
            // resultTimeDecode1
            // 
            this.resultTimeDecode1.Location = new System.Drawing.Point(436, 145);
            this.resultTimeDecode1.Name = "resultTimeDecode1";
            this.resultTimeDecode1.Size = new System.Drawing.Size(215, 22);
            this.resultTimeDecode1.TabIndex = 6;
            // 
            // resultCode1
            // 
            this.resultCode1.Location = new System.Drawing.Point(52, 183);
            this.resultCode1.MaximumSize = new System.Drawing.Size(217, 70);
            this.resultCode1.MinimumSize = new System.Drawing.Size(222, 55);
            this.resultCode1.Name = "resultCode1";
            this.resultCode1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.resultCode1.Size = new System.Drawing.Size(222, 55);
            this.resultCode1.TabIndex = 7;
            // 
            // resultDecode1
            // 
            this.resultDecode1.Location = new System.Drawing.Point(436, 183);
            this.resultDecode1.MaximumSize = new System.Drawing.Size(217, 70);
            this.resultDecode1.MinimumSize = new System.Drawing.Size(222, 55);
            this.resultDecode1.Name = "resultDecode1";
            this.resultDecode1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.resultDecode1.Size = new System.Drawing.Size(222, 55);
            this.resultDecode1.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(180, 333);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(329, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Множественная перестановка";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(218)))), ((int)(((byte)(158)))));
            this.button3.Location = new System.Drawing.Point(53, 411);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(222, 70);
            this.button3.TabIndex = 10;
            this.button3.Text = "Зашифровать";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(218)))), ((int)(((byte)(158)))));
            this.button4.Location = new System.Drawing.Point(435, 411);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(222, 70);
            this.button4.TabIndex = 11;
            this.button4.Text = "Расшифровать";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // resultDecode2
            // 
            this.resultDecode2.Location = new System.Drawing.Point(437, 543);
            this.resultDecode2.MaximumSize = new System.Drawing.Size(217, 70);
            this.resultDecode2.MinimumSize = new System.Drawing.Size(222, 55);
            this.resultDecode2.Name = "resultDecode2";
            this.resultDecode2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.resultDecode2.Size = new System.Drawing.Size(222, 55);
            this.resultDecode2.TabIndex = 17;
            this.resultDecode2.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // resultCode2
            // 
            this.resultCode2.Location = new System.Drawing.Point(54, 542);
            this.resultCode2.MaximumSize = new System.Drawing.Size(217, 70);
            this.resultCode2.MinimumSize = new System.Drawing.Size(222, 55);
            this.resultCode2.Name = "resultCode2";
            this.resultCode2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.resultCode2.Size = new System.Drawing.Size(222, 55);
            this.resultCode2.TabIndex = 16;
            // 
            // resultTimeDecode2
            // 
            this.resultTimeDecode2.Location = new System.Drawing.Point(437, 509);
            this.resultTimeDecode2.Name = "resultTimeDecode2";
            this.resultTimeDecode2.Size = new System.Drawing.Size(215, 22);
            this.resultTimeDecode2.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(433, 488);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 18);
            this.label5.TabIndex = 14;
            this.label5.Text = "время выполнения:";
            // 
            // resultTimeCode2
            // 
            this.resultTimeCode2.Location = new System.Drawing.Point(54, 509);
            this.resultTimeCode2.Name = "resultTimeCode2";
            this.resultTimeCode2.Size = new System.Drawing.Size(215, 22);
            this.resultTimeCode2.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(50, 490);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "время выполнения:";
            // 
            // keyWord1
            // 
            this.keyWord1.Location = new System.Drawing.Point(54, 383);
            this.keyWord1.Name = "keyWord1";
            this.keyWord1.Size = new System.Drawing.Size(215, 22);
            this.keyWord1.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(50, 364);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(163, 18);
            this.label7.TabIndex = 18;
            this.label7.Text = "ключевое слово 1:";
            // 
            // keyWord2
            // 
            this.keyWord2.Location = new System.Drawing.Point(294, 383);
            this.keyWord2.Name = "keyWord2";
            this.keyWord2.Size = new System.Drawing.Size(215, 22);
            this.keyWord2.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(290, 364);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(163, 18);
            this.label11.TabIndex = 20;
            this.label11.Text = "ключевое слово 2:";
            // 
            // countCode1
            // 
            this.countCode1.Location = new System.Drawing.Point(52, 258);
            this.countCode1.MaximumSize = new System.Drawing.Size(217, 70);
            this.countCode1.MinimumSize = new System.Drawing.Size(222, 55);
            this.countCode1.Name = "countCode1";
            this.countCode1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.countCode1.Size = new System.Drawing.Size(222, 55);
            this.countCode1.TabIndex = 22;
            // 
            // countDecode1
            // 
            this.countDecode1.Location = new System.Drawing.Point(436, 258);
            this.countDecode1.MaximumSize = new System.Drawing.Size(217, 70);
            this.countDecode1.MinimumSize = new System.Drawing.Size(222, 55);
            this.countDecode1.Name = "countDecode1";
            this.countDecode1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.countDecode1.Size = new System.Drawing.Size(222, 55);
            this.countDecode1.TabIndex = 23;
            // 
            // countCode2
            // 
            this.countCode2.Location = new System.Drawing.Point(54, 612);
            this.countCode2.MaximumSize = new System.Drawing.Size(217, 70);
            this.countCode2.MinimumSize = new System.Drawing.Size(222, 55);
            this.countCode2.Name = "countCode2";
            this.countCode2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.countCode2.Size = new System.Drawing.Size(222, 55);
            this.countCode2.TabIndex = 24;
            // 
            // countDecode2
            // 
            this.countDecode2.Location = new System.Drawing.Point(437, 612);
            this.countDecode2.MaximumSize = new System.Drawing.Size(217, 70);
            this.countDecode2.MinimumSize = new System.Drawing.Size(222, 55);
            this.countDecode2.Name = "countDecode2";
            this.countDecode2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.countDecode2.Size = new System.Drawing.Size(222, 55);
            this.countDecode2.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(724, 685);
            this.Controls.Add(this.countDecode2);
            this.Controls.Add(this.countCode2);
            this.Controls.Add(this.countDecode1);
            this.Controls.Add(this.countCode1);
            this.Controls.Add(this.keyWord2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.keyWord1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.resultDecode2);
            this.Controls.Add(this.resultCode2);
            this.Controls.Add(this.resultTimeDecode2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.resultTimeCode2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.resultDecode1);
            this.Controls.Add(this.resultCode1);
            this.Controls.Add(this.resultTimeDecode1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.resultTimeCode1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox resultTimeCode1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox resultTimeDecode1;
        private System.Windows.Forms.TextBox resultCode1;
        private System.Windows.Forms.TextBox resultDecode1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox resultDecode2;
        private System.Windows.Forms.TextBox resultCode2;
        private System.Windows.Forms.TextBox resultTimeDecode2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox resultTimeCode2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox keyWord1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox keyWord2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox countCode1;
        private System.Windows.Forms.TextBox countDecode1;
        private System.Windows.Forms.TextBox countCode2;
        private System.Windows.Forms.TextBox countDecode2;
    }
}

