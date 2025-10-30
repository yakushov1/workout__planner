namespace workout_planner
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
            this.btnCalendar = new System.Windows.Forms.Button();
            this.btnConstructor = new System.Windows.Forms.Button();
            this.btnStatistics = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCalendar
            // 
            this.btnCalendar.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalendar.Location = new System.Drawing.Point(222, 89);
            this.btnCalendar.Name = "btnCalendar";
            this.btnCalendar.Size = new System.Drawing.Size(368, 52);
            this.btnCalendar.TabIndex = 0;
            this.btnCalendar.Text = "📅 Календарь";
            this.btnCalendar.UseVisualStyleBackColor = true;
            this.btnCalendar.Click += new System.EventHandler(this.btnCalendar_Click);
            // 
            // btnConstructor
            // 
            this.btnConstructor.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConstructor.Location = new System.Drawing.Point(222, 164);
            this.btnConstructor.Name = "btnConstructor";
            this.btnConstructor.Size = new System.Drawing.Size(368, 52);
            this.btnConstructor.TabIndex = 1;
            this.btnConstructor.Text = "⚙️ Конструктор";
            this.btnConstructor.UseVisualStyleBackColor = true;
            this.btnConstructor.Click += new System.EventHandler(this.btnConstructor_Click);
            // 
            // btnStatistics
            // 
            this.btnStatistics.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatistics.Location = new System.Drawing.Point(222, 240);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Size = new System.Drawing.Size(368, 52);
            this.btnStatistics.TabIndex = 2;
            this.btnStatistics.Text = "📊 Статистика";
            this.btnStatistics.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnStatistics);
            this.Controls.Add(this.btnConstructor);
            this.Controls.Add(this.btnCalendar);
            this.Name = "Form1";
            this.Text = "Добро пожаловать в планировщик";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCalendar;
        private System.Windows.Forms.Button btnConstructor;
        private System.Windows.Forms.Button btnStatistics;
    }
}

