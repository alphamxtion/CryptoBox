using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptoBox.Forms
{
    public partial class AddFiles : Form
    {
        Box.Core.FileSystemHandler.FileSystemHandler fsHandler;

        public AddFiles(Box.Core.FileSystemHandler.FileSystemHandler fsHandler)
        {
            InitializeComponent();           

            this.fsHandler = fsHandler;

            RefreshDirectoryList();
        }

        private void AddFiles_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Multiselect = true })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    fileList.Items.AddRange(ofd.FileNames);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (object item in fileList.SelectedItems) fileList.Items.Remove(item);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (string file in fileList.Items)
            {
                statusLabel.Text = $"Status: Loading {Path.GetFileName(file)} into container ...";

                fsHandler.AddFile(file, $@"{(string)fsDirList.SelectedItem}\{Path.GetFileName(file)}");
            }

            statusLabel.Text = "Status: done!";

            fileList.Items.Clear();

            MessageBox.Show("Files added");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateDirectory createDir = new CreateDirectory(fsHandler);

            createDir.ShowDialog();

            RefreshDirectoryList();
        }

        private void RefreshDirectoryList()
        {
            fsDirList.Items.Clear();

            fsDirList.Items.AddRange(fsHandler.GetDirectories("", "*.*", System.IO.SearchOption.AllDirectories));
        }
    }
}
