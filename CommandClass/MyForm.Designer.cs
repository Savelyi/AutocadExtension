namespace AutocadExtension
{
    partial class LabForm
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
            this.OK = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.PointsCheckBox = new System.Windows.Forms.CheckBox();
            this.PolylinesCheckBox = new System.Windows.Forms.CheckBox();
            this.SplinesCheckBox = new System.Windows.Forms.CheckBox();
            this.PathLabel = new System.Windows.Forms.Label();
            this.PathTextBox = new System.Windows.Forms.TextBox();
            this.SavePrimitivesGroupBox = new System.Windows.Forms.GroupBox();
            this.Found = new System.Windows.Forms.GroupBox();
            this.PoliLinesLabel = new System.Windows.Forms.Label();
            this.SplinesLabel = new System.Windows.Forms.Label();
            this.PointsLabel = new System.Windows.Forms.Label();
            this.PolylinesTextBox = new System.Windows.Forms.TextBox();
            this.SplinesTextBox = new System.Windows.Forms.TextBox();
            this.PointsTextBox = new System.Windows.Forms.TextBox();
            this.SavePrimitivesGroupBox.SuspendLayout();
            this.Found.SuspendLayout();
            this.SuspendLayout();
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(162, 231);
            this.OK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(112, 35);
            this.OK.TabIndex = 0;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(306, 231);
            this.Cancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(112, 35);
            this.Cancel.TabIndex = 1;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // PointsCheckBox
            // 
            this.PointsCheckBox.AutoSize = true;
            this.PointsCheckBox.Location = new System.Drawing.Point(9, 29);
            this.PointsCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PointsCheckBox.Name = "PointsCheckBox";
            this.PointsCheckBox.Size = new System.Drawing.Size(79, 24);
            this.PointsCheckBox.TabIndex = 2;
            this.PointsCheckBox.Text = "Точки";
            this.PointsCheckBox.UseVisualStyleBackColor = true;
            this.PointsCheckBox.CheckedChanged += new System.EventHandler(this.PointsCheckBox_CheckedChanged);
            // 
            // PolylinesCheckBox
            // 
            this.PolylinesCheckBox.AutoSize = true;
            this.PolylinesCheckBox.Location = new System.Drawing.Point(9, 65);
            this.PolylinesCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PolylinesCheckBox.Name = "PolylinesCheckBox";
            this.PolylinesCheckBox.Size = new System.Drawing.Size(121, 24);
            this.PolylinesCheckBox.TabIndex = 3;
            this.PolylinesCheckBox.Text = "Полилинии";
            this.PolylinesCheckBox.UseVisualStyleBackColor = true;
            this.PolylinesCheckBox.CheckedChanged += new System.EventHandler(this.PolylinesCheckBox_CheckedChanged);
            // 
            // SplinesCheckBox
            // 
            this.SplinesCheckBox.AutoSize = true;
            this.SplinesCheckBox.BackColor = System.Drawing.SystemColors.Control;
            this.SplinesCheckBox.Location = new System.Drawing.Point(9, 100);
            this.SplinesCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SplinesCheckBox.Name = "SplinesCheckBox";
            this.SplinesCheckBox.Size = new System.Drawing.Size(103, 24);
            this.SplinesCheckBox.TabIndex = 4;
            this.SplinesCheckBox.Text = "Сплайны";
            this.SplinesCheckBox.UseVisualStyleBackColor = false;
            this.SplinesCheckBox.CheckedChanged += new System.EventHandler(this.SplinesCheckBox_CheckedChanged);
            // 
            // PathLabel
            // 
            this.PathLabel.AutoSize = true;
            this.PathLabel.Location = new System.Drawing.Point(18, 28);
            this.PathLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PathLabel.Name = "PathLabel";
            this.PathLabel.Size = new System.Drawing.Size(273, 20);
            this.PathLabel.TabIndex = 5;
            this.PathLabel.Text = "Enter path and name of file with data:";
            // 
            // PathTextBox
            // 
            this.PathTextBox.Location = new System.Drawing.Point(306, 23);
            this.PathTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PathTextBox.Name = "PathTextBox";
            this.PathTextBox.Size = new System.Drawing.Size(260, 26);
            this.PathTextBox.TabIndex = 8;
            // 
            // SavePrimitivesGroupBox
            // 
            this.SavePrimitivesGroupBox.Controls.Add(this.PointsCheckBox);
            this.SavePrimitivesGroupBox.Controls.Add(this.PolylinesCheckBox);
            this.SavePrimitivesGroupBox.Controls.Add(this.SplinesCheckBox);
            this.SavePrimitivesGroupBox.Location = new System.Drawing.Point(32, 74);
            this.SavePrimitivesGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SavePrimitivesGroupBox.Name = "SavePrimitivesGroupBox";
            this.SavePrimitivesGroupBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SavePrimitivesGroupBox.Size = new System.Drawing.Size(243, 148);
            this.SavePrimitivesGroupBox.TabIndex = 9;
            this.SavePrimitivesGroupBox.TabStop = false;
            this.SavePrimitivesGroupBox.Text = "Сохранить примитивы";
            // 
            // Found
            // 
            this.Found.Controls.Add(this.PoliLinesLabel);
            this.Found.Controls.Add(this.SplinesLabel);
            this.Found.Controls.Add(this.PointsLabel);
            this.Found.Controls.Add(this.PolylinesTextBox);
            this.Found.Controls.Add(this.SplinesTextBox);
            this.Found.Controls.Add(this.PointsTextBox);
            this.Found.Location = new System.Drawing.Point(306, 74);
            this.Found.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Found.Name = "Found";
            this.Found.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Found.Size = new System.Drawing.Size(250, 148);
            this.Found.TabIndex = 5;
            this.Found.TabStop = false;
            this.Found.Text = "Найдено примитивов";
            // 
            // PoliLinesLabel
            // 
            this.PoliLinesLabel.AutoSize = true;
            this.PoliLinesLabel.Location = new System.Drawing.Point(10, 69);
            this.PoliLinesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PoliLinesLabel.Name = "PoliLinesLabel";
            this.PoliLinesLabel.Size = new System.Drawing.Size(95, 20);
            this.PoliLinesLabel.TabIndex = 5;
            this.PoliLinesLabel.Text = "Полилиний";
            // 
            // SplinesLabel
            // 
            this.SplinesLabel.AutoSize = true;
            this.SplinesLabel.Location = new System.Drawing.Point(10, 102);
            this.SplinesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SplinesLabel.Name = "SplinesLabel";
            this.SplinesLabel.Size = new System.Drawing.Size(88, 20);
            this.SplinesLabel.TabIndex = 4;
            this.SplinesLabel.Text = "Сплайнов:";
            // 
            // PointsLabel
            // 
            this.PointsLabel.AutoSize = true;
            this.PointsLabel.Location = new System.Drawing.Point(10, 34);
            this.PointsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PointsLabel.Name = "PointsLabel";
            this.PointsLabel.Size = new System.Drawing.Size(57, 20);
            this.PointsLabel.TabIndex = 3;
            this.PointsLabel.Text = "Точек:";
            // 
            // PolylinesTextBox
            // 
            this.PolylinesTextBox.Location = new System.Drawing.Point(188, 65);
            this.PolylinesTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PolylinesTextBox.Name = "PolylinesTextBox";
            this.PolylinesTextBox.ReadOnly = true;
            this.PolylinesTextBox.Size = new System.Drawing.Size(52, 26);
            this.PolylinesTextBox.TabIndex = 2;
            // 
            // SplinesTextBox
            // 
            this.SplinesTextBox.Location = new System.Drawing.Point(188, 97);
            this.SplinesTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SplinesTextBox.Name = "SplinesTextBox";
            this.SplinesTextBox.ReadOnly = true;
            this.SplinesTextBox.Size = new System.Drawing.Size(52, 26);
            this.SplinesTextBox.TabIndex = 1;
            // 
            // PointsTextBox
            // 
            this.PointsTextBox.Location = new System.Drawing.Point(188, 29);
            this.PointsTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PointsTextBox.Name = "PointsTextBox";
            this.PointsTextBox.ReadOnly = true;
            this.PointsTextBox.Size = new System.Drawing.Size(52, 26);
            this.PointsTextBox.TabIndex = 0;
            // 
            // LabForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 294);
            this.Controls.Add(this.Found);
            this.Controls.Add(this.SavePrimitivesGroupBox);
            this.Controls.Add(this.PathTextBox);
            this.Controls.Add(this.PathLabel);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.OK);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(590, 350);
            this.MinimumSize = new System.Drawing.Size(589, 308);
            this.Name = "LabForm";
            this.Text = "Lab";
            this.SavePrimitivesGroupBox.ResumeLayout(false);
            this.SavePrimitivesGroupBox.PerformLayout();
            this.Found.ResumeLayout(false);
            this.Found.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.CheckBox PointsCheckBox;
        private System.Windows.Forms.CheckBox PolylinesCheckBox;
        private System.Windows.Forms.CheckBox SplinesCheckBox;
        private System.Windows.Forms.Label PathLabel;
        private System.Windows.Forms.TextBox PathTextBox;
        private System.Windows.Forms.GroupBox SavePrimitivesGroupBox;
        private System.Windows.Forms.GroupBox Found;
        private System.Windows.Forms.Label PoliLinesLabel;
        private System.Windows.Forms.Label SplinesLabel;
        private System.Windows.Forms.Label PointsLabel;
        private System.Windows.Forms.TextBox PolylinesTextBox;
        private System.Windows.Forms.TextBox SplinesTextBox;
        private System.Windows.Forms.TextBox PointsTextBox;
    }
}