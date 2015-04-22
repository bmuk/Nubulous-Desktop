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
    public partial class Form2 : Form
    {
        private string integration1;
        private string integration2;

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
            Console.WriteLine(this.integration1);
            Console.WriteLine(this.integration2);
        }
    }
}
