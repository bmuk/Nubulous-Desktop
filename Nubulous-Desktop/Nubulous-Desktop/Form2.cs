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

namespace Nubulous_Desktop
{
    public partial class Form2 : Form
    {
        private string integration1;
        private string integration2;
        private HashSet<string> fileSet;

        public Form2(string integration1, string integration2)
        {
            this.integration1 = integration1;
            this.integration2 = integration2;
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // dedup
            try
            {
                // loop over all files in integration 1
                foreach (var directory in Directory.GetDirectories(this.integration1))
                {
                    foreach (var file in Directory.GetFiles(directory))
                    {
                        Console.WriteLine(file);
                    }
                }
                foreach (var directory in Directory.GetDirectories(this.integration2))
                {
                    foreach (var file in Directory.GetFiles(directory))
                    {
                        Console.WriteLine(file);
                    }
                }
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
