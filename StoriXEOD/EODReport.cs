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
    public partial class EODReport : Form
    {
        public EODReport()
        {
            InitializeComponent();

            DepSalesList.Rows.Add("‾", "‾‾‾‾‾‾", "‾‾‾‾‾‾", "‾‾‾‾‾‾‾", "‾‾‾‾‾‾‾", "‾‾‾‾‾‾‾‾", "‾‾‾‾‾‾", "‾‾‾‾‾‾");
            DepSalesList.Rows.Add("1","Store","849","$ 5,792.98","$ 6.82","$ 3,755.09","64.82%","3.41%");
            DepSalesList.Rows.Add("1", "Store", "849", "$ 5,792.98", "$ 6.82", "$ 3,755.09", "64.82%", "3.41%");
           

            CatList.Rows.Add ("‾‾‾‾‾‾", "‾‾‾‾‾‾", "‾‾‾‾‾‾‾", "‾‾‾‾‾‾‾", "‾‾‾‾‾‾‾‾");
            CatList.Rows.Add("Store", "Coffee", "Joe", "136.00", "$ 982.92");

            PayList.Rows.Add("‾", "‾‾‾‾‾‾", "‾‾‾‾‾‾", "‾‾‾‾‾‾‾",  "‾‾‾‾‾‾‾‾", "‾‾‾‾‾‾", "‾‾‾‾‾‾");
            PayList.Rows.Add("1", "Cash", " $74,546.10", "1061",  "$ 63,300.00", "", "$ 74,546.10", " $ -11,246.10");


            PumpList.Rows.Add("‾‾‾‾", "‾‾‾‾‾‾", "‾‾‾‾‾‾", "‾‾‾‾‾‾‾", "‾‾‾‾‾‾‾", "‾‾‾‾‾‾‾‾", "‾‾‾‾‾‾", "‾‾‾‾‾‾", "‾‾‾‾‾‾", "‾‾‾‾‾‾");
            PumpList.Rows.Add("8977", "1", "3", "312,952.48", "314,649.38", "1,696.90", "1,696.88", "0.00", "0.00", "-0.02");

            OverList.Rows.Add("‾‾‾‾‾‾", "‾‾‾‾‾‾", "‾‾‾‾‾‾‾");
            OverList.Rows.Add("227", "Alex Smith", "$ -1.14");


            
        }

        private void EODReport_Load(object sender, EventArgs e)
        {
            DepSalesList.ClearSelection();
            CatList.ClearSelection();
            PayList.ClearSelection();
            OverList.ClearSelection();
            PumpList.ClearSelection();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
