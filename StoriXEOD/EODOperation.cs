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
    public partial class WeeklyClock : Form
    {
        public WeeklyClock()
        {
            InitializeComponent();
            //CashiersList.Rows.Add("Batch","Cashier","Status","POS ID","Diff","Sales","Deposit","Loan","Open Fund","Close Fund");
            CashiersList.Rows.Add("7234","Alex","Closed","1","-123","5600","5430","0","800","-800");
            CashiersList.Rows.Add("7235", "Bill", "Suspended", "1", "-123", "5600", "5430", "0", "800", "-800");
            CashiersList.Rows.Add("7236", "David", "Suspended", "1", "-123", "5600", "5430", "0", "800", "-800");

            POSList.Rows.Add("6734", "2", "POS 2", "$8492.43", "563", "301", "05:40", "16:50", "Closed");
            POSList.Rows.Add("6735", "Fuel1", "Self Service", "$13492.43", "263", "263", "06:00", "06:02", "Closed");

            PayMethodList.Rows.Add("Cash", "$66,381.70");
            PayMethodList.Rows.Add("Dalkan", "$26,640.82");
            PayMethodList.Rows.Add("Visa", "$47,023.55");

            VATList.Rows.Add("Store %17", "17", "$2,272.96", "$ 15,643.29");
            VATList.Rows.Add("Fuel %17", "17", " $ 29,115.56", "$ 200,379.16");


            ClockingList.Rows.Add("96192","500","Alex Smith","Store worker","28-05-2017 08:27","28-05-2017 11:58","3:31","Out","Yes");
            ClockingList.Rows.Add("96198", "781", "Mark", "Store worker", "28-05-2017 16:37", "28-05-2017 21:28", "4:51", "Out","No");

            FuelList.Rows.Add("8977", "1", "Close", "05:58", "05:55", "$ 372,111.43", "$ 185,863.53", "$ -186,247.90");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Lock_Click(object sender, EventArgs e)
        {
            if (CashiersList.SelectedRows.Count > 0)
            {
                int i = CashiersList.SelectedCells[0].RowIndex;

                CashiersList.Rows[i].Cells[2].Value = "Closed";
            }
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void Statement_Click(object sender, EventArgs e)
        {
            Statement s = new Statement();

            s.ShowDialog();
        }

        private void CashiersList_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Statement s = new Statement();

            s.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (CashiersList.SelectedRows.Count > 0)
            {
                int i = CashiersList.SelectedCells[0].RowIndex;

                CashiersList.Rows[i].Cells[2].Value = "Suspended";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Search dialog by cashier name / code", "StoriX", MessageBoxButtons.OK);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EODReport r = new EODReport();
            r.Show();
        }

        private void CloseDay_Click(object sender, EventArgs e)
        {
            //check that all cashier all closed
            MessageBox.Show("Please close all cashiers first.", "StoriX", MessageBoxButtons.OK);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            BankDeposit b = new BankDeposit();

            b.ShowDialog();
        }

        private void EditFuel_Click(object sender, EventArgs e)
        {
            ShiftFuel sf = new ShiftFuel();

            sf.ShowDialog();
        }
    }
}
