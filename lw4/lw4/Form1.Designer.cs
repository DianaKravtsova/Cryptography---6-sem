namespace lw4
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
            this.button1 = new System.Windows.Forms.Button();
            this.resultTask1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.resultTask11 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.resultTask2 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.keyWord = new System.Windows.Forms.TextBox();
            this.resultTask22 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.resultTimeTask1 = new System.Windows.Forms.TextBox();
            this.resultTimeTask2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.countChar2 = new System.Windows.Forms.TextBox();
            this.countChar1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(81)))), ((int)(((byte)(78)))));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(249)))), ((int)(((byte)(245)))));
            this.button1.Location = new System.Drawing.Point(48, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(247, 51);
            this.button1.TabIndex = 0;
            this.button1.Text = "Зашифровать ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // resultTask1
            // 
            this.resultTask1.AcceptsTab = true;
            this.resultTask1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.resultTask1.Location = new System.Drawing.Point(376, 57);
            this.resultTask1.MaximumSize = new System.Drawing.Size(450, 130);
            this.resultTask1.MinimumSize = new System.Drawing.Size(450, 130);
            this.resultTask1.Multiline = true;
            this.resultTask1.Name = "resultTask1";
            this.resultTask1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.resultTask1.Size = new System.Drawing.Size(450, 130);
            this.resultTask1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(304, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 45);
            this.label1.TabIndex = 2;
            this.label1.Text = "Шифр Порты";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // resultTask11
            // 
            this.resultTask11.AcceptsTab = true;
            this.resultTask11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.resultTask11.Location = new System.Drawing.Point(376, 193);
            this.resultTask11.MaximumSize = new System.Drawing.Size(450, 130);
            this.resultTask11.MinimumSize = new System.Drawing.Size(450, 130);
            this.resultTask11.Multiline = true;
            this.resultTask11.Name = "resultTask11";
            this.resultTask11.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.resultTask11.Size = new System.Drawing.Size(450, 130);
            this.resultTask11.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(81)))), ((int)(((byte)(78)))));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(249)))), ((int)(((byte)(245)))));
            this.button2.Location = new System.Drawing.Point(48, 136);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(247, 51);
            this.button2.TabIndex = 4;
            this.button2.Text = "Расшифровать ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(0, 374);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(861, 11);
            this.label4.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(304, 395);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 45);
            this.label2.TabIndex = 35;
            this.label2.Text = "Шифр Цезаря";
            // 
            // resultTask2
            // 
            this.resultTask2.AcceptsTab = true;
            this.resultTask2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.resultTask2.Location = new System.Drawing.Point(376, 506);
            this.resultTask2.MaximumSize = new System.Drawing.Size(450, 130);
            this.resultTask2.MinimumSize = new System.Drawing.Size(450, 130);
            this.resultTask2.Multiline = true;
            this.resultTask2.Name = "resultTask2";
            this.resultTask2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.resultTask2.Size = new System.Drawing.Size(450, 130);
            this.resultTask2.TabIndex = 36;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(81)))), ((int)(((byte)(78)))));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(249)))), ((int)(((byte)(245)))));
            this.button3.Location = new System.Drawing.Point(48, 506);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(247, 51);
            this.button3.TabIndex = 37;
            this.button3.Text = "Зашифровать ";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(371, 440);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 30);
            this.label3.TabIndex = 38;
            this.label3.Text = "ключевое слово:";
            // 
            // keyWord
            // 
            this.keyWord.Location = new System.Drawing.Point(553, 449);
            this.keyWord.Name = "keyWord";
            this.keyWord.Size = new System.Drawing.Size(246, 22);
            this.keyWord.TabIndex = 39;
            // 
            // resultTask22
            // 
            this.resultTask22.AcceptsTab = true;
            this.resultTask22.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.resultTask22.Location = new System.Drawing.Point(376, 666);
            this.resultTask22.MaximumSize = new System.Drawing.Size(450, 130);
            this.resultTask22.MinimumSize = new System.Drawing.Size(450, 130);
            this.resultTask22.Multiline = true;
            this.resultTask22.Name = "resultTask22";
            this.resultTask22.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.resultTask22.Size = new System.Drawing.Size(450, 130);
            this.resultTask22.TabIndex = 40;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(81)))), ((int)(((byte)(78)))));
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(249)))), ((int)(((byte)(245)))));
            this.button4.Location = new System.Drawing.Point(48, 585);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(247, 51);
            this.button4.TabIndex = 41;
            this.button4.Text = "Расшифровать ";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift Condensed", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(371, 326);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 30);
            this.label5.TabIndex = 42;
            this.label5.Text = "время выполнения:";
            // 
            // resultTimeTask1
            // 
            this.resultTimeTask1.Location = new System.Drawing.Point(553, 334);
            this.resultTimeTask1.Name = "resultTimeTask1";
            this.resultTimeTask1.Size = new System.Drawing.Size(246, 22);
            this.resultTimeTask1.TabIndex = 43;
            // 
            // resultTimeTask2
            // 
            this.resultTimeTask2.Location = new System.Drawing.Point(553, 802);
            this.resultTimeTask2.Name = "resultTimeTask2";
            this.resultTimeTask2.Size = new System.Drawing.Size(246, 22);
            this.resultTimeTask2.TabIndex = 45;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift Condensed", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(371, 795);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 30);
            this.label6.TabIndex = 44;
            this.label6.Text = "время выполнения:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift Condensed", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(73, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(209, 30);
            this.label7.TabIndex = 46;
            this.label7.Text = "количество вхождений:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift Condensed", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(73, 666);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(209, 30);
            this.label8.TabIndex = 47;
            this.label8.Text = "количество вхождений:";
            // 
            // countChar2
            // 
            this.countChar2.AcceptsTab = true;
            this.countChar2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.countChar2.Location = new System.Drawing.Point(78, 699);
            this.countChar2.MaximumSize = new System.Drawing.Size(200, 100);
            this.countChar2.MinimumSize = new System.Drawing.Size(200, 100);
            this.countChar2.Multiline = true;
            this.countChar2.Name = "countChar2";
            this.countChar2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.countChar2.Size = new System.Drawing.Size(200, 100);
            this.countChar2.TabIndex = 48;
            // 
            // countChar1
            // 
            this.countChar1.AcceptsTab = true;
            this.countChar1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.countChar1.Location = new System.Drawing.Point(78, 226);
            this.countChar1.MaximumSize = new System.Drawing.Size(200, 100);
            this.countChar1.MinimumSize = new System.Drawing.Size(200, 100);
            this.countChar1.Multiline = true;
            this.countChar1.Name = "countChar1";
            this.countChar1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.countChar1.Size = new System.Drawing.Size(200, 100);
            this.countChar1.TabIndex = 49;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(227)))), ((int)(((byte)(202)))));
            this.ClientSize = new System.Drawing.Size(853, 905);
            this.Controls.Add(this.countChar1);
            this.Controls.Add(this.countChar2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.resultTimeTask2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.resultTimeTask1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.resultTask22);
            this.Controls.Add(this.keyWord);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.resultTask2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.resultTask11);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resultTask1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox resultTask1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox resultTask11;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox resultTask2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox keyWord;
        private System.Windows.Forms.TextBox resultTask22;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox resultTimeTask1;
        private System.Windows.Forms.TextBox resultTimeTask2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox countChar2;
        private System.Windows.Forms.TextBox countChar1;
    }
}

