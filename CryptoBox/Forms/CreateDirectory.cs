using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptoBox.Forms
{
    public partial class CreateDirectory : Form
    {
        private Box.Core.FileSystemHandler.FileSystemHandler fsHandler;

        public CreateDirectory(Box.Core.FileSystemHandler.FileSystemHandler fsHandler)
        {
            InitializeComponent();

            this.fsHandler = fsHandler;

            RefreshList();          
        }

        private void CreateDirectory_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            fsHandler.CreateDirectory(fsDirList.Text);

            MessageBox.Show("Directory created!");

            RefreshList();
        }

        private void RefreshList()
        {
            fsDirList.Items.Clear();

            fsDirList.Items.AddRange(fsHandler.GetDirectories("", "*.*", System.IO.SearchOption.AllDirectories));
        }
    }
}
