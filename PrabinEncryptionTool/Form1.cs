/*@author name: Prabin Siwakoti, 
 *@author email : developer.prabin@gmail.com,
 *@date : 2017-08-31
 * */

using System;
using System.Windows.Forms;

namespace PrabinEncryptionTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            try
            {
                txtResult.Text = EncryptDecrypt.Encrypt(txtText.Text.Trim(), txtKey.Text);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Error");
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            try
            {
                txtResult.Text = EncryptDecrypt.Decrypt(txtText.Text.Trim(), txtKey.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            
        }
    }
}
