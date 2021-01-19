using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace PasswordManagementSystem
{
    public partial class UserWindowForm : Form
    {
        public UserWindowForm()
        {
            InitializeComponent();
             CreateNewPasswGroupBox.Visible = false;
             UpdateRecordGroupBox.Visible = false;
             FindPasswordGroupBox.Visible = false;
             DeleteGroupBox.Visible = false;
            showPasswordTextBox.Visible = false;
        }

        string filePath = "C:\\Users\\Akvilė\\source\\repos\\PasswordManagementSystem\\UserPasswordsFile.txt";
        string fPath = "C:\\Users\\Akvilė\\Desktop\\Test.txt";

        private static string key = "ikksotqrwsndirtqqlklpffexmjtebpq"; //32
        private static string IV = "juiosdtysmckqols"; //16



        private void LogOutButton_Click(object sender, EventArgs e)
        {
            EncryptFile(filePath, key);

            this.Hide();
            SignUpOrLogInForm f1 = new SignUpOrLogInForm();
            f1.ShowDialog();
            this.Close();
        }

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

        private void CreateButton_Click(object sender, EventArgs e)
        {
            if (LogInNameTextBox.Text == string.Empty || PasswordTextBox.Text == string.Empty ||
                URLApplicationTextBox.Text == string.Empty || MoreInformationTextBox.Text == string.Empty)
            {
                MessageBox.Show("Please fill in all fields");
                return;
            }
            else
            {            
                StreamWriter toFile = new StreamWriter(filePath, true);//atidarom faila
                string encryptedPassword = AesCryp.Encrypt(PasswordTextBox.Text); // ir tik tada koduojam slaptazodi !!!
                
                toFile.Write(LogInNameTextBox.Text + ", ");         
                toFile.Write(encryptedPassword + ", "); // AES sifruojam slaptazodi
                toFile.Write(URLApplicationTextBox.Text + ", ");
                toFile.Write(MoreInformationTextBox.Text + "\r\n");
                toFile.Close();

                LogInNameTextBox.Clear();
                PasswordTextBox.Clear();
                URLApplicationTextBox.Clear();
                MoreInformationTextBox.Clear();

                MessageBox.Show("New record successfully created");
                return;              
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            string line;
            int k = 0;

            using (StreamReader reader = new StreamReader(filePath))
            { 
                using (StreamWriter writer = new StreamWriter(fPath))
                {
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (line.Contains(UpdateNameTextBox.Text))       // (String.Compare(line, line_to_delete) == 0)
                        {
                            MessageBox.Show("Record found and will be updated");
                            
                            writer.Write(UpdateNameTextBox.Text + ", ");
                              string encryptedPassword = AesCryp.Encrypt(UpdatePasswordTextBox.Text); //slaptazodzio sifravimui

                            writer.Write(encryptedPassword + ", ");
                            writer.Write(UpdateURLtextBox.Text + ", ");
                            writer.Write(UpdateInfoTextBox.Text + "\r\n");
                            k++;
                        }
                        else
                        {
                            writer.WriteLine(line);                            
                        }
                    }
                    writer.Close();
                }
                reader.Close();
            }
            File.Delete(filePath);
            File.Move(fPath, filePath);

            if (k==0) { MessageBox.Show("Record not found..."); }

            UpdateNameTextBox.Clear();
            UpdatePasswordTextBox.Clear();
            UpdateURLtextBox.Clear();
            UpdateInfoTextBox.Clear();

            /*
            // pakeicia zodi, kuri parasau
            string text = File.ReadAllText(filePath);
            text = text.Replace(UpdateNameTextBox.Text, UpdatePasswordTextBox.Text);
            File.WriteAllText(filePath, text);

            // LinesFound.Add(line.Split(',')[1]); parodo antra zodi eiluteje
            */
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
             string stringToSearch = FindByNameTextBox.Text; //tekstas, kurio ieskau eiluteje

              string[] lines = File.ReadAllLines(filePath); //failas, kuriame ieskau    
            ArrayList list = new ArrayList(lines);

              foreach (string line in lines) //po viena eilute ziuri failo eilutese
              {
                  if (line.Contains(stringToSearch)) //jei eilute turi ieskoma teksta, tada 
                  {
                       ResultsListBox.Items.AddRange(lines); //isveda viska
                  }
              }

            try
            {
                string line;
                List<String> linesFound = new List<string>(); //Visam irasui
                List<String> passwordFound = new List<string>(); //Slaptazodziui

                // Read the file and display it line by line. 
                StreamReader file = new StreamReader(filePath);

                while ((line = file.ReadLine()) != null)
                {
                    if (line.Contains(FindByNameTextBox.Text))
                    {
                        linesFound.Add(line); // prideda line i List LinesFound (parodo visa eilute)
                        passwordFound.Add(line.Split(',')[1]); //parodo antra zodi eiluteje
                    }                  
                }  
                file.Close();

                foreach (string Line in linesFound) //visam irasui
                {
                    textBox1.Text = textBox1.Text + Line + Environment.NewLine;
                }

                foreach (string Password in passwordFound) //tik slaptazodziui parodyti
                {
                    showPasswordTextBox.Text = showPasswordTextBox.Text + Password + Environment.NewLine;
                }          
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
            string decryptedPassword = AesCryp.Decrypt(showPasswordTextBox.Text);
            showPasswordTextBox.Text = decryptedPassword;


            if (textBox1.TextLength == 0)
            {
                MessageBox.Show("Record not found...");

                FindByNameTextBox.Clear();
            }
            else
            {

            }

        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            FindByNameTextBox.Clear();
            ResultsListBox.Items.Clear();
            showPasswordTextBox.Clear();
            showPasswordTextBox.Visible = false;

        }

        private void DeleteSearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                string line;
                List<String> LinesFound = new List<string>();

                // Read the file and display it line by line. 
                StreamReader file = new StreamReader(filePath);

                while ((line = file.ReadLine()) != null)
                {
                    if (line.Contains(DeleteNameTextBox.Text))
                    {
                        LinesFound.Add(line); // parodo visa eilute    
                    }
                }
                file.Close();

                foreach (string Line in LinesFound)
                {
                    DeleteFoundPasswtextBox.Text = DeleteFoundPasswtextBox.Text + Line + Environment.NewLine;
                }
            }
            catch (Exception) {  MessageBox.Show("Error"); }

            if (DeleteFoundPasswtextBox.TextLength == 0)
            {
                MessageBox.Show("Record not found...");

                DeleteNameTextBox.Clear();
            }
            else
            {

            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
               string line;

               using (StreamReader reader = new StreamReader(filePath))
               {
                   using (StreamWriter writer = new StreamWriter(fPath))
                   {
                       while ((line = reader.ReadLine()) != null)
                       {
                           if (line.Contains(DeleteNameTextBox.Text))       // (String.Compare(line, line_to_delete) == 0)
                           {
                              // MessageBox.Show("if viduje");
                           }
                           else
                           {     
                            writer.WriteLine(line);                           
                           }                                              
                       } writer.Close();
                   } reader.Close();
               } 
               File.Delete(filePath);
               File.Move(fPath, filePath);

            if (DeleteFoundPasswtextBox.TextLength != 0)
            {
                MessageBox.Show("Record successfully deleted");             
            }
            else
            {

            }
            DeleteNameTextBox.Clear();
            DeleteFoundPasswtextBox.Clear();
        }

        private void DeleteGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void NewPasswordButton_Click(object sender, EventArgs e)
        {
            CreateNewPasswGroupBox.Visible = true;
        }

        private void UpdatePasswordButton_Click(object sender, EventArgs e)
        {
            UpdateRecordGroupBox.Visible = true;
        }

        private void FindPasswordButton_Click(object sender, EventArgs e)
        {
            FindPasswordGroupBox.Visible = true;
        }

        private void DeletePasswordButton_Click(object sender, EventArgs e)
        {
            DeleteGroupBox.Visible = true;
        }

        private void ShowPasswordButton_Click(object sender, EventArgs e)
        {
            showPasswordTextBox.Visible = true;
        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(showPasswordTextBox.Text);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DeleteNameTextBox.Clear();
            DeleteFoundPasswtextBox.Clear();
        }
        private void GenerateButton_Click(object sender, EventArgs e)
        {
            UpdatePasswordTextBox.Text  = RandomPassword();
        }
        public string RandomPassword()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(RandomString(4, true));
            builder.Append(RandomNumber(1000, 9999));
            builder.Append(RandomString(2, false));
            return builder.ToString();
        }

        // Generate a random number between two numbers  
        public int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
        public string RandomString(int size, bool lowerCase)
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }
            if (lowerCase)
                return builder.ToString().ToLower();
            return builder.ToString();
        }

    }
}
