using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutocadExtension
{
    public partial class Lab : Form
    {
        private MyCommandClass commandClass;
        public bool IncludePoliLines { get; set; }
        public bool IncludeSplines { get; set; }
        public bool IncludePoints { get; set; }
        public Lab()
        {
            //commandClass = new MyCommandClass();
            InitializeComponent();
        }

        private void MyForm_Load(object sender, EventArgs e)
        {

        }

        private void PathTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void PointsTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SplinesTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PolilinesTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PointsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            IncludePoints = PointsCheckBox.Checked;
        }

        private void PolilinesCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            IncludePoliLines = PointsCheckBox.Checked;
        }

        private void SplinesCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            IncludeSplines = SplinesCheckBox.Checked;
        }
        private void Cancel_Click(object sender, EventArgs e)
        {

        }
        private void OK_Click(object sender, EventArgs e)
        {

        }
        private void FoundGroupBox_Enter(object sender, EventArgs e)
        {

        }
        private void PointsLabel_Click(object sender, EventArgs e)
        {

        }
        private void PoliLinesLabel_Click(object sender, EventArgs e)
        {

        }

        private void EnterPathLabel_Click(object sender, EventArgs e)
        {

        }
        private void Splines_Label(object sender, EventArgs e)
        {

        }
        private void SavePrimitivesGroupBox_Enter(object sender, EventArgs e)
        {

        }
    }
}


