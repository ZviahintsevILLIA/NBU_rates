using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using System.Net;
using System.IO;
using System.ComponentModel;
using System.Windows.Forms.DataVisualization.Charting;
using System.Globalization;

namespace Kurs_Nbu
{
    static class Program
    {
        /// <summary>
        /// Main method.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }
        // Number of days for some period statistic
        static int daysPeriod = 7;
        // Dictionory with rates: Key is Date
        public static Dictionary<DateTime, XmlDocument> periodXmlData = new Dictionary<DateTime, XmlDocument>(daysPeriod); 
        // NBU API url: Exchange rate as at the date (given in the YYYYMMDD format)
        public static String urlRateOnDate = "http://bank.gov.ua/NBUStatService/v1/statdirectory/exchange?date="; //+yyyyMMdd

        public static List<String> currentCurrencies = new List<string>();

        // Fill DataGridView with data on Date, returms true, if need update charts
        public static bool drawTableAndPopularCurrencForDate(DataGridView dataGridView, DateTime date, Control popCurSection, Control chartsSection)
        {
            XmlNodeList xmlnodes = getXmlDocByDate(date).GetElementsByTagName("currency");
            if (xmlnodes.Count == 0) {
                String wrongDate = date.ToShortDateString();
                MessageBox.Show("Rates not yet available on " + wrongDate);
                return false;
            } else {
                dataGridView.Rows.Clear();
                resetPopCurrencuies(popCurSection);
                currentCurrencies.Clear();
                List<Label> popCurValues = getLabelsFromControlByPartOfName(popCurSection, "popc");
                List<Label> popCurDiffers = getLabelsFromControlByPartOfName(popCurSection, "popd");
                for (int i = 0; i <= xmlnodes.Count - 1; i++) {
                    // Add row to main table
                    XmlNode node = xmlnodes[i];
                    String digitalCode = node.SelectSingleNode("r030").InnerText;
                    String currencyName = node.SelectSingleNode("txt").InnerText;
                    String rate = node.SelectSingleNode("rate").InnerText;
                    String letterCode = node.SelectSingleNode("cc").InnerText;
                    String exchangeDate = node.SelectSingleNode("exchangedate").InnerText;
                    dataGridView.Rows.Add(digitalCode, currencyName, rate, letterCode, exchangeDate);
                    currentCurrencies.Add(currencyName);
                    //dataGridView.Update();
                    // If currency is popular, update it Value in Popular currencies block
                    setRateValueInTextLabel(letterCode, rate, popCurValues);
                    // If currency is popular, update it Differnce between previous date in Popular currencies block
                    setRateDiffernceInTextLabel(letterCode, rate, popCurDiffers, date);
                }
                dataGridView.Sort(dataGridView.Columns["name_txt"], ListSortDirection.Ascending);
                currentCurrencies.Sort();
                initComboBoxes(chartsSection);
                return true;
            }                        
        }

        // Get XmlDataDocument by url
        public static XmlDocument getXmlDocFromUrl(String url) {
            XmlDocument xmldoc = new XmlDocument();
            //FileStream fs = new FileStream("product.xml", FileMode.Open, FileAccess.Read);
            WebRequest req = HttpWebRequest.Create(url);
            Stream stream = req.GetResponse().GetResponseStream();
            xmldoc.Load(stream);
            return xmldoc;
        }

        // Get XmlDataDocument by Date
        public static XmlDocument getXmlDocByDate(DateTime date) {
            XmlDocument result;
            if (periodXmlData.ContainsKey(date)) {
                result = periodXmlData[date];
            } else {
                result = getXmlDocFromUrl(urlRateOnDate + date.ToString("yyyyMMdd"));
                if (result.GetElementsByTagName("currency").Count != 0) {
                    periodXmlData.Add(date, result);
                }
            }
            return result;
        }

        private static void setRateValueInTextLabel(String letterCode, String rate, List<Label> labels) {
            foreach (Label label in labels) {
                String labelName = label.Name;
                if (labelName == ("popc" + letterCode)) {
                    label.Text = rate;
                    label.Update();
                    break;
                }
            }
        }

        private static void setRateDiffernceInTextLabel(String letterCode, String rate, List<Label> labels, DateTime currentDate) {
            DateTime previousDate = currentDate.AddDays(-1);
            foreach (Label label in labels)
            {
                String labelName = label.Name;
                if (labelName == ("popd" + letterCode))
                {
                    double currentDateRate = getRateForCurrencyByDate(letterCode, currentDate);
                    double previousDateRate = getRateForCurrencyByDate(letterCode, previousDate);
                    double diffDouble = currentDateRate - previousDateRate;
                    label.Text = stringFromDoubleWithSign(diffDouble);
                    label.Update();
                    break;
                }
            }
        }

        static double getRateForCurrencyByDate(String letterCode, DateTime date)
        {
            XmlNodeList xmlnodes = getXmlDocByDate(date).GetElementsByTagName("currency");
            foreach (XmlNode node in xmlnodes)
            {
                if (node.SelectSingleNode("cc").InnerText.Equals(letterCode) || node.SelectSingleNode("txt").InnerText.Equals(letterCode))
                {
                    return Double.Parse(node.SelectSingleNode("rate").InnerText, NumberFormatInfo.InvariantInfo);
                }
                
            }
            return 0.0;
        }

        // Get List of labels in Control by Label Name
        private static List<Label> getLabelsFromControlByPartOfName(Control control, String labelName) {
            List<Label> result = new List<Label>();
            foreach (Control c in control.Controls) {
                if (c.GetType() == typeof(Label)) {
                    if (c.Name.Contains(labelName)) {
                        result.Add((Label)c);
                    }
                }
            }
            return result;
        }

        static String stringFromDoubleWithSign(double number) {
            number = Math.Round(number, 2);
            String s = "+";
            if (number < 0) s = "" + number;
            else s += number;
            String[] arr = s.Split(new String[] {"."}, StringSplitOptions.None);
            if (arr.Length == 1) s += ".00";
            else if (arr[1].Length == 1) s += "0";
            return s;
        }

        static void resetPopCurrencuies(Control controls)
        {
            foreach (Control c in controls.Controls)
            {
                if (c is Label)
                {
                    Label label = (Label)c;
                    if (label.Name.Contains("pop"))
                        label.Text = "N/A";
                }
            }
        }

        // Drow chart for currency in interval before specified date
        public static void drowChart(Chart chart, String letterCode, DateTime date) {
            chart.Series.Clear();
            var series1 = new Series
            {
                Name = "Series1",
                Color = System.Drawing.Color.DarkBlue,
                IsVisibleInLegend = false,
                IsXValueIndexed = true,
                ChartType = SeriesChartType.Spline,
                XValueType = ChartValueType.Date,
                YValueType = ChartValueType.Double,
            };
            chart.Series.Add(series1);
            List<double> rates = new List<double>();
            for (int i = daysPeriod - 1; i >= 0; i--)
            {
                DateTime tempDate = date.AddDays(-i);
                double rate = getRateForCurrencyByDate(letterCode, tempDate);
                rates.Add(rate);
                series1.Points.AddXY(tempDate, rate);
            }
            rates.Sort();
            chart.ChartAreas[0].AxisY.LabelStyle.Format = "0.00";
            List<double> intervals = new List<double>() {
                0.01, 0.05, 0.1, 0.2, 0.25, 0.5, 1.0, 2.0, 4.0, 5.0, 10.0, 20.0, 25.0, 50.0, 100.0, 200.0
            };
            intervals.Reverse();
            foreach (double interval in intervals) {
                bool gotMax = false;
                if (gotMax) break;
                double min = getMinForRateByInterval(rates[0], interval);
                for (int i = 1; i < 6; i++)
                {
                    double max = min + interval * i;
                    if (max > rates[rates.Count - 1])
                    {
                        chart.ChartAreas[0].AxisY.Maximum = max;
                        chart.ChartAreas[0].AxisY.Minimum = min;
                        chart.ChartAreas[0].AxisY.Interval = interval;
                        gotMax = true;
                        break;
                    }
                }
            }
        }

        private static double getMinForRateByInterval(Double rate, Double interval) {
            int full = (int)(rate * 100)/(int)(interval * 100);
            return full * interval;
        }

        private static void initComboBoxes(Control control)
        {
            foreach (Control c in control.Controls)
            {
                int i = 0;
                if (c is ComboBox)
                {
                    ComboBox cBox = (ComboBox)c;
                    cBox.Items.Clear();
                    foreach (String s in Program.currentCurrencies)
                        cBox.Items.Add(s);
                    cBox.SelectedIndex = i;
                    i++;
                }
            }
        }

        private static List<Chart> getChartsList(Control control)
        {
            List<Chart> result = new List<Chart>();
            foreach (Control c in control.Controls)
            {
                if (c is Chart)
                {
                    Chart chart = (Chart)c;
                    result.Add(chart);
                }
            }
            return result;
        }
    }
}
