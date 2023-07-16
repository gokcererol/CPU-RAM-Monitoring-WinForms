using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
using System.Threading;

namespace CPU_RAM_Monitoring
{
    public partial class Form1 : Form
    {
        private PerformanceCounter cpuCounter;
        private PerformanceCounter memCounter;
        private Thread updateThread;


        public Form1()
        {
            InitializeComponent();
            this.Text = "CPU & RAM Monitor by Ankyra";
            InitializeCounters();

            // Add the CPU Usage series
            chart1.Series.Add("CPU Usage");
            chart1.Series["CPU Usage"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart1.Series["CPU Usage"].BorderWidth = 2;
            chart1.Series["CPU Usage"].Color = Color.Blue;
            chart1.Series["CPU Usage"].Points.AddY(0); // Add an initial data point at 0.

            // Add the Memory Usage series
            chart1.Series.Add("Memory Usage");
            chart1.Series["Memory Usage"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart1.Series["Memory Usage"].BorderWidth = 2;
            chart1.Series["Memory Usage"].Color = Color.Red;
            chart1.Series["Memory Usage"].Points.AddY(0); // Add an initial data point at 0.

        }

        private void InitializeCounters()
        {
            cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
            memCounter = new PerformanceCounter("Memory", "Available MBytes");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 100;
            timer1.Start();

            updateThread = new Thread(UpdateChart);
            updateThread.IsBackground = true;
            updateThread.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
        }
        private void UpdateChart()
        {
            while (true)
            {
                float cpuUsage = cpuCounter.NextValue();
                float availableMemory = (memCounter.NextValue());

                this.Invoke(new Action(() =>
                {
                    chart1.Series["CPU Usage"].Points.AddY(cpuUsage);
                    cpuProgress.Value = (int)Math.Ceiling(cpuUsage);
                    cpuText.Text = "%"+ cpuProgress.Value.ToString();
                    chart1.Series["Memory Usage"].Points.AddY(100 - (availableMemory * 100 / 16000));
                    ramProgress.Value = (int)Math.Ceiling(100-(availableMemory * 100 / 16000));
                    ramText.Text = "%" + ramProgress.Value.ToString();

                    if (chart1.Series["CPU Usage"].Points.Count > 100)
                    {
                        chart1.Series["CPU Usage"].Points.RemoveAt(0);
                        chart1.Series["Memory Usage"].Points.RemoveAt(0);
                    }
                }));

                Thread.Sleep(1000); // Wait for 1 second before updating again
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cpuText_Click(object sender, EventArgs e)
        {

        }

        private void ramText_Click(object sender, EventArgs e)
        {

        }
    }
}
