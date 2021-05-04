using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using DiscUtils;
using DiscUtils.Partitions;

namespace CryptoBox.Box.Core.FileSystemHandler
{
    public class FileSystemHandler
    {
        Core core;
        DiscFileSystem discFs;

        public FileSystemHandler(Core core)
        {
            this.core = core; discFs = core.discFs;
        }

        public void CreateDirectory(string path)
        {
            discFs.CreateDirectory(path);
        }

        public string[] GetDirectories(string path, string searchPattern = "*.*", SearchOption option = SearchOption.AllDirectories)
        {
            return discFs.GetDirectories(path, searchPattern, option);
        }

        public string[] GetFiles(string path, string searchPattern = "*.*", SearchOption option = SearchOption.AllDirectories)
        {
            return discFs.GetFiles(path, searchPattern, option);
        }

        public void DeleteDirectory(string path, bool recursive = false)
        {
            discFs.DeleteDirectory(path, recursive);
        }

        public void DeleteFile(string path)
        {
            discFs.DeleteFile(path);
        }

        public bool FileExists(string path)
        {
            return discFs.FileExists(path);
        }

        public bool DirectoryExists(string path)
        {
            return discFs.DirectoryExists(path);
        }

        public DiscFileInfo GetFileInfo(string path)
        {
            return discFs.GetFileInfo(path);
        }

        public DiscDirectoryInfo GetDirectoryInfo(string path)
        {
            return discFs.GetDirectoryInfo(path);
        }

        public void AddFile(string fsFilePath, string filePath)
        {
            using (FileStream fsStream = File.OpenRead(fsFilePath))
            using (var vhdStream = discFs.OpenFile(filePath, FileMode.OpenOrCreate))
            {
                fsStream.CopyTo(vhdStream);
            }
        }

        public void OpenFile(string vhdFilePath, string fsFilePath)
        {           
            using (var vhdStream = discFs.OpenFile(vhdFilePath, FileMode.Open))
            using (FileStream fsStream = File.Open(fsFilePath, FileMode.OpenOrCreate))
            {
                vhdStream.CopyTo(fsStream);
            }
        }
    }
}
