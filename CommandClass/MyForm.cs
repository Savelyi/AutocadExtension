using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace AutocadExtension
{
    public partial class LabForm : Form
    {
        public bool IncludePolyLines { get; set; }
        public bool IncludeSplines { get; set; }
        public bool IncludePoints { get; set; }
        public LabForm()
        {
            InitializeComponent();
        }
        private void PointsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            IncludePoints = PointsCheckBox.Checked;
        }

        private void PolylinesCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            IncludePolyLines = PolylinesCheckBox.Checked;
        }

        private void SplinesCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            IncludeSplines = SplinesCheckBox.Checked;
        }
        private void Cancel_Click(object sender, EventArgs e)
        {
            PointsTextBox.Clear();
            PolylinesTextBox.Clear();
            SplinesTextBox.Clear();
            PointsCheckBox.Checked = false;
            PointsCheckBox.Checked = false;
            PointsCheckBox.Checked = false;
            this.Close();
        }
        private void OK_Click(object sender, EventArgs e)
        {
            FindAndSaveData();
        }


        private void FindAndSaveData()
        {
            GeneralInfoDTO generalInfo = MyCommandClassHelpers.GetInfo();
            string path = PathTextBox.Text;
            FileStream stream;
            try
            {
                stream = new FileStream(path, FileMode.Create, FileAccess.Write);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            PointsTextBox.Text = generalInfo.Points.Count.ToString();
            SplinesTextBox.Text = generalInfo.Splines.Count.ToString();
            PolylinesTextBox.Text = generalInfo.PolyLines.Count.ToString();
            using (StreamWriter streamWriter = new StreamWriter(stream))
            {
                if (IncludePoints)
                {
                    foreach (var item in generalInfo.Points)
                    {
                        streamWriter.WriteLine(item);
                    }
                }
                if (IncludePolyLines)
                {
                    foreach (var item in generalInfo.PolyLines)
                    {
                        streamWriter.WriteLine(item);
                    }
                }
                if (IncludeSplines)
                {
                    foreach (var item in generalInfo.Splines)
                    {
                        streamWriter.WriteLine(item);
                    }
                }
            }
            stream.Close();
            MessageBox.Show("Data found and saved");

        }

        
    }
}


