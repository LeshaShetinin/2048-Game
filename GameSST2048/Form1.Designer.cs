namespace GameSST2048
{
    partial class MainForm
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
            this.gameControl = new GameProject.GameControl();
            this.SuspendLayout();
            // 
            // gameControl
            // 
            this.gameControl.Location = new System.Drawing.Point(12, 12);
            this.gameControl.Name = "gameControl";
            this.gameControl.Size = new System.Drawing.Size(532, 369);
            this.gameControl.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 420);
            this.Controls.Add(this.gameControl);
            this.Name = "MainForm";
            this.Text = "GameSST2048";
            this.ResumeLayout(false);

        }

        #endregion

        private GameProject.GameControl gameControl;
    }
}

