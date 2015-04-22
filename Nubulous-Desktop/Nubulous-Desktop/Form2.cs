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
        private HashSet<string> fileSet = new HashSet<string>();

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

        private List<string> accumulate(string directory)
        {
            var fileList = new List<string>();
            // dedup
            try
            {
                // loop over all files in integration 1
                foreach (var dir in Directory.GetDirectories(directory))
                {
                    foreach (var file in Directory.GetFiles(dir))
                    {
                        fileList.Add(file);
                    }
                }
                return fileList;
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
                return fileList;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var integrations = new List<string>();
            integrations.Add(this.integration1);
            integrations.Add(this.integration2);
            foreach (var integration in integrations)
            {
                foreach (var file in accumulate(this.integration1))
                {
                    if (this.fileSet.Contains(file))
                    {
                        Console.WriteLine("Found duplicate");
                    }
                    else
                    {
                        this.fileSet.Add(file);
                    }
                }
            }
        }
    }
}
