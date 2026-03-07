using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Legends;
using OxyPlot.Series;
using System.IO;
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace SensorVisualizer
{
    public partial class Form1 : Form
    {
        LineSeries tempSeries;
        LineSeries humSeries;
        Random random = new Random();
        TimeSpan visibleRange = TimeSpan.FromSeconds(10);

        public Form1()
        {
            InitializeComponent();
        }

        private void plotView1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var plotModel = new PlotModel { Title = "Live Sensor Data" };

            if (!File.Exists("sensordata.csv"))
            {
                File.WriteAllText("sensordata.csv", "Time;Temperature;Humidity\n");
            }

            var timeAxis = new DateTimeAxis
            {
                Position = AxisPosition.Bottom,
                StringFormat = "HH:mm:ss",
                Title = "Time",
                IntervalType = DateTimeIntervalType.Seconds,
                MinorIntervalType = DateTimeIntervalType.Seconds,
                IsZoomEnabled = true,
                IsPanEnabled = true,
                MajorGridlineStyle = LineStyle.Solid,
                MinorGridlineStyle = LineStyle.Dot,
            };

            plotModel.Axes.Add(timeAxis);

            plotModel.Axes.Add(new LinearAxis
            {
                Position = AxisPosition.Left,
                Title = "Sensor Value",
                MajorGridlineStyle = LineStyle.Solid,
                MinorGridlineStyle = LineStyle.Dot
            });

            tempSeries = new LineSeries
            {
                Title = "Temperature",
                Color = OxyColors.Orange,
                MarkerType = MarkerType.Circle,
                MarkerFill = OxyColors.DarkOrange,
                MarkerSize = 3,
                StrokeThickness = 3
            };

            humSeries = new LineSeries
            {
                Title = "Humidity",
                Color = OxyColors.Blue,
                MarkerType = MarkerType.Diamond,
                MarkerFill = OxyColors.BlueViolet,
                MarkerSize = 3,
                StrokeThickness = 3
            };


            plotModel.Series.Add(tempSeries);
            plotModel.Series.Add(humSeries);

            plotView1.Model = plotModel;

            //  timer1.Tick += timer1_Tick_1;
            timer1.Interval = 1000; 
            timer1.Start();

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            timer1.Stop();
            double temp = 20 + random.NextDouble() * 5;
            double hum = 35 + random.NextDouble() * 10;
            string time = DateTime.Now.ToString("HH:mm:ss");

            DateTime now = DateTime.Now;

            File.AppendAllText("sensordata.csv", $"{now:HH:mm:ss};{temp:0.0};{hum:0.0}\n");

            if (temp > 24)
            {
                labelTempValue.ForeColor = Color.Red;
                labelTempValue.Font = new Font(labelTempValue.Font.FontFamily, 16, FontStyle.Bold);

            }
            else
            {
                labelTempValue.ForeColor = Color.Black;
                labelTempValue.Font = new Font(labelTempValue.Font.FontFamily, 12, FontStyle.Regular);

            }

            if (hum > 40)
            {
                labelHumValue.ForeColor = Color.Red;
                labelHumValue.Font = new Font(labelHumValue.Font.FontFamily, 16, FontStyle.Bold);
            }
            else
            {
                labelHumValue.ForeColor = Color.Black;
                labelHumValue.Font = new Font(labelHumValue.Font.FontFamily, 12, FontStyle.Regular);
            }

            labelTempValue.Text = temp.ToString("0.0") + " °C";
            labelHumValue.Text = hum.ToString("0.0") + " %";

            labelLastUpdate.Text = "Last update: " + DateTime.Now.ToString("HH:mm:ss");

            tempSeries.Points.Add(DateTimeAxis.CreateDataPoint(now, temp));
            humSeries.Points.Add(DateTimeAxis.CreateDataPoint(now, hum));

            if (tempSeries.Points.Count > 3600)
            {
                tempSeries.Points.RemoveAt(0);
                humSeries.Points.RemoveAt(0);
            }

            var axis = plotView1.Model.Axes.First(a => a.Position == AxisPosition.Bottom) as DateTimeAxis;

            if (axis != null)
            {
                axis.Maximum = DateTimeAxis.ToDouble(now);
                DateTime firstPointTime = DateTimeAxis.ToDateTime(tempSeries.Points[0].X);

                DateTime minTime = now - visibleRange;

                if (firstPointTime > minTime)
                {
                    axis.Minimum = DateTimeAxis.ToDouble(firstPointTime);
                }
                else
                {
                    axis.Minimum = DateTimeAxis.ToDouble(minTime);
                }
            }

            plotView1.InvalidatePlot(true);
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tempSeries.Points.Clear();
            humSeries.Points.Clear();
            plotView1.InvalidatePlot(true);
        }

        private void labelHumValue_Click(object sender, EventArgs e)
        {

        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "sensordata.csv",
                UseShellExecute = true
            });
        }

        private void minute_Click(object sender, EventArgs e)
        {
            visibleRange = TimeSpan.FromMinutes(1);
        }

        private void hour_Click(object sender, EventArgs e)
        {
            visibleRange = TimeSpan.FromHours(1);
        }

        private void live_Click(object sender, EventArgs e)
        {
            visibleRange = TimeSpan.FromSeconds(10);
        }
    }
}
