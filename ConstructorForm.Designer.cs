namespace workout_planner
{
    partial class ConstructorForm
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
            this.settingWorkoutPreset = new System.Windows.Forms.Button();
            this.exerciseManager = new System.Windows.Forms.Button();
            this.backToMain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // settingWorkoutPreset
            // 
            this.settingWorkoutPreset.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingWorkoutPreset.Location = new System.Drawing.Point(222, 89);
            this.settingWorkoutPreset.Name = "settingWorkoutPreset";
            this.settingWorkoutPreset.Size = new System.Drawing.Size(368, 52);
            this.settingWorkoutPreset.TabIndex = 0;
            this.settingWorkoutPreset.Text = "Шаблоны тренировок";
            this.settingWorkoutPreset.UseVisualStyleBackColor = true;
            this.settingWorkoutPreset.Click += new System.EventHandler(this.settingWorkoutPreset_Click);
            // 
            // exerciseManager
            // 
            this.exerciseManager.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exerciseManager.Location = new System.Drawing.Point(222, 156);
            this.exerciseManager.Name = "exerciseManager";
            this.exerciseManager.Size = new System.Drawing.Size(368, 52);
            this.exerciseManager.TabIndex = 1;
            this.exerciseManager.Text = "Управление приложениями";
            this.exerciseManager.UseVisualStyleBackColor = true;
            // 
            // backToMain
            // 
            this.backToMain.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backToMain.Location = new System.Drawing.Point(222, 223);
            this.backToMain.Name = "backToMain";
            this.backToMain.Size = new System.Drawing.Size(368, 52);
            this.backToMain.TabIndex = 2;
            this.backToMain.Text = "На главную";
            this.backToMain.UseVisualStyleBackColor = true;
            this.backToMain.Click += new System.EventHandler(this.backToMain_Click);
            // 
            // ConstructorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backToMain);
            this.Controls.Add(this.exerciseManager);
            this.Controls.Add(this.settingWorkoutPreset);
            this.Name = "ConstructorForm";
            this.Text = "Конструктор";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button settingWorkoutPreset;
        private System.Windows.Forms.Button exerciseManager;
        private System.Windows.Forms.Button backToMain;
    }
}