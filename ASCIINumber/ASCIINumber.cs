//  Andrew Mackinnon
//  October 16 2015
//  ICS3UR
//  Convert ASCII numbers to letters

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASCIINumber
{
    public partial class frmASCIINumber : Form
    {
        public frmASCIINumber()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Varibles
            const int maxNumber = 91;
            // Process
            for (int loopCounter = 65; loopCounter != maxNumber; loopCounter++)
            {
                this.lstNumbers.Items.Add(Char.ConvertFromUtf32(loopCounter) + " --> " + loopCounter);
            }

        }
    }
}
