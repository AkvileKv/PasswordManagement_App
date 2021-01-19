using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Security.Cryptography;
using System.IO;

namespace PasswordManagementSystem
{
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
            PasswordLogInTextBox.PasswordChar = '*';
          //  generateKeys(); //generuoju raktus
        }

        //  private static RSAParameters publicKey;

        string filePath = "C:\\Users\\Akvilė\\source\\repos\\PasswordManagementSystem\\UserPasswordsFile.txt";
        private static string key = "ikksotqrwsndirtqqlklpffexmjtebpq"; //32 (AES)
        private static string IV = "juiosdtysmckqols"; //16 (AES)

        // Cikliškai generuoja raktą, kol jo ilgis nėra lygus įvesto password ilgiui
        public string GenerateKey(string passwordText, string keyVigenere)
        {
            int passwordLength = passwordText.Length;

            for (int i = 0; ; i++)
            {
                if (passwordLength == i)
                    i = 0;
                if (keyVigenere.Length == passwordText.Length)
                    break;
                keyVigenere += (keyVigenere[i]);
            }
            return keyVigenere;
        }

        // grąžina užkoduotą tekstą, sugeneruotą rakto pagalba 
        public string CipherText(string passwordText, string keyVigenere)
        {
            string cipherText = "";

            for (int i = 0; i < passwordText.Length; i++)
            {
                // konvertavimo diapazonas 0-127 
                int x = (passwordText[i] + keyVigenere[i]) % 128;

                // konvertuojam i simbolius (ASCII)             
                x += '!'; // pradedam nuo !

                cipherText += (char)(x);
            }
            return cipherText;
        }

        private void BackButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUpOrLogInForm f1 = new SignUpOrLogInForm();
            f1.ShowDialog();
            this.Close();
        }

        // Generuoja raktą
        /*      static void generateKeys() //RSA
              {
                  using (var rsa = new RSACryptoServiceProvider(2048)) //naudoju 2048 bit rakta
                  {
                      rsa.PersistKeyInCsp = false; // nesaugau konteineryje raktu
                      publicKey = rsa.ExportParameters(false);

                  }
              } */

        // grąžina užkoduotą tekstą, sugeneruotą rakto pagalba 
        /*   static byte[] Encrypt(byte[] input) //RSA
           {
               byte[] encrypted;

               using (var rsa = new RSACryptoServiceProvider(2048))
               {
                   rsa.PersistKeyInCsp = false;
                   rsa.ImportParameters(publicKey); //Importuoju anksciau sukurta rakta
                   encrypted = rsa.Encrypt(input, true); //Enkriptinu
               }
               return encrypted; //bus grazintas kaip byte masyvas
           } */

        private static void DecryptFile(string filePath, string key)
        {
            byte[] encryptedTextBytes = File.ReadAllBytes(filePath); //byte nuskaitymui is failo

            using (var AES = new AesCryptoServiceProvider()) //Inicializuojama nauja DES algoritmo instancija
            {
                AES.BlockSize = 128;
                AES.KeySize = 256;
                AES.IV = Encoding.ASCII.GetBytes(IV);  //Inicializacijos vektorius simetriniam algoritmui;
                AES.Key = Encoding.ASCII.GetBytes(key);  //Pateikia simbolių kodavimą.
                AES.Mode = CipherMode.ECB;  //Sifravimo bloko rezimas
                AES.Padding = PaddingMode.PKCS7;  //Uzpildymo tipas, kai pranesimo duomenu blokas yra trumpesnis uz key

                using (var memoryStream = new MemoryStream()) //objektas, kur rezultatai bus saugomi
                {
                    CryptoStream cryptoStream = new CryptoStream(memoryStream, AES.CreateDecryptor(), CryptoStreamMode.Write);
                    //Apibrėžia srautą, kuris susieja duomenų srautus su kriptografinėmis transformacijomis.

                    cryptoStream.Write(encryptedTextBytes, 0, encryptedTextBytes.Length); //nuo 0 iki pabaigos
                    cryptoStream.FlushFinalBlock(); //Atnaujina pagrindinį duomenų šaltinį ar saugyklą su dabartine buferio būsena, tada išvalo buferį.
                    File.WriteAllBytes(filePath, memoryStream.ToArray()); // is memoryStream i faila irasau                 
                }
            }
        }

        private void LogInLogInButton_Click(object sender, EventArgs e)
        {
            if (UserNameLogInTextBox.Text == string.Empty || PasswordLogInTextBox.Text == string.Empty)
            {
                MessageBox.Show("Please fill in all fields");
                return;
            }
            else
            {
                string query = "SELECT * FROM Customer WHERE Username=@Username AND Password = @Password"; //tikrinu, ar yra toks username and password DB
                SQLiteConnection conn = new SQLiteConnection("Data Source=PasswordSystemDB.db;Version=3");
                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@Username", UserNameLogInTextBox.Text);
                //------------------------------------------------------------------
                //byte[] encrypted = Encrypt(Encoding.ASCII.GetBytes(PasswordLogInTextBox.Text)); //ok
                // string cipherTextRSA = BitConverter.ToString(encrypted); //ok

                string keyword = "cat"; //slaptazodis turi buti ne trumpesnis uz key
                string str = PasswordLogInTextBox.Text;

                string keyVigenere = GenerateKey(str, keyword);
                string cipherText = CipherText(str, keyVigenere);
                //------------------------------------------------------------------
                cmd.Parameters.AddWithValue("@Password", cipherText); //cipherTextRSA
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);

                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0) //jei randa mano ieskoma username and password
                {                                                
                        MessageBox.Show("Login Successful");
                       
                        DecryptFile(filePath, key);

                        this.Hide();
                        UserWindowForm f2 = new UserWindowForm();
                        f2.ShowDialog();
                        this.Close();                  
                }
                else
                {
                    MessageBox.Show("This user does not exist!");
                }
            }
        }
    }
}
