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
    public partial class ShiftFuel : Form
    {
        public ShiftFuel()
        {
            InitializeComponent();

            TankReadList.Rows.Add("1", "Soler", "53.1", "1401.23", "28682.33", "1.2", "19.8");
            TankReadList.Rows.Add("3", "95", "136.1", "4601.53", "18662.92", "0.2", "18.5");

            PumpReadList.Rows.Add("3", "Soler", "89899.1", "$ 907,952.33", "89632.8", "$ 902,254.31");

            TankDlvList.Rows.Add("1", "Soler", "27/01/2017", "4991.19", "5000.00", "8.81", "34892", "Fule Cop.", "34234");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
