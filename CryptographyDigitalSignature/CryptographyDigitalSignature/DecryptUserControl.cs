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
            cbxDecryptionAlgorithm.Items.Add("RSA");
            cbxDecryptionAlgorithm.SelectedIndex = 0;
        }

        readonly AesAlgorithm aesAlgorithm = new AesAlgorithm();
        readonly RsaAlgorithm rsaAlgorithm = new RsaAlgorithm();
        string plainText = string.Empty;
        string keyAndIV = string.Empty;
        byte[] encryptedText;
        byte[] key;
        byte[] iv;

        public MainForm MainForm { get => MainForm; set => MainForm = value; }
        private void btnOpenFileDialog_Click(object sender, EventArgs e)
        {
            MainForm = new MainForm();
            plainText = MainForm.OpenFileDialog();
            tbxEncryptedText.Text = plainText;
        }

        private void btnChooseKey_Click(object sender, EventArgs e)
        {
            MainForm = new MainForm();
            keyAndIV = MainForm.OpenFileDialog();
            string[] lines = keyAndIV.Split(
                        new[] { Environment.NewLine },
                        StringSplitOptions.None
                        );

            encryptedText = Convert.FromBase64String(tbxEncryptedText.Text);
            key = Convert.FromBase64String(lines[0]);
            iv = Convert.FromBase64String(lines[1]);
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            if(cbxDecryptionAlgorithm.SelectedIndex == 0)
            {
                tbxDecryptedText.Text = aesAlgorithm.DecryptFromByteArray(encryptedText, key, iv);
            }
            else
            {
                EncryptUserControl encrypt = new EncryptUserControl();
                tbxDecryptedText.Text = encrypt.Decrypt();
            }
        }

        private void btnSaveDecryptedText_Click(object sender, EventArgs e)
        {
            MainForm = new MainForm();
            MainForm.SaveFileDialog(tbxDecryptedText.Text);
        }
    }
}
