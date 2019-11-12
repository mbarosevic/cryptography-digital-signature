using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptographyDigitalSignature
{
    public partial class HashUserControl : UserControl
    {
        public HashUserControl()
        {
            InitializeComponent();
        }

        readonly Sha sha = new Sha();
        private void btnCalculateHash_Click(object sender, EventArgs e)
        {
            string plainText = tbxPlainText.Text;
            if(plainText != string.Empty)
            {
                tbxHash.Text = sha.HashCalculate(plainText);
            }
        }
    }
}
