namespace laba_2_s4
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Profession_comboBox = new System.Windows.Forms.ComboBox();
            this.Course_comboBox = new System.Windows.Forms.ComboBox();
            this.Name_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Surname_txtbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ViewResultOfSearch_listBox = new System.Windows.Forms.ListBox();
            this.BeforeAverage_txtbox = new System.Windows.Forms.TextBox();
            this.AfterAverage_txtbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Range = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Search_btn = new System.Windows.Forms.Button();
            this.Clear_SearchBtn = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.Range.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(273, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Course";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(273, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 23);
            this.label7.TabIndex = 6;
            this.label7.Text = "Profession";
            // 
            // Profession_comboBox
            // 
            this.Profession_comboBox.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Profession_comboBox.FormattingEnabled = true;
            this.Profession_comboBox.Items.AddRange(new object[] {
            "ISaT",
            "SIT",
            "SIPMS",
            "DDaWP"});
            this.Profession_comboBox.Location = new System.Drawing.Point(264, 148);
            this.Profession_comboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Profession_comboBox.Name = "Profession_comboBox";
            this.Profession_comboBox.Size = new System.Drawing.Size(135, 31);
            this.Profession_comboBox.TabIndex = 28;
            // 
            // Course_comboBox
            // 
            this.Course_comboBox.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Course_comboBox.FormattingEnabled = true;
            this.Course_comboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.Course_comboBox.Location = new System.Drawing.Point(264, 84);
            this.Course_comboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Course_comboBox.Name = "Course_comboBox";
            this.Course_comboBox.Size = new System.Drawing.Size(135, 31);
            this.Course_comboBox.TabIndex = 27;
            // 
            // Name_textBox
            // 
            this.Name_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Name_textBox.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name_textBox.Location = new System.Drawing.Point(22, 148);
            this.Name_textBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name_textBox.MaxLength = 30;
            this.Name_textBox.Multiline = true;
            this.Name_textBox.Name = "Name_textBox";
            this.Name_textBox.Size = new System.Drawing.Size(207, 30);
            this.Name_textBox.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(31, 120);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 23);
            this.label1.TabIndex = 31;
            this.label1.Text = "Name";
            // 
            // Surname_txtbox
            // 
            this.Surname_txtbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Surname_txtbox.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Surname_txtbox.Location = new System.Drawing.Point(23, 85);
            this.Surname_txtbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Surname_txtbox.MaxLength = 30;
            this.Surname_txtbox.Multiline = true;
            this.Surname_txtbox.Name = "Surname_txtbox";
            this.Surname_txtbox.Size = new System.Drawing.Size(206, 30);
            this.Surname_txtbox.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(31, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 23);
            this.label2.TabIndex = 29;
            this.label2.Text = "Surname";
            // 
            // ViewResultOfSearch_listBox
            // 
            this.ViewResultOfSearch_listBox.FormattingEnabled = true;
            this.ViewResultOfSearch_listBox.Location = new System.Drawing.Point(24, 198);
            this.ViewResultOfSearch_listBox.Name = "ViewResultOfSearch_listBox";
            this.ViewResultOfSearch_listBox.Size = new System.Drawing.Size(562, 95);
            this.ViewResultOfSearch_listBox.TabIndex = 33;
            // 
            // BeforeAverage_txtbox
            // 
            this.BeforeAverage_txtbox.Location = new System.Drawing.Point(6, 29);
            this.BeforeAverage_txtbox.MaxLength = 2;
            this.BeforeAverage_txtbox.Multiline = true;
            this.BeforeAverage_txtbox.Name = "BeforeAverage_txtbox";
            this.BeforeAverage_txtbox.Size = new System.Drawing.Size(62, 30);
            this.BeforeAverage_txtbox.TabIndex = 34;
            // 
            // AfterAverage_txtbox
            // 
            this.AfterAverage_txtbox.Location = new System.Drawing.Point(97, 29);
            this.AfterAverage_txtbox.MaxLength = 2;
            this.AfterAverage_txtbox.Multiline = true;
            this.AfterAverage_txtbox.Name = "AfterAverage_txtbox";
            this.AfterAverage_txtbox.Size = new System.Drawing.Size(62, 30);
            this.AfterAverage_txtbox.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 23);
            this.label4.TabIndex = 36;
            this.label4.Text = "—";
            // 
            // Range
            // 
            this.Range.Controls.Add(this.BeforeAverage_txtbox);
            this.Range.Controls.Add(this.AfterAverage_txtbox);
            this.Range.Controls.Add(this.label4);
            this.Range.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Range.Location = new System.Drawing.Point(430, 56);
            this.Range.Name = "Range";
            this.Range.Size = new System.Drawing.Size(167, 69);
            this.Range.TabIndex = 37;
            this.Range.TabStop = false;
            this.Range.Text = "Average Range";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(223, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 33);
            this.label5.TabIndex = 38;
            this.label5.Text = "FORM OF SEARCH";
            // 
            // Search_btn
            // 
            this.Search_btn.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Search_btn.Location = new System.Drawing.Point(23, 315);
            this.Search_btn.Name = "Search_btn";
            this.Search_btn.Size = new System.Drawing.Size(125, 38);
            this.Search_btn.TabIndex = 39;
            this.Search_btn.Text = "Search";
            this.Search_btn.UseVisualStyleBackColor = true;
            this.Search_btn.Click += new System.EventHandler(this.Search_btn_Click);
            // 
            // Clear_SearchBtn
            // 
            this.Clear_SearchBtn.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Clear_SearchBtn.Location = new System.Drawing.Point(465, 315);
            this.Clear_SearchBtn.Name = "Clear_SearchBtn";
            this.Clear_SearchBtn.Size = new System.Drawing.Size(125, 38);
            this.Clear_SearchBtn.TabIndex = 40;
            this.Clear_SearchBtn.Text = "Clear ";
            this.Clear_SearchBtn.UseVisualStyleBackColor = true;
            this.Clear_SearchBtn.Click += new System.EventHandler(this.Clear_SearchBtn_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 360);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(609, 28);
            this.statusStrip1.TabIndex = 41;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StripStatusLabel
            // 
            this.StripStatusLabel.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StripStatusLabel.Name = "StripStatusLabel";
            this.StripStatusLabel.Size = new System.Drawing.Size(50, 23);
            this.StripStatusLabel.Text = "status";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 388);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.Clear_SearchBtn);
            this.Controls.Add(this.Search_btn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Range);
            this.Controls.Add(this.ViewResultOfSearch_listBox);
            this.Controls.Add(this.Name_textBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Surname_txtbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Profession_comboBox);
            this.Controls.Add(this.Course_comboBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Range.ResumeLayout(false);
            this.Range.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox Profession_comboBox;
        private System.Windows.Forms.ComboBox Course_comboBox;
        private System.Windows.Forms.TextBox Name_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Surname_txtbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox ViewResultOfSearch_listBox;
        private System.Windows.Forms.TextBox BeforeAverage_txtbox;
        private System.Windows.Forms.TextBox AfterAverage_txtbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox Range;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Search_btn;
        private System.Windows.Forms.Button Clear_SearchBtn;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StripStatusLabel;
    }
}