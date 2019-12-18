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
        /// <summary>
        /// Hash button click method that checks if the user entered some text to calculate hash
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        private void ChooseFileButtonClick(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            tbxPlainText.Text = mainForm.OpenFileDialog();
            mainForm.Dispose();
        }

        private void SaveHashDataButtonClick(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.SaveFileDialog(tbxHash.Text);
            mainForm.Dispose();
        }

        private void SaveDigitalSignatureButtonClick(object sender, EventArgs e)
        {
            string digitalSignature = sha.GenerateDigitalSignature(tbxHash.Text);
            MainForm mainForm = new MainForm();
            mainForm.SaveFileDialog(digitalSignature);
            mainForm.Dispose();
        }
    }
}
