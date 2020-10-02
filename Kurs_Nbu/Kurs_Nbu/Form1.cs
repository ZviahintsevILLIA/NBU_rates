using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using System.Net;
using System.Windows.Forms.DataVisualization.Charting;

namespace Kurs_Nbu
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            updateForm();
            buttonGetCourse_Click(null, EventArgs.Empty);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonGetCourse_Click(object sender, EventArgs e)
        {
            // Get selected date from Calendar
            DateTime selectedDate = monthCalendar1.SelectionStart;
            // Draw main table
            bool isNeedToUpdateCharts = Program.drawTableAndPopularCurrencForDate(dataGridView1, selectedDate, popCurBox, chartsBox);
            if (isNeedToUpdateCharts)
            {
                Program.drowChart(chart1, "USD", selectedDate);
                Program.drowChart(chart2, "EUR", selectedDate);
                Program.drowChart(chart3, "RUB", selectedDate);
                Program.drowChart(chart4, getCodeFromDropbox(), selectedDate);
            }
        }

        private void updateForm() {
            this.Show();
            this.Select();
            foreach (Control c in this.Controls)  c.Update();
        }

        private String getCodeFromDropbox() {
            return comboBox4.Text;
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            Program.drowChart(chart4, getCodeFromDropbox(), monthCalendar1.SelectionStart);
        }



        Point? prevPosition = null;
        ToolTip tooltip = new ToolTip();
        private void chart1_MouseMove(object sender, MouseEventArgs e){
            showTooltip(e, (Chart)sender);
        }

        private void chart2_MouseMove(object sender, MouseEventArgs e)
        {
            showTooltip(e, (Chart)sender);
        }

        private void showTooltip(MouseEventArgs e, Chart chart)
        {
            var pos = e.Location;
            if (prevPosition.HasValue && pos == prevPosition.Value)
                return;
            tooltip.RemoveAll();
            prevPosition = pos;
            var results = chart.HitTest(pos.X, pos.Y, true, ChartElementType.DataPoint);
            foreach (var result in results)
            {
                if (result.ChartElementType == ChartElementType.DataPoint)
                {
                    var prop = result.Object as DataPoint;
                    if (prop != null)
                    {
                        tooltip.Show(prop.YValues[0].ToString(), chart, pos.X, pos.Y - 15);
                    }
                }
            }
        }

        private void chart3_MouseMove(object sender, MouseEventArgs e)
        {
            showTooltip(e, (Chart)sender);
        }

        private void chart4_MouseMove(object sender, MouseEventArgs e)
        {
            showTooltip(e, (Chart)sender);
        }
    }
}
