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

        readonly ShaAlgorithm sha = new ShaAlgorithm();
        public MainForm mainForm;

        private void CalculateHashButtonClick(object sender, EventArgs e)
        {
            string plainText = tbxPlainText.Text;
            if(!string.IsNullOrEmpty(plainText))
            {
                tbxHash.Text = sha.HashCalculate(plainText);
            }
            else
            {
                MessageBox.Show("Please choose text file or input text!");
            }
        }

        private void btnOpenFileDialog_Click(object sender, EventArgs e)
        {
            mainForm = new MainForm();
            tbxPlainText.Text = mainForm.OpenFileDialog();
        }

        private void SaveHashDataButtonClick(object sender, EventArgs e)
        {
            mainForm = new MainForm();
            mainForm.SaveFileDialog(tbxHash.Text);
        }

        private void btnSaveDigitalSignature_Click(object sender, EventArgs e)
        {
            string digitalSignature = sha.GenerateDigitalSignature(tbxHash.Text);
            mainForm = new MainForm();
            mainForm.SaveFileDialog(digitalSignature);
        }
    }
}
