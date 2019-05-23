using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
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

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            var player = new SoundPlayer();

            if (checkBox1.Checked)
            {
                //SoundPlayer Mainplayer = player;
                player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "tem_shop.wav";
                player.PlayLooping();
                checkBox1.Text = "Mute Music";
            }

            else
            {
                checkBox1.Text = "Play Music";
                player.Stop();
            }
        }
    }
}
