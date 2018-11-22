using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OneNote.WFRP
{
    public partial class DiceForm : Form
    {
        int mode;
        Random rand;
        public DiceForm(int m)
        {
            InitializeComponent();
            mode = m;
            rand = new Random();
            if (mode >= 1)
            {
                roll100Button_Click(null, null);
            }
            else
            {
                roll10button_Click(null, null);
            }
        }

        private void roll100Button_Click(object sender, EventArgs e)
        {
            d100label.Text = String.Format("{0}", rand.Next(1, 101));
        }

        private void roll10button_Click(object sender, EventArgs e)
        {
            d10label.Text = String.Format("{0}", rand.Next(1, 11));

        }
    }
}
