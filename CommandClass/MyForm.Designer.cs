namespace AutocadExtension
{
    partial class Lab
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
            this.Polilines = new System.Windows.Forms.CheckBox();
            this.SplinesCheckBox = new System.Windows.Forms.CheckBox();
            this.PathLabel = new System.Windows.Forms.Label();
            this.PathTextBox = new System.Windows.Forms.TextBox();
            this.SavePrimitivesGroupBox = new System.Windows.Forms.GroupBox();
            this.Found = new System.Windows.Forms.GroupBox();
            this.PoliLinesLabel = new System.Windows.Forms.Label();
            this.SplinesLabel = new System.Windows.Forms.Label();
            this.PointsLabel = new System.Windows.Forms.Label();
            this.PolilinesTextBox = new System.Windows.Forms.TextBox();
            this.SplinesTextBox = new System.Windows.Forms.TextBox();
            this.PointsTextBox = new System.Windows.Forms.TextBox();
            this.SavePrimitivesGroupBox.SuspendLayout();
            this.Found.SuspendLayout();
            this.SuspendLayout();
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(108, 150);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 0;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(204, 150);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 1;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // PointsCheckBox
            // 
            this.PointsCheckBox.AutoSize = true;
            this.PointsCheckBox.Location = new System.Drawing.Point(6, 19);
            this.PointsCheckBox.Name = "PointsCheckBox";
            this.PointsCheckBox.Size = new System.Drawing.Size(56, 17);
            this.PointsCheckBox.TabIndex = 2;
            this.PointsCheckBox.Text = "Точки";
            this.PointsCheckBox.UseVisualStyleBackColor = true;
            this.PointsCheckBox.CheckedChanged += new System.EventHandler(this.PointsCheckBox_CheckedChanged);
            // 
            // Polilines
            // 
            this.Polilines.AutoSize = true;
            this.Polilines.Location = new System.Drawing.Point(6, 42);
            this.Polilines.Name = "Polilines";
            this.Polilines.Size = new System.Drawing.Size(82, 17);
            this.Polilines.TabIndex = 3;
            this.Polilines.Text = "Полилинии";
            this.Polilines.UseVisualStyleBackColor = true;
            this.Polilines.CheckedChanged += new System.EventHandler(this.PolilinesCheckBox_CheckedChanged);
            // 
            // SplinesCheckBox
            // 
            this.SplinesCheckBox.AutoSize = true;
            this.SplinesCheckBox.BackColor = System.Drawing.SystemColors.Control;
            this.SplinesCheckBox.Location = new System.Drawing.Point(6, 65);
            this.SplinesCheckBox.Name = "SplinesCheckBox";
            this.SplinesCheckBox.Size = new System.Drawing.Size(71, 17);
            this.SplinesCheckBox.TabIndex = 4;
            this.SplinesCheckBox.Text = "Сплайны";
            this.SplinesCheckBox.UseVisualStyleBackColor = false;
            this.SplinesCheckBox.CheckedChanged += new System.EventHandler(this.SplinesCheckBox_CheckedChanged);
            // 
            // PathLabel
            // 
            this.PathLabel.AutoSize = true;
            this.PathLabel.Location = new System.Drawing.Point(12, 18);
            this.PathLabel.Name = "PathLabel";
            this.PathLabel.Size = new System.Drawing.Size(183, 13);
            this.PathLabel.TabIndex = 5;
            this.PathLabel.Text = "Enter path and name of file with data:";
            this.PathLabel.Click += new System.EventHandler(this.EnterPathLabel_Click);
            // 
            // PathTextBox
            // 
            this.PathTextBox.Location = new System.Drawing.Point(204, 15);
            this.PathTextBox.Name = "PathTextBox";
            this.PathTextBox.Size = new System.Drawing.Size(175, 20);
            this.PathTextBox.TabIndex = 8;
            this.PathTextBox.TextChanged += new System.EventHandler(this.PathTextBox_TextChanged);
            // 
            // SavePrimitivesGroupBox
            // 
            this.SavePrimitivesGroupBox.Controls.Add(this.PointsCheckBox);
            this.SavePrimitivesGroupBox.Controls.Add(this.Polilines);
            this.SavePrimitivesGroupBox.Controls.Add(this.SplinesCheckBox);
            this.SavePrimitivesGroupBox.Location = new System.Drawing.Point(21, 48);
            this.SavePrimitivesGroupBox.Name = "SavePrimitivesGroupBox";
            this.SavePrimitivesGroupBox.Size = new System.Drawing.Size(162, 96);
            this.SavePrimitivesGroupBox.TabIndex = 9;
            this.SavePrimitivesGroupBox.TabStop = false;
            this.SavePrimitivesGroupBox.Text = "Сохранить примитивы";
            this.SavePrimitivesGroupBox.Enter += new System.EventHandler(this.SavePrimitivesGroupBox_Enter);
            // 
            // Found
            // 
            this.Found.Controls.Add(this.PoliLinesLabel);
            this.Found.Controls.Add(this.SplinesLabel);
            this.Found.Controls.Add(this.PointsLabel);
            this.Found.Controls.Add(this.PolilinesTextBox);
            this.Found.Controls.Add(this.SplinesTextBox);
            this.Found.Controls.Add(this.PointsTextBox);
            this.Found.Location = new System.Drawing.Point(204, 48);
            this.Found.Name = "Found";
            this.Found.Size = new System.Drawing.Size(167, 96);
            this.Found.TabIndex = 5;
            this.Found.TabStop = false;
            this.Found.Text = "Найдено примитивов";
            this.Found.Enter += new System.EventHandler(this.FoundGroupBox_Enter);
            // 
            // PoliLinesLabel
            // 
            this.PoliLinesLabel.AutoSize = true;
            this.PoliLinesLabel.Location = new System.Drawing.Point(7, 68);
            this.PoliLinesLabel.Name = "PoliLinesLabel";
            this.PoliLinesLabel.Size = new System.Drawing.Size(63, 13);
            this.PoliLinesLabel.TabIndex = 5;
            this.PoliLinesLabel.Text = "Полилиний";
            this.PoliLinesLabel.Click += new System.EventHandler(this.PoliLinesLabel_Click);
            // 
            // SplinesLabel
            // 
            this.SplinesLabel.AutoSize = true;
            this.SplinesLabel.Location = new System.Drawing.Point(7, 45);
            this.SplinesLabel.Name = "SplinesLabel";
            this.SplinesLabel.Size = new System.Drawing.Size(59, 13);
            this.SplinesLabel.TabIndex = 4;
            this.SplinesLabel.Text = "Сплайнов:";
            this.SplinesLabel.Click += new System.EventHandler(this.Splines_Label);
            // 
            // PointsLabel
            // 
            this.PointsLabel.AutoSize = true;
            this.PointsLabel.Location = new System.Drawing.Point(7, 22);
            this.PointsLabel.Name = "PointsLabel";
            this.PointsLabel.Size = new System.Drawing.Size(40, 13);
            this.PointsLabel.TabIndex = 3;
            this.PointsLabel.Text = "Точек:";
            this.PointsLabel.Click += new System.EventHandler(this.PointsLabel_Click);
            // 
            // PolilinesTextBox
            // 
            this.PolilinesTextBox.Location = new System.Drawing.Point(125, 65);
            this.PolilinesTextBox.Name = "PolilinesTextBox";
            this.PolilinesTextBox.ReadOnly = true;
            this.PolilinesTextBox.Size = new System.Drawing.Size(36, 20);
            this.PolilinesTextBox.TabIndex = 2;
            this.PolilinesTextBox.TextChanged += new System.EventHandler(this.PolilinesTextBox_TextChanged);
            // 
            // SplinesTextBox
            // 
            this.SplinesTextBox.Location = new System.Drawing.Point(125, 42);
            this.SplinesTextBox.Name = "SplinesTextBox";
            this.SplinesTextBox.ReadOnly = true;
            this.SplinesTextBox.Size = new System.Drawing.Size(36, 20);
            this.SplinesTextBox.TabIndex = 1;
            this.SplinesTextBox.TextChanged += new System.EventHandler(this.SplinesTextBox_TextChanged);
            // 
            // PointsTextBox
            // 
            this.PointsTextBox.Location = new System.Drawing.Point(125, 19);
            this.PointsTextBox.Name = "PointsTextBox";
            this.PointsTextBox.ReadOnly = true;
            this.PointsTextBox.Size = new System.Drawing.Size(36, 20);
            this.PointsTextBox.TabIndex = 0;
            this.PointsTextBox.TextChanged += new System.EventHandler(this.PointsTextBox_TextChanged);
            // 
            // Lab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 181);
            this.Controls.Add(this.Found);
            this.Controls.Add(this.SavePrimitivesGroupBox);
            this.Controls.Add(this.PathTextBox);
            this.Controls.Add(this.PathLabel);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.OK);
            this.MaximumSize = new System.Drawing.Size(400, 220);
            this.MinimumSize = new System.Drawing.Size(400, 220);
            this.Name = "Lab";
            this.Text = "Lab";
            this.Load += new System.EventHandler(this.MyForm_Load);
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
        private System.Windows.Forms.CheckBox Polilines;
        private System.Windows.Forms.CheckBox SplinesCheckBox;
        private System.Windows.Forms.Label PathLabel;
        private System.Windows.Forms.TextBox PathTextBox;
        private System.Windows.Forms.GroupBox SavePrimitivesGroupBox;
        private System.Windows.Forms.GroupBox Found;
        private System.Windows.Forms.Label PoliLinesLabel;
        private System.Windows.Forms.Label SplinesLabel;
        private System.Windows.Forms.Label PointsLabel;
        private System.Windows.Forms.TextBox PolilinesTextBox;
        private System.Windows.Forms.TextBox SplinesTextBox;
        private System.Windows.Forms.TextBox PointsTextBox;
    }
}