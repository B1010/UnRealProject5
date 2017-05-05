using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnRealProject5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int cputhread()
        {
            RegistryKey threadcount = Registry.LocalMachine.OpenSubKey(@"HARDWARE\DESCRIPTION\System\CentralProcessor");
            int realthreadcount = threadcount.SubKeyCount;
            return realthreadcount;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(cputhread());
        }
    }
}
