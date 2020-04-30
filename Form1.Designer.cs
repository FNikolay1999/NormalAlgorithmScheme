namespace NormalAlgorithmScheme
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
            this.rules = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuTitle = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SchemeTitle = new System.Windows.Forms.Label();
            this.solution = new System.Windows.Forms.TextBox();
            this.inputStrTitle = new System.Windows.Forms.Label();
            this.outputStrTitle = new System.Windows.Forms.Label();
            this.outputStr = new System.Windows.Forms.TextBox();
            this.direction = new System.Windows.Forms.Label();
            this.record = new System.Windows.Forms.Label();
            this.record2 = new System.Windows.Forms.Label();
            this.record3 = new System.Windows.Forms.Label();
            this.record1 = new System.Windows.Forms.Label();
            this.direction1 = new System.Windows.Forms.Label();
            this.SolutionTitle = new System.Windows.Forms.Label();
            this.inputStr = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rules
            // 
            this.rules.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rules.Location = new System.Drawing.Point(12, 99);
            this.rules.Multiline = true;
            this.rules.Name = "rules";
            this.rules.Size = new System.Drawing.Size(256, 312);
            this.rules.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.menuTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(952, 55);
            this.panel1.TabIndex = 8;
            // 
            // menuTitle
            // 
            this.menuTitle.AutoSize = true;
            this.menuTitle.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuTitle.Location = new System.Drawing.Point(99, 0);
            this.menuTitle.Name = "menuTitle";
            this.menuTitle.Size = new System.Drawing.Size(527, 49);
            this.menuTitle.TabIndex = 0;
            this.menuTitle.Text = "Схема нормального алгритма";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(160)))), ((int)(((byte)(192)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(210)))), ((int)(((byte)(239)))));
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(307, 286);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 125);
            this.button1.TabIndex = 9;
            this.button1.Text = "Пуск";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SchemeTitle
            // 
            this.SchemeTitle.AutoSize = true;
            this.SchemeTitle.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SchemeTitle.Location = new System.Drawing.Point(65, 58);
            this.SchemeTitle.Name = "SchemeTitle";
            this.SchemeTitle.Size = new System.Drawing.Size(140, 38);
            this.SchemeTitle.TabIndex = 10;
            this.SchemeTitle.Text = "Правила:";
            // 
            // solution
            // 
            this.solution.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.solution.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.solution.Location = new System.Drawing.Point(0, 455);
            this.solution.Multiline = true;
            this.solution.Name = "solution";
            this.solution.Size = new System.Drawing.Size(952, 145);
            this.solution.TabIndex = 7;
            // 
            // inputStrTitle
            // 
            this.inputStrTitle.AutoSize = true;
            this.inputStrTitle.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputStrTitle.Location = new System.Drawing.Point(300, 58);
            this.inputStrTitle.Name = "inputStrTitle";
            this.inputStrTitle.Size = new System.Drawing.Size(88, 38);
            this.inputStrTitle.TabIndex = 11;
            this.inputStrTitle.Text = "Ввод:";
            // 
            // outputStrTitle
            // 
            this.outputStrTitle.AutoSize = true;
            this.outputStrTitle.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outputStrTitle.Location = new System.Drawing.Point(300, 158);
            this.outputStrTitle.Name = "outputStrTitle";
            this.outputStrTitle.Size = new System.Drawing.Size(109, 38);
            this.outputStrTitle.TabIndex = 13;
            this.outputStrTitle.Text = "Вывод:";
            // 
            // outputStr
            // 
            this.outputStr.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outputStr.Location = new System.Drawing.Point(307, 209);
            this.outputStr.Multiline = true;
            this.outputStr.Name = "outputStr";
            this.outputStr.Size = new System.Drawing.Size(150, 45);
            this.outputStr.TabIndex = 12;
            // 
            // direction
            // 
            this.direction.AutoSize = true;
            this.direction.BackColor = System.Drawing.Color.Gainsboro;
            this.direction.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.direction.Location = new System.Drawing.Point(517, 61);
            this.direction.Name = "direction";
            this.direction.Size = new System.Drawing.Size(141, 38);
            this.direction.TabIndex = 14;
            this.direction.Text = "Указания:";
            // 
            // record
            // 
            this.record.AutoSize = true;
            this.record.BackColor = System.Drawing.Color.Gainsboro;
            this.record.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.record.Location = new System.Drawing.Point(523, 153);
            this.record.Name = "record";
            this.record.Size = new System.Drawing.Size(116, 38);
            this.record.TabIndex = 15;
            this.record.Text = "Запись:";
            // 
            // record2
            // 
            this.record2.AutoSize = true;
            this.record2.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.record2.Location = new System.Drawing.Point(533, 229);
            this.record2.Name = "record2";
            this.record2.Size = new System.Drawing.Size(309, 38);
            this.record2.TabIndex = 16;
            this.record2.Text = "последнее действие: .";
            // 
            // record3
            // 
            this.record3.AutoSize = true;
            this.record3.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.record3.Location = new System.Drawing.Point(533, 270);
            this.record3.Name = "record3";
            this.record3.Size = new System.Drawing.Size(265, 38);
            this.record3.TabIndex = 18;
            this.record3.Text = "стрелка в схеме: ->";
            // 
            // record1
            // 
            this.record1.AutoSize = true;
            this.record1.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.record1.Location = new System.Drawing.Point(533, 191);
            this.record1.Name = "record1";
            this.record1.Size = new System.Drawing.Size(245, 38);
            this.record1.TabIndex = 19;
            this.record1.Text = "пустота: E (англ.)";
            // 
            // direction1
            // 
            this.direction1.AutoSize = true;
            this.direction1.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.direction1.Location = new System.Drawing.Point(523, 106);
            this.direction1.Name = "direction1";
            this.direction1.Size = new System.Drawing.Size(429, 38);
            this.direction1.TabIndex = 20;
            this.direction1.Text = "каждое правило с новой строки";
            // 
            // SolutionTitle
            // 
            this.SolutionTitle.AutoSize = true;
            this.SolutionTitle.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SolutionTitle.Location = new System.Drawing.Point(5, 414);
            this.SolutionTitle.Name = "SolutionTitle";
            this.SolutionTitle.Size = new System.Drawing.Size(137, 38);
            this.SolutionTitle.TabIndex = 21;
            this.SolutionTitle.Text = "Решение:";
            // 
            // inputStr
            // 
            this.inputStr.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputStr.Location = new System.Drawing.Point(307, 106);
            this.inputStr.Multiline = true;
            this.inputStr.Name = "inputStr";
            this.inputStr.Size = new System.Drawing.Size(150, 45);
            this.inputStr.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 600);
            this.Controls.Add(this.inputStr);
            this.Controls.Add(this.SolutionTitle);
            this.Controls.Add(this.direction1);
            this.Controls.Add(this.record1);
            this.Controls.Add(this.record3);
            this.Controls.Add(this.record2);
            this.Controls.Add(this.record);
            this.Controls.Add(this.direction);
            this.Controls.Add(this.outputStrTitle);
            this.Controls.Add(this.outputStr);
            this.Controls.Add(this.inputStrTitle);
            this.Controls.Add(this.SchemeTitle);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.solution);
            this.Controls.Add(this.rules);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox rules;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label menuTitle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label SchemeTitle;
        private System.Windows.Forms.TextBox solution;
        private System.Windows.Forms.Label inputStrTitle;
        private System.Windows.Forms.Label outputStrTitle;
        private System.Windows.Forms.TextBox outputStr;
        private System.Windows.Forms.Label direction;
        private System.Windows.Forms.Label record;
        private System.Windows.Forms.Label record2;
        private System.Windows.Forms.Label record3;
        private System.Windows.Forms.Label record1;
        private System.Windows.Forms.Label direction1;
        private System.Windows.Forms.Label SolutionTitle;
        private System.Windows.Forms.TextBox inputStr;
    }
}

