using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using DiscUtils;
using DiscUtils.Partitions;
using Org.BouncyCastle.Crypto.Engines;
using System.Diagnostics;
using System.Windows.Forms;

namespace CryptoBox.Box.Core
{
    public class Core
    {
        public VirtualDisk disk;
        public PhysicalVolumeInfo volume;
        public DiscUtils.FileSystemInfo fsInfo;
        public DiscFileSystem discFs;
        public FileSystemHandler.FileSystemHandler fsHandler;

        private MainForm instFrm;

        public string originalPath;
        public string temporaryPath;
        public string pwdKey;

        public List<string> tmpFiles;

        public Core(string filePath, string pwdKey, MainForm form)
        {
            instFrm = form;

            MainForm.Debug("Core 04-05-21, start init");

            originalPath = filePath;
            temporaryPath = Path.GetTempFileName() + ".vhd";
            this.pwdKey = pwdKey;

            MainForm.Debug($"Container original path: {originalPath}");
            MainForm.Debug($"Container temp path: {temporaryPath}");
            MainForm.Debug($"Container key: {pwdKey}");

            Debug.WriteLine(temporaryPath);           

            AttemptDecryption(filePath, pwdKey);

            LoadContainer(temporaryPath);
        }

        private void AttemptDecryption(string filePath, string pwdKey)
        {
            MainForm.Debug($"Attempt decryption start");

            Crypto.DecryptFile(filePath, temporaryPath, pwdKey, new AesEngine(), 128, 128);
        }

        private void LoadContainer(string filePath)
        {
            disk = VirtualDisk.OpenDisk(filePath, FileAccess.ReadWrite);

            Debug.WriteLine(disk.Capacity + ", " + disk.DiskTypeInfo.Name);

            volume = VolumeManager.GetPhysicalVolumes(disk.Content)[0];

            fsInfo = FileSystemManager.DetectFileSystems(volume)[0];

            discFs = fsInfo.Open(volume);

            tmpFiles = new List<string>();

            Debug.WriteLine(fsInfo.Name + " - " + fsInfo.Description);

            fsHandler = new FileSystemHandler.FileSystemHandler(this);
        }

        public void OpenFileInContainer(string vhdFilePath)
        {
            string fileExt = Path.GetExtension(vhdFilePath);
            string tempFilePath = Path.GetTempFileName() + fileExt;

            fsHandler.OpenFile(vhdFilePath, tempFilePath);

            Process p = Process.Start(tempFilePath);

            if (p != null)
            {
                p.WaitForInputIdle();
                p.WaitForExit();

                File.Delete(tempFilePath);
            }                       
            else
            {
                // need to manual clean up later on
                tmpFiles.Add(tempFilePath);
            }
        }

        public void CloseContainer()
        {
            fsHandler = null; discFs.Dispose();
            fsInfo = null; volume = null;
            disk.Dispose();

            File.Delete(originalPath);

            Crypto.EncryptFile(temporaryPath, originalPath, pwdKey, new AesEngine(), 128, 128);

            File.Delete(temporaryPath);
        }
    }
}
