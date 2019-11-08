using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
namespace CryptographyDigitalSignature
{
    public partial class DecryptUserControl : UserControl
    {
        public DecryptUserControl()
        {
            InitializeComponent();

            cbxDecryptionAlgorithm.Items.Add("AES");
            cbxDecryptionAlgorithm.SelectedIndex = 0;
        }
        MainForm mainForm;
        AesAlgorithm aesAlg = new AesAlgorithm();
        string plainText = string.Empty;
        string keyAndIV = string.Empty;
        private void btnOpenFileDialog_Click(object sender, EventArgs e)
        {
            mainForm = new MainForm();
            plainText = mainForm.OpenFileDialog();
            tbxEncryptedText.Text = plainText;
        }

        private void btnChooseKey_Click(object sender, EventArgs e)
        {
            mainForm = new MainForm();
            keyAndIV = mainForm.OpenFileDialog();
            string[] lines = keyAndIV.Split(
                        new[] { Environment.NewLine },
                        StringSplitOptions.None
                        );

            byte[] encryptedText = Convert.FromBase64String(tbxEncryptedText.Text);
            byte[] key = Convert.FromBase64String(lines[0]);
            byte[] iv = Convert.FromBase64String(lines[1]);
            tbxDecryptedText.Text = aesAlg.DecryptFromByteArray(encryptedText, key, iv);
        }
    }
}
