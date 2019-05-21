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
    public partial class SearchQuotes : Form
    {
        List<DeskQuote> deskquotes = new List<DeskQuote>();

        public SearchQuotes()
        {
            InitializeComponent();
            cbSearch.DataSource = Enum.GetValues(typeof(Material));
            cbSearch.SelectedIndex = -1;

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
            foreach (DeskQuote quote in deskquotes)
            {
               
            }
        }

        private void SrchBtn_Click(object sender, EventArgs e)
        {

            
        }
    }
}
