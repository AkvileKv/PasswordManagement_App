using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManagementSystem
{
    class AesCryp
    {
        private static string key = "ipksotcrwsndirtrqlklpffexmjtebpq"; //32
        private static string IV = "jrioadtysmckqmls"; //16

        public static string Encrypt(string decrypted) //Uzkoduoti
        {
            byte[] textBytes = ASCIIEncoding.ASCII.GetBytes(decrypted);

            AesCryptoServiceProvider AES = new AesCryptoServiceProvider();

                AES.BlockSize = 128;
                AES.KeySize = 256;
                AES.IV = ASCIIEncoding.ASCII.GetBytes(IV);  //Inicializacijos vektorius simetriniam algoritmui;
                AES.Key = ASCIIEncoding.ASCII.GetBytes(key);  //Pateikia simbolių kodavimą.
                AES.Mode = CipherMode.ECB;  //Sifravimo bloko rezimas
                AES.Padding = PaddingMode.PKCS7;  //Uzpildymo tipas, kai pranesimo duomenu blokas yra trumpesnis uz key

            ICryptoTransform icrypt = AES.CreateEncryptor(AES.Key, AES.IV);
                    //Apibrėžia srautą, kuris susieja duomenų srautus su kriptografinėmis transformacijomis.

            byte[] enc = icrypt.TransformFinalBlock(textBytes, 0, textBytes.Length); //nuo 0 iki pabaigos
            icrypt.Dispose();

            return Convert.ToBase64String(enc);                         
        }

        public static string Decrypt(string encrypted) //Atkoduoti
        {
            byte[] encBytes = Convert.FromBase64String(encrypted);

            AesCryptoServiceProvider AES = new AesCryptoServiceProvider();

            AES.BlockSize = 128;
            AES.KeySize = 256;
            AES.IV = ASCIIEncoding.ASCII.GetBytes(IV);  //Inicializacijos vektorius simetriniam algoritmui;
            AES.Key = ASCIIEncoding.ASCII.GetBytes(key);  //Pateikia simbolių kodavimą.
            AES.Mode = CipherMode.ECB;  //Sifravimo bloko rezimas
            AES.Padding = PaddingMode.PKCS7;  //Uzpildymo tipas, kai pranesimo duomenu blokas yra trumpesnis uz key

            ICryptoTransform icrypt = AES.CreateDecryptor(AES.Key, AES.IV);
            //Apibrėžia srautą, kuris susieja duomenų srautus su kriptografinėmis transformacijomis.

            byte[] dec = icrypt.TransformFinalBlock(encBytes, 0, encBytes.Length); //nuo 0 iki pabaigos
            icrypt.Dispose();

            return ASCIIEncoding.ASCII.GetString(dec);             
        }
    }
}
