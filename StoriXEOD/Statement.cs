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
    public partial class Statement : Form
    {
        public Statement()
        {
            InitializeComponent();
            StatementList.Rows.Add("Drop", "Credit", "$ -10,266.70");
            StatementList.Rows.Add("Drop", "Safe", "$ -10,140.00");
            StatementList.Rows.Add("Sales", "Sales", "$ 21,363.80");


            SafeList.Rows.Add("Drop", "Safe", "$1000");
            SafeList.Rows.Add("Drop", "Safe", "$4000");
            SafeList.Rows.Add("Drop", "Safe", "$2140");
            SafeList.Rows.Add("Drop", "Safe", "$3000");
            SafeList.Rows.Add("Drop", "Safe", "$4000");
            SafeList.Rows.Add("Drop", "Safe", "$6000");


        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Update u = new Update();

            u.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CoinsForm c = new CoinsForm();

            c.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Deposit dep = new Deposit();

            dep.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateFund uf = new UpdateFund();

            uf.ShowDialog();
        }
    }
}
