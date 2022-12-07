await Task.Run(() =>
{

    try
    {
        if (string.IsNullOrEmpty(txtData.Text) && string.IsNullOrEmpty(txtKey.Text) && string.IsNullOrEmpty(txtIV.Text)) return;

        var plainText = txtData.Text; // Burada, kullanıcıdan alınan veriyi alıyoruz
        var key = Encoding.UTF8.GetBytes($"{txtKey.Text}"); // Anahtarımızı alıyoruz
        var iv = Encoding.UTF8.GetBytes($"{txtIV.Text}"); // IV değerini alıyoruz

        using (var mana = new RijndaelManaged())
        {
            mana.Mode = CipherMode.CBC;
            mana.Padding = PaddingMode.PKCS7;
            mana.FeedbackSize = 128;
            mana.Key = key;
            mana.IV = iv;

            var sifreleyen = mana.CreateEncryptor(mana.Key, mana.IV); // Veriyi şifreleyecek olan Encryptor nesnesini oluşturuyoruz

            using (var msEnc = new MemoryStream())
            {
                using (var csEnc = new CryptoStream(msEnc, sifreleyen, CryptoStreamMode.Write))
                {
                    using (var swEnc = new StreamWriter(csEnc))
                    {
                        swEnc.Write(plainText); // Şifrelenecek veriyi yazıyoruz
                    }
                }

                var encryptedData = msEnc.ToArray(); // Şifrelenmiş veriyi dizi halinde alıyoruz
                txtData.Text = Convert.ToBase64String(encryptedData); // Şifrelenmiş veriyi base64 formatına dönüştürüp, kullanıcıya gösteriyoruz
            }
        }
    }
    catch (Exception ex)
    {
        MessageBox.Show("key value or iv value may be wrong! \r\n" + ex.Message);
    }
    finally
    {
        GC.Collect();
    }

});
