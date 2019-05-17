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
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();
        }

        private void Btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddQuote_Load(object sender, EventArgs e)
        {
        }

        private void Btn_submit_Click(object sender, EventArgs e)
        {
            var temp_desk = new Desk()
            {
                width = Convert.ToInt32(deskWidth.Value),
                depth = Convert.ToInt32(deskDepth.Value),
                numberOfDrawer = (int)numDrawers.Value,
                desktop = (Material)MaterialsCombo.SelectedValue
            };

            var deskQuote = new DeskQuote
            {
                desk = temp_desk,
                customerName = txtcustomerName.Text,
                quoteDate = DateTime.Now,
                shipping = (Shipping)comShipping.SelectedValue

            };

            var quotesFile = @"quotes.json";
            List<DeskQuote> deskquotes = new List<DeskQuote>();

            //read existing quotes if any
            if (File.)
            //List<DeskQuote> deskQuotes = JsonConvert.DeserializeObject<
        }


    }

}