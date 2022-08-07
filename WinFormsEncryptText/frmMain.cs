
using EncryptionHandler;

namespace WinFormsEncryptText
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }       

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtSecretKey.Text) && !String.IsNullOrEmpty(txtPublicKey.Text) && !String.IsNullOrEmpty(rtbText.Text))
            {
                if (txtSecretKey.Text.Length != 8 || txtPublicKey.Text.Length != 8)
                    MessageBox.Show("Key must be of 8 characters", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    if (cmbOption.Text == "Encrypt")
                        rtbResult.Text = EncryptorClass.Encrypt(rtbText.Text, txtSecretKey.Text, txtPublicKey.Text);
                    else if (cmbOption.Text == "Decrypt")
                        rtbResult.Text = EncryptorClass.Decrypt(rtbText.Text, txtSecretKey.Text, txtPublicKey.Text);
                }
            }
            else
                MessageBox.Show("Please fill all information","Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtSecretKey.Text = "";
            txtPublicKey.Text = "";
            rtbText.Text = "";
            rtbResult.Text = "";
        }
    }
}