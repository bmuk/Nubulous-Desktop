using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace Nubulous_Desktop
{
    public partial class Form2 : Form
    {
        private string integration1;
        private string integration2;
        private HashSet<string> fileSet = new HashSet<string>();
        private Queue<string> duplicates = new Queue<string>();

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
                foreach (var file in Directory.GetFiles(directory))
                {
                    fileList.Add(file);
                }
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

        private static string GetChecksum(string filepath)
        {
            using (FileStream stream = File.OpenRead(filepath))
            {
                SHA256Managed sha = new SHA256Managed();
                byte[] checksum = sha.ComputeHash(stream);
                return BitConverter.ToString(checksum).Replace("-", String.Empty);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var integrations = new List<string>();
            integrations.Add(this.integration1);
            integrations.Add(this.integration2);
            foreach (var integration in integrations)
            {
                Console.WriteLine("Integration: {0}", integration);
                foreach (var file in accumulate(integration))
                {
                    var hash = GetChecksum(file);
                    Console.WriteLine("File: {0}, Hash: {1}", file, hash);
                    if (this.fileSet.Contains(hash))
                    {
                        Console.WriteLine("File: {0} is a duplicate", file);
                        this.duplicates.Enqueue(file);
                    }
                    else
                    {
                        Console.WriteLine("File: {0} is not a duplicate", file);
                        this.fileSet.Add(hash);
                    }
                }
            }
            var duplicateCount = this.duplicates.Count;
            foreach (var file in this.duplicates)
            {
                Console.WriteLine("Deleting file: {0}", file);
                File.Delete(file);
            }
            System.Windows.Forms.MessageBox.Show(String.Format("Removed {0} duplicate files.", duplicateCount.ToString()));
        }
    }
}
