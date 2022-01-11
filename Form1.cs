using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computer
{
    public partial class ComputerForm : Form
    {
        public ComputerForm()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double total;

            // Code for the radio buttons
            if (deluxeRadioButton.Checked)
            {
                total = 1000;
            }
            else
            {
                total = 1500;
            }

            // Code for the check boxes
            if (videoCheckBox.Checked)
            {
                total += 200;
            }
            if (modemCheckBox.Checked)
            {
                total += 30;
            }
            if (memoryCheckBox.Checked)
            {
                total += 120;
            }

            totalTextBox.Text = "$" + total;
        }
    }
}
