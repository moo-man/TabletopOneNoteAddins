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
    public partial class AdvancesPossibleForm : Form
    {
        public AdvancesPossibleForm()
        {
            InitializeComponent();
            this.Show();
        }

        private void Value_Changed(object sender, EventArgs e)
        {
            skillAdv.Text = XPCalculator.CalculateSkillAdvancesPossible((int)startNumeric.Value, (int)XPNumeric.Value).ToString();
            charAdv.Text = XPCalculator.CalculateCharAdvancesPossible((int)startNumeric.Value, (int)XPNumeric.Value).ToString();
        }

        private void Value_Changed(object sender, KeyPressEventArgs e)
        {
            skillAdv.Text = XPCalculator.CalculateSkillAdvancesPossible((int)startNumeric.Value, (int)XPNumeric.Value).ToString();
            charAdv.Text = XPCalculator.CalculateCharAdvancesPossible((int)startNumeric.Value, (int)XPNumeric.Value).ToString();
        }

        private void AdvancesPossibleForm_Leave(object sender, EventArgs e)
        {
        }
    }
}
