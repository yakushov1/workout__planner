namespace workout_planner
{
    partial class workoutPresetSetting
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.workoutPresetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workoutDataSet = new workout_planner.workoutDataSet();
            this.workoutPresetTableAdapter = new workout_planner.workoutDataSetTableAdapters.workoutPresetTableAdapter();
            this.dataGridPreset = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.backToConstructor = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Setting = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.workoutPresetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workoutDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPreset)).BeginInit();
            this.SuspendLayout();
            // 
            // workoutPresetBindingSource
            // 
            this.workoutPresetBindingSource.DataMember = "workoutPreset";
            this.workoutPresetBindingSource.DataSource = this.workoutDataSet;
            // 
            // workoutDataSet
            // 
            this.workoutDataSet.DataSetName = "workoutDataSet";
            this.workoutDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // workoutPresetTableAdapter
            // 
            this.workoutPresetTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridPreset
            // 
            this.dataGridPreset.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridPreset.AutoGenerateColumns = false;
            this.dataGridPreset.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridPreset.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridPreset.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridPreset.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridPreset.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPreset.ColumnHeadersVisible = false;
            this.dataGridPreset.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titleDataGridViewTextBoxColumn,
            this.Setting});
            this.dataGridPreset.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.dataGridPreset.DataSource = this.workoutPresetBindingSource;
            this.dataGridPreset.EnableHeadersVisualStyles = false;
            this.dataGridPreset.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridPreset.Location = new System.Drawing.Point(110, 76);
            this.dataGridPreset.Name = "dataGridPreset";
            this.dataGridPreset.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            this.dataGridPreset.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridPreset.RowTemplate.Height = 24;
            this.dataGridPreset.Size = new System.Drawing.Size(487, 217);
            this.dataGridPreset.TabIndex = 0;
            this.dataGridPreset.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridPreset_CellContentClick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(110, 299);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(332, 51);
            this.button1.TabIndex = 1;
            this.button1.Text = "Сохранить изменения";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(106, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(454, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Двойной клик по пустой ячейке добавляет новый шаблон";
            // 
            // backToConstructor
            // 
            this.backToConstructor.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backToConstructor.Location = new System.Drawing.Point(110, 367);
            this.backToConstructor.Name = "backToConstructor";
            this.backToConstructor.Size = new System.Drawing.Size(332, 51);
            this.backToConstructor.TabIndex = 3;
            this.backToConstructor.Text = "Назад к конструктору";
            this.backToConstructor.UseVisualStyleBackColor = true;
            this.backToConstructor.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(106, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(499, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Для удаления шаблона выделите всю строку и нажмите Delete";
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "";
            this.titleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.Width = 125;
            // 
            // Setting
            // 
            this.Setting.HeaderText = "⚙️Настройка";
            this.Setting.MinimumWidth = 6;
            this.Setting.Name = "Setting";
            this.Setting.Text = "⚙";
            this.Setting.UseColumnTextForButtonValue = true;
            this.Setting.Width = 125;
            // 
            // workoutPresetSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.backToConstructor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridPreset);
            this.Name = "workoutPresetSetting";
            this.Text = "Настройка шаблонов тренировок";
            this.Load += new System.EventHandler(this.workoutPresetSetting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.workoutPresetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workoutDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPreset)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private workoutDataSet workoutDataSet;
        private System.Windows.Forms.BindingSource workoutPresetBindingSource;
        private workoutDataSetTableAdapters.workoutPresetTableAdapter workoutPresetTableAdapter;
        private System.Windows.Forms.DataGridView dataGridPreset;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backToConstructor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Setting;
    }
}