
namespace CryptoBox
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("Files", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("Directories", System.Windows.Forms.HorizontalAlignment.Left);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cryptoBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utilsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearUpTempFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.addThingsToolStripBtn = new System.Windows.Forms.ToolStripSplitButton();
            this.addFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.createADirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.refreshViewBtn = new System.Windows.Forms.ToolStripButton();
            this.openFileBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.closeContainerBtn = new System.Windows.Forms.ToolStripButton();
            this.fsView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.containerInfoLabel = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.debugBox = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cryptoBoxToolStripMenuItem,
            this.utilsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(486, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cryptoBoxToolStripMenuItem
            // 
            this.cryptoBoxToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadBoxToolStripMenuItem,
            this.createBoxToolStripMenuItem});
            this.cryptoBoxToolStripMenuItem.Name = "cryptoBoxToolStripMenuItem";
            this.cryptoBoxToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.cryptoBoxToolStripMenuItem.Text = "CryptoBox";
            // 
            // loadBoxToolStripMenuItem
            // 
            this.loadBoxToolStripMenuItem.Name = "loadBoxToolStripMenuItem";
            this.loadBoxToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loadBoxToolStripMenuItem.Text = "Load Box";
            this.loadBoxToolStripMenuItem.Click += new System.EventHandler(this.loadBoxToolStripMenuItem_Click);
            // 
            // createBoxToolStripMenuItem
            // 
            this.createBoxToolStripMenuItem.Name = "createBoxToolStripMenuItem";
            this.createBoxToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.createBoxToolStripMenuItem.Text = "Create Box";
            this.createBoxToolStripMenuItem.Click += new System.EventHandler(this.createBoxToolStripMenuItem_Click);
            // 
            // utilsToolStripMenuItem
            // 
            this.utilsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearUpTempFilesToolStripMenuItem});
            this.utilsToolStripMenuItem.Name = "utilsToolStripMenuItem";
            this.utilsToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.utilsToolStripMenuItem.Text = "Utils";
            // 
            // clearUpTempFilesToolStripMenuItem
            // 
            this.clearUpTempFilesToolStripMenuItem.Name = "clearUpTempFilesToolStripMenuItem";
            this.clearUpTempFilesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clearUpTempFilesToolStripMenuItem.Text = "Clear Up Temp Files";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 581);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(486, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(39, 17);
            this.statusLabel.Text = "Status";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Enabled = false;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addThingsToolStripBtn,
            this.deleteBtn,
            this.toolStripSeparator1,
            this.refreshViewBtn,
            this.openFileBtn,
            this.toolStripSeparator2,
            this.closeContainerBtn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(486, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // addThingsToolStripBtn
            // 
            this.addThingsToolStripBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addFileToolStripMenuItem,
            this.toolStripSeparator3,
            this.createADirectoryToolStripMenuItem});
            this.addThingsToolStripBtn.Image = ((System.Drawing.Image)(resources.GetObject("addThingsToolStripBtn.Image")));
            this.addThingsToolStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addThingsToolStripBtn.Name = "addThingsToolStripBtn";
            this.addThingsToolStripBtn.Size = new System.Drawing.Size(61, 22);
            this.addThingsToolStripBtn.Text = "Add";
            // 
            // addFileToolStripMenuItem
            // 
            this.addFileToolStripMenuItem.Name = "addFileToolStripMenuItem";
            this.addFileToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.addFileToolStripMenuItem.Text = "Add Files";
            this.addFileToolStripMenuItem.Click += new System.EventHandler(this.addFileToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(165, 6);
            // 
            // createADirectoryToolStripMenuItem
            // 
            this.createADirectoryToolStripMenuItem.Name = "createADirectoryToolStripMenuItem";
            this.createADirectoryToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.createADirectoryToolStripMenuItem.Text = "Create a Directory";
            this.createADirectoryToolStripMenuItem.Click += new System.EventHandler(this.createADirectoryToolStripMenuItem_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Image = ((System.Drawing.Image)(resources.GetObject("deleteBtn.Image")));
            this.deleteBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(60, 22);
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // refreshViewBtn
            // 
            this.refreshViewBtn.Image = ((System.Drawing.Image)(resources.GetObject("refreshViewBtn.Image")));
            this.refreshViewBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.refreshViewBtn.Name = "refreshViewBtn";
            this.refreshViewBtn.Size = new System.Drawing.Size(66, 22);
            this.refreshViewBtn.Text = "Refresh";
            this.refreshViewBtn.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // openFileBtn
            // 
            this.openFileBtn.Image = ((System.Drawing.Image)(resources.GetObject("openFileBtn.Image")));
            this.openFileBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openFileBtn.Name = "openFileBtn";
            this.openFileBtn.Size = new System.Drawing.Size(56, 22);
            this.openFileBtn.Text = "Open";
            this.openFileBtn.Click += new System.EventHandler(this.openFileBtn_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // closeContainerBtn
            // 
            this.closeContainerBtn.Image = ((System.Drawing.Image)(resources.GetObject("closeContainerBtn.Image")));
            this.closeContainerBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.closeContainerBtn.Name = "closeContainerBtn";
            this.closeContainerBtn.Size = new System.Drawing.Size(106, 22);
            this.closeContainerBtn.Text = "Save and Close";
            this.closeContainerBtn.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // fsView
            // 
            this.fsView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.fsView.Dock = System.Windows.Forms.DockStyle.Top;
            listViewGroup3.Header = "Files";
            listViewGroup3.Name = "listViewGroup1";
            listViewGroup4.Header = "Directories";
            listViewGroup4.Name = "listViewGroup2";
            this.fsView.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup3,
            listViewGroup4});
            this.fsView.HideSelection = false;
            this.fsView.Location = new System.Drawing.Point(0, 49);
            this.fsView.Name = "fsView";
            this.fsView.Size = new System.Drawing.Size(486, 383);
            this.fsView.TabIndex = 3;
            this.fsView.UseCompatibleStateImageBehavior = false;
            this.fsView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 109;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Path";
            this.columnHeader2.Width = 111;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Size";
            this.columnHeader3.Width = 72;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Created on";
            this.columnHeader4.Width = 84;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Last accessed on";
            this.columnHeader5.Width = 103;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 432);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(486, 149);
            this.tabControl.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.containerInfoLabel);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(478, 123);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Container Information";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // containerInfoLabel
            // 
            this.containerInfoLabel.AutoSize = true;
            this.containerInfoLabel.Location = new System.Drawing.Point(8, 8);
            this.containerInfoLabel.Name = "containerInfoLabel";
            this.containerInfoLabel.Size = new System.Drawing.Size(106, 13);
            this.containerInfoLabel.TabIndex = 0;
            this.containerInfoLabel.Text = "No container loaded.";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.debugBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(478, 123);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Debug";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // debugBox
            // 
            this.debugBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.debugBox.Location = new System.Drawing.Point(3, 3);
            this.debugBox.Name = "debugBox";
            this.debugBox.Size = new System.Drawing.Size(472, 117);
            this.debugBox.TabIndex = 0;
            this.debugBox.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 603);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.fsView);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cryptoBoxToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSplitButton addThingsToolStripBtn;
        private System.Windows.Forms.ToolStripMenuItem addFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton deleteBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton refreshViewBtn;
        private System.Windows.Forms.ToolStripButton openFileBtn;
        private System.Windows.Forms.ToolStripMenuItem loadBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createBoxToolStripMenuItem;
        private System.Windows.Forms.ListView fsView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton closeContainerBtn;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem createADirectoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem utilsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearUpTempFilesToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label containerInfoLabel;
        private System.Windows.Forms.TabPage tabPage2;
        public System.Windows.Forms.RichTextBox debugBox;
    }
}

