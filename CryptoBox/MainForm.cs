using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CryptoBox
{
    public partial class MainForm : Form
    {
        Box.Core.Core core;

        public string currentlyLoadedContainer;

        private static RichTextBox _dBox;

        public MainForm()
        {
            InitializeComponent();

            DiscUtils.Complete.SetupHelper.SetupComplete();

            _dBox = debugBox;
        }

        public static void Debug(string text)
        {
            string txt = $"[{DateTime.Now.ToString()}]: {text}{Environment.NewLine}";

            if (_dBox.InvokeRequired || !_dBox.IsHandleCreated) _dBox.Invoke(new Action(() => { _dBox.AppendText(txt); })); else _dBox.AppendText(txt);
        }

        private void createBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Debug("Creating CreateBox form");

            using (Forms.CreateBox createBox = new Forms.CreateBox()) createBox.ShowDialog();

            Debug("CreateBox form closed");
        }

        private void loadBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadContainer();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            RefreshFileSystemView();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            CloseAndEncrypt();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            DeleteEntries();
        }
        
        private void addFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Debug("Creating AddFiles form");

            using (Forms.AddFiles addFiles = new Forms.AddFiles(core.fsHandler)) addFiles.ShowDialog();

            RefreshFileSystemView();
        }

        private void createADirectoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Debug("Creating CreateDirectory form");

            using (Forms.CreateDirectory createDir = new Forms.CreateDirectory(core.fsHandler)) createDir.ShowDialog();

            RefreshFileSystemView();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Debug("Loading main form");
        }

        private void openFileBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Important message: some applications that get opened by starting files may create sub-processes that" +
                " manage handling the file, so CryptoBox might be unable to clean up the temp files afterwards. Please make sure to " +
                " to manually clean up temp files by going to Tools > Clean Up Temp Files. CryptoBox automatically cleans up temp files " +
                "when you save and close your container. Click OK to continue.", "Important information", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            OpenFiles();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CloseAndEncrypt();
        }

        /* main methods and functions for a clean code */

        private void LoadContainer()
        {
            Debug("LoadContainer start");

            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    using (Forms.LoadBox loadBox = new Forms.LoadBox(ofd.FileName))
                    {
                        if (loadBox.ShowDialog() == DialogResult.OK)
                        {
                            Debug($"Opening container from GUI {ofd.FileName}");

                            SetStatus($"Opening container {Path.GetFileName(ofd.FileName)} with key {loadBox.pwdKey}");

                            currentlyLoadedContainer = ofd.FileName;

                            Debug("Variable set, initializing core");

                            core = new Box.Core.Core(ofd.FileName, loadBox.pwdKey, this);

                            SetStatus("Loading filesystem ...");

                            RefreshFileSystemView();

                            toolStrip1.Enabled = true;
                        }
                    }
                }
            }

            Debug("LoadContainer completed");
        }

        private void OpenFiles()
        {         
            if (fsView.SelectedItems.Count > 0)
            {
                ListViewItem item = fsView.SelectedItems[0];

                SetStatus("Temporarily opening " + item.Text);

                this.Enabled = false;

                if (item.Group != fsView.Groups[1]) core.OpenFileInContainer(item.SubItems[1].Text);
            }

            this.Enabled = true;

            SetStatus("Temp opening stopped and cleared.");
        }

        private void CloseAndEncrypt()
        {
            SetStatus("Clearing up temp files ...");

            foreach (string file in core.tmpFiles) if (File.Exists(file)) File.Delete(file);

            SetStatus("Closing and encrypting container ...");

            core.CloseContainer();

            SetStatus("Clearing GUI ...");

            fsView.Items.Clear();
            toolStrip1.Enabled = false;
            core = null;

            SetStatus("No container loaded.");
        }

        private void DeleteEntries()
        {
            if (fsView.SelectedItems.Count > 0)
            {
                int count = fsView.SelectedItems.Count;

                foreach (ListViewItem item in fsView.SelectedItems)
                {
                    if (item.Group == fsView.Groups[0])
                    {
                        SetStatus("Deleting file ...");

                        core.fsHandler.DeleteFile(item.SubItems[1].Text);
                    }
                    else
                    {
                        SetStatus("Deleting directory ...");

                        core.fsHandler.DeleteDirectory(item.SubItems[1].Text);
                    }
                }

                SetStatus("Refreshing view ...");

                RefreshFileSystemView();

                SetStatus($"Done! {count} entries deleted.");
            }
        }

        private void RefreshFileSystemView()
        {
            fsView.Items.Clear();

            SetStatus("Loading directories ...");

            foreach (string dir in core.fsHandler.GetDirectories("", "*.*", SearchOption.AllDirectories))
            {
                ListViewItem dirItem = new ListViewItem((dir));
                dirItem.SubItems.Add(dir);
                dirItem.SubItems.Add("-");

                dirItem.Group = fsView.Groups[1];

                fsView.Items.Add(dirItem);
            }

            SetStatus("Loading files ...");

            foreach (string file in core.fsHandler.GetFiles("", "*.*", SearchOption.AllDirectories))
            {
                ListViewItem fileItem = new ListViewItem(Path.GetFileName(file));
                fileItem.SubItems.Add(file);
                fileItem.SubItems.Add("-");

                fileItem.Group = fsView.Groups[0];

                fsView.Items.Add(fileItem);
            }

            SetStatus("Container successfully loaded!");
        }
        private void SetStatus(string text)
        {
            statusLabel.Text = $"Status: {text}";
        }
    }
}
