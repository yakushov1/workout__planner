using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace workout_planner
{
    public partial class workoutPresetStructure : Form
    {
        private int _presetId;

        // Конструктор по умолчанию
        public workoutPresetStructure()
        {
            InitializeComponent();
        }

        // ДОБАВЬТЕ ЭТОТ КОНСТРУКТОР - он принимает 2 параметра
        public workoutPresetStructure(int presetId, string presetName) : this()
        {
            _presetId = presetId;
            this.Text = $"Структура пресета: {presetName}";
        }

        private void workoutPresetStructure_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: данная строка кода позволяет загрузить данные в таблицу "exerciseDataSet.exercise". При необходимости она может быть перемещена или удалена.
                this.exerciseTableAdapter.Fill(this.exerciseDataSet.exercise);
                // TODO: данная строка кода позволяет загрузить данные в таблицу "presetStructureDataSet.presetStruct". При необходимости она может быть перемещена или удалена.
                this.presetStructTableAdapter.Fill(this.presetStructureDataSet.presetStruct);

                if (presetStructBindingSource != null)
                {
                    presetStructBindingSource.Filter = $"workoutPresetId = {_presetId}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки: {ex.Message}");
            }
        }

        private void dataGridView1_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            // Заполняем значения по умолчанию при создании новой строки
            e.Row.Cells["workoutPresetId"].Value = _presetId;
            e.Row.Cells["ordernumber"].Value = dataGridView1.Rows.Count;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.presetStructBindingSource.EndEdit();
                this.presetStructTableAdapter.Update(this.presetStructureDataSet.presetStruct);

                MessageBox.Show("Изменения сохранены успешно!", "Успех",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении: {ex.Message}", "Ошибка",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void backToConstructor_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
