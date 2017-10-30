using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace BittrexScanner
{
    public partial class BTRXscanner : Form
    {
        private Stopwatch Lag = new Stopwatch();
        private List<Dictionary<string, object>> markets, lvlpart;
        private BittrexCommunication btrx = new BittrexCommunication("", "");
        private double max = 0, summary = 0, Multiplier = 1, ratio = 0;
        private int i = 0, Depth = 1, count=0;
        private decimal price = 0;
        private string side = "";
        private Timer btrxct = new Timer();

        public BTRXscanner()
        {
            InitializeComponent();

            btrxct.Enabled = true;
            btrxct.Interval = 500;
            btrxct.Tick += isProblem;
        }

        private void isProblem (object sender, EventArgs e)
        {
            if (btrx.problem) countLabel.ForeColor = System.Drawing.Color.Red; else countLabel.ForeColor = System.Drawing.Color.White;
        }

        private void ConsiderSize_CheckedChanged(object sender, EventArgs e)
        {
            check.Checked = false;
        }

        private void depthBox_TextChanged(object sender, EventArgs e)
        {
            Int32.TryParse(depthBox.Text, out Depth);
            check.Checked = false;
        }

        private void BTRXscanner_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void MultiplierBox_TextChanged(object sender, EventArgs e)
        {
            Double.TryParse(MultiplierBox.Text, out Multiplier);
            check.Checked = false;
        }

        private async void check_CheckedChanged(object sender, EventArgs e)
        {
            if (check.Checked && Depth >= 1 && Multiplier >= 1)
            {
                dataScreen.Rows.Clear();
                markets = await btrx.ExecuteRequestAsync(btrx.Request["getMarkets"]);
                search();
            }
        }

        private async void search()
        {
            count = 0;
            foreach (Dictionary<string, object> coin in markets)
            {
                for (int x = 0; x < 2; x++)
                {
                    if (x > 0) side = "buy"; else side = "sell";
                    Lag.Restart();
                    max = 0; i = 0; summary = 0;
                    lvlpart = await btrx.ExecuteRequestAsync(btrx.Request["getOrderBook"] + "&market=" + coin["MarketName"] + "&type=" + side);
                    foreach (Dictionary<string, object> lvl in lvlpart)
                    {
                        if (lvl != null)
                        {
                            summary = summary + (double)lvl["Quantity"];
                            if ((double)lvl["Quantity"] > max) { max = (double)lvl["Quantity"]; price = Convert.ToDecimal(lvl["Rate"]); }
                            i++;
                        }
                        if (i == Convert.ToInt32(Depth)) break;
                    }
                    if (!ConsiderSize.Checked) summary = summary - max;
                    if (max >= ((summary / i) * Convert.ToDouble(Multiplier)))
                    {
                        ratio = Math.Round(max / (summary / i), 3);
                        dataScreen.Rows.Insert(0, coin["MarketName"], side.ToUpper(), price, ratio, DateTime.Now.TimeOfDay);
                    }
                    Lag.Stop();
                    scanLag.Text = "BTRX(ms) " + Lag.ElapsedMilliseconds.ToString();
                    //MessageBox.Show("max =" + max + " price = " + price + " depth=" + Depth + " multiplier=" + Multiplier + " summary=" + summary + " i=" + i + " ratio =" + ratio);
                    if (check.Checked == false) return;
                }
                count++;
                countLabel.Text = "Market " + count + "/" + markets.Count;
            }
            GC.Collect(GC.MaxGeneration);
            if (check.Checked && Depth >= 1 && Multiplier >= 1) search();
        }
    }
}
