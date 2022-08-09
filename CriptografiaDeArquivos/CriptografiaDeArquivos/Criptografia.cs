using System;
using System.Security.Cryptography;
using System.IO;

namespace CriptografiaDeArquivos
{
    public class Criptografia
    {
        public static CspParameters cspp;
        public static RSACryptoServiceProvider rsa;


        private static string _encrPasta;
        public static string EncrPasta { get { return _encrPasta; } 
                                         set { _encrPasta = value; PubKeyPasta = EncrPasta + "rsaPublicKey.txt";  } }

        public static string DecrPasta { get; set; }
        public static string SRCPasta { get; set; }

        public static string PubKeyPasta = EncrPasta + "rsaPublicKey.txt";
        public static string KeyName;

        public static string CreateAsmKey()
        {
            string result = "";

            // Armazenar a chave no container
            if (string.IsNullOrEmpty(KeyName)) return "Chave pública não definida";

            cspp.KeyContainerName = KeyName;
            rsa = new RSACryptoServiceProvider(cspp);
            rsa.PersistKeyInCsp = true;

            if (rsa.PublicOnly) result = "Key " + cspp.KeyContainerName + " - Somente pública"; else result = "Key " + cspp.KeyContainerName + " - Key Pair completa";



            return result;
        }

        public static bool ExportPublicKey()
        {
            bool result = true;

            if (rsa == null) return false;

            if (!Directory.Exists(EncrPasta)) Directory.CreateDirectory(EncrPasta);

            StreamWriter sw = new StreamWriter(PubKeyPasta, false);

            try
            {
                sw.Write(rsa.ToXmlString(false));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                result = false;
                
            }
            finally
            {
                sw.Close();
            }

            return result;
        }
        
        public static string ImportPublicKey()
        {
            string result = "";

            if (!File.Exists(PubKeyPasta)) return "Arquivo de chave pública não encontrado!";

            if (string.IsNullOrEmpty(KeyName)) return "Chave pública não definida!";

            StreamReader sr = new StreamReader(PubKeyPasta);

            try
            {
                cspp.KeyContainerName = KeyName;
                rsa = new RSACryptoServiceProvider(cspp);
                string keyTxt = sr.ReadToEnd();

                rsa.FromXmlString(keyTxt);

                rsa.PersistKeyInCsp = true;

                if (rsa.PublicOnly) result = "Key " + cspp.KeyContainerName + " - Somente pública"; else result = "Key " + cspp.KeyContainerName + " - Key Pair completa";
            }
            catch (Exception ex)
            {
                result = ex.Message;
                Console.WriteLine(ex.Message);
            }
            finally
            {
                sr.Close();
            }

            return result;
        }

        public static string GetPrivateKey()
        {
            string result = "";

            if (string.IsNullOrEmpty(KeyName)) return "Chave privada não definida!";

            cspp.KeyContainerName = KeyName;
            rsa = new RSACryptoServiceProvider(cspp);
            rsa.PersistKeyInCsp = true;

            if (rsa.PublicOnly) result = "Key " + cspp.KeyContainerName + " - Somente pública"; else result = "Key " + cspp.KeyContainerName + " - Key Pair completa";



            return result;
        }

        public static string EncryptFile(string inFile)
        {
            Aes aes = Aes.Create();
            ICryptoTransform transform = aes.CreateEncryptor();

            byte[] keyEncrypted = rsa.Encrypt(aes.Key, false);

            byte[] lenKey = new byte[4];
            byte[] lenVetorInicializacao = new byte[4];

            int lKey = keyEncrypted.Length;
            lenKey = BitConverter.GetBytes(lKey);
            int lIV = aes.IV.Length;
            lenVetorInicializacao = BitConverter.GetBytes(lIV);

            int startFile = inFile.LastIndexOf("\\") + 1;

            string outFile = EncrPasta + inFile.Substring(startFile) + ".enc";

            try
            {
                using (FileStream outFs = new FileStream(outFile, FileMode.Create))
                {
                    outFs.Write(lenKey, 0, 4);
                    outFs.Write(lenVetorInicializacao, 0, 4);
                    outFs.Write(keyEncrypted, 0, lKey);
                    outFs.Write(aes.IV, 0, lIV);

                    using(CryptoStream outStreamEncrypted = new CryptoStream(outFs, transform, CryptoStreamMode.Write))
                    {
                        // Criptografar o arquivo por blocos permite economizar memória
                        int count = 0;
                        int offset = 0;
                        
                        int blockSizedBytes = aes.BlockSize / 8;
                        byte[] data = new byte[blockSizedBytes];
                        int bytesRead = 0;

                        using (FileStream inFS = new FileStream(inFile, FileMode.Open))
                        {
                            do
                            {
                                count = inFS.Read(data, 0, blockSizedBytes);
                                offset += count;
                                outStreamEncrypted.Write(data, 0, count);
                                bytesRead += blockSizedBytes;
                            } while (count > 0);
                            inFS.Close();
                        }
                        outStreamEncrypted.FlushFinalBlock();
                        outStreamEncrypted.Close();

                    }
                    outFs.Close();
                }
            }
            catch (Exception ex)
            {
                return ex.Message; 
            }

            return $"Arquivo Encriptografado.\n" +
                   $"Origem: {inFile}.\n" +
                   $"Destino: {outFile}";

        }

    
        public static string DecryptFile(string inFile)
        {
            Aes aes = Aes.Create();

            byte[] LenK = new byte[4];
            byte[] LenIV = new byte[4];

            string outFile = DecrPasta + inFile.Substring(0, inFile.LastIndexOf("."));

            try
            {
                using(FileStream inFs = new FileStream(EncrPasta + inFile, FileMode.Open))
                {
                    inFs.Seek(0, SeekOrigin.Begin);
                    inFs.Seek(0, SeekOrigin.Begin);
                    inFs.Read(LenK, 0, 3);
                    inFs.Seek(4, SeekOrigin.Begin);
                    inFs.Read(LenIV, 0, 3);

                    int lenK = BitConverter.ToInt32(LenK, 0);
                    int lenIV = BitConverter.ToInt32(LenIV, 0);

                    int startC = lenK + lenIV + 8;
                    int lenC = (int)inFs.Length - startC;

                    byte[] keyEncrypted = new byte[lenK];
                    byte[] IV = new byte[lenIV];

                    inFs.Seek(8, SeekOrigin.Begin);
                    inFs.Read(keyEncrypted, 0, lenK);
                    inFs.Seek(8 + lenK, SeekOrigin.Begin);
                    inFs.Read(IV, 0, lenIV);

                    if(!Directory.Exists(DecrPasta))
                    {
                        Directory.CreateDirectory(DecrPasta);
                    }

                    byte[] KeyDecrypted = rsa.Decrypt(keyEncrypted, false);

                    ICryptoTransform transform = aes.CreateDecryptor(KeyDecrypted, IV);

                    using(FileStream outFS = new FileStream(outFile, FileMode.Create))
                    {
                        int count = 0;
                        int offset = 0;

                        int blockSizeBytes = aes.BlockSize / 8;
                        byte[] data = new byte[blockSizeBytes];

                        inFs.Seek(startC, SeekOrigin.Begin);
                        using (CryptoStream outStreamDecrypted = new CryptoStream(outFS, transform, CryptoStreamMode.Write))
                        {
                            do
                            {
                                count = inFs.Read(data, 0, blockSizeBytes);
                                offset += count;
                                outStreamDecrypted.Write(data, 0, count);
                            } while (count > 0);

                            outStreamDecrypted.FlushFinalBlock();
                            outStreamDecrypted.Close();
                        }
                        outFS.Close();
                    }
                    inFs.Close();

                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

            return $"Arquivo descriptografado.\nOrigem: {inFile}\nDestino: {outFile}";
        }
    }
}
