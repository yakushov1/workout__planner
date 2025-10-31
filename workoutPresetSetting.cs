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
    public partial class workoutPresetSetting : Form
    {
        public workoutPresetSetting()
        {
            InitializeComponent();
        }

        private void workoutPresetSetting_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'workoutDataSet.workoutPreset' table.
            this.workoutPresetTableAdapter.Fill(this.workoutDataSet.workoutPreset);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.workoutPresetBindingSource.EndEdit();
                this.workoutPresetTableAdapter.Update(this.workoutDataSet.workoutPreset);

                MessageBox.Show("Изменения сохранены успешно!", "Успех",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении: {ex.Message}", "Ошибка",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridPreset_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // ПРОВЕРЯЕМ что кликнули именно по колонке с кнопкой "Настроить"
            if (e.RowIndex >= 0 && dataGridPreset.Columns[e.ColumnIndex].Name == "configureColumn")
            {
                // Получаем ID и название пресета из текущей строки
                int presetId = (int)dataGridPreset.Rows[e.RowIndex].Cells["id"].Value;
                string presetName = dataGridPreset.Rows[e.RowIndex].Cells["title"].Value.ToString();

                // Открываем форму настройки структуры пресета
                workoutPresetStructure configForm = new workoutPresetStructure(presetId, presetName);
                configForm.ShowDialog();
            }
        }
    }
}
