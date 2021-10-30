namespace Rezultat_sorevnovanii_yuzhakov_nikita
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
            this.buttonOtchet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxFio = new System.Windows.Forms.TextBox();
            this.textBoxMaxRez = new System.Windows.Forms.TextBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.textBoxTxt = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.buttonFileText = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonOtchet
            // 
            this.buttonOtchet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOtchet.Location = new System.Drawing.Point(154, 92);
            this.buttonOtchet.Name = "buttonOtchet";
            this.buttonOtchet.Size = new System.Drawing.Size(89, 76);
            this.buttonOtchet.TabIndex = 0;
            this.buttonOtchet.Text = "Отчет";
            this.buttonOtchet.UseVisualStyleBackColor = true;
            this.buttonOtchet.Click += new System.EventHandler(this.buttonOtchet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Фио спортсмена";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Макс. доп. результат";
            // 
            // textBoxFio
            // 
            this.textBoxFio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFio.Location = new System.Drawing.Point(154, 6);
            this.textBoxFio.Name = "textBoxFio";
            this.textBoxFio.Size = new System.Drawing.Size(193, 26);
            this.textBoxFio.TabIndex = 3;
            this.textBoxFio.TextChanged += new System.EventHandler(this.textBoxFio_TextChanged);
            // 
            // textBoxMaxRez
            // 
            this.textBoxMaxRez.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxMaxRez.Location = new System.Drawing.Point(189, 54);
            this.textBoxMaxRez.Name = "textBoxMaxRez";
            this.textBoxMaxRez.Size = new System.Drawing.Size(158, 26);
            this.textBoxMaxRez.TabIndex = 4;
            this.textBoxMaxRez.TextChanged += new System.EventHandler(this.textBoxMaxRez_TextChanged);
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClear.Location = new System.Drawing.Point(249, 92);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(98, 76);
            this.buttonClear.TabIndex = 5;
            this.buttonClear.Text = "Очистить";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // textBoxTxt
            // 
            this.textBoxTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTxt.Location = new System.Drawing.Point(16, 174);
            this.textBoxTxt.Multiline = true;
            this.textBoxTxt.Name = "textBoxTxt";
            this.textBoxTxt.Size = new System.Drawing.Size(331, 187);
            this.textBoxTxt.TabIndex = 6;
            this.textBoxTxt.TextChanged += new System.EventHandler(this.textBoxTxt_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // buttonFileText
            // 
            this.buttonFileText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFileText.Location = new System.Drawing.Point(16, 92);
            this.buttonFileText.Name = "buttonFileText";
            this.buttonFileText.Size = new System.Drawing.Size(132, 76);
            this.buttonFileText.TabIndex = 7;
            this.buttonFileText.Text = "Загрузить данные из файла";
            this.buttonFileText.UseVisualStyleBackColor = true;
            this.buttonFileText.Click += new System.EventHandler(this.buttonFileText_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 380);
            this.Controls.Add(this.buttonFileText);
            this.Controls.Add(this.textBoxTxt);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.textBoxMaxRez);
            this.Controls.Add(this.textBoxFio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonOtchet);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOtchet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxFio;
        private System.Windows.Forms.TextBox textBoxMaxRez;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.TextBox textBoxTxt;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button buttonFileText;
    }
}

