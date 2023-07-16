namespace CPU_RAM_Monitoring
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cpuProgress = new System.Windows.Forms.ProgressBar();
            this.ramProgress = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cpuText = new System.Windows.Forms.Label();
            this.ramText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // chart1
            // 
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(12, 12);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(372, 426);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // cpuProgress
            // 
            this.cpuProgress.Location = new System.Drawing.Point(12, 444);
            this.cpuProgress.Name = "cpuProgress";
            this.cpuProgress.Size = new System.Drawing.Size(372, 23);
            this.cpuProgress.Step = 1;
            this.cpuProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.cpuProgress.TabIndex = 1;
            // 
            // ramProgress
            // 
            this.ramProgress.Location = new System.Drawing.Point(12, 473);
            this.ramProgress.Name = "ramProgress";
            this.ramProgress.Size = new System.Drawing.Size(372, 23);
            this.ramProgress.Step = 1;
            this.ramProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.ramProgress.TabIndex = 2;
            this.ramProgress.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.4F);
            this.label1.Location = new System.Drawing.Point(330, 448);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "%CPU";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.4F);
            this.label2.Location = new System.Drawing.Point(330, 477);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "%RAM";
            // 
            // cpuText
            // 
            this.cpuText.AutoSize = true;
            this.cpuText.Location = new System.Drawing.Point(164, 454);
            this.cpuText.Name = "cpuText";
            this.cpuText.Size = new System.Drawing.Size(21, 13);
            this.cpuText.TabIndex = 5;
            this.cpuText.Text = "%0";
            this.cpuText.Click += new System.EventHandler(this.cpuText_Click);
            // 
            // ramText
            // 
            this.ramText.AutoSize = true;
            this.ramText.Location = new System.Drawing.Point(164, 483);
            this.ramText.Name = "ramText";
            this.ramText.Size = new System.Drawing.Size(21, 13);
            this.ramText.TabIndex = 6;
            this.ramText.Text = "%0";
            this.ramText.Click += new System.EventHandler(this.ramText_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 512);
            this.Controls.Add(this.ramText);
            this.Controls.Add(this.cpuText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ramProgress);
            this.Controls.Add(this.cpuProgress);
            this.Controls.Add(this.chart1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ProgressBar cpuProgress;
        private System.Windows.Forms.ProgressBar ramProgress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label cpuText;
        private System.Windows.Forms.Label ramText;
    }
}

