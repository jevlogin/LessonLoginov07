namespace GuessTheNumber
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMenuItem1NewGame = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMenuItem1Close = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(515, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnMenuItem1
            // 
            this.btnMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMenuItem1NewGame,
            this.btnMenuItem1Close});
            this.btnMenuItem1.Name = "btnMenuItem1";
            this.btnMenuItem1.Size = new System.Drawing.Size(48, 20);
            this.btnMenuItem1.Text = "Файл";
            // 
            // btnMenuItem1NewGame
            // 
            this.btnMenuItem1NewGame.Name = "btnMenuItem1NewGame";
            this.btnMenuItem1NewGame.Size = new System.Drawing.Size(180, 22);
            this.btnMenuItem1NewGame.Text = "Новая игра";
            this.btnMenuItem1NewGame.Click += new System.EventHandler(this.btnMenuItem1NewGame_Click);
            // 
            // btnMenuItem1Close
            // 
            this.btnMenuItem1Close.Name = "btnMenuItem1Close";
            this.btnMenuItem1Close.Size = new System.Drawing.Size(180, 22);
            this.btnMenuItem1Close.Text = "Выход";
            this.btnMenuItem1Close.Click += new System.EventHandler(this.btnMenuItem1Close_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 357);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Угадай число";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem btnMenuItem1NewGame;
        private System.Windows.Forms.ToolStripMenuItem btnMenuItem1Close;
    }
}

