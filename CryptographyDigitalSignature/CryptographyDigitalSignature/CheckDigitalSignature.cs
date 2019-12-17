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
    public partial class CheckDigitalSignatureUserControl : UserControl
    {
        public CheckDigitalSignatureUserControl()
        {
            InitializeComponent();
        }
        MainForm mainForm;
        ShaAlgorithm shaAlg = new ShaAlgorithm();
        string plainText = string.Empty;
        string generatedDigitalSignature = string.Empty;
        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            mainForm = new MainForm();
            plainText = mainForm.OpenFileDialog();
            tbxPlainTekst.Text = plainText;
        }

        private void btnChooseDigitalSignature_Click(object sender, EventArgs e)
        {
            mainForm = new MainForm();
            generatedDigitalSignature = mainForm.OpenFileDialog();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            string hashedText = shaAlg.HashCalculate(plainText);
            string decryptedDigitalSignature = shaAlg.DecryptDigitalSignature(generatedDigitalSignature);
            if(decryptedDigitalSignature != null && hashedText == decryptedDigitalSignature)
            {
                lblCheckStatus.Text = "OK";
            }
            else
            {
                lblCheckStatus.Text = "Modified!";
            }
        }
    }
}
