using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nubulous_Desktop
{
    public partial class Nubulous : Form
    {
        public Nubulous()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                {
                    textBox1.Text = folderBrowserDialog1.SelectedPath;
                }
            }
            else
            {
                if (folderBrowserDialog2.ShowDialog() == DialogResult.OK)
                {
                    textBox2.Text = folderBrowserDialog2.SelectedPath;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                Form2 frm = new Form2(textBox1.Text, textBox2.Text);
                frm.Show();
            }
        }
    }
}
