using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroSet_UI.Forms;
namespace CryptographyDigitalSignature
{
    public partial class MainForm : MetroSetForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            HidePanels();
            pnlEncrypt.Show();
        }

        private void btnEncryptUc_Click(object sender, EventArgs e)
        {
            HidePanels();
            pnlEncrypt.Show();
        }

        private void btnDecryptUc_Click(object sender, EventArgs e)
        {
            HidePanels();
            pnlDecrypt.Show();
        }

        private void btnHashUc_Click(object sender, EventArgs e)
        {
            HidePanels();
            pnlHash.Show();
        }

        private void btnDigitalSignature_Click(object sender, EventArgs e)
        {
            HidePanels();
            pnlDigitalSignature.Show();
        }

        private void HidePanels()
        {
            foreach(Control c in this.Controls)
            {
                if(c is Panel)
                {
                    c.Visible = false;
                }
            }
        }
    }
}
