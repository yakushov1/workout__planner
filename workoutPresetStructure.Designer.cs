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
            this.presetStructureDataSet = new workout_planner.PresetStructureDataSet();
            this.presetStructBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.presetStructTableAdapter = new workout_planner.PresetStructureDataSetTableAdapters.presetStructTableAdapter();
            this.exerciseDataSet = new workout_planner.ExerciseDataSet();
            this.exerciseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.exerciseTableAdapter = new workout_planner.ExerciseDataSetTableAdapters.exerciseTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workoutPresetIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exerciseIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordernumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exerciseColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.presetStructureDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.presetStructBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exerciseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exerciseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.workoutPresetIdDataGridViewTextBoxColumn,
            this.exerciseIdDataGridViewTextBoxColumn,
            this.ordernumberDataGridViewTextBoxColumn,
            this.exerciseColumn});
            this.dataGridView1.DataSource = this.presetStructBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(133, 95);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(586, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // presetStructureDataSet
            // 
            this.presetStructureDataSet.DataSetName = "PresetStructureDataSet";
            this.presetStructureDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // presetStructBindingSource
            // 
            this.presetStructBindingSource.DataMember = "presetStruct";
            this.presetStructBindingSource.DataSource = this.presetStructureDataSet;
            // 
            // presetStructTableAdapter
            // 
            this.presetStructTableAdapter.ClearBeforeFill = true;
            // 
            // exerciseDataSet
            // 
            this.exerciseDataSet.DataSetName = "ExerciseDataSet";
            this.exerciseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // exerciseBindingSource
            // 
            this.exerciseBindingSource.DataMember = "exercise";
            this.exerciseBindingSource.DataSource = this.exerciseDataSet;
            // 
            // exerciseTableAdapter
            // 
            this.exerciseTableAdapter.ClearBeforeFill = true;
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
            // workoutPresetIdDataGridViewTextBoxColumn
            // 
            this.workoutPresetIdDataGridViewTextBoxColumn.DataPropertyName = "workoutPresetId";
            this.workoutPresetIdDataGridViewTextBoxColumn.HeaderText = "workoutPresetId";
            this.workoutPresetIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.workoutPresetIdDataGridViewTextBoxColumn.Name = "workoutPresetIdDataGridViewTextBoxColumn";
            this.workoutPresetIdDataGridViewTextBoxColumn.Visible = false;
            this.workoutPresetIdDataGridViewTextBoxColumn.Width = 125;
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
            // ordernumberDataGridViewTextBoxColumn
            // 
            this.ordernumberDataGridViewTextBoxColumn.DataPropertyName = "order_number";
            this.ordernumberDataGridViewTextBoxColumn.HeaderText = "Порядок";
            this.ordernumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ordernumberDataGridViewTextBoxColumn.Name = "ordernumberDataGridViewTextBoxColumn";
            this.ordernumberDataGridViewTextBoxColumn.Width = 125;
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
            this.Controls.Add(this.dataGridView1);
            this.Name = "workoutPresetStructure";
            this.Text = "workoutPresetStructure";
            this.Load += new System.EventHandler(this.workoutPresetStructure_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.presetStructureDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.presetStructBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exerciseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exerciseBindingSource)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workoutPresetIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn exerciseIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordernumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn exerciseColumn;
    }
}