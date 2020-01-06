using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace USMarketAssistant
{
    public static class Drawing
    {
        public static void Draw(Chart chrt, Stock stock, int period)
        {
            double max = Double.MinValue;
            double min = Double.MaxValue;
            chrt.ChartAreas.Clear();
            chrt.Series.Clear();
            var chartArea = new ChartArea();
            //chartArea.AxisX.LabelStyle.Format = string.Format("{0} / {1} / {2}",  );
            chartArea.AxisX.MajorGrid.LineColor = Color.LightGray;
            chartArea.AxisY.MajorGrid.LineColor = Color.LightGray;
            chartArea.AxisX.LabelStyle.Font = new Font("Consolas", 8);
            chartArea.AxisY.LabelStyle.Font = new Font("Consolas", 8);
            chartArea.AxisY.IntervalAutoMode = IntervalAutoMode.VariableCount;
            chartArea.AxisY.LabelStyle.Format = "{0:0}";
            chartArea.AxisX.MajorGrid.LineWidth = 0;
            chartArea.AxisY.MajorGrid.LineWidth = 0;
            chartArea.AxisX.Interval = 50;
            chartArea.CursorX.IsUserSelectionEnabled = true;
            chartArea.CursorY.IsUserSelectionEnabled = true;
            chrt.ChartAreas.Add(chartArea);

            chartArea.AxisX.ScaleView.Zoomable = true;
            chartArea.AxisY.ScaleView.Zoomable = true;

            //chrt.MouseWheel += new MouseEventHandler();

            var series = new Series();
            series.Name = stock.Name;
            series.ChartType = SeriesChartType.Line;
            //series.XValueType = ChartValueType.String;// ChartValueType.DateTime;
            chrt.Series.Add(series);

            foreach (Tick tck in stock.Ticks)
            {
                if (tck.Date > DateTime.Now.AddDays(period*(-1)))
                {
                    DataPoint dp = new DataPoint();
                    dp.XValue = tck.Date.ToOADate();//  string.Format("{0} / {1} / {2}", pc.GetYear(tck.Date),pc.GetMonth(tck.Date), pc.GetDayOfMonth(tck.Date));
                    dp.AxisLabel = tck.Date.ToString();
                    dp.ToolTip = tck.Close.ToString() + " on " + tck.Date.ToString();
                    dp.YValues = new double[] { tck.Close };
                    

                    chrt.Series[0].Points.Add(dp);
                    min = Math.Min(min, dp.YValues[0]);
                    max = Math.Max(max, dp.YValues[0]);

                }
            }

            // bind the datapoints

            chrt.ChartAreas[0].AxisY.Maximum = max + min / 50;
            chrt.ChartAreas[0].AxisY.Minimum = min - min / 50;

            // draw!
            chrt.Invalidate();

        }
    }


}
