using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordManagementSystem
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        string filePath = "C:\\Users\\Akvilė\\Desktop\\UserPasswordsFile.txt";
        private static string key = "ikksotqrwsndirtqqlklpffexmjtebpq"; //32
        private static string IV = "juiosdtysmckqols"; //16

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

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUpOrLogInForm f1 = new SignUpOrLogInForm();
            f1.ShowDialog();
            this.Close();
        }

        //--------UŽKODUOTI FAILUI DES-----------------------------
        private void EncryptFile(string filePath, string key)
        {
            byte[] plaintextBytes = File.ReadAllBytes(filePath); //byte nuskaitymui is failo

            using (var AES = new AesCryptoServiceProvider()) //Inicializuojama nauja DES algoritmo instancija
            {
                AES.BlockSize = 128;
                AES.KeySize = 256;
                AES.IV = Encoding.ASCII.GetBytes(IV);  //Inicializacijos vektorius simetriniam algoritmui;
                AES.Key = Encoding.ASCII.GetBytes(key);  //Pateikia simbolių kodavimą.
                AES.Mode = CipherMode.ECB;  //Sifravimo bloko rezimas
                AES.Padding = PaddingMode.PKCS7;  //Uzpildymo tipas, kai pranesimo duomenu blokas yra trumpesnis uz key

                using (var memoryStream = new MemoryStream()) //sukuriamas memoryStream object, kur rezultatas bus saugomas
                {
                    CryptoStream cryptoStream = new CryptoStream(memoryStream, AES.CreateEncryptor(), CryptoStreamMode.Write);
                    //Apibrėžia srautą, kuris susieja duomenų srautus su kriptografinėmis transformacijomis.

                    cryptoStream.Write(plaintextBytes, 0, plaintextBytes.Length); //nuo 0 iki pabaigos
                    cryptoStream.FlushFinalBlock(); //Atnaujina pagrindinį duomenų šaltinį ar saugyklą su dabartine buferio būsena, tada išvalo buferį.
                    File.WriteAllBytes(filePath, memoryStream.ToArray()); // is memoryStream i faila irasau

                }
            }
        }
        //--------------------------------------------------------


        private void GetStartedButton_Click(object sender, EventArgs e) //Confirm butoon
        {
            if (UserNameTextBox.Text == string.Empty || PasswordTextBox.Text == string.Empty || ConfirmTextBox.Text == string.Empty)
            {
                MessageBox.Show("Please fill in all fields");
                return;
           
            }
            else if (PasswordTextBox.Text != ConfirmTextBox.Text)
            {
                MessageBox.Show("Passwords do not match");
                return;
            }
            else
            { //------tikrinimui, ar DB Customer lentelej jau yra ivestas username---------------
                string query = "SELECT * FROM Customer WHERE Username=@Username";
                SQLiteConnection conn = new SQLiteConnection("Data Source=PasswordSystemDB.db;Version=3");
                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@Username", UserNameTextBox.Text);
                //-----------------------------------------------------------------------------------
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0) //jei randa mano ieskoma username, igauna verte didesne nei 0
                {
                    MessageBox.Show("Username already exist");
                }
                else //sukuria nauja naudotoja---
                {
                    //------------------------------RSA-----------------------------
                    string keyword = "cat"; //slaptazodis turi buti ne trumpesnis uz key
                    string str = PasswordTextBox.Text;

                    string keyVigenere = GenerateKey(str, keyword);
                    string cipherText = CipherText(str, keyVigenere);

                    //------------------------------------------------------------
                    Customer c = new Customer();

                    c.Username = UserNameTextBox.Text;
                    c.Password = cipherText;  //   PasswordTextBox.Text;

                    SqliteDataAccess.SaveCustomer(c);

                    MessageBox.Show("New User created");

                    System.IO.File.WriteAllText(filePath, string.Empty);

                    EncryptFile(filePath, key);

                    this.Hide();
                    SignUpOrLogInForm f3 = new SignUpOrLogInForm();
                    f3.ShowDialog();
                    this.Close();


                }
            }
        }
    }
}
