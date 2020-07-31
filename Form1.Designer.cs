namespace BeginerLearnProjrct {
    partial class FormSort {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent() {
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.buttonSort = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.radioButtonBubble = new System.Windows.Forms.RadioButton();
            this.radioButtonInsert = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Location = new System.Drawing.Point(477, 323);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(187, 39);
            this.buttonGenerate.TabIndex = 1;
            this.buttonGenerate.Text = "Generate Massive";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // buttonSort
            // 
            this.buttonSort.Location = new System.Drawing.Point(94, 323);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(173, 39);
            this.buttonSort.TabIndex = 2;
            this.buttonSort.Text = "Sort";
            this.buttonSort.UseVisualStyleBackColor = true;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(343, 27);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(445, 268);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // radioButtonBubble
            // 
            this.radioButtonBubble.AutoSize = true;
            this.radioButtonBubble.Checked = true;
            this.radioButtonBubble.Location = new System.Drawing.Point(49, 55);
            this.radioButtonBubble.Name = "radioButtonBubble";
            this.radioButtonBubble.Size = new System.Drawing.Size(78, 17);
            this.radioButtonBubble.TabIndex = 4;
            this.radioButtonBubble.TabStop = true;
            this.radioButtonBubble.Text = "Bubble sort";
            this.radioButtonBubble.UseVisualStyleBackColor = true;
            this.radioButtonBubble.CheckedChanged += new System.EventHandler(this.radioButtonBubble_CheckedChanged);
            // 
            // radioButtonInsert
            // 
            this.radioButtonInsert.AutoSize = true;
            this.radioButtonInsert.Location = new System.Drawing.Point(49, 89);
            this.radioButtonInsert.Name = "radioButtonInsert";
            this.radioButtonInsert.Size = new System.Drawing.Size(73, 17);
            this.radioButtonInsert.TabIndex = 5;
            this.radioButtonInsert.TabStop = true;
            this.radioButtonInsert.Text = "Insert Sort";
            this.radioButtonInsert.UseVisualStyleBackColor = true;
            this.radioButtonInsert.CheckedChanged += new System.EventHandler(this.radioButtonInsert_CheckedChanged);
            // 
            // FormSort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.radioButtonInsert);
            this.Controls.Add(this.radioButtonBubble);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.buttonSort);
            this.Controls.Add(this.buttonGenerate);
            this.Name = "FormSort";
            this.Text = "Sort";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.Button buttonSort;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RadioButton radioButtonBubble;
        private System.Windows.Forms.RadioButton radioButtonInsert;
    }
}

