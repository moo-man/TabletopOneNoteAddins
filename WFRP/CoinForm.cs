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
    public partial class CoinForm : Form
    {
        /// <summary>
        /// Starts a CoinForm
        /// </summary>
        /// <param name="mode">Which value is focused initially. 1 = gold, 2 = silver, 3 = brass</param>
        public CoinForm(int mode)
        {   
            InitializeComponent();
            switch (mode)
            {
                case 1:
                    goldNum.Value = 1;
                    goldNum.Focus();
                    break;
                case 2:
                    silverNum.Value = 1;
                    silverNum.Focus();
                    break;
                case 3:
                    brassNum.Value = 1;
                    brassNum.Focus();
                    break;
            }
        }

        private void input_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown changed = sender as NumericUpDown;
            switch (changed.Name)
            {
                case "goldNum":
                    silverNum.Value = CoinCalculator.GoldToSilver(goldNum.Value);
                    brassNum.Value = CoinCalculator.GoldToPennies(goldNum.Value);
                    break;
                case "silverNum":
                    goldNum.Value = CoinCalculator.SilverToGold(silverNum.Value);
                    brassNum.Value = CoinCalculator.SilverToPennies(silverNum.Value);
                    break;
                case "brassNum":
                    goldNum.Value = CoinCalculator.PenniesToGold(brassNum.Value);
                    silverNum.Value = CoinCalculator.PenniesToSilver(brassNum.Value);
                    break;
            }
        }
    }
}
