using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExceptionExample_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void totalPriceButton_Click(object sender, EventArgs e)
        {

            TicketPriceCalculator aTicketPriceCalculator = new TicketPriceCalculator();
            try
            {
                double total = aTicketPriceCalculator.GetTotalPrice(noOfTicketsTextBox.Text);
                MessageBox.Show(total.ToString());
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
