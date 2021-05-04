using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Digests;
using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Crypto.Modes;
using Org.BouncyCastle.Crypto.Generators;
using Org.BouncyCastle.Crypto.Paddings;
using System.Diagnostics;

namespace CryptoBox.Box.Core
{
    public class Crypto
    {
        private static byte[] GetRandomBytes(int size)
        {
            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                byte[] bytes = new byte[size];
                rng.GetBytes(bytes);
                return bytes;
            }
        }

        public static void EncryptFile(string filePath, string newFilePath, string pwdKey, IBlockCipher cipher, int keySize, int blockSize)
        {
            CbcBlockCipher cbc = new CbcBlockCipher(cipher);
            PaddedBufferedBlockCipher padCbc = new PaddedBufferedBlockCipher(cbc, new Pkcs7Padding());

            MainForm.Debug($"Init padded buffered CBC cipher with algorithm {cipher.AlgorithmName} and padding PKCS7");

            MainForm.Debug($"PKCS5S2 param generator init with salt size 32 and 8192 iterations");

            Pkcs5S2ParametersGenerator pkcs = new Pkcs5S2ParametersGenerator();
            pkcs.Init(Encoding.UTF8.GetBytes(pwdKey), GetRandomBytes(32), 8192);

            MainForm.Debug($"Generate params for {cipher.AlgorithmName} with key size {keySize}");

            ICipherParameters param = pkcs.GenerateDerivedParameters(cipher.AlgorithmName, keySize);

            MainForm.Debug($"Generate params with initialization vector (size {blockSize / 8} - blockSize / 8)");

            ParametersWithIV paramIv = new ParametersWithIV(param, GetRandomBytes(blockSize / 8));

            MainForm.Debug($"Initializing encryption crypto engine with parameters");

            padCbc.Init(true, paramIv);

            using (FileStream fsin = new FileStream(filePath, FileMode.Open))
            {
                MainForm.Debug($"FileStream IN open {filePath}");

                using (FileStream fsout = new FileStream(newFilePath, FileMode.OpenOrCreate))
                {
                    MainForm.Debug($"FileStream OUT open {newFilePath}");

                    int read;
                    byte[] inBuf = new byte[128], outBuf = new byte[128];

                    MainForm.Debug($"Init in/out buffers, 128 bytes");

                    byte[] salt = new byte[32]; byte[] iv = new byte[blockSize / 8];
                    salt = pkcs.Salt; iv = paramIv.GetIV();

                    MainForm.Debug($"Writing salt and IV to out file");

                    fsout.Write(salt, 0, salt.Length); fsout.Write(iv, 0, iv.Length);

                    MainForm.Debug($"Beginning transformation");

                    do
                    {
                        read = fsin.Read(inBuf, 0, inBuf.Length);

                        MainForm.Debug($"Read {read} bytes into InBuf");

                        if (read != 0)
                        {
                            int proc = padCbc.ProcessBytes(inBuf, 0, read, outBuf, 0);

                            MainForm.Debug($"Processed {proc} bytes, writing to OutStream");

                            fsout.Write(outBuf, 0, proc);
                        }
                        else
                        {
                            byte[] final = padCbc.DoFinal();
                            fsout.Write(final, 0, final.Length);

                            MainForm.Debug($"End of file, PadCbc DoFinal {final.Length} bytes, encryption end");

                            break;
                        }
                    } while (true);
                }
            }
        }

        public static void DecryptFile(string filePath, string newFilePath, string pwdKey, IBlockCipher cipher, int keySize, int blockSize)
        {
            CbcBlockCipher cbc = new CbcBlockCipher(cipher);
            PaddedBufferedBlockCipher padCbc = new PaddedBufferedBlockCipher(cbc, new Pkcs7Padding());

            using (FileStream fsin = new FileStream(filePath, FileMode.Open))
            {
                byte[] salt = new byte[32]; byte[] iv = new byte[blockSize / 8];
                fsin.Read(salt, 0, salt.Length); fsin.Read(iv, 0, iv.Length);

                Debug.WriteLine("cryptfsin " + filePath);
                Debug.WriteLine("cryptfsout " + newFilePath);
                Debug.WriteLine("pwdkey " + pwdKey);

                Pkcs5S2ParametersGenerator pkcs = new Pkcs5S2ParametersGenerator();
                pkcs.Init(Encoding.UTF8.GetBytes(pwdKey), salt, 8192);

                ICipherParameters param = pkcs.GenerateDerivedParameters(cipher.AlgorithmName, keySize);
                ParametersWithIV paramIv = new ParametersWithIV(param, iv);

                padCbc.Init(false, paramIv);

                using (FileStream fsout = new FileStream(newFilePath, FileMode.OpenOrCreate))
                {
                    int read;
                    byte[] inBuf = new byte[128], outBuf = new byte[128];                    

                    do
                    {
                        read = fsin.Read(inBuf, 0, inBuf.Length);

                        if (read != 0)
                        {
                            int proc = padCbc.ProcessBytes(inBuf, 0, read, outBuf, 0);
                            fsout.Write(outBuf, 0, proc);
                        }
                        else
                        {
                            byte[] final = padCbc.DoFinal();
                            fsout.Write(final, 0, final.Length);

                            break;
                        }
                    } while (true);
                }
            }
        }
    }
}
