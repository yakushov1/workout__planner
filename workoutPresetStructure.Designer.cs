namespace workout_planner
{
    partial class workoutPresetStructure
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.exerciseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.exerciseDataSet = new workout_planner.ExerciseDataSet();
            this.presetStructBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.presetStructureDataSet = new workout_planner.PresetStructureDataSet();
            this.presetStructTableAdapter = new workout_planner.PresetStructureDataSetTableAdapters.presetStructTableAdapter();
            this.exerciseTableAdapter = new workout_planner.ExerciseDataSetTableAdapters.exerciseTableAdapter();
            this.backToConstructor = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workoutPresetId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exerciseIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordernumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exerciseColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exerciseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exerciseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.presetStructBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.presetStructureDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.workoutPresetId,
            this.exerciseIdDataGridViewTextBoxColumn,
            this.ordernumber,
            this.exerciseColumn});
            this.dataGridView1.DataSource = this.presetStructBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(133, 95);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(586, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView1_DefaultValuesNeeded);
            // 
            // exerciseBindingSource
            // 
            this.exerciseBindingSource.DataMember = "exercise";
            this.exerciseBindingSource.DataSource = this.exerciseDataSet;
            // 
            // exerciseDataSet
            // 
            this.exerciseDataSet.DataSetName = "ExerciseDataSet";
            this.exerciseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // presetStructBindingSource
            // 
            this.presetStructBindingSource.DataMember = "presetStruct";
            this.presetStructBindingSource.DataSource = this.presetStructureDataSet;
            // 
            // presetStructureDataSet
            // 
            this.presetStructureDataSet.DataSetName = "PresetStructureDataSet";
            this.presetStructureDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // presetStructTableAdapter
            // 
            this.presetStructTableAdapter.ClearBeforeFill = true;
            // 
            // exerciseTableAdapter
            // 
            this.exerciseTableAdapter.ClearBeforeFill = true;
            // 
            // backToConstructor
            // 
            this.backToConstructor.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backToConstructor.Location = new System.Drawing.Point(133, 353);
            this.backToConstructor.Name = "backToConstructor";
            this.backToConstructor.Size = new System.Drawing.Size(332, 51);
            this.backToConstructor.TabIndex = 5;
            this.backToConstructor.Text = "Назад к конструктору";
            this.backToConstructor.UseVisualStyleBackColor = true;
            this.backToConstructor.Click += new System.EventHandler(this.backToConstructor_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(133, 285);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(332, 51);
            this.button1.TabIndex = 4;
            this.button1.Text = "Сохранить изменения";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // workoutPresetId
            // 
            this.workoutPresetId.DataPropertyName = "workoutPresetId";
            this.workoutPresetId.HeaderText = "workoutPresetId";
            this.workoutPresetId.MinimumWidth = 6;
            this.workoutPresetId.Name = "workoutPresetId";
            this.workoutPresetId.Visible = false;
            this.workoutPresetId.Width = 125;
            // 
            // exerciseIdDataGridViewTextBoxColumn
            // 
            this.exerciseIdDataGridViewTextBoxColumn.DataPropertyName = "exerciseId";
            this.exerciseIdDataGridViewTextBoxColumn.HeaderText = "exerciseId";
            this.exerciseIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.exerciseIdDataGridViewTextBoxColumn.Name = "exerciseIdDataGridViewTextBoxColumn";
            this.exerciseIdDataGridViewTextBoxColumn.Visible = false;
            this.exerciseIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // ordernumber
            // 
            this.ordernumber.DataPropertyName = "order_number";
            this.ordernumber.HeaderText = "Порядок";
            this.ordernumber.MinimumWidth = 6;
            this.ordernumber.Name = "ordernumber";
            this.ordernumber.Width = 125;
            // 
            // exerciseColumn
            // 
            this.exerciseColumn.DataPropertyName = "exerciseId";
            this.exerciseColumn.DataSource = this.exerciseBindingSource;
            this.exerciseColumn.DisplayMember = "title";
            this.exerciseColumn.HeaderText = "Упражнение";
            this.exerciseColumn.MinimumWidth = 6;
            this.exerciseColumn.Name = "exerciseColumn";
            this.exerciseColumn.ValueMember = "id";
            this.exerciseColumn.Width = 125;
            // 
            // workoutPresetStructure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backToConstructor);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "workoutPresetStructure";
            this.Text = "workoutPresetStructure";
            this.Load += new System.EventHandler(this.workoutPresetStructure_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exerciseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exerciseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.presetStructBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.presetStructureDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private PresetStructureDataSet presetStructureDataSet;
        private System.Windows.Forms.BindingSource presetStructBindingSource;
        private PresetStructureDataSetTableAdapters.presetStructTableAdapter presetStructTableAdapter;
        private ExerciseDataSet exerciseDataSet;
        private System.Windows.Forms.BindingSource exerciseBindingSource;
        private ExerciseDataSetTableAdapters.exerciseTableAdapter exerciseTableAdapter;
        private System.Windows.Forms.Button backToConstructor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workoutPresetId;
        private System.Windows.Forms.DataGridViewTextBoxColumn exerciseIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordernumber;
        private System.Windows.Forms.DataGridViewComboBoxColumn exerciseColumn;
    }
}