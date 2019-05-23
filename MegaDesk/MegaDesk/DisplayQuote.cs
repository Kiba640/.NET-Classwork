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
            numDrawers.Text = deskQuote.desk.numberOfDrawer.ToString();
            numDepth.Text = deskQuote.desk.depth.ToString();
            numWidth.Text = deskQuote.desk.width.ToString();
            numMaterial.Text = deskQuote.desk.desktop.ToString();
            numShipping.Text = deskQuote.shipping.ToString();
        }

        private void DisplayQuote_Load(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void NumMaterial_Click(object sender, EventArgs e)
        {

        }

        private void NumShipping_Click(object sender, EventArgs e)
        {

        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Label9_Click(object sender, EventArgs e)
        {

        }

        private void NumWidth_Click(object sender, EventArgs e)
        {

        }

        private void NumDepth_Click(object sender, EventArgs e)
        {

        }

        private void NumDrawers_Click(object sender, EventArgs e)
        {

        }

        private void CustomerPrice_Click(object sender, EventArgs e)
        {

        }

        private void PriceTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
