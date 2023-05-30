using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace egg54_FW
{
    public partial class Form1 : Form
    {
        string[] data;
        int index = -1;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int indexOf;
            index++;
            data = textBox1.Text.Split(new string[] { ", "}, StringSplitOptions.RemoveEmptyEntries);
            chart1.Series.Add(index.ToString());
            chart1.Series[index].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            foreach (string point in data)
            {
                indexOf = point.IndexOf(';');
                chart1.Series[0].Points.AddXY(
                    double.Parse(point.Substring(1, indexOf - 1)),
                    double.Parse(point.Substring(indexOf + 1, point.IndexOf(')') - indexOf - 1))
                    );
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string info = "";
            foreach (var item in chart1.Series[index].Points)
            {
                info += $"x:{item.XValue}; y:{item.YValues[0]}\n";
            }
            MessageBox.Show(info);
        }
    }
}
