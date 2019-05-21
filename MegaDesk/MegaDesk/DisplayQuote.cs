using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk
{
    public partial class DisplayQuote : Form
    {
        DeskQuote _deskQuote;
        public DisplayQuote(DeskQuote deskQuote)
        {
            InitializeComponent();

            _deskQuote = deskQuote;

            customerName.Text = deskQuote.customerName;
            customerPrice.Text = "$ " + deskQuote.quotePrice.ToString();
        }

        private void DisplayQuote_Load(object sender, EventArgs e)
        {

        }
    }
}
