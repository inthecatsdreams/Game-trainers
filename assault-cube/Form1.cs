using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Memory;


namespace Assault_Cube
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public Mem Memlib = new Mem();

        private void Form1_Load(object sender, EventArgs e)
        {
            checkBox1.Text = "god mode";
            if (Memlib.OpenProcess("ac_client"))
            {
                if (backgroundWorker1.IsBusy == false)
                {
                    backgroundWorker1.RunWorkerAsync();
                }
            }

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
           
                while (true)
                {
                    if (checkBox1.Checked)
                {
                    Memlib.WriteMemory("base+0017E0A8, 0xEC", "int", "100");

                }
                }
           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
