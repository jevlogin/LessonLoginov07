namespace WF_Udvoitel
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
            this.btnPlus1 = new System.Windows.Forms.Button();
            this.btnX2 = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblScore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPlus1
            // 
            this.btnPlus1.Location = new System.Drawing.Point(110, 44);
            this.btnPlus1.Name = "btnPlus1";
            this.btnPlus1.Size = new System.Drawing.Size(75, 23);
            this.btnPlus1.TabIndex = 0;
            this.btnPlus1.Text = "+1";
            this.btnPlus1.UseVisualStyleBackColor = true;
            // 
            // btnX2
            // 
            this.btnX2.Location = new System.Drawing.Point(110, 104);
            this.btnX2.Name = "btnX2";
            this.btnX2.Size = new System.Drawing.Size(75, 23);
            this.btnX2.TabIndex = 1;
            this.btnX2.Text = "x2";
            this.btnX2.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(110, 161);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Сброс";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblScore.Location = new System.Drawing.Point(31, 51);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(13, 13);
            this.lblScore.TabIndex = 3;
            this.lblScore.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 225);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnX2);
            this.Controls.Add(this.btnPlus1);
            this.Name = "Form1";
            this.Text = "Удвоитель";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPlus1;
        private System.Windows.Forms.Button btnX2;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblScore;
    }
}

