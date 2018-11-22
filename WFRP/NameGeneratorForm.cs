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

    public partial class NameGeneratorForm : Form
    {
        int mode;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="m">1 = male, 2 = female, 3 = surname only</param>
        public NameGeneratorForm(int m)
        {
            InitializeComponent();
            toolTip1.SetToolTip(generateButton, "Generates a new name and copies it to your clipboard");

            mode = m;
            nameLabel.Text = Generate();
            try
            {
                Clipboard.SetText(nameLabel.Text);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            nameLabel.Text = Generate();
          //  Clipboard.SetText(nameLabel.Text);
        }

        private string Generate()
        {
            switch (mode)
            {
                case 1: return NameGenerator.MaleName();
                case 2: return NameGenerator.FemaleName();
                case 3: return NameGenerator.Surname();
                default: return null;
            }
        }

        private void nameLabel_Click(object sender, EventArgs e)
        {
            nameLabel.SelectionStart = 0;
            nameLabel.SelectionLength = nameLabel.Text.Length;
        }

        private void generateButton_Click_1(object sender, EventArgs e)
        {
            nameLabel.Text = Generate();
        }
    }
}
