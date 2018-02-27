namespace laba1_2_sem4
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
            this.textBox_Generate = new System.Windows.Forms.TextBox();
            this.label_size = new System.Windows.Forms.Label();
            this.btn_Generate = new System.Windows.Forms.Button();
            this.bnt_Asc = new System.Windows.Forms.Button();
            this.btn_Dsc = new System.Windows.Forms.Button();
            this.textBox_Before = new System.Windows.Forms.TextBox();
            this.btn_Max = new System.Windows.Forms.Button();
            this.btn_Min = new System.Windows.Forms.Button();
            this.textBox_After = new System.Windows.Forms.TextBox();
            this.label_Before = new System.Windows.Forms.Label();
            this.label_After = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_Generate
            // 
            this.textBox_Generate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Generate.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Generate.Location = new System.Drawing.Point(263, 68);
            this.textBox_Generate.Multiline = true;
            this.textBox_Generate.Name = "textBox_Generate";
            this.textBox_Generate.Size = new System.Drawing.Size(208, 42);
            this.textBox_Generate.TabIndex = 0;
            this.textBox_Generate.TextChanged += new System.EventHandler(this.textBox_Generate_TextChanged);
            // 
            // label_size
            // 
            this.label_size.AutoSize = true;
            this.label_size.BackColor = System.Drawing.Color.Transparent;
            this.label_size.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_size.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_size.Location = new System.Drawing.Point(208, 23);
            this.label_size.Name = "label_size";
            this.label_size.Size = new System.Drawing.Size(317, 37);
            this.label_size.TabIndex = 105;
            this.label_size.Text = "Введите размер коллекции";
            // 
            // btn_Generate
            // 
            this.btn_Generate.BackColor = System.Drawing.Color.Salmon;
            this.btn_Generate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Generate.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Generate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Generate.Location = new System.Drawing.Point(214, 124);
            this.btn_Generate.Name = "btn_Generate";
            this.btn_Generate.Size = new System.Drawing.Size(307, 59);
            this.btn_Generate.TabIndex = 2;
            this.btn_Generate.Text = "Сгенерировать коллекцию";
            this.btn_Generate.UseVisualStyleBackColor = false;
            this.btn_Generate.Click += new System.EventHandler(this.btn_Generate_Click);
            // 
            // bnt_Asc
            // 
            this.bnt_Asc.BackColor = System.Drawing.Color.MistyRose;
            this.bnt_Asc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnt_Asc.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bnt_Asc.Location = new System.Drawing.Point(23, 122);
            this.bnt_Asc.Name = "bnt_Asc";
            this.bnt_Asc.Size = new System.Drawing.Size(137, 61);
            this.bnt_Asc.TabIndex = 1;
            this.bnt_Asc.Text = "Сортировка по возрастанию";
            this.bnt_Asc.UseVisualStyleBackColor = false;
            this.bnt_Asc.Click += new System.EventHandler(this.bnt_Asc_Click);
            // 
            // btn_Dsc
            // 
            this.btn_Dsc.BackColor = System.Drawing.Color.MistyRose;
            this.btn_Dsc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Dsc.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Dsc.Location = new System.Drawing.Point(563, 124);
            this.btn_Dsc.Name = "btn_Dsc";
            this.btn_Dsc.Size = new System.Drawing.Size(111, 59);
            this.btn_Dsc.TabIndex = 3;
            this.btn_Dsc.Text = "Сортировка по убыванию";
            this.btn_Dsc.UseVisualStyleBackColor = false;
            this.btn_Dsc.Click += new System.EventHandler(this.btn_Dsc_Click);
            // 
            // textBox_Before
            // 
            this.textBox_Before.BackColor = System.Drawing.Color.White;
            this.textBox_Before.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Before.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Before.Location = new System.Drawing.Point(23, 245);
            this.textBox_Before.Margin = new System.Windows.Forms.Padding(8);
            this.textBox_Before.Multiline = true;
            this.textBox_Before.Name = "textBox_Before";
            this.textBox_Before.ReadOnly = true;
            this.textBox_Before.Size = new System.Drawing.Size(247, 205);
            this.textBox_Before.TabIndex = 100;
            this.textBox_Before.TextChanged += new System.EventHandler(this.textBox_Before_TextChanged);
            // 
            // btn_Max
            // 
            this.btn_Max.BackColor = System.Drawing.Color.Snow;
            this.btn_Max.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Max.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Max.Location = new System.Drawing.Point(290, 245);
            this.btn_Max.Name = "btn_Max";
            this.btn_Max.Size = new System.Drawing.Size(117, 42);
            this.btn_Max.TabIndex = 4;
            this.btn_Max.Text = "Max";
            this.btn_Max.UseVisualStyleBackColor = false;
            this.btn_Max.Click += new System.EventHandler(this.btn_Max_Click);
            // 
            // btn_Min
            // 
            this.btn_Min.BackColor = System.Drawing.Color.Snow;
            this.btn_Min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Min.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Min.Location = new System.Drawing.Point(290, 293);
            this.btn_Min.Name = "btn_Min";
            this.btn_Min.Size = new System.Drawing.Size(117, 42);
            this.btn_Min.TabIndex = 5;
            this.btn_Min.Text = "Min";
            this.btn_Min.UseVisualStyleBackColor = false;
            this.btn_Min.Click += new System.EventHandler(this.btn_Min_Click);
            // 
            // textBox_After
            // 
            this.textBox_After.BackColor = System.Drawing.Color.White;
            this.textBox_After.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_After.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_After.Location = new System.Drawing.Point(424, 245);
            this.textBox_After.Multiline = true;
            this.textBox_After.Name = "textBox_After";
            this.textBox_After.ReadOnly = true;
            this.textBox_After.Size = new System.Drawing.Size(250, 205);
            this.textBox_After.TabIndex = 101;
            this.textBox_After.TextChanged += new System.EventHandler(this.textBox_After_TextChanged);
            // 
            // label_Before
            // 
            this.label_Before.AutoSize = true;
            this.label_Before.BackColor = System.Drawing.Color.Transparent;
            this.label_Before.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Before.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_Before.Location = new System.Drawing.Point(23, 204);
            this.label_Before.Name = "label_Before";
            this.label_Before.Size = new System.Drawing.Size(77, 33);
            this.label_Before.TabIndex = 103;
            this.label_Before.Text = "Before";
            // 
            // label_After
            // 
            this.label_After.AutoSize = true;
            this.label_After.BackColor = System.Drawing.Color.Transparent;
            this.label_After.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_After.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_After.Location = new System.Drawing.Point(418, 204);
            this.label_After.Name = "label_After";
            this.label_After.Size = new System.Drawing.Size(66, 33);
            this.label_After.TabIndex = 104;
            this.label_After.Text = "After";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::laba1_2_sem4.Properties.Resources.afHysg1pK6w;
            this.ClientSize = new System.Drawing.Size(703, 462);
            this.Controls.Add(this.label_After);
            this.Controls.Add(this.label_Before);
            this.Controls.Add(this.textBox_After);
            this.Controls.Add(this.btn_Min);
            this.Controls.Add(this.btn_Max);
            this.Controls.Add(this.textBox_Before);
            this.Controls.Add(this.btn_Dsc);
            this.Controls.Add(this.bnt_Asc);
            this.Controls.Add(this.btn_Generate);
            this.Controls.Add(this.label_size);
            this.Controls.Add(this.textBox_Generate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Generate;
        private System.Windows.Forms.Label label_size;
        private System.Windows.Forms.Button btn_Generate;
        private System.Windows.Forms.Button bnt_Asc;
        private System.Windows.Forms.Button btn_Dsc;
        private System.Windows.Forms.TextBox textBox_Before;
        private System.Windows.Forms.Button btn_Max;
        private System.Windows.Forms.Button btn_Min;
        private System.Windows.Forms.TextBox textBox_After;
        private System.Windows.Forms.Label label_Before;
        private System.Windows.Forms.Label label_After;
    }
}

