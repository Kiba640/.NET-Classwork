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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void Btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Btn_newQuote_Click(object sender, EventArgs e)
        {
            AddQuote addQuote = new AddQuote();
            addQuote.Show();
        }

        private void Btn_viewQuote_Click(object sender, EventArgs e)
        {
            ViewAllQuotes viewAllQuotes = new ViewAllQuotes();
            viewAllQuotes.Show();
        }

        private void Btn_searchQuote_Click(object sender, EventArgs e)
        {
            SearchQuotes search = new SearchQuotes();
            search.Show();
        }
    }
}
