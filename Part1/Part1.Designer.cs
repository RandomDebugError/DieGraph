
namespace Part1
{
    partial class btnRoll
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.button1 = new System.Windows.Forms.Button();
            this.nRolls = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rollsInterval = new System.Windows.Forms.ComboBox();
            this.timeInterval = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.stdCkBox = new System.Windows.Forms.CheckBox();
            this.RollCkBox = new System.Windows.Forms.CheckBox();
            this.TimeCkBox = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Tahoma", 13.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(765, 596);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(382, 78);
            this.button1.TabIndex = 0;
            this.button1.Text = "Throw";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nRolls
            // 
            this.nRolls.BackColor = System.Drawing.Color.White;
            this.nRolls.Font = new System.Drawing.Font("Tahoma", 16.125F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nRolls.Location = new System.Drawing.Point(753, 87);
            this.nRolls.Name = "nRolls";
            this.nRolls.Size = new System.Drawing.Size(454, 59);
            this.nRolls.TabIndex = 2;
            this.nRolls.Text = "6000";
            this.nRolls.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nRolls.Click += new System.EventHandler(this.clearRolls);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(809, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 45);
            this.label1.TabIndex = 4;
            this.label1.Text = "How Many Rolls?";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 30);
            this.chart1.Name = "chart1";
            series1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalRight;
            series1.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.DarkBlue;
            series1.Legend = "Legend1";
            series1.Name = "Rolls";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(695, 753);
            this.chart1.TabIndex = 5;
            this.chart1.Text = "Rolls";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkGray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Tahoma", 13.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(771, 688);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(382, 95);
            this.button2.TabIndex = 6;
            this.button2.Text = "2 Die Sum";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(748, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 35);
            this.label2.TabIndex = 7;
            this.label2.Text = "Roll Interval";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(972, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(235, 39);
            this.label3.TabIndex = 8;
            this.label3.Text = "Time Interval";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // rollsInterval
            // 
            this.rollsInterval.Font = new System.Drawing.Font("Tahoma", 16.125F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rollsInterval.FormattingEnabled = true;
            this.rollsInterval.Items.AddRange(new object[] {
            "1",
            "10",
            "100",
            "1000",
            "10000"});
            this.rollsInterval.Location = new System.Drawing.Point(784, 232);
            this.rollsInterval.Name = "rollsInterval";
            this.rollsInterval.Size = new System.Drawing.Size(125, 60);
            this.rollsInterval.TabIndex = 11;
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
            this.timeInterval.Location = new System.Drawing.Point(1005, 232);
            this.timeInterval.Name = "timeInterval";
            this.timeInterval.Size = new System.Drawing.Size(157, 60);
            this.timeInterval.TabIndex = 12;
            this.timeInterval.Text = "0.1";
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // stdCkBox
            // 
            this.stdCkBox.AutoSize = true;
            this.stdCkBox.Location = new System.Drawing.Point(886, 397);
            this.stdCkBox.Name = "stdCkBox";
            this.stdCkBox.Size = new System.Drawing.Size(149, 29);
            this.stdCkBox.TabIndex = 13;
            this.stdCkBox.Text = "STANDARD";
            this.stdCkBox.UseVisualStyleBackColor = true;
            // 
            // RollCkBox
            // 
            this.RollCkBox.AutoSize = true;
            this.RollCkBox.Location = new System.Drawing.Point(886, 456);
            this.RollCkBox.Name = "RollCkBox";
            this.RollCkBox.Size = new System.Drawing.Size(104, 29);
            this.RollCkBox.TabIndex = 14;
            this.RollCkBox.Text = "ROLLS";
            this.RollCkBox.UseVisualStyleBackColor = true;
            // 
            // TimeCkBox
            // 
            this.TimeCkBox.AutoSize = true;
            this.TimeCkBox.Location = new System.Drawing.Point(886, 516);
            this.TimeCkBox.Name = "TimeCkBox";
            this.TimeCkBox.Size = new System.Drawing.Size(92, 29);
            this.TimeCkBox.TabIndex = 15;
            this.TimeCkBox.Text = "TIME";
            this.TimeCkBox.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(827, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(291, 39);
            this.label4.TabIndex = 16;
            this.label4.Text = "Execution Choice";
            // 
            // btnRoll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1236, 807);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TimeCkBox);
            this.Controls.Add(this.RollCkBox);
            this.Controls.Add(this.stdCkBox);
            this.Controls.Add(this.timeInterval);
            this.Controls.Add(this.rollsInterval);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nRolls);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Tahoma", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "btnRoll";
            this.Text = "Part 1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox nRolls;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox rollsInterval;
        private System.Windows.Forms.ComboBox timeInterval;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox stdCkBox;
        private System.Windows.Forms.CheckBox RollCkBox;
        private System.Windows.Forms.CheckBox TimeCkBox;
        private System.Windows.Forms.Label label4;
    }
}

