using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoriXEOD
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            EODList.Rows.Add("4100", "17/01/2017", "Demo Station", "Closed", "16/01/2017 06:01", "17/01/2017 05:51");
            EODList.Rows.Add("4101", "18/01/2017", "Demo Station", "Closed", "17/01/2017 06:01", "18/01/2017 05:51");
            EODList.Rows.Add("4102", "19/01/2017", "Demo Station", "Suspended", "18/01/2017 06:01", "19/01/2017 05:51");
            EODList.Rows.Add("4103", "20/01/2017", "Demo Station", "Open", "19/01/2017 06:01", "20/01/2017 05:51");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WeeklyClock eod = new WeeklyClock();

            eod.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Day will be closed", "StoriX", MessageBoxButtons.OK);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Export all EOD data", "StoriX", MessageBoxButtons.OK);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EODReport r = new EODReport();

            r.Show();
        }
    }
}
