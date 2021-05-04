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
    public partial class LoadBox : Form
    {
        private string boxPath;

        public string pwdKey;

        public LoadBox(string filePath)
        {
            boxPath = filePath;

            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;

            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;

            pwdKey = textBox1.Text;

            Close();
        }
    }
}
