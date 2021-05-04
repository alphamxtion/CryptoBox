using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using DiscUtils;
using DiscUtils.Partitions;
using DiscUtils.Ntfs;
using Org.BouncyCastle.Crypto.Engines;

namespace CryptoBox.Box
{
    public class BoxCreator
    {
        public static void CreateDisk(string filePath, int size, string pwdKey)
        {
            CreateVirtualDisk(filePath, size);

            Core.Crypto.EncryptFile(filePath, filePath + ".cryptobox", pwdKey, new AesEngine(), 128, 128);

            File.Delete(filePath);
        }

        private static void CreateVirtualDisk(string filePath, int size)
        {
            using (FileStream fsStream = File.Open(filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite))
            using (VirtualDisk disk = DiscUtils.Vhd.Disk.InitializeDynamic(fsStream, DiscUtils.Streams.Ownership.Dispose, size * 1024 * 1024))
            {
                GuidPartitionTable.Initialize(disk, WellKnownPartitionType.WindowsNtfs);

                PhysicalVolumeInfo volume = VolumeManager.GetPhysicalVolumes(disk)[0];

                NtfsFileSystem.Format(volume, "CryptoBox");
            }
        }
    }
}
