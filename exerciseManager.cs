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
    public partial class exerciseManager : Form
    {
        public exerciseManager()
        {
            InitializeComponent();
        }

        private void exerciseManager_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "exercise._exercise". При необходимости она может быть перемещена или удалена.
            this.exerciseTableAdapter.Fill(this.exercise._exercise);

        }

        private void backToConstructor_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.exerciseBindingSource.EndEdit();
                this.exerciseTableAdapter.Update(this.exercise._exercise);

                MessageBox.Show("Изменения сохранены успешно!", "Успех",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении: {ex.Message}", "Ошибка",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
