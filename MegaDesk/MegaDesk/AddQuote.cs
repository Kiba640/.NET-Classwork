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

            int Depth = Convert.ToInt32(deskDepth.Value);
            int Width = Convert.ToInt32(deskWidth.Value);
            int NumberOfDrawers = (int)numDrawers.Value;
            Material material = (Material)MaterialsCombo.SelectedValue;
            Desk desk = new Desk(Width, Depth, material, NumberOfDrawers );
        }
    }

}