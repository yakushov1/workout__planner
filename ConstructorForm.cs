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
    public partial class ConstructorForm : Form
    {
        public ConstructorForm()
        {
            InitializeComponent();
        }

        private void backToMain_Click(object sender, EventArgs e)
        {
            
            this.Close();
            
        }

        private void settingWorkoutPreset_Click(object sender, EventArgs e)
        {
            workoutPresetSetting workoutPresetSetting = new workoutPresetSetting();
            workoutPresetSetting.ShowDialog();
        }

        private void exerciseManager_Click(object sender, EventArgs e)
        {
            exerciseManager exerciseManager = new exerciseManager();
            exerciseManager.ShowDialog();
        }
    }
}
