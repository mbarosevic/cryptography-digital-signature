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
        public MainForm MainForm { get => MainForm; set => MainForm = value; }

        private void CalculateHashButtonClick(object sender, EventArgs e)
        {
            string plainText = tbxPlainText.Text;
            if(!string.IsNullOrEmpty(plainText))
            {
                tbxHash.Text = sha.HashCalculate(plainText);
            }
        }

        private void SaveHashDataButtonClick(object sender, EventArgs e)
        {
            MainForm = new MainForm();
            MainForm.SaveFileDialog(tbxHash.Text);
        }
    }
}
