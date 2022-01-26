using System;
using System.IO;
using System.Security.Cryptography;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using CryptMe.exceptions;

namespace CryptMe.utils
{
    class Aes
    {
        //  Remove Key from Memory
        [DllImport("KERNEL32.DLL", EntryPoint = "RtlZeroMemory")]
        public static extern bool ZeroMemory(IntPtr Destination, int Length);

        /// <summary>
        /// Creates a random salt.
        /// </summary>
        /// <returns></returns>
        public static byte[] GenerateRandomSalt()
        {
            byte[] data = new byte[32];

            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                for (int i = 0; i < 10; i++)
                {
                    // Fille the buffer with the generated data
                    rng.GetBytes(data);
                }
            }

            return data;
        }

        /// <summary>
        /// Encrypts a file from its path and a plain password.
        /// </summary>
        /// <param name="inputFile"></param>
        /// <param name="outputFile"></param>
        /// <param name="password"></param>
        public void FileEncrypt(string inputFile, string outputFile, string password)
        {
            byte[] salt = GenerateRandomSalt();
            FileStream fsCrypt = new FileStream(outputFile, FileMode.Create);

            byte[] passwordBytes = System.Text.Encoding.UTF8.GetBytes(password);
            RijndaelManaged aes = new RijndaelManaged();
            aes.KeySize = 256;
            aes.BlockSize = 128;
            aes.Padding = PaddingMode.PKCS7;

            var key = new Rfc2898DeriveBytes(passwordBytes, salt, 50000);
            aes.Key = key.GetBytes(aes.KeySize / 8);
            aes.IV = key.GetBytes(aes.BlockSize / 8);

            aes.Mode = CipherMode.CFB;
            
            fsCrypt.Write(salt, 0, salt.Length);

            CryptoStream cs = new CryptoStream(fsCrypt, aes.CreateEncryptor(), CryptoStreamMode.Write);

            FileStream fsIn = new FileStream(inputFile, FileMode.Open);

            //create a buffer (1mb) so only this amount will allocate in the memory and not the whole file
            byte[] buffer = new byte[1048576];
            int read;

            try
            {
                while ((read = fsIn.Read(buffer, 0, buffer.Length)) > 0)
                {
                    Application.DoEvents(); 
                    cs.Write(buffer, 0, read);
                }

                // Close up
                fsIn.Close();
            }
            catch (Exception ex)
            {
                throw new EncryptionException("Error: " + ex.Message, ex);
            }
            finally
            {
                cs.Close();
                fsCrypt.Close();
            }
        }

        /// <summary>
        /// Decrypts an encrypted file with the FileEncrypt method through its path and the plain password.
        /// </summary>
        /// <param name="inputFile"></param>
        /// <param name="outputFile"></param>
        /// <param name="password"></param>
        public void FileDecrypt(string inputFile, string outputFile, string password)
        {
            byte[] passwordBytes = System.Text.Encoding.UTF8.GetBytes(password);
            byte[] salt = new byte[32];

            FileStream fsCrypt = new FileStream(inputFile, FileMode.Open);
            fsCrypt.Read(salt, 0, salt.Length);

            RijndaelManaged aes = new RijndaelManaged();
            aes.KeySize = 256;
            aes.BlockSize = 128;
            var key = new Rfc2898DeriveBytes(passwordBytes, salt, 50000);
            aes.Key = key.GetBytes(aes.KeySize / 8);
            aes.IV = key.GetBytes(aes.BlockSize / 8);
            aes.Padding = PaddingMode.PKCS7;
            aes.Mode = CipherMode.CFB;

            CryptoStream cs = new CryptoStream(fsCrypt, aes.CreateDecryptor(), CryptoStreamMode.Read);

            FileStream fsOut = new FileStream(outputFile, FileMode.Create);

            int read;
            byte[] buffer = new byte[1048576];

            try
            {
                while ((read = cs.Read(buffer, 0, buffer.Length)) > 0)
                {
                    Application.DoEvents();
                    fsOut.Write(buffer, 0, read);
                }
            }
            catch (CryptographicException exCryptographicException)
            {
                throw new DecryptionException("CryptographicException error" + exCryptographicException.Message, exCryptographicException);
            }
            catch (Exception ex)
            {
                throw new DecryptionException("Error: " + ex.Message, ex);
            }

            try
            {
                cs.Close();
            }
            catch (Exception ex)
            {
                throw new DecryptionException("Error by closing CryptoStream: " + ex.Message, ex);
            }
            finally
            {
                fsOut.Close();
                fsCrypt.Close();
            }
        }
    }
}
