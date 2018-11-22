using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.OneNote;
using Application = Microsoft.Office.Interop.OneNote.Application;  // Conflicts with System.Windows.Forms

namespace OneNote.WFRP
{
    public partial class XpNeededForm : Form
    {
        private Application onenoteApplication;

        public XpNeededForm(Application application)
        {
            InitializeComponent();
            this.onenoteApplication = application;
        }


        private void Value_Changed(object sender, EventArgs e)
        {
            skillCost.Text = XPCalculator.CalculateSkillXPNeeded((int)startNumeric.Value, (int)targetNumeric.Value).ToString();
            charCost.Text = XPCalculator.CalculateCharXPNeeded((int)startNumeric.Value, (int)targetNumeric.Value).ToString();
        }

        private void Value_Changed(object sender, KeyPressEventArgs e)
        {
            skillCost.Text = XPCalculator.CalculateSkillXPNeeded((int)startNumeric.Value, (int)targetNumeric.Value).ToString();
            charCost.Text = XPCalculator.CalculateCharXPNeeded((int)startNumeric.Value, (int)targetNumeric.Value).ToString();
        }
    }
}
