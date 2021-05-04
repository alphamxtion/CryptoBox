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
    public partial class CreateBox : Form
    {
        public CreateBox()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    textBox1.Text = sfd.FileName;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Box.BoxCreator.CreateDisk(textBox1.Text, 200, textBox2.Text);

            MessageBox.Show("Box has been created. Open the box and enter your password to access your container. ", "CryptoBox");

            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
