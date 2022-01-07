
namespace Part1
{
    partial class Part2
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.button1 = new System.Windows.Forms.Button();
            this.nRolls2 = new System.Windows.Forms.TextBox();
            this.nRolls2Label = new System.Windows.Forms.Label();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.rollsInterval = new System.Windows.Forms.ComboBox();
            this.timeInterval = new System.Windows.Forms.ComboBox();
            this.stdCkBox = new System.Windows.Forms.CheckBox();
            this.rollCkBox = new System.Windows.Forms.CheckBox();
            this.timeCkBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Tahoma", 22.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(834, 539);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(392, 210);
            this.button1.TabIndex = 0;
            this.button1.Text = "Throw";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nRolls2
            // 
            this.nRolls2.BackColor = System.Drawing.Color.White;
            this.nRolls2.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nRolls2.Location = new System.Drawing.Point(834, 72);
            this.nRolls2.Name = "nRolls2";
            this.nRolls2.Size = new System.Drawing.Size(394, 65);
            this.nRolls2.TabIndex = 1;
            this.nRolls2.Text = "6000";
            this.nRolls2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nRolls2.Click += new System.EventHandler(this.clearRolls2);
            // 
            // nRolls2Label
            // 
            this.nRolls2Label.AutoSize = true;
            this.nRolls2Label.Font = new System.Drawing.Font("Tahoma", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nRolls2Label.Location = new System.Drawing.Point(868, 13);
            this.nRolls2Label.Name = "nRolls2Label";
            this.nRolls2Label.Size = new System.Drawing.Size(338, 45);
            this.nRolls2Label.TabIndex = 4;
            this.nRolls2Label.Text = "How Many Rolls?";
            // 
            // chart2
            // 
            chartArea6.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chart2.Legends.Add(legend6);
            this.chart2.Location = new System.Drawing.Point(12, 13);
            this.chart2.Name = "chart2";
            series6.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalRight;
            series6.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            series6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series6.ChartArea = "ChartArea1";
            series6.Color = System.Drawing.Color.DarkBlue;
            series6.Legend = "Legend1";
            series6.Name = "Rolls";
            this.chart2.Series.Add(series6);
            this.chart2.Size = new System.Drawing.Size(777, 756);
            this.chart2.TabIndex = 5;
            this.chart2.Text = "chart1";
            // 
            // rollsInterval
            // 
            this.rollsInterval.Font = new System.Drawing.Font("Tahoma", 16.125F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rollsInterval.FormattingEnabled = true;
            this.rollsInterval.Items.AddRange(new object[] {
            "1",
            "10",
            "100",
            "1000"});
            this.rollsInterval.Location = new System.Drawing.Point(848, 210);
            this.rollsInterval.Name = "rollsInterval";
            this.rollsInterval.Size = new System.Drawing.Size(110, 60);
            this.rollsInterval.TabIndex = 6;
            this.rollsInterval.Text = "1";
            // 
            // timeInterval
            // 
            this.timeInterval.Font = new System.Drawing.Font("Tahoma", 16.125F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeInterval.FormattingEnabled = true;
            this.timeInterval.Items.AddRange(new object[] {
            "0.1",
            "1.0",
            "10.0",
            "100.0"});
            this.timeInterval.Location = new System.Drawing.Point(1071, 210);
            this.timeInterval.Name = "timeInterval";
            this.timeInterval.Size = new System.Drawing.Size(118, 60);
            this.timeInterval.TabIndex = 7;
            this.timeInterval.Text = "0.1";
            // 
            // stdCkBox
            // 
            this.stdCkBox.AutoSize = true;
            this.stdCkBox.Location = new System.Drawing.Point(944, 372);
            this.stdCkBox.Name = "stdCkBox";
            this.stdCkBox.Size = new System.Drawing.Size(149, 29);
            this.stdCkBox.TabIndex = 8;
            this.stdCkBox.Text = "STANDARD";
            this.stdCkBox.UseVisualStyleBackColor = true;
            // 
            // rollCkBox
            // 
            this.rollCkBox.AutoSize = true;
            this.rollCkBox.Location = new System.Drawing.Point(944, 420);
            this.rollCkBox.Name = "rollCkBox";
            this.rollCkBox.Size = new System.Drawing.Size(104, 29);
            this.rollCkBox.TabIndex = 9;
            this.rollCkBox.Text = "ROLLS";
            this.rollCkBox.UseVisualStyleBackColor = true;
            // 
            // timeCkBox
            // 
            this.timeCkBox.AutoSize = true;
            this.timeCkBox.Location = new System.Drawing.Point(944, 472);
            this.timeCkBox.Name = "timeCkBox";
            this.timeCkBox.Size = new System.Drawing.Size(92, 29);
            this.timeCkBox.TabIndex = 10;
            this.timeCkBox.Text = "TIME";
            this.timeCkBox.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(800, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 35);
            this.label2.TabIndex = 11;
            this.label2.Text = "Roll Interval";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1019, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(235, 39);
            this.label3.TabIndex = 12;
            this.label3.Text = "Time Interval";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(881, 306);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(291, 39);
            this.label4.TabIndex = 17;
            this.label4.Text = "Execution Choice";
            // 
            // Part2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1249, 779);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.timeCkBox);
            this.Controls.Add(this.rollCkBox);
            this.Controls.Add(this.stdCkBox);
            this.Controls.Add(this.timeInterval);
            this.Controls.Add(this.rollsInterval);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.nRolls2Label);
            this.Controls.Add(this.nRolls2);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Tahoma", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Part2";
            this.Text = "Part2";
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox nRolls2;
        private System.Windows.Forms.Label nRolls2Label;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.ComboBox rollsInterval;
        private System.Windows.Forms.ComboBox timeInterval;
        private System.Windows.Forms.CheckBox stdCkBox;
        private System.Windows.Forms.CheckBox rollCkBox;
        private System.Windows.Forms.CheckBox timeCkBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
    }
}