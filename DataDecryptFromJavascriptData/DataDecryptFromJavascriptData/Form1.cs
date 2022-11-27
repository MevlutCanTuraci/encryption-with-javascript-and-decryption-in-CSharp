using System.Text;
using System.Security.Cryptography;

namespace DataDecryptFromJavascriptData
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnDecrypte_Click(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {

                try
                {
                    if (string.IsNullOrEmpty(txtData.Text) && string.IsNullOrEmpty(txtKey.Text) && string.IsNullOrEmpty(txtIV.Text)) return;

                    var plainText = string.Empty;

                    var key = Encoding.UTF8.GetBytes($"{txtKey.Text}");
                    var iv = Encoding.UTF8.GetBytes($"{txtIV.Text}");

                    var encryptedData = Convert.FromBase64String(txtData.Text);

                    using (var mana = new RijndaelManaged())
                    {
                        mana.Mode = CipherMode.CBC;
                        mana.Padding = PaddingMode.PKCS7;
                        mana.FeedbackSize = 128;
                        mana.Key = key;
                        mana.IV = iv;

                        var cozulenVeri = mana.CreateDecryptor(mana.Key, mana.IV);

                        using (var msDec = new MemoryStream(encryptedData))
                        {
                            using (var csDec = new CryptoStream(msDec, cozulenVeri, CryptoStreamMode.Read))
                            {
                                using (var srDec = new StreamReader(csDec))
                                {
                                    plainText = srDec.ReadToEnd();
                                }
                            }
                        }

                    }

                    MessageBox.Show("okunan veri : " + plainText);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("key value or iv value may be wrong! \r\n"  + ex.Message);                    
                }
                finally
                {
                    GC.Collect();
                }


            });
        }
    }
}