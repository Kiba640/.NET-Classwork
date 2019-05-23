using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk
{
    public partial class ViewAllQuotes : Form
    {
        List<DeskQuote> deskquotes = new List<DeskQuote>();
        public ViewAllQuotes()
        {
            InitializeComponent();
            // read in data from json and save it to a variable
            var quotesFile = @"quotes.json";
            //check to see if we can open the json file.
            if (File.Exists(quotesFile))
            {
                using (StreamReader reader = new StreamReader(quotesFile))
                {
                    //load existing quotes
                    string quotes = reader.ReadToEnd();

                    if (quotes.Length > 0)
                    {
                        // deserialization time!
                        deskquotes = JsonConvert.DeserializeObject<List<DeskQuote>>(File.ReadAllText(quotesFile)) ?? new List<DeskQuote>();
                    }
                }
            }

            // display all data to the grid by default
            display(deskquotes);
        }

        private void display(List<DeskQuote> quoteList)
        {
            quoteGrid.Rows.Clear();
            quoteGrid.Refresh();
            foreach (DeskQuote quote in quoteList)
            {
                quoteGrid.Rows.Add(new object[]
                {quote.customerName,
                 quote.desk.width,
                 quote.desk.depth,
                 quote.desk.desktop,
                 quote.desk.numberOfDrawer,
                 quote.quotePrice,
                 quote.quoteDate,
                 quote.shipping});
            }
        }
    }
}
